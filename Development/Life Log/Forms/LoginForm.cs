using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Life_Log.Forms
{
    /// <summary>
    /// Login form
    /// </summary>
	public partial class LoginForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region MAIN

        /// <summary>
        /// Constructor
        /// </summary>
        public LoginForm() => InitializeComponent();

        #endregion

        #region CLICK

        private void sbLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        #endregion

        private void bbiDatabaseSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            bbiDatabaseSettings.Visibility = BarItemVisibility.Never;
            bbiGoBack.Visibility = BarItemVisibility.Always;

            navigationFrame1.SelectedPage = navigationPage2;
        }

        private void bbiGoBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            bbiDatabaseSettings.Visibility = BarItemVisibility.Always;
            bbiGoBack.Visibility = BarItemVisibility.Never;
            navigationFrame1.SelectedPage = navigationPage1;
        }
    }
}