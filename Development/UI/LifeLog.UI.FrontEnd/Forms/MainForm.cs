using DevExpress.Data.Utils;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using LifeLog.Base.Infrastructure.Flags;
using LifeLog.Base.Utils;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Forms.Dialog;
using LifeLog.UI.Common.Forms.Others;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.UI.FrontEnd.Forms
{
	/// <summary>
	/// Main form
	/// </summary>
	public partial class MainForm : RibbonForm
	{
		#region MAIN

		//PROPERTIES
		public bool Logout { get; set; }

		private Dictionary<BarButtonItem, FrontModulesFlag> _mapModules;
		private bool _galeryCheckedChanged = false;

		/// <summary>
		/// Constructor
		/// </summary>
		public MainForm() => InitializeComponent();

		/// <summary>
		/// Main form load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			Version version = Assembly.GetExecutingAssembly().GetName().Version;
#if DEBUG
			bsiAppVersion.Caption = $"v{version} (DEBUG!)";
			bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Critical;
#else
			bsiAppVersion.Caption = $"v{version}";
			bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Information;
#endif
			bsiUserMenu.Caption = AppSession.CurrentUser.Username;
			bsiDatabase.Caption = AppSession.DataEngine.DBName;

			modulesSettingView.OnSavedModules += LoadModuleSettings;
			navigationFrame.TransitionManager.AfterTransitionEnds += (ts, te) => DialogHelper.CloseWait();
			DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;

			_mapModules = new Dictionary<BarButtonItem, FrontModulesFlag>
			{
				{ bbiNotes, FrontModulesFlag.Notes },
				{ bbiCommandsRunner, FrontModulesFlag.CommandsRunner },
				{ bbiPasswords, FrontModulesFlag.Passwords },
				{ bbiWeather, FrontModulesFlag.Weather },
				{ bbiRollDice, FrontModulesFlag.RollDice },
				{ bbiFlipCoin, FrontModulesFlag.CoinFlip },
				{ bbiTicTacToe, FrontModulesFlag.TicTacToe },
				{ bbiPasswordGenerator, FrontModulesFlag.PasswordsGenerator },
				{ bbiPdfMerger, FrontModulesFlag.PdfMerger },
				{ bbiGradesCalculador, FrontModulesFlag.GradesCalculator },
				{ bbiConvertText, FrontModulesFlag.ConvertText },
				{ bbiFormOut, FrontModulesFlag.FormOut },
				{ bbiThreeSimpleRule, FrontModulesFlag.ThreeSimpleRule }
			};

			LoadModuleSettings(AppSession.UserAppConfigs.FrontModules);

			bciThemeLight.CheckedChanged -= bciTheme_CheckedChanged;
			bciThemeDark.CheckedChanged -= bciTheme_CheckedChanged;
			bciThemeSystem.CheckedChanged -= bciTheme_CheckedChanged;

			switch (AppSession.AppConfigs.Theme)
			{
				case Base.Infrastructure.Enums.ThemeEnum.SYSTEM:
					bciThemeSystem.Checked = true;
					bciThemeLight.Checked = false;
					bciThemeDark.Checked = false;
					break;
				case Base.Infrastructure.Enums.ThemeEnum.DARK:
					bciThemeSystem.Checked = false;
					bciThemeLight.Checked = false;
					bciThemeDark.Checked = true;
					break;
				case Base.Infrastructure.Enums.ThemeEnum.LIGHT:
					bciThemeSystem.Checked = false;
					bciThemeLight.Checked = true;
					bciThemeDark.Checked = false;
					break;
				case Base.Infrastructure.Enums.ThemeEnum.OTHER:
					bciThemeSystem.Checked = false;
					bciThemeLight.Checked = false;
					bciThemeDark.Checked = false;
					break;
			}

			bciThemeLight.CheckedChanged += bciTheme_CheckedChanged;
			bciThemeDark.CheckedChanged += bciTheme_CheckedChanged;
			bciThemeSystem.CheckedChanged += bciTheme_CheckedChanged;

			InitAccentColors();
		}

		/// <summary>
		/// Main form closing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool istop = this.TopMost;
			this.TopMost = false;
			DialogResult result = MessageBoxDialogForm.SD(MessageBoxIcon.Question, "Exit Confirmation", "Are you sure you want to close the program?\nAny unsaved changes will be lost.");
			if (result != DialogResult.Yes)
			{
				e.Cancel = true;
				this.TopMost = istop;
			}
		}

		/// <summary>
		/// Timer tick
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer_Tick(object sender, EventArgs e)
		{
			bsiTime.Caption = $"{DateTime.Now:HH:mm:ss}";
		}

		#endregion

		#region EVENTS

		#region CLICK

		/// <summary>
		/// Open the pages
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void ribbon_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (e.Item.Tag is string tag && !string.IsNullOrWhiteSpace(tag))
				await OpenPages(e, tag);
		}

		/// <summary>
		/// Open settings app
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiSettingsApp_ItemClick(object sender, ItemClickEventArgs e)
		{
			ribbon.ShowApplicationButtonContentControl();
		}

		/// <summary>
		/// Logout 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiLogoutUser_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Logout = true;
			this.Close();
		}

		/// <summary>
		/// Make the form out 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiFormOut_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				NavigationPage selectedPage = navigationFrame.SelectedPage;
				XtraUserControl control = selectedPage.Controls.OfType<XtraUserControl>().FirstOrDefault();

				if (control != null)
				{
					string typeName = control.GetType().FullName;
					await ContainerForm.ShowFormAsync(Assembly.GetExecutingAssembly(), typeName, "LifeLog.UI.FrontEnd.Views");
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}

		}

		/// <summary>
		/// Three simple rule
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiThreeSimpleRule_ItemClick(object sender, ItemClickEventArgs e)
		{
			using (ThreeSimpleRuleForm form = new ThreeSimpleRuleForm())
			{
				form.ShowDialog();
			}
		}

		#endregion

		#region CHECK CHANGED

		/// <summary>
		/// Set top most
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btsiTopMost_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			this.TopMost = btsiTopMost.Checked;
		}

		/// <summary>
		/// Theme checked changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bciTheme_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			BarCheckItem item = sender as BarCheckItem;

			if (item == null)
				return;

			if (!item.Checked && !bciThemeDark.Checked && !bciThemeLight.Checked && !bciThemeSystem.Checked)
			{
				item.Checked = true;
				return;
			}

			this.skinPaletteRibbonGalleryBarItem.GalleryItemCheckedChanged -= skinPaletteRibbonGalleryBarItem_GalleryItemCheckedChanged;

			_galeryCheckedChanged = false;

			switch (item.Name)
			{
				case nameof(bciThemeLight):
					AppSession.AppConfigs.Theme = Base.Infrastructure.Enums.ThemeEnum.LIGHT;
					bciThemeSystem.Checked = false;
					bciThemeDark.Checked = false;
					ThemeHelper.ApplyTheme();
					break;
				case nameof(bciThemeDark):
					AppSession.AppConfigs.Theme = Base.Infrastructure.Enums.ThemeEnum.DARK;
					bciThemeSystem.Checked = false;
					bciThemeLight.Checked = false;
					ThemeHelper.ApplyTheme();
					break;
				case nameof(bciThemeSystem):
					AppSession.AppConfigs.Theme = Base.Infrastructure.Enums.ThemeEnum.SYSTEM;
					bciThemeLight.Checked = false;
					bciThemeDark.Checked = false;
					ThemeHelper.ApplyTheme();
					break;
			}

			this.skinPaletteRibbonGalleryBarItem.GalleryItemCheckedChanged += skinPaletteRibbonGalleryBarItem_GalleryItemCheckedChanged;
		}

		/// <summary>
		/// Skin palette gallery checked changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void skinPaletteRibbonGalleryBarItem_GalleryItemCheckedChanged(object sender, GalleryItemEventArgs e)
		{
			_galeryCheckedChanged = true;
		}

		#endregion

		#region OTHERS

		/// <summary>
		/// Selected tab changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void backstageViewControl_SelectedTabChanged(object sender, BackstageViewItemEventArgs e)
		{
			BackstageViewTabItem tab = e.Item as BackstageViewTabItem;

			BackstageViewLoadTabData(tab);
		}

		/// <summary>
		/// On showing page
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void backstageViewControl_Showing(object sender, EventArgs e)
		{
			BackstageViewLoadTabData(backstageViewControl.SelectedTab);
		}

		/// <summary>
		/// Default style changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <exception cref="NotImplementedException"></exception>
		private void Default_StyleChanged(object sender, EventArgs e)
		{
			IOverlaySplashScreenHandle loader = SplashScreenManager.ShowOverlayForm(this);
			Application.DoEvents();
			try
			{
				bciThemeLight.CheckedChanged -= bciTheme_CheckedChanged;
				bciThemeDark.CheckedChanged -= bciTheme_CheckedChanged;
				bciThemeSystem.CheckedChanged -= bciTheme_CheckedChanged;

				if (UserLookAndFeel.Default.SkinName == SkinStyle.WXI)
				{
					if (bciThemeSystem.Checked && !_galeryCheckedChanged)
					{
						AppSession.AppConfigs.Theme = Base.Infrastructure.Enums.ThemeEnum.SYSTEM;
					}
					else
					{
						if (UserLookAndFeel.Default.ActiveSvgPaletteName == "LIGHT")
						{
							bciThemeSystem.Checked = false;
							bciThemeLight.Checked = true;
							bciThemeDark.Checked = false;
							AppSession.AppConfigs.Theme = Base.Infrastructure.Enums.ThemeEnum.LIGHT;
						}
						else if (UserLookAndFeel.Default.ActiveSvgPaletteName == "DARK")
						{
							bciThemeSystem.Checked = false;
							bciThemeLight.Checked = false;
							bciThemeDark.Checked = true;
							AppSession.AppConfigs.Theme = Base.Infrastructure.Enums.ThemeEnum.DARK;
						}
						else
						{
							AppSession.AppConfigs.Theme = Base.Infrastructure.Enums.ThemeEnum.OTHER;
							bciThemeSystem.Checked = false;
							bciThemeLight.Checked = false;
							bciThemeDark.Checked = false;
						}
					}
				}
				else
				{
					AppSession.AppConfigs.Theme = Base.Infrastructure.Enums.ThemeEnum.OTHER;
					bciThemeSystem.Checked = false;
					bciThemeLight.Checked = false;
					bciThemeDark.Checked = false;
				}

				_galeryCheckedChanged = false;

				bciThemeLight.CheckedChanged += bciTheme_CheckedChanged;
				bciThemeDark.CheckedChanged += bciTheme_CheckedChanged;
				bciThemeSystem.CheckedChanged += bciTheme_CheckedChanged;
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}

			loader.Close();
		}

		#endregion

		#endregion

		#region FUNCTIONS
		
		#region PRIVATE

		/// <summary>
		/// Open the pages
		/// </summary>
		/// <param name="e"></param>
		/// <param name="userControl"></param>
		private async Task OpenPages(ItemClickEventArgs e, string userControl)
		{
			DialogHelper.ShowWait();
			Application.DoEvents();
			await Task.Delay(250);

			try
			{
				string caption = e.Item.Caption.Replace("\r\n", " ");
				ribbon.ApplicationDocumentCaption = caption;

				NavigationPage pageExists = navigationFrame.Pages
					 .OfType<NavigationPage>()
					 .FirstOrDefault(p => p.Tag?.ToString() == userControl);

				if (pageExists != null)
				{
					if (navigationFrame.SelectedPage != pageExists)
						navigationFrame.SelectedPage = pageExists;
					else
						DialogHelper.CloseWait();

					return;
				}

				object obj = ControlsHelper.CreateInstanceFromName(Assembly.GetExecutingAssembly(), userControl, "LifeLog.UI.FrontEnd.Views");

				if (!(obj is XtraUserControl control))
				{
					AppHelper.StatusMessage("Page not found!", false);
					return;
				}

				control.Dock = DockStyle.Fill;

				NavigationPage page = new NavigationPage();
				page.Controls.Add(control);
				page.Name = control.Name;
				page.Tag = userControl;
				page.Text = caption;

				if (e.Item is BarButtonItem btn)
				{
					if (btn.ImageOptions.SvgImage != null)
						page.ImageOptions.SvgImage = btn.ImageOptions.SvgImage;
					else
						page.ImageOptions.Image = btn.ImageOptions.Image;
				}

				navigationFrame.Pages.Add(page);

				navigationFrame.SelectedPage = page;

				MethodInfo method = obj.GetType().GetMethod("LoadData");

				if (method != null)
				{
					object result = method.Invoke(obj, null);
					if (result is Task taskResult)
						await taskResult;
				}
			}
			catch (Exception ex)
			{
				DialogHelper.CloseWait();
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Load module settings
		/// </summary>
		private void LoadModuleSettings(long valor)
		{
			foreach (var kvp in _mapModules)
				kvp.Key.Visibility = kvp.Value.IsActive(valor) ? BarItemVisibility.Always : BarItemVisibility.Never;
		}

		/// <summary>
		/// Helper to load tab page data
		/// </summary>
		/// <param name="tab"></param>
		private void BackstageViewLoadTabData(BackstageViewTabItem tab)
		{
			switch (tab.Name)
			{
				case nameof(bvtiDatabaseSettings):
					databaseSettingsView.LoadData();
					break;
				case nameof(bvtiModulesSettings):
					modulesSettingView.LoadData(AppSession.UserAppConfigs.FrontModules);
					break;
			}
		}

		/// <summary>
		/// Initialize accent colors
		/// </summary>
		private void InitAccentColors()
		{
			SkinHelper.InitTrackWindowsAppMode(bciTrackWindowsAppMode);
			bciTrackWindowsAppMode.SuperTip = new SuperToolTip();
			bciTrackWindowsAppMode.SuperTip.Items.Add("This setting is available for WXI, Basic, and Bezier skins.");
			bciTrackWindowsAppMode.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
			SkinHelper.InitResetToOriginalPalette(bciOriginalPalette);
			SkinHelper.InitTrackWindowsAccentColor(bciTrackWindowsAccentColor);
			SkinHelper.InitCustomAccentColor(Ribbon.Manager, bbiCustomColors);
			bbiCustomColors.SuperTip = new SuperToolTip();
			bbiCustomColors.SuperTip.Items.Add("Custom Accent Color.");
			bbiCustomColors.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
			SkinHelper.InitCustomAccentColor2(Ribbon.Manager, bbiCustomColors2);
			bbiCustomColors2.SuperTip = new SuperToolTip();
			bbiCustomColors2.SuperTip.Items.Add("Custom Accent Color 2.");
			bbiCustomColors2.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
		}

		#endregion
		
		#endregion

		/// <summary>
		/// Test code button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiTestCode_ItemClick(object sender, ItemClickEventArgs e)
		{
			LifeLog.Base.Forms.QrCodeForm.ShowCode("WIFI:T:WPA;S:Vodafone-7D9753;P:Es7wFuGxeG;H:false;;", this);
		}
	}
}