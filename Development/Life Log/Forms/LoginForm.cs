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
using Core.Models;
using static DevExpress.LookAndFeel.DXSkinColors;
using Data.Entities;
using Core.Extensions;

namespace Life_Log.Forms
{
    /// <summary>
    /// Login form
    /// </summary>
	public partial class LoginForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region MAIN

        //PRIVATE
        private LoginModel _loginModel;

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
            try
            {
#if DEBUG
                bsiAppVersion.Caption = $"v{Application.ProductVersion} (DEBUG!)";
                bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Critical;
#else
            bsiAppVersion.Caption = $"v{Application.ProductVersion}";
            bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Information;
#endif
                bsiDatabase.Caption = AppHelper.DataEngine.DBName;

                CenterLoginForm();
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Login form shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            try
            {
                _loginModel = new LoginModel();
                _loginModel.Email = AppHelper.AppConfigs.LastEmail;

                teEmail.Text = _loginModel.Email;

                loginModelBindingSource.DataSource = _loginModel;
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            bsiTime.Caption = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
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
            RegisterLogin();
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
            bsiDatabase.Caption = AppHelper.DataEngine.DBName;
        }

        /// <summary>
        /// Toggles the show password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bePassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AppHelper.ButtonTogglePassword(bePassword, e);
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
            _loginModel = new LoginModel();
            _loginModel.IsNew = tsLoginRegister.IsOn;
            _loginModel.Email = teEmail.Text;
            _loginModel.Password = bePassword.Text;

            if (tsLoginRegister.IsOn)
            {
                lciLoginUsername.Visibility = LayoutVisibility.Always;
                sbLogin.Text = "Register";

                if (!string.IsNullOrWhiteSpace(teEmail.Text) && teEmail.Text.IsEmailValid())
                    _loginModel.Username = teEmail.Text.Split('@')[0];
            }
            else
            {
                lciLoginUsername.Visibility = LayoutVisibility.Never;
                sbLogin.Text = "Login";
            }

            CenterLoginForm();

            loginModelBindingSource.DataSource = _loginModel;
        }

        #endregion

        #region KEY DOWN

        /// <summary>
        /// Key down event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextEdits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RegisterLogin();
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

        /// <summary>
        /// Register or login
        /// </summary>
        private void RegisterLogin()
        {
            try
            {
                _loginModel.Username = teUsername.Text;
                _loginModel.Email = teEmail.Text;
                _loginModel.Password = bePassword.Text;

                if (!ValidationHelper.ValidateModelAndSetError(_loginModel, dxErrorProvider, dataLayoutControl))
                    return;

                if (tsLoginRegister.IsOn)
                {
                    bool saved = AppHelper.DataEngine.Users.RegisterUser(_loginModel, out string message);
                    AppHelper.StatusMessage(message, saved);
                    if (saved)
                    {
                        tsLoginRegister.IsOn = false;
                    }
                }
                else
                {
                    bool validUser = AppHelper.DataEngine.Users.ValidateUserLogin(_loginModel, out UsersEntity loggedUser, out string message);
                    AppHelper.StatusMessage(message, validUser);
                    if (validUser && loggedUser != null)
                    {
                        AppHelper.AppConfigs.LastEmail = _loginModel.Email;

                        AppHelper.CurrentUser = loggedUser;
                        AppHelper.LoginFormInstance = null;
                        this.DialogResult = DialogResult.Yes;
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        #endregion

        
    }
}