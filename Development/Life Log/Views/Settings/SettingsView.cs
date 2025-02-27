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
    /// Settings view to manage the application settings
    /// </summary>
    public partial class SettingsView : XtraUserControl
    {
        #region MAIN

        /// <summary>
        /// Constructor to initialize the view
        /// </summary>
        public SettingsView() => InitializeComponent();


        #endregion

        /// <summary>
        /// Selected page changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navigationPaneEx_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (e.Page  == npDbSettings)
            {
                databaseSettingsView.LoadData();
            }
        }
    }
}
