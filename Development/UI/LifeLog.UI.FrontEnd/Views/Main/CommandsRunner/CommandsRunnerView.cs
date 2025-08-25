using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using LifeLog.Base.Models.Data;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
using LifeLog.UI.FrontEnd.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
	public partial class CommandsRunnerView : DevExpress.XtraEditors.XtraUserControl
	{
		#region MAIN

		//PRIVATE
		private CommandsModel _crtCommands;

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
						lista.Add(_crtCommands);
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

		#endregion

		#region TILE VIEW

		/// <summary>
		/// Right click commands event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tileView_ItemRightClick(object sender, TileViewItemClickEventArgs e)
		{
			popupMenu.ShowPopup(Control.MousePosition);
		}

		/// <summary>
		/// Item double click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tileView_ItemDoubleClick(object sender, TileViewItemClickEventArgs e)
		{
			try
			{
				if (!(tileView.GetFocusedRow() is CommandsModel model))
					return;

				ExecuteFile(model);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

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
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

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

				listboxPrograms.SelectedIndex = 0;

				(List<CommandsModel> commands, string message) = await AppSession.DataEngine.Commands.GetUserCommands(AppSession.CurrentUser.Id);
				bsCommandsList.DataSource = commands;

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

			Task.Run(async () =>
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

					if (runInAdmin)
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

		#endregion

		#endregion

	}
}
