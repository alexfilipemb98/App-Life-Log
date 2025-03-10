using Core.Extensions;
using DevExpress.XtraEditors;
using Life_Log.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Log.Views.Settings
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
                    Math.Max(screenSize.Width / 2, AppHelper.MainFormInstance.Width), 
                    Math.Max(screenSize.Height / 2, AppHelper.MainFormInstance.Height)
                );

                AppHelper.MainFormInstance.Size = newSize;

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
                seFormHeight.EditValue = AppHelper.MainFormInstance.Height;
                seFormWidth.EditValue = AppHelper.MainFormInstance.Width;

                cbStartMode.Properties.Items.Clear();
                List<string> startModes = typeof(System.Windows.Forms.FormStartPosition)
                    .ToList()
                    .Select(w => w.Type)
                    .ToList();

                cbStartMode.Properties.Items.AddRange(startModes);
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
                AppHelper.AppConfigs.FormWidth = Convert.ToInt32(seFormWidth.EditValue);
                AppHelper.AppConfigs.FormHeight = Convert.ToInt32(seFormHeight.EditValue);

                AppHelper.MainFormInstance.Size = new Size(Convert.ToInt32(seFormWidth.EditValue), Convert.ToInt32(seFormHeight.EditValue));

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
