using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.Utils.Svg;
using DevExpress.Xpo.Helpers;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using LifeLog.Data.Database;
using LifeLog.UI.Common.Forms.Loading;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LifeLog.UI.Common.Helpers
{
	/// <summary>
	/// Dialog Helper class
	/// </summary>
	public static class DialogHelper
	{
		/// <summary>
		/// Open the folder dialog
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static string OpenFolder(string path)
		{
			using (FolderBrowserDialog dialog = new FolderBrowserDialog())
			{
				dialog.Description = "Select the folder to save the merged pdf.";

				if (!string.IsNullOrWhiteSpace(path) && Directory.Exists(path))
					dialog.SelectedPath = path;

				if (dialog.ShowDialog() == DialogResult.OK)
					path = dialog.SelectedPath;
			}

			return path;
		}

		#region WAIT FORM

		/// <summary>
		/// Show the wait form
		/// </summary>
		/// <param name="form"></param>
		public static void ShowWait(Form form)
		{
			SplashScreenManager.ShowForm(form, typeof(LoadingForm), true, true, false);
		}
	
		/// <summary>
		/// Show the wait form
		/// </summary>
		/// <param name="form"></param>
		public static void ShowWait()
		{
			SplashScreenManager.ShowForm(AppSession.Container.EngineForm.MainForm, typeof(LoadingForm), true, true, false);
		}

		/// <summary>
		/// Close the wait form
		/// </summary>
		public static void CloseWait()
		{
			SplashScreenManager.CloseForm(false);
		}

		#endregion

		#region ALERT

		public static void Alert(string caption, string message, MessageBoxIcon icon)
		{
			Alert(AppSession.Container.EngineForm.MainForm, caption, message, icon);
		}

		public static void Alert(Form owner, string caption, string message, MessageBoxIcon icon)
		{
			AlertControl control = new AlertControl();
			AlertInfo info = new AlertInfo(caption, message);

			switch (icon)
			{
				case MessageBoxIcon.Error:
					info.ImageOptions.SvgImage = Base.Assets.Resources.error_close;
					break;
				case MessageBoxIcon.Warning:
					info.ImageOptions.SvgImage = Base.Assets.Resources.bo_attention;
					break;
				case MessageBoxIcon.Information:
					info.ImageOptions.SvgImage = Base.Assets.Resources.about;
					break;
			}

			control.HtmlImages = new SvgImageCollection {
				{ "close", Base.Assets.Resources.del }
			};

			control.HtmlTemplate.Template = $@"
				<div class=""container"">
				  <div class=""popup"">
					<div class=""stripe""></div>

					<div class=""content"">
					  <div class=""icon-container"">
						<img class=""icon"" src='${{SvgImage}}'>
					  </div>
					  <div class=""message"">
						<div class=""caption"">${{Caption}}</div>
						<div class=""text"">${{Text}}</div>
					  </div>
					</div>

					<div id=""closeButton"" class=""close-button"" aria-label=""Close"">
					  <img class=""close-icon"" src='close'>
					</div>
				  </div>
				</div>";

			control.HtmlTemplate.Styles = @"
				.container {
				  width: 380px;
				  height: auto;
				  padding: 7px 12px 12px 7px;
				}

				.popup {
				  position: relative;
				  background-color: @Window/0.95;
				  border-radius: 8px;
				  border: 1px solid @Black/0.2;
				  box-shadow: 2px 2px 12px @Black/0.25;
				  display: flex;
				  flex-direction: row;
				  overflow: hidden;
				}

				.stripe {
				  width: 4px;
				  background-color: @Black/0.8; /* depois podes trocar consoante tipo */
				}

				.content {
				  flex: 1;
				  display: flex;
				  flex-direction: row;
				  align-items: center;
				  padding: 12px 16px;
				  background-color: @Black/0.015;
				}

				.icon-container {
				  margin-right: 12px;
				  flex-shrink: 0;
				}

				.icon {
				  width: 32px;    /* maior */
				  height: 32px;
				}

				.message {
				  flex: 1;
				  display: flex;
				  flex-direction: column;
				  font-family: 'Segoe UI';
				  color: @WindowText;
				}

				.caption {
				  font-size: 12pt;
				  font-weight: bold;
				  margin-bottom: 4px;
				}

				.text {
				  font-size: 10.5pt;
				  opacity: 0.9;
				}

				/* Botão de fechar no topo direito */
				.close-button {
				  position: absolute;
				  top: 6px;
				  right: 6px;
				  width: 26px;
				  height: 26px;
				  display: flex;
				  align-items: center;
				  justify-content: center;
				  border-radius: 50%;
				  cursor: pointer;
				}

				.close-button:hover { background-color: @Black/0.1; }
				.close-button:active { background-color: @Black/0.2; }

				.close-icon {
				  width: 18px;
				  height: 18px;
				}";

			control.HtmlElementMouseClick += (s, e) =>
			{
				if (e.ElementId == "closeButton" || e.ParentHasId("closeButton") ||
					e.ElementId == "okButton" || e.ParentHasId("okButton"))
					e.HtmlPopup.Close();
				else
					e.HtmlPopup.Pinned = !e.HtmlPopup.Pinned;
			};

			if (owner is null)
			{
				Form fakeForm = new Form();

				fakeForm.StartPosition = FormStartPosition.Manual;
				fakeForm.Location = new Point(0, 0);
				fakeForm.Size = new Size(1, 1);
				fakeForm.ShowInTaskbar = false;
				fakeForm.Opacity = 0;
				fakeForm.Show();

				owner = fakeForm;
			}

			control.Show(owner, info);
		}

		#endregion
	}
}
