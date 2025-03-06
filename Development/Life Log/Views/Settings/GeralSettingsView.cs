using DevExpress.XtraEditors;
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
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        } 

        #endregion
    }
}
