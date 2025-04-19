using Core.Extensions;
using Core.Models;
using Data.ORM.DataModelCode;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using LifeLogApp.Helpers;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLogApp.Forms.Auth
{
    /// <summary>
    /// This login form 
    /// </summary>
    public partial class LoginForm : RibbonForm
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
                Version verssion = Assembly.GetExecutingAssembly().GetName().Version;
#if DEBUG
                bsiAppVersion.Caption = $"v{verssion} (DEBUG!)";
                bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Critical;
#else
                bsiAppVersion.Caption = $"v{Application.ProductVersion}";
                bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Information;
#endif
                bsiDatabase.Caption = AppContext.DataEngine.DBName;

                AjustFormLayout();

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
                _loginModel.Email = AppContext.AppConfigs.LastEmail;

                loginModelBindingSource.DataSource = _loginModel;
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region CLICK

        /// <summary>
        /// Login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbLogin_Click(object sender, EventArgs e)
        {
            RegisterLogin();
        }

        /// <summary>
        /// Button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bePassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ControlsHelper.ButtonTogglePassword(sender as ButtonEdit, e);
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
            databaseSettingsView.LoadData();
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
            bsiDatabase.Caption = AppContext.DataEngine.DBName;
        }

        #endregion

        #region KEY DOWN

        /// <summary>
        /// EditValue edit key enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RegisterLogin();
        }

        #endregion

        #region TOGGLED

        /// <summary>
        /// Handles the new user toggleS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsNewUser_Toggled(object sender, EventArgs e)
        {
            LoginModel login = loginModelBindingSource.DataSource as LoginModel;
            login.IsNew = tsNewUser.IsOn;

            if (tsNewUser.IsOn)
            {
                lciLoginUsername.Visibility = LayoutVisibility.Always;
                sbSubmit.Text = "Register";

                if (!string.IsNullOrWhiteSpace(teEmail.Text) && teEmail.Text.IsEmailValid())
                    teUsername.Text = teEmail.Text.Split('@')[0];
            }
            else
            {
                lciLoginUsername.Visibility = LayoutVisibility.Never;
                sbSubmit.Text = "Login";
            }

            AjustFormLayout();
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Adjusts the form layout
        /// </summary>
        private void AjustFormLayout()
        {
            int height = (esiBottom.Height + esiTop.Height) / 2;
            esiTop.Height = height;
            esiBottom.Height = height;

            int width = (esiBtnLeft.Width + esiBtnRight.Width) / 2;
            esiBtnLeft.Width = width;
            esiBtnRight.Width = width;
        }

        /// <summary>
        /// Register or login
        /// </summary>
        private void RegisterLogin()
        {
            try
            {

                loginModelBindingSource.EndEdit();
                LoginModel login = loginModelBindingSource.DataSource as LoginModel;

                dataLayoutControl.Validate();

                if (!ValidationHelper.ValidateModelAndSetError(_loginModel, dxErrorProvider, dataLayoutControl))
                    return;

                if (tsNewUser.IsOn)
                {
                    bool saved = AppContext.DataEngine.Users.RegisterUser(_loginModel, out string message);
                    AppHelper.StatusMessage(message, saved);
                    if (saved)
                        tsNewUser.IsOn = false;
                }
                else
                {
                    bool validUser = AppContext.DataEngine.Users.ValidateUserLogin(_loginModel, out ORM_Users loggedUser, out string message);
                    AppHelper.StatusMessage(message, validUser);
                    if (validUser && loggedUser != null)
                    {
                        AppContext.AppConfigs.LastEmail = _loginModel.Email;
                        AppContext.CurrentUser = loggedUser;

                        this.DialogResult = DialogResult.Yes;
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