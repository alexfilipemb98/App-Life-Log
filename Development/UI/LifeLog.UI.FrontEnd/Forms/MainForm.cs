using DevExpress.Data.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Forms.Dialog;
using LifeLog.UI.Common.Forms.Others;
using LifeLog.UI.Common.Helpers;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.UI.FrontEnd.Forms
{
	public partial class MainForm : RibbonForm
	{
		#region MAIN

		//PROPERTIES
		public bool Logout { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		public MainForm() => InitializeComponent();

		/// <summary>
		/// Main form load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			Version version = Assembly.GetExecutingAssembly().GetName().Version;
#if DEBUG
			bsiAppVersion.Caption = $"v{version} (DEBUG!)";
			bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Critical;
#else
			bsiAppVersion.Caption = $"v{version}";
			bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Information;
#endif
			bsiUserMenu.Caption = AppSession.CurrentUser.Username;
			bsiDatabase.Caption = AppSession.DataEngine.DBName;
		}

		/// <summary>
		/// Main form closing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool istop = this.TopMost;
			this.TopMost = false;
			DialogResult result = MessageBoxDialogForm.SD(MessageBoxIcon.Question, "Exit Confirmation", "Are you sure you want to close the program?\nAny unsaved changes will be lost.");
			if (result != DialogResult.Yes)
			{
				e.Cancel = true;
				this.TopMost = istop;
			}
		}

		/// <summary>
		/// Timer tick
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer_Tick(object sender, EventArgs e)
		{
			bsiTime.Caption = $"{DateTime.Now:HH:mm:ss}";
		}

		#endregion

		/// <summary>
		/// Set top most
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btsiTopMost_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			this.TopMost = btsiTopMost.Checked;
		}

		private async void ribbon_ItemClickAsync(object sender, ItemClickEventArgs e)
		{
			if (e.Item.Tag is string tag && !string.IsNullOrWhiteSpace(tag))
				await OpenPages(e, tag);
		}

		/// <summary>
		/// Open settings app
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiSettingsApp_ItemClick(object sender, ItemClickEventArgs e)
		{
			ribbon.ShowApplicationButtonContentControl();
		}

		/// <summary>
		/// Logout 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiLogoutUser_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Logout = true;
			this.Close();
		}

		/// <summary>
		/// Make the form out 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiFormOut_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				NavigationPage selectedPage = navigationFrame.SelectedPage;
				XtraUserControl control = selectedPage.Controls.OfType<XtraUserControl>().FirstOrDefault();

				if (control != null)
				{
					string typeName = control.GetType().FullName;
					await ContainerForm.ShowFormAsync(Assembly.GetExecutingAssembly(), typeName, "LifeLog.UI.FrontEnd.Views");
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}

		}

		/// <summary>
		/// Three simple rule
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiThreeSimpleRule_ItemClick(object sender, ItemClickEventArgs e)
		{
			using (ThreeSimpleRuleForm form = new ThreeSimpleRuleForm())
			{
				form.ShowDialog();
			}
		}

		#region FUNCTIONS

		/// <summary>
		/// Open the pages
		/// </summary>
		/// <param name="e"></param>
		/// <param name="userControl"></param>
		private async Task OpenPages(ItemClickEventArgs e, string userControl)
		{
			try
			{
				DialogHelper.ShowWait(this);

				string caption = e.Item.Caption.Replace("\r\n", " ");
				ribbon.ApplicationDocumentCaption = caption;

				NavigationPage pageExists = navigationFrame.Pages
					 .OfType<NavigationPage>()
					 .FirstOrDefault(p => p.Tag?.ToString() == userControl);

				if (pageExists != null)
				{
					navigationFrame.SelectedPage = pageExists;
					return;
				}

				object obj = ControlsHelper.CreateInstanceFromName(Assembly.GetExecutingAssembly(), userControl, "LifeLog.UI.FrontEnd.Views");

				if (!(obj is XtraUserControl control))
				{
					AppHelper.StatusMessage("Page not found!", false);
					return;
				}

				control.Dock = DockStyle.Fill;

				NavigationPage page = new NavigationPage();
				page.Controls.Add(control);
				page.Name = control.Name;
				page.Tag = userControl;
				page.Text = caption;

				if (e.Item is BarButtonItem btn)
				{
					if (btn.ImageOptions.SvgImage != null)
						page.ImageOptions.SvgImage = btn.ImageOptions.SvgImage;
					else
						page.ImageOptions.Image = btn.ImageOptions.Image;
				}

				navigationFrame.Pages.Add(page);

				navigationFrame.SelectedPage = page;

				System.Reflection.MethodInfo method = obj.GetType().GetMethod("LoadData");

				if (method != null)
				{
					var result = method.Invoke(obj, null);
					if (result is Task taskResult)
					{
						await taskResult; // aguarda pela execução do método assíncrono
					}
				}
			}
			catch (Exception ex)
			{
				//teste.Dispose();
				DialogHelper.CloseWait();
				ErrorHelper.Handler(ex);
			}
			finally
			{
				//teste.Dispose();
				DialogHelper.CloseWait();
			}
		}

		#endregion

	}
}