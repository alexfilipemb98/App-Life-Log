using Life_Log_App.Helpers;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Utils.Extensions;

namespace Life_Log_App.Views.Settings
{
    /// <summary>
    /// Geral Settings
    /// </summary>
    public partial class GeralSettingsView : DevExpress.XtraEditors.XtraUserControl
    {
        #region MAIN

        /// <summary>
        /// Construtor
        /// </summary>
        public GeralSettingsView() => InitializeComponent();

        #endregion

        #region CLICK

        /// <summary>
        /// Reset the form size to default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbResetSize_Click(object sender, EventArgs e)
        {
            try
            {
                Size screenSize = Screen.PrimaryScreen.Bounds.Size;
                Size newSize = new Size(
                    Math.Max(screenSize.Width / 2, AppContext.MainForm.Width),
                    Math.Max(screenSize.Height / 2, AppContext.MainForm.Height)
                );

                AppContext.MainForm.Size = newSize;

                seFormHeight.EditValue = newSize.Height;
                seFormWidth.EditValue = newSize.Width;
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Save the configs to the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Loads the genaral settings to the form
        /// </summary>
        public void LoadData()
        {
            try
            {
                AppConfigsModel configs = AppHelper.LoadAppConfigs();

                appConfigsModelBindingSource.DataSource = configs;

                //seFormHeight.EditValue = AppContext.AppConfigs.MainFormHeight;
                //seFormWidth.EditValue = AppContext.AppConfigs.MainFormWidth;

                cbWindowSate.Properties.Items.Clear();
                List<string> startModes = typeof(FormWindowState)
                    .ToList()
                    .Select(s=>s.Value)
                    .ToList();

                cbWindowSate.Properties.Items.AddRange(startModes);

                cbWindowSate.SelectedIndex = configs.MainFormWindowState;
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Saves the data
        /// </summary>
        private void SaveData()
        {
            try
            {
                appConfigsModelBindingSource.EndEdit();
                AppConfigsModel configs = appConfigsModelBindingSource.DataSource as AppConfigsModel;

                AppContext.MainForm.Size = new Size(Convert.ToInt32(seFormWidth.EditValue), Convert.ToInt32(seFormHeight.EditValue));
                AppContext.MainForm.WindowState = (FormWindowState)cbWindowSate.SelectedIndex;

                AppHelper.SaveAppSetings(configs);

                AppContext.AppConfigs = configs;

                if (configs.InternalApiEnabled && !string.IsNullOrWhiteSpace(configs.InternalApiUrl))
                {
                    if (AppContext.ApiEngine != null)
                        AppContext.ApiEngine.Dispose();

                    AppContext.ApiEngine = new Api.Engine(AppContext.DataEngine);
                    AppContext.ApiEngine.Inicialize(AppContext.AppConfigs.InternalApiUrl);
                }
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        #endregion

        /// <summary>
        /// Open the url to the browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beApiUrl_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(beApiUrl.Text))
                    return;

                string url = beApiUrl.Text.Trim();

                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                    url = $"http://{url}";

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = $"{url}//swagger",
                    UseShellExecute = true
                });

            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }
    }
}
