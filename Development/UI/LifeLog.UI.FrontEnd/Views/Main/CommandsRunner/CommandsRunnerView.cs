using DevExpress.Office.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using LifeLog.Base.Models.Data;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Forms.Dialog;
using LifeLog.UI.Common.Helpers;
using LifeLog.UI.FrontEnd.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.UI.FrontEnd.Views.Main.CommandsRunner
{
	/// <summary>
	/// Commands Runner View
	/// </summary>
	public partial class CommandsRunnerView : XtraUserControl
	{
		#region MAIN

		//PRIVATE
		private CommandsModel _crtCommands;
		private List<CommandsModel> _listCommands;

		/// <summary>
		/// Constructor
		/// </summary>
		public CommandsRunnerView() => InitializeComponent();

		#endregion

		#region EVENTS

		#region CLICK

		/// <summary>
		/// Refresh Button Click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e) =>
			await LoadData();

		/// <summary>
		/// New command click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiNew_ItemClick(object sender, ItemClickEventArgs e) =>
			ShowDetailView();

		/// <summary>
		/// Back
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiBack_ItemClick(object sender, ItemClickEventArgs e) =>
			ShowListView();

		/// <summary>
		/// Edit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			CommandsModel command = ControlsHelper.GetObjectByRowHandle<CommandsModel>(tileView, tileView.FocusedRowHandle);
			if (command != null)
				ShowDetailView(command);
		}

		/// <summary>
		/// Save commands
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				lcEditValues.Focus();
				bsCommandsEdit.EndEdit();

				if (cbeProgram.GetSelectedDataRow() is ExternalProgramsModel program)
					_crtCommands.ExternalProgram = program;

				dxErrorProvider.SetError(recMain, "asdasd asd asd ");
				_crtCommands.Command = recMain.Text;

				if (!Common.Helpers.ValidationHelper.ValidateModelAndSetError(_crtCommands, dxErrorProvider, lcEditValues))
					return;

				(bool saved, string message) = await AppSession.DataEngine.Commands.Save(_crtCommands);

				AppHelper.StatusMessage(message, saved);

				if (saved)
				{
					List<CommandsModel> lista = bsCommandsList.List.Cast<CommandsModel>().ToList();

					if (!lista.Any(w => w.Id == _crtCommands.Id))
					{
						bsCommandsList.Add(_crtCommands);
						tileView.RefreshData();
					}
					else
						tileView.UpdateCurrentRow();

					_crtCommands = null;

					ShowListView();
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Enables or disables the command
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiEnable_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				CommandsModel command = ControlsHelper.GetObjectByRowHandle<CommandsModel>(tileView, tileView.FocusedRowHandle);
				if (command == null)
					return;

				(bool state, string message) = await AppSession.DataEngine.Commands.ToggleEnabledState(command.Id);

				command.IsEnabled = state;

				AppHelper.StatusMessage(message, state);

				int rowHandle = tileView.LocateByValue(nameof(command.Id), command.Id);

				tileView.RefreshRow(rowHandle);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Save commands to a file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiCreateFile_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				CommandsModel command = ControlsHelper.GetObjectByRowHandle<CommandsModel>(tileView, tileView.FocusedRowHandle);
				if (command == null)
					return;

				using (SaveFileDialog dialog = new SaveFileDialog())
				{
					string ext = command.ExternalProgram.FileExtension.Replace(".", ""); // "bat"
					dialog.Filter = $"Files {ext.ToUpper()} (*.{ext})|*.{ext}|All Files (*.*)|*.*";
					dialog.DefaultExt = ext;
					dialog.Title = $"Save | {command.Name}";
					dialog.AddExtension = true;

					if (dialog.ShowDialog() == DialogResult.OK)
					{
						Encoding encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

						File.WriteAllText(dialog.FileName, command.Command, encoding);

						AppHelper.StatusMessage("Command exported to file!", true);
					}
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Delete command!
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				CommandsModel command = ControlsHelper.GetObjectByRowHandle<CommandsModel>(tileView, tileView.FocusedRowHandle);
				if (command == null)
					return;


				DialogResult result = MessageBoxDialogForm.SD(MessageBoxIcon.Question, "Delete Command", $"Do you really want to delete {command.Name}?");

				if (result == DialogResult.Yes)
				{
					(bool deleted, string message) = await AppSession.DataEngine.Commands.Delete(command.Id);
					if (deleted)
					{
						bsCommandsList.Remove(command);
						AppHelper.StatusMessage(message, ForeColors.Critical);
					}
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Run command as admin
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiRunAdmin_ItemClick(object sender, ItemClickEventArgs e) =>
			RunCommandClickHelper(true);

		/// <summary>
		/// Export commands to a json file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.Title = "Save commands as JSON";
					saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
					saveFileDialog.DefaultExt = "json";
					saveFileDialog.FileName = "commands.json";

					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						(List<CommandsModel> commands, _) = await AppSession.DataEngine.Commands.GetUserCommands(AppSession.CurrentUser.Id);
						JsonUtil.ExportToFile(commands, saveFileDialog.FileName, indented: true);
						AppHelper.StatusMessage($"({commands.Count}) Commands exported successfuly!", true);
					}
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Import commnads
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiImport_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				using (var openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Title = "Open commands JSON";
					openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
					openFileDialog.DefaultExt = "json";

					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						List<CommandsModel> commandsJson = JsonUtil.ImportFromFile<List<CommandsModel>>(openFileDialog.FileName);

						commandsJson.ForEach(w => w.User = AppSession.CurrentUser);

						(bool saved, _) = await AppSession.DataEngine.Commands.SaveList(commandsJson);

						if (saved)
						{
							foreach (var command in commandsJson)
								bsCommandsList.Add(command);
						}

						AppHelper.StatusMessage($"({commandsJson.Count}) Commands {(saved ? "imported successfuly" : "not imported")}!", saved);
					}
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region TILE VIEW

		/// <summary>
		/// Tile View
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tileView_Click(object sender, EventArgs e)
		{
			if (((MouseEventArgs)e).Button != MouseButtons.Right)
				return;

			bbiEdit.Visibility = BarItemVisibility.Never;
			bbiDelete.Visibility = BarItemVisibility.Never;
			bbiEnable.Visibility = BarItemVisibility.Never;
			bbiCreateFile.Visibility = BarItemVisibility.Never;
			bbiRunAdmin.Visibility = BarItemVisibility.Never;

			popupMenu.ShowPopup(Control.MousePosition);
		}

		/// <summary>
		/// Right click commands event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tileView_ItemRightClick(object sender, TileViewItemClickEventArgs e)
		{
			if (!(tileView.GetFocusedRow() is CommandsModel model))
				return;

			bbiEdit.Visibility = BarItemVisibility.Always;
			bbiDelete.Visibility = BarItemVisibility.Always;
			bbiEnable.Visibility = BarItemVisibility.Always;
			bbiCreateFile.Visibility = BarItemVisibility.Always;

			bbiEnable.ImageOptions.SvgImage = model.IsEnabled ? Resources.actions_deletecircled : Resources.actions_checkcircled;
			bbiEnable.Caption = model.IsEnabled ? "Disable" : "Enable";

			bbiRunAdmin.Visibility = model.IsEnabled ? BarItemVisibility.Always : BarItemVisibility.Never;

			popupMenu.ShowPopup(Control.MousePosition);
		}

		/// <summary>
		/// Item double click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tileView_ItemDoubleClick(object sender, TileViewItemClickEventArgs e) =>
			RunCommandClickHelper(false);

		/// <summary>
		/// Custom item template event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tileView_CustomItemTemplate(object sender, TileViewCustomItemTemplateEventArgs e)
		{
			try
			{
				CommandsModel model = ControlsHelper.GetObjectByRowHandle<CommandsModel>(tileView, e.RowHandle);

				if (model == null)
					return;

				e.HtmlTemplate.Template =
					e.HtmlTemplate.Template.Replace("@@classEnabled@@",
					model.IsEnabled ? "cardBorderEnabled"
								  : "cardBorderDisabled");

				if (model.ExternalProgram != null)
				{
					ImagesModel iconData = model.ExternalProgram.Image;
					if (iconData == null)
					{
						e.HtmlTemplate.Template = e.HtmlTemplate.Template.Replace("@@icon@@", string.Empty);
						return;
					}
					else
					{
						if (iconData.IsSvg)
							model.Icon = iconData.SvgImage;
						else
							model.Icon = iconData.BitImage;
					}
				}

			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region SELECTED VALUE CHANGED

		/// <summary>
		/// Selected value changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listboxPrograms_SelectedValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (_listCommands is null)
					return;

				LoadCommandsHelper();

			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region CHECKED CHANGED

		/// <summary>
		/// Show or Hides the disabled commands
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bstiShowDisabledCommands_CheckedChanged(object sender, ItemClickEventArgs e) =>
			LoadCommandsHelper();

		#endregion

		#endregion

		#region FUNCTIONS

		#region PUBLIC

		/// <summary>
		/// Load data
		/// </summary>
		/// <returns></returns>
		public async Task LoadData()
		{
			try
			{
				(List<ExternalProgramsModel> externalPrograms, string _) = await AppSession.DataEngine.ExternalPrograms.GetAll();

				externalPrograms.Insert(0, new ExternalProgramsModel
				{
					Id = Guid.Empty,
					Icon = Resources.clearfilter,
				});

				cbeProgram.Properties.DataSource = externalPrograms.Where(w => w.Id != Guid.Empty);

				bsExternalPrograms.DataSource = externalPrograms;

				(List<CommandsModel> commands, string message) = await AppSession.DataEngine.Commands.GetUserCommands(AppSession.CurrentUser.Id);
				_listCommands = commands;

				LoadCommandsHelper();

				AppHelper.StatusMessage(message, commands.Count > 0);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region PRIVATE

		/// <summary>
		/// Runs the commands 
		/// </summary>
		/// <param name="admin"></param>
		private void RunCommandClickHelper(bool admin)
		{
			try
			{
				if (!(tileView.GetFocusedRow() is CommandsModel model))
					return;

				ExecuteFile(model, admin);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Execute File
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		private void ExecuteFile(CommandsModel command, bool runInAdmin = false)
		{
			if (!command.IsEnabled)
			{
				AppHelper.StatusMessage("Command is disabled!", ForeColors.Critical);
				return;
			}

			Task.Run(() =>
			{
				string batchFilePath = string.Empty;
				string fileName = string.Empty;
				string arguments = string.Empty;

				try
				{
					if (!Directory.Exists("Temp"))
						Directory.CreateDirectory("Temp");

					batchFilePath = Path.Combine("Temp", $"temp_{Guid.NewGuid()}");

					if (command.ExternalProgram == null)
						throw new ArgumentNullException("External program is not defined for this command.");

					command.ExternalProgram.FileExtension = command.ExternalProgram.FileExtension.Replace(".", string.Empty);
					batchFilePath += $".{command.ExternalProgram.FileExtension}";
					fileName = command.ExternalProgram.PathToProgram;
					arguments = $"{command.ExternalProgram.Arguments} {batchFilePath}";

					Encoding encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

					File.WriteAllText(batchFilePath, command.Command, encoding);

					ProcessStartInfo startInfo = new ProcessStartInfo
					{
						FileName = fileName,
						Arguments = arguments,
						UseShellExecute = true,
						CreateNoWindow = false,
					};

					if (runInAdmin || command.NeedsAdmin)
						startInfo.Verb = "runas";

					Process process = new Process
					{
						StartInfo = startInfo
					};

					process.Start();
					process.WaitForExit();

					AppHelper.StatusMessage($"Command '{command.Name}' executed!", ForeColors.Information);

				}
				catch (Exception ex)
				{
					ErrorHelper.Handler(ex);
				}
				finally
				{
					if (File.Exists(batchFilePath))
						File.Delete(batchFilePath);
				}

			}).ContinueWith(t =>
			{
				AppSession.Container.EngineForm.MainForm.Invoke((MethodInvoker)(() =>
					AppSession.Container.EngineForm.MainForm.BringToFront()));
			});
		}

		/// <summary>
		/// Show the list view
		/// </summary>
		private void ShowListView()
		{
			try
			{
				bbiNew.Visibility = BarItemVisibility.Always;
				bbiEdit.Visibility = BarItemVisibility.Always;
				bbiBack.Visibility = BarItemVisibility.Never;
				bbiSave.Visibility = BarItemVisibility.Never;
				bbiRefresh.Visibility = BarItemVisibility.Always;
				bbiSearch.Visibility = BarItemVisibility.Always;

				navigationFrame.SelectedPage = npMain;

				bsCommandsEdit.Clear();
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Show detail view 
		/// </summary>
		/// <param name="command"></param>
		private void ShowDetailView(CommandsModel command = null)
		{
			try
			{
				if (command == null)
				{
					command = new CommandsModel();
					command.User = AppSession.CurrentUser;
				}

				bbiNew.Visibility = BarItemVisibility.Never;
				bbiSave.Visibility = BarItemVisibility.Always;
				bbiBack.Visibility = BarItemVisibility.Always;
				bbiEdit.Visibility = BarItemVisibility.Never;
				bbiRefresh.Visibility = BarItemVisibility.Never;
				bbiSearch.Visibility = BarItemVisibility.Never;

				navigationFrame.SelectedPage = npEditor;

				_crtCommands = command;

				bsCommandsEdit.DataSource = _crtCommands;

				cbeProgram.EditValue = command.ExternalProgram?.Id;
				recMain.Text = command.Command;
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Help to load the commands
		/// </summary>
		private void LoadCommandsHelper()
		{
			List<CommandsModel> list = bstiShowDisabledCommands.Checked ? _listCommands : _listCommands.Where(w => w.IsEnabled).ToList();

			if (!(listboxPrograms.SelectedItem is ExternalProgramsModel ep) || ep.Id == Guid.Empty)
				bsCommandsList.DataSource = list;
			else
				bsCommandsList.DataSource = list.Where(w => w.ExternalProgram?.Id == ep.Id).ToList();
		}

		#endregion

		#endregion

		private void tileView_ItemDrag(object sender, DevExpress.XtraGrid.Views.Tile.ItemDragEventArgs e)
		{

		}

		private void tileView_ItemDrop(object sender, ItemDropEventArgs e)
		{
			Task.Run(async () =>
			{
				//await Task.Delay(1500);

				for (int i = 0; i < tileView.RowCount; i++)
				{
					int rowHandle = tileView.GetRowHandle(i);

					if (tileView.GetRow(rowHandle) is CommandsModel command)
					{
						//command.Position = i;
						//CommandsData.SavePosition(command);
					}
				}
			});

			CommandsModel cmd = tileView.GetObjectByRowHandle<CommandsModel>(e.RowHandle);

			AppHelper.StatusMessage($"Command '{cmd.Name}' moved!", Color.Green);
		}
	}
}
