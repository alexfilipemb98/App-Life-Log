using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using LifeLog.Helpers;
using System.Reflection;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.Forms.Auth;

/// <summary>
/// Login form
/// </summary>
public partial class AuthForm : RibbonForm
{
    #region MAIN

    //PRIVATE
    private LoginModel login;

    /// <summary>
    /// Constructor
    /// </summary>
    public AuthForm() => InitializeComponent();

    /// <summary>
    /// Login form on load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LoginForm_Load(object sender, EventArgs e)
    {
        try
        {
            string? fileVersion = Assembly.GetExecutingAssembly()
               .GetCustomAttribute<AssemblyFileVersionAttribute>()?
               .Version;
#if DEBUG
            bsiAppVersion.Caption = $"v{fileVersion} (DEBUG!)";
            bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Critical;
#else
	            bsiAppVersion.Caption = $"v{fileVersion}";
	            bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Information;
#endif
            bsiDatabase.Caption = Program.DataEngine!.DBName!;

            AjustFormLayout();

            login = new LoginModel();

            bsiStatusLabel.Caption = "Please login to continue.";
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
            string? email = AppHelper.ReadAppConfigs()!.LastEmail;

            if (string.IsNullOrWhiteSpace(email))
                teEmail.Focus();
            else
            {
                teEmail.Text = email;
                bePassword.Focus();
            }
        }
        catch (Exception ex)
        {
            Helpers.ErrorHelper.Handler(ex);
        }
    }

    #endregion

    #region EVENTS

    #region CLICK

    /// <summary>
    /// Login button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void sbLogin_Click(object sender, EventArgs e)
    {
        await RegisterLogin();
    }

    /// <summary>
    /// Button click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bePassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        if (sender is null) return;
        ControlsHelper.ButtonTogglePassword((ButtonEdit)sender, e);
    }

    /// <summary>
    /// Show data base settings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bbiDatabaseSettings_ItemClick(object sender, ItemClickEventArgs e)
    {
        ShowSettingsPage();
    }

    /// <summary>
    /// Goes back to login
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bbiGoBack_ItemClick(object sender, ItemClickEventArgs e)
    {
        if (Program.DataEngine == null) return;

        bbiDatabaseSettings.Visibility = BarItemVisibility.Always;
        bbiGoBack.Visibility = BarItemVisibility.Never;
        navigationFrame.SelectedPage = npAuth;

        bsiDatabase.Caption = Program.DataEngine.DBName;
    }

    #endregion

    #region KEY DOWN

    /// <summary>
    /// EditValue edit key enter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void TextEdit_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            await RegisterLogin();
    }

    #endregion

    #region CHECKED CHANGED

    /// <summary>
    /// Handles the new user
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void chkLoginSignup_CheckedChanged(object sender, EventArgs e)
    {
        CheckButton? chk = sender as CheckButton;

        if (chk == chkLogin && chkLogin.Checked)
        {
            lciLoginUsername.Visibility = LayoutVisibility.Never;
            chkSignup.Checked = false;

            if (!string.IsNullOrWhiteSpace(teEmail.Text))
                bePassword.Focus();
            else
                teEmail.Focus();
        }

        if (chk == chkSignup && chkSignup.Checked)
        {
            lciLoginUsername.Visibility = LayoutVisibility.Always;
            chkLogin.Checked = false;
            if (!string.IsNullOrWhiteSpace(teEmail.Text) && teEmail.Text.IsValidEmail())
                teUsername.Text = teEmail.Text.Split('@')[0];

            teUsername.Focus();
        }

        AjustFormLayout();
    }

    #endregion

    #endregion

    #region FUNCTIONS

    #region PRIVATE

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
    private async Task RegisterLogin()
    {
        try
        {
            if (!ValidateForm())
                return;

            if (login.IsNewUser)
            {
                (bool saved, string message) = await Program.DataEngine!.Users.RegisterUser(teUsername.Text, teEmail.Text, bePassword.Text);

                AppHelper.StatusMessage(message, saved);

                if (saved)
                    chkLogin.Checked = true;
            }
            else
            {
                (bool logged, LoggedUserModel? user, string message) = await Program.DataEngine!.Users.Login(teEmail.Text, bePassword.Text);

                AppHelper.StatusMessage(message, logged);

                if (user is not null && logged)
                {
                    Program.AppConfigs!.LastEmail = user.Email;
                    AppHelper.SaveAppConfigs(Program.AppConfigs);
                    Program.LoggedUser = user;
                    this.DialogResult = DialogResult.Yes;
                }
            }
        }
        catch (Exception ex)
        {
            Helpers.ErrorHelper.Handler(ex);
        }
    }

    /// <summary>
    /// Show settings page
    /// </summary>
    private void ShowSettingsPage()
    {
        bbiDatabaseSettings.Visibility = BarItemVisibility.Never;
        bbiGoBack.Visibility = BarItemVisibility.Always;

        navigationFrame.SelectedPage = npDbSettings;

        databaseSettingsView.LoadData();
    }

    /// <summary>
    /// Validate form
    /// </summary>
    /// <returns></returns>
    private bool ValidateForm()
    {
        this.ValidateChildren();

        LoadFillObj(ref login);

        return ControlsHelper.ValidateForm(
            login,
            dxErrorProvider,
            new Dictionary<string, Control>(StringComparer.Ordinal)
            {
                [nameof(LoginModel.Username)] = teUsername,
                [nameof(LoginModel.Email)] = teEmail,
                [nameof(LoginModel.Password)] = bePassword,
            });
    }

    /// <summary>
    /// Load Data From Form
    /// </summary>
    /// <returns></returns>
    private void LoadFillObj(ref LoginModel obj)
    {
        obj.Username = teUsername.Text?.Trim();
        obj.Email = teEmail.Text?.Trim();
        obj.Password = bePassword.Text?.Trim();
        obj.IsNewUser = chkSignup.Checked;
    }

    #endregion

    #endregion
}