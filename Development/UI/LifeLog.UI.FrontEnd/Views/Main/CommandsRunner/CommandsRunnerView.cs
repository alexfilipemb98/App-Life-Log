using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraSpellChecker.Native;
using LifeLog.Data.Database.Entities;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

				bsExternalPrograms.DataSource = result;

				listboxPrograms.SelectedIndex = 0;
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

					Encoding utf8WithBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);
					File.WriteAllText(batchFilePath, command.Command, utf8WithBom);

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

		#endregion
	}
}
