using LifeLog.Core.Enums;
using LifeLog.Core.Models;
using LifeLog.Core.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using LifeLog.Helpers;
using System.Reflection;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.Forms.Auth
{
	/// <summary>
	/// Login form
	/// </summary>
	public partial class AuthForm : RibbonForm
	{
		#region MAIN

		public bool isNew = false;

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
				Version verssion = Assembly.GetExecutingAssembly().GetName()!.Version!;
#if DEBUG
				bsiAppVersion.Caption = $"v{verssion} (DEBUG!)";
				bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Critical;
#else
	            bsiAppVersion.Caption = $"v{Application.ProductVersion}";
	            bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Information;
#endif

				bsiDatabase.Caption = Program.DataEngine!.DBName!;

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
				isNew = false;

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

				isNew = true;

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
				if (!ValidateLogin())
					return;

				if (isNew)
				{
					(bool saved, _) = await Program.DataEngine!.Users.RegisterUser(teUsername.Text, teEmail.Text, bePassword.Text);

					if (saved)
					{
						MessageBox.Show("Criado");
					}
					else
						MessageBox.Show("not saved");

					if (saved)
						chkLogin.Checked = true;
				}
				else
				{
					(_,LoggedUserModel? user, _) = await Program.DataEngine!.Users.Login(teEmail.Text, bePassword.Text);

					if (user is null)
					{
						MessageBox.Show("not legged");
					}
					else
					{
						MessageBox.Show("Logged In");
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
		}

		private bool ValidateLogin()
		{
			this.ValidateChildren();
			dxErrorProvider.ClearErrors();

			if (string.IsNullOrWhiteSpace(teEmail.Text))
				dxErrorProvider.SetError(teEmail, "Email not provided!");
			else
				if (!teEmail.Text.IsValidEmail())
				dxErrorProvider.SetError(teEmail, "Email not valid!");

			if (string.IsNullOrWhiteSpace(bePassword.Text))
				dxErrorProvider.SetError(teEmail, "Password not provided!");

			if (isNew)
			{
				if (string.IsNullOrWhiteSpace(teUsername.Text))
					dxErrorProvider.SetError(teUsername, "Username not provided!");
			}

			return !dxErrorProvider.HasErrors;
		}

		#endregion

		#endregion
	}
}