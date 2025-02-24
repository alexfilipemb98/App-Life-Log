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
using Life_Log.Helpers;
using DevExpress.XtraLayout.Utils;

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

        /// <summary>
        /// Login form on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterLoginForm();
        }

        #endregion

        #region CLICK

        /// <summary>
        /// Login click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbLogin_Click(object sender, EventArgs e)
        {

            try
            {
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Show data base settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDatabaseSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            bbiDatabaseSettings.Visibility = BarItemVisibility.Never;
            bbiGoBack.Visibility = BarItemVisibility.Always;

            navigationFrame.SelectedPage = npDbSettings;
            databaseSettingsView1.LoadData();
        }

        /// <summary>
        /// Goes back to login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiGoBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            bbiDatabaseSettings.Visibility = BarItemVisibility.Always;
            bbiGoBack.Visibility = BarItemVisibility.Never;
            navigationFrame.SelectedPage = npLogin;
        }

        #endregion

        #region EDIT VALUE CHANGEDED

        /// <summary>
        /// Toggle the login metodo from login to register mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsLoginRegister_EditValueChanged(object sender, EventArgs e)
        {
            if (tsLoginRegister.IsOn)
            {
                lciLoginUsername.Visibility = LayoutVisibility.Always;
                sbLogin.Text = "Register";
            }
            else
            {
                lciLoginUsername.Visibility = LayoutVisibility.Never;
                sbLogin.Text = "Login";
            }

            CenterLoginForm();
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Center Loin
        /// </summary>
        private void CenterLoginForm()
        {
            int h = (esiTop.Height + esiBottom.Height) / 2;
            esiTop.Height = h;
            esiBottom.Height = h;
        }

        #endregion
    }
}