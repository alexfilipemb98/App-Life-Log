using DevExpress.XtraBars;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Forms.Dialog;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.UI.BackEnd.Forms
{
	public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
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
			try
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
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			bsiTime.Caption = $"{DateTime.Now:HH:mm:ss}";
			ribbonStatusBar.Refresh();
		}

		private void bbiLogoutUser_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Logout = true;
			this.Close();
		}

		private async void navigationPaneEx_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
		{
			try
			{
				DialogHelper.ShowWait();

				switch (((Control)e.Page).Name)
				{
					case nameof(npExternalPrograms):
						await externalProgramsListView.LoadData();
						break;
					case nameof(npUsers):
						await usersListView.LoadData();
						break;
					case nameof(npNotes):
						await notesListView.LoadData();
						break;
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		private void navigationPaneEx_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
		{
			try
			{
				DialogHelper.CloseWait();
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
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
			DialogResult result = MessageBoxDialogForm.SD("Exit Confirmation", "Are you sure you want to close the program?\nAny unsaved changes will be lost.");
			if (result != DialogResult.Yes)
			{
				e.Cancel = true;
				this.TopMost = istop;
			}
		}

		private void bbiSettings_ItemClick(object sender, ItemClickEventArgs e)
		{
			ribbon.ShowApplicationButtonContentControl();
		}
	}
}