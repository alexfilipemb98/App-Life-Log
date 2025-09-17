using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using LifeLog.Base.Infrastructure.Enums;
using LifeLog.Base.Models;
using LifeLog.Base.Utils;
using LifeLog.UI.Common.Helpers;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.UI.Common.Forms.Auth
{
	/// <summary>
	/// Login form
	/// </summary>
	public partial class AuthForm : RibbonForm
	{
		#region MAIN

		public AppInterfaceEnum AplicationInterface { get; private set; }

		//PRIVATE
		private AuthModel _loginModel;

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
				Version verssion = Assembly.GetExecutingAssembly().GetName().Version;
#if DEBUG
				bsiAppVersion.Caption = $"v{verssion} (DEBUG!)";
				bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Critical;
#else
                bsiAppVersion.Caption = $"v{Application.ProductVersion}";
                bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Information;
#endif

				bsiDatabase.Caption = AppSession.DataEngine.DBName;
				bsiStatusLabel.Caption = "Loaded!";

				cbeStartAplicationType.Properties.Items.Clear();
				cbeStartAplicationType.Properties.Items.AddRange(typeof(AppInterfaceEnum).ToList().Select(w => w.Value.ToString()).ToList());
				cbeStartAplicationType.SelectedIndex = 0;

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
				_loginModel = new AuthModel();
				_loginModel.Email = AppSession.AppConfigs.LastEmail;

				loginModelBindingSource.DataSource = _loginModel;

				if (string.IsNullOrWhiteSpace(_loginModel.Email))
					teEmail.Focus();
				else
					bePassword.Focus();
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
			ControlsHelper.ButtonTogglePassword(sender as ButtonEdit, e);
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
			if (AppSession.DataEngine == null) return;
			bbiDatabaseSettings.Visibility = BarItemVisibility.Always;
			bbiGoBack.Visibility = BarItemVisibility.Never;
			navigationFrame.SelectedPage = npAuth;
			bsiDatabase.Caption = AppSession.DataEngine.DBName;
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
			AuthModel login = loginModelBindingSource.DataSource as AuthModel;
			CheckButton chk = sender as CheckButton;

			if (chk == chkLogin && chkLogin.Checked)
			{
				login.IsNew = false;
				lciLoginUsername.Visibility = LayoutVisibility.Never;
				chkSignup.Checked = false;
			}

			if (chk == chkSignup && chkSignup.Checked)
			{
				login.IsNew = true;
				lciLoginUsername.Visibility = LayoutVisibility.Always;
				chkLogin.Checked = false;
				if (!string.IsNullOrWhiteSpace(teEmail.Text) && teEmail.Text.IsValidEmail())
					teUsername.Text = teEmail.Text.Split('@')[0];

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
				this.ValidateChildren();
				loginModelBindingSource.EndEdit();
				AuthModel login = loginModelBindingSource.DataSource as AuthModel;

				if (!ValidationHelper.ValidateModelAndSetError(_loginModel, dxErrorProvider, dataLayoutControl))
					return;

				if (login.IsNew)
				{
					(bool saved, string message) = await AppSession.DataEngine.Users.RegisterUser(_loginModel);
					AppHelper.StatusMessage(message, saved);
					if (saved)
						chkLogin.Checked = true;
				}
				else
				{
					(bool validUser, string message, LoggedUserModel loggedUser) = await AppSession.DataEngine.Users.ValidateUserLogin(_loginModel);
					AppHelper.StatusMessage(message, validUser);
					if (validUser && loggedUser != null)
					{
						AppSession.AppConfigs.LastEmail = _loginModel.Email;
						AppSession.CurrentUser = loggedUser;
						this.AplicationInterface = (AppInterfaceEnum)cbeStartAplicationType.SelectedIndex;

						(Data.Models.UserAppConfigsModel configs, string msg) = await AppSession.DataEngine.UserAppConfigs.GetUserAppConfig(AppSession.CurrentUser.Id);
						AppSession.UserAppConfigs = configs;
						AppHelper.StatusMessage(msg, configs != null);
						Task.Delay(1000).Wait();
						AppHelper.SaveAppSetings();
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

		#endregion

		#endregion

		private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
		{

		}
	}
}