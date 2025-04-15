using Core.Extensions;
using LifeLogApp.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LifeLogApp.Views.Settings
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
                seFormHeight.EditValue = AppContext.AppConfigs.MainFormHeight;
                seFormWidth.EditValue = AppContext.AppConfigs.MainFormWidth;
                            
                cbWindowSate.Properties.Items.Clear();
                List<string> startModes = typeof(FormWindowState)
                    .ToList()
                    .Select(w => w.Type)
                    .ToList();

                cbWindowSate.Properties.Items.AddRange(startModes);

                cbWindowSate.SelectedIndex = AppContext.AppConfigs.MainFormWindowState;
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
                AppContext.AppConfigs.MainFormWidth = Convert.ToInt32(seFormWidth.EditValue);
                AppContext.AppConfigs.MainFormHeight = Convert.ToInt32(seFormHeight.EditValue);
                AppContext.AppConfigs.MainFormWindowState = Convert.ToInt32(cbWindowSate.SelectedIndex);

                AppContext.MainForm.Size = new Size(Convert.ToInt32(seFormWidth.EditValue), Convert.ToInt32(seFormHeight.EditValue));
                AppContext.MainForm.WindowState = (FormWindowState)cbWindowSate.SelectedIndex;

                AppHelper.SaveAppSetings();
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        #endregion

    }
}
