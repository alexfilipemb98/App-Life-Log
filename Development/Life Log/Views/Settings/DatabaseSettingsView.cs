using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    /// Database settings View
    /// </summary>
    public partial class DatabaseSettingsView : XtraUserControl
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public DatabaseSettingsView() => InitializeComponent();
        
        #region CLICK

        /// <summary>
        /// Password button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beSqlPassword_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            AppHelper.ButtonTogglePassword(sender as ButtonEdit, e);
        }
        
        #endregion
    }
}
