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

namespace Life_Log_App.Views.Main.Passwords
{
    /// <summary>
    /// PasswordView class
    /// </summary>
    public partial class PasswordView : XtraUserControl
    {
        #region MAIN
        /// <summary>
        /// Constructor
        /// </summary>
        public PasswordView() => InitializeComponent();

        #endregion

        #region CHECKED CHANGED

        /// <summary>
        /// Checked changed event for the btsiEnableEdit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btsiEnableEdit_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load the data
        /// </summary>
        public void LoadData()
        {

        }

        #endregion


    }
}
