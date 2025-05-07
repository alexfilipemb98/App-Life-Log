using Data.ORM.DataModelCode;
using Life_Log_App.Helpers;
using System;
using System.Windows.Forms;

namespace Life_Log_App.Views.Settings
{
	public partial class ModulleSettingsView : DevExpress.XtraEditors.XtraUserControl
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		public ModulleSettingsView() => InitializeComponent();

		#endregion

		#region CLICK

		/// <summary>
		/// Save the settings
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				((CurrencyManager)this.BindingContext[moduleSettingsXPBindingSource])?.EndCurrentEdit();

				if (moduleSettingsXPBindingSource.DataSource is ORM_ModuleSettings settings)
				{
					bool saved = AppContext.DataEngine.ModuleSettings.Save(settings, out string message);
					AppHelper.StatusMessage(message, saved, true);

					if (saved)
						AppContext.ModuleSettings = settings;
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Load the settings
		/// </summary>
		public void LoadData()
		{
			ORM_ModuleSettings settings = AppContext.DataEngine.ModuleSettings.GetUserModuleSettings(AppContext.CurrentUser.Id);
			moduleSettingsXPBindingSource.DataSource = settings;
		}

		#endregion
	}
}
