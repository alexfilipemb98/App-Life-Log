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
                Size newSize = new Size(screenSize.Width / 2, screenSize.Height / 2);
               
                AppHelper.MainFormInstance.Size = newSize;

                seFormHeight.EditValue = newSize.Height;
                seFormWidth.EditValue = newSize.Width;
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
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

        }

        #endregion
    }
}
