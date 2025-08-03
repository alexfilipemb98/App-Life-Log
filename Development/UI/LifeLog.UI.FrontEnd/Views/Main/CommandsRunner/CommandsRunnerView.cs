using DevExpress.XtraBars;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraSpellChecker.Native;
using LifeLog.Data.Database.Entities;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
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
		private CommandsEntity _crtCommands;
		private BindingSource _bs;

		/// <summary>
		/// Constructor
		/// </summary>
		public CommandsRunnerView() => InitializeComponent();

		#endregion

		#region CLICK

		/// <summary>
		/// Refresh Button Click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			await LoadData();
		}

		/// <summary>
		/// New command click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ShowDetailView();
		}

		/// <summary>
		/// Back
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiBack_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowListView();
		}

		/// <summary>
		/// Edit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			CommandsEntity command = ControlsHelper.GetObjectByRowHandle<CommandsEntity>(tileView, tileView.FocusedRowHandle);
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
				_bs.EndEdit();

				if (cbeProgram.GetSelectedDataRow() is ExternalProgramsEntity program)
					_crtCommands.ExternalProgram = program;

				_crtCommands.Command = recMain.Text;

				if (!Common.Helpers.ValidationHelper.ValidateModelAndSetError(_crtCommands, dxErrorProvider, lcEditValues))
					return;

				(bool saved, string message) = await AppSession.DataEngine.Commands.Save(_crtCommands, AppSession.CurrentUser.Id);

				AppHelper.StatusMessage(message, saved);

				if (saved)
				{
					List<CommandsEntity> lista = bsCommands.DataSource as List<CommandsEntity>;

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
				if (!(tileView.GetFocusedRow() is CommandsEntity model))
					return;

				ExecuteFile(model);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region OTHERS EVENTS

		/// <summary>
		/// Custom item template event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tileView_CustomItemTemplate(object sender, TileViewCustomItemTemplateEventArgs e)
		{
			try
			{
				CommandsEntity model = ControlsHelper.GetObjectByRowHandle<CommandsEntity>(tileView, e.RowHandle);

				if (model == null)
					return;

				e.HtmlTemplate.Template =
					e.HtmlTemplate.Template.Replace("@@classEnabled@@",
					model.IsEnabled ? "cardBorderEnabled"
								  : "cardBorderDisabled");

				ExternalProgramsEntity externalProgram = model.ExternalProgram;

				if (externalProgram != null && externalProgram.Image != null)
				{
					ImagesEntity iconData = externalProgram.Image;

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

		#region FUNCTIONS

		//PUBLIC

		/// <summary>
		/// Load data
		/// </summary>
		/// <returns></returns>
		public async Task LoadData()
		{
			try
			{
				List<ExternalProgramsEntity> result = await AppSession.DataEngine.ExternalPrograms.GetUserExternalPrograms(AppSession.CurrentUser.Id);

				result.Insert(0, new ExternalProgramsEntity
				{
					Id = Guid.Empty,
					Image = null,
					Icon = Resources.Properties.Resources.clearfilter,
					Saving = false,
				});

				cbeProgram.Properties.DataSource = result.Where(w => w.Id != Guid.Empty);

				bsExternalPrograms.DataSource = result;

				listboxPrograms.SelectedIndex = 0;

				bsCommands.DataSource = await AppSession.DataEngine.Commands.GetUserCommands(AppSession.CurrentUser.Id);

			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		//PRIVATE

		/// <summary>
		/// Execute File
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		private void ExecuteFile(CommandsEntity command, bool runInAdmin = false)
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

					ExternalProgramsEntity program = command.ExternalProgram;

					program.FileExtension = program.FileExtension.Replace(".", string.Empty);
					batchFilePath += $".{program.FileExtension}";
					fileName = program.PathToProgram;
					arguments = $"{program.Arguments} {batchFilePath}";

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
		private void ShowDetailView(CommandsEntity command = null)
		{
			try
			{
				if (command == null)
					command = new CommandsEntity();

				bbiNew.Visibility = BarItemVisibility.Never;
				bbiSave.Visibility = BarItemVisibility.Always;
				bbiBack.Visibility = BarItemVisibility.Always;
				bbiEdit.Visibility = BarItemVisibility.Never;
				bbiRefresh.Visibility = BarItemVisibility.Never;
				bbiSearch.Visibility = BarItemVisibility.Never;

				navigationFrame.SelectedPage = npEditor;

				_crtCommands = command;

				_bs = new BindingSource();
				_bs.DataSource = _crtCommands;

				lcEditValues.DataSource = _bs;

				cbeProgram.EditValue = command.IdExternalProgram;
				recMain.Text = command.Command;
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}





		#endregion

		
	}
}
