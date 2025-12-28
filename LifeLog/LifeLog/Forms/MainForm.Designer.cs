namespace LifeLog.Forms;

partial class MainForm
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		components = new System.ComponentModel.Container();
		ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
		backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
		backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
		backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
		bbiShowSettings = new DevExpress.XtraBars.BarButtonItem();
		bbiCommandsRunner = new DevExpress.XtraBars.BarButtonItem();
		skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
		skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
		barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
		barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
		barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
		barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
		barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
		bbiRollDice = new DevExpress.XtraBars.BarButtonItem();
		bbiTicTacToe = new DevExpress.XtraBars.BarButtonItem();
		bbiCoinFlip = new DevExpress.XtraBars.BarButtonItem();
		bsiTime = new DevExpress.XtraBars.BarStaticItem();
		bsiAppVersion = new DevExpress.XtraBars.BarStaticItem();
		bsiUserMenu = new DevExpress.XtraBars.BarSubItem();
		bbiLogout = new DevExpress.XtraBars.BarButtonItem();
		bsiDatabase = new DevExpress.XtraBars.BarStaticItem();
		bciTrackWindowsAppMode = new DevExpress.XtraBars.BarCheckItem();
		bbiCustomColors = new DevExpress.XtraBars.BarButtonItem();
		bbiCustomColors2 = new DevExpress.XtraBars.BarButtonItem();
		bciOriginalPalette = new DevExpress.XtraBars.BarCheckItem();
		bciTrackWindowsAccentColor = new DevExpress.XtraBars.BarCheckItem();
		ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
		ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
		ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
		ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
		ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
		ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
		ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
		ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
		ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
		mainTimer = new System.Windows.Forms.Timer(components);
		((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
		((System.ComponentModel.ISupportInitialize)backstageViewControl1).BeginInit();
		backstageViewControl1.SuspendLayout();
		SuspendLayout();
		// 
		// ribbon
		// 
		ribbon.ApplicationButtonDropDownControl = backstageViewControl1;
		ribbon.CaptionBarItemLinks.Add(bbiShowSettings);
		ribbon.ExpandCollapseItem.Id = 0;
		ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bbiShowSettings, ribbon.ExpandCollapseItem, bbiCommandsRunner, skinDropDownButtonItem1, skinPaletteRibbonGalleryBarItem1, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4, barButtonItem5, bbiRollDice, bbiTicTacToe, bbiCoinFlip, bsiTime, bsiAppVersion, bsiUserMenu, bbiLogout, bsiDatabase, bciTrackWindowsAppMode, bbiCustomColors, bbiCustomColors2, bciOriginalPalette, bciTrackWindowsAccentColor });
		ribbon.Location = new Point(0, 0);
		ribbon.Margin = new Padding(4, 3, 4, 3);
		ribbon.MaxItemId = 27;
		ribbon.Name = "ribbon";
		ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage4, ribbonPage2, ribbonPage3 });
		ribbon.Size = new Size(1102, 215);
		ribbon.StatusBar = ribbonStatusBar;
		// 
		// backstageViewControl1
		// 
		backstageViewControl1.Controls.Add(backstageViewClientControl1);
		backstageViewControl1.Items.Add(backstageViewTabItem1);
		backstageViewControl1.Location = new Point(248, 250);
		backstageViewControl1.Margin = new Padding(4, 3, 4, 3);
		backstageViewControl1.Name = "backstageViewControl1";
		backstageViewControl1.OwnerControl = ribbon;
		backstageViewControl1.SelectedTab = backstageViewTabItem1;
		backstageViewControl1.SelectedTabIndex = 0;
		backstageViewControl1.Size = new Size(646, 369);
		backstageViewControl1.TabIndex = 2;
		backstageViewControl1.Text = "backstageViewControl1";
		// 
		// backstageViewClientControl1
		// 
		backstageViewClientControl1.Location = new Point(170, 63);
		backstageViewClientControl1.Margin = new Padding(4, 3, 4, 3);
		backstageViewClientControl1.Name = "backstageViewClientControl1";
		backstageViewClientControl1.Size = new Size(475, 305);
		backstageViewClientControl1.TabIndex = 1;
		// 
		// backstageViewTabItem1
		// 
		backstageViewTabItem1.Caption = "Sql Browser";
		backstageViewTabItem1.ContentControl = backstageViewClientControl1;
		backstageViewTabItem1.ImageOptions.ItemNormal.SvgImage = Properties.Resources.selectdatasource;
		backstageViewTabItem1.Name = "backstageViewTabItem1";
		backstageViewTabItem1.Selected = true;
		// 
		// bbiShowSettings
		// 
		bbiShowSettings.Caption = "Settings";
		bbiShowSettings.Id = 2;
		bbiShowSettings.ImageOptions.SvgImage = Properties.Resources.yaxissettings;
		bbiShowSettings.Name = "bbiShowSettings";
		bbiShowSettings.ItemClick += bbiShowSettings_ItemClick;
		// 
		// bbiCommandsRunner
		// 
		bbiCommandsRunner.Caption = "Comnands Runner";
		bbiCommandsRunner.Id = 3;
		bbiCommandsRunner.ImageOptions.SvgImage = Properties.Resources.cli;
		bbiCommandsRunner.Name = "bbiCommandsRunner";
		// 
		// skinDropDownButtonItem1
		// 
		skinDropDownButtonItem1.Id = 5;
		skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
		// 
		// skinPaletteRibbonGalleryBarItem1
		// 
		skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
		skinPaletteRibbonGalleryBarItem1.Id = 6;
		skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
		// 
		// barButtonItem1
		// 
		barButtonItem1.Caption = "barButtonItem1";
		barButtonItem1.Id = 8;
		barButtonItem1.Name = "barButtonItem1";
		// 
		// barButtonItem2
		// 
		barButtonItem2.Caption = "barButtonItem2";
		barButtonItem2.Id = 9;
		barButtonItem2.Name = "barButtonItem2";
		// 
		// barButtonItem3
		// 
		barButtonItem3.Caption = "barButtonItem3";
		barButtonItem3.Id = 10;
		barButtonItem3.Name = "barButtonItem3";
		// 
		// barButtonItem4
		// 
		barButtonItem4.Caption = "barButtonItem4";
		barButtonItem4.Id = 11;
		barButtonItem4.Name = "barButtonItem4";
		// 
		// barButtonItem5
		// 
		barButtonItem5.Caption = "barButtonItem5";
		barButtonItem5.Id = 12;
		barButtonItem5.Name = "barButtonItem5";
		// 
		// bbiRollDice
		// 
		bbiRollDice.Caption = "Roll Dice";
		bbiRollDice.Id = 13;
		bbiRollDice.ImageOptions.SvgImage = Properties.Resources.dice_dice;
		bbiRollDice.Name = "bbiRollDice";
		bbiRollDice.ItemClick += barButtonItem6_ItemClick;
		// 
		// bbiTicTacToe
		// 
		bbiTicTacToe.Caption = "Tic Tac Toe";
		bbiTicTacToe.Id = 14;
		bbiTicTacToe.ImageOptions.SvgImage = Properties.Resources.tic_tac_toe;
		bbiTicTacToe.Name = "bbiTicTacToe";
		// 
		// bbiCoinFlip
		// 
		bbiCoinFlip.Caption = "Coin Flip";
		bbiCoinFlip.Id = 16;
		bbiCoinFlip.ImageOptions.SvgImage = Properties.Resources.coin_flip;
		bbiCoinFlip.Name = "bbiCoinFlip";
		// 
		// bsiTime
		// 
		bsiTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		bsiTime.Caption = "<TIME>";
		bsiTime.Id = 17;
		bsiTime.ImageOptions.SvgImage = Properties.Resources.time;
		bsiTime.Name = "bsiTime";
		bsiTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		// 
		// bsiAppVersion
		// 
		bsiAppVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		bsiAppVersion.Caption = "<VERSION>";
		bsiAppVersion.Id = 18;
		bsiAppVersion.ImageOptions.SvgImage = Properties.Resources.bo_fileattachment;
		bsiAppVersion.Name = "bsiAppVersion";
		bsiAppVersion.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		// 
		// bsiUserMenu
		// 
		bsiUserMenu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		bsiUserMenu.Caption = "<USER>";
		bsiUserMenu.Id = 19;
		bsiUserMenu.ImageOptions.SvgImage = Properties.Resources.bo_person;
		bsiUserMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(bbiLogout) });
		bsiUserMenu.Name = "bsiUserMenu";
		// 
		// bbiLogout
		// 
		bbiLogout.Caption = "Logout";
		bbiLogout.Id = 20;
		bbiLogout.ImageOptions.SvgImage = Properties.Resources.power_button_red;
		bbiLogout.Name = "bbiLogout";
		// 
		// bsiDatabase
		// 
		bsiDatabase.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		bsiDatabase.Caption = "<DATABASE>";
		bsiDatabase.Id = 21;
		bsiDatabase.ImageOptions.SvgImage = Properties.Resources.actions_database;
		bsiDatabase.Name = "bsiDatabase";
		bsiDatabase.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		// 
		// bciTrackWindowsAppMode
		// 
		bciTrackWindowsAppMode.Caption = "Use Windows App Mode";
		bciTrackWindowsAppMode.Id = 22;
		bciTrackWindowsAppMode.ImageOptions.SvgImage = Properties.Resources.actions_window;
		bciTrackWindowsAppMode.Name = "bciTrackWindowsAppMode";
		// 
		// bbiCustomColors
		// 
		bbiCustomColors.Caption = "Custom Color 1";
		bbiCustomColors.Id = 23;
		bbiCustomColors.ImageOptions.SvgImage = Properties.Resources.actions_window;
		bbiCustomColors.Name = "bbiCustomColors";
		// 
		// bbiCustomColors2
		// 
		bbiCustomColors2.Caption = "Custom Color 2";
		bbiCustomColors2.Id = 24;
		bbiCustomColors2.ImageOptions.SvgImage = Properties.Resources.actions_window;
		bbiCustomColors2.Name = "bbiCustomColors2";
		// 
		// bciOriginalPalette
		// 
		bciOriginalPalette.Caption = "Original Palette";
		bciOriginalPalette.Id = 25;
		bciOriginalPalette.ImageOptions.SvgImage = Properties.Resources.actions_window;
		bciOriginalPalette.Name = "bciOriginalPalette";
		// 
		// bciTrackWindowsAccentColor
		// 
		bciTrackWindowsAccentColor.Caption = "System \r\nAccent \r\nColor";
		bciTrackWindowsAccentColor.Id = 26;
		bciTrackWindowsAccentColor.ImageOptions.SvgImage = Properties.Resources.actions_window;
		bciTrackWindowsAccentColor.Name = "bciTrackWindowsAccentColor";
		// 
		// ribbonPage1
		// 
		ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
		ribbonPage1.ImageOptions.SvgImage = Properties.Resources.Home;
		ribbonPage1.ImageOptions.SvgImageSize = new Size(25, 25);
		ribbonPage1.Name = "ribbonPage1";
		ribbonPage1.Text = "Home";
		// 
		// ribbonPageGroup1
		// 
		ribbonPageGroup1.ItemLinks.Add(bbiCommandsRunner);
		ribbonPageGroup1.Name = "ribbonPageGroup1";
		ribbonPageGroup1.Text = "Main";
		// 
		// ribbonPage4
		// 
		ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4 });
		ribbonPage4.ImageOptions.SvgImage = Properties.Resources.Game;
		ribbonPage4.ImageOptions.SvgImageSize = new Size(25, 25);
		ribbonPage4.Name = "ribbonPage4";
		ribbonPage4.Text = "Games";
		// 
		// ribbonPageGroup4
		// 
		ribbonPageGroup4.ItemLinks.Add(bbiRollDice);
		ribbonPageGroup4.ItemLinks.Add(bbiCoinFlip);
		ribbonPageGroup4.ItemLinks.Add(bbiTicTacToe);
		ribbonPageGroup4.Name = "ribbonPageGroup4";
		ribbonPageGroup4.Text = "Games";
		// 
		// ribbonPage2
		// 
		ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
		ribbonPage2.Name = "ribbonPage2";
		ribbonPage2.Text = "ribbonPage2";
		// 
		// ribbonPageGroup2
		// 
		ribbonPageGroup2.ItemLinks.Add(barButtonItem1);
		ribbonPageGroup2.ItemLinks.Add(barButtonItem2);
		ribbonPageGroup2.ItemLinks.Add(barButtonItem3);
		ribbonPageGroup2.ItemLinks.Add(barButtonItem4);
		ribbonPageGroup2.ItemLinks.Add(barButtonItem5);
		ribbonPageGroup2.Name = "ribbonPageGroup2";
		ribbonPageGroup2.Text = "Tools";
		// 
		// ribbonPage3
		// 
		ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3 });
		ribbonPage3.ImageOptions.SvgImage = Properties.Resources.Setting;
		ribbonPage3.ImageOptions.SvgImageSize = new Size(25, 25);
		ribbonPage3.Name = "ribbonPage3";
		ribbonPage3.Text = "Settings";
		// 
		// ribbonPageGroup3
		// 
		ribbonPageGroup3.ItemLinks.Add(skinDropDownButtonItem1);
		ribbonPageGroup3.ItemLinks.Add(skinPaletteRibbonGalleryBarItem1);
		ribbonPageGroup3.ItemLinks.Add(bciTrackWindowsAppMode);
		ribbonPageGroup3.ItemLinks.Add(bciOriginalPalette);
		ribbonPageGroup3.ItemLinks.Add(bciTrackWindowsAccentColor);
		ribbonPageGroup3.ItemLinks.Add(bbiCustomColors);
		ribbonPageGroup3.ItemLinks.Add(bbiCustomColors2);
		ribbonPageGroup3.Name = "ribbonPageGroup3";
		ribbonPageGroup3.Text = "Theme";
		// 
		// ribbonStatusBar
		// 
		ribbonStatusBar.ItemLinks.Add(bsiDatabase);
		ribbonStatusBar.ItemLinks.Add(bsiAppVersion);
		ribbonStatusBar.ItemLinks.Add(bsiTime);
		ribbonStatusBar.ItemLinks.Add(bsiUserMenu);
		ribbonStatusBar.Location = new Point(0, 624);
		ribbonStatusBar.Margin = new Padding(4, 3, 4, 3);
		ribbonStatusBar.Name = "ribbonStatusBar";
		ribbonStatusBar.Ribbon = ribbon;
		ribbonStatusBar.Size = new Size(1102, 39);
		// 
		// mainTimer
		// 
		mainTimer.Enabled = true;
		mainTimer.Interval = 1000;
		mainTimer.Tick += mainTimer_Tick;
		// 
		// MainForm
		// 
		Appearance.Options.UseFont = true;
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1102, 663);
		Controls.Add(backstageViewControl1);
		Controls.Add(ribbonStatusBar);
		Controls.Add(ribbon);
		Margin = new Padding(4, 3, 4, 3);
		Name = "MainForm";
		Ribbon = ribbon;
		StatusBar = ribbonStatusBar;
		Text = "Mainorm";
		((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
		((System.ComponentModel.ISupportInitialize)backstageViewControl1).EndInit();
		backstageViewControl1.ResumeLayout(false);
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
	private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
	private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
	private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
	private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
	private Views.Sql.SqlBrowserView sqlBrowserView1;
	private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
	private DevExpress.XtraBars.BarButtonItem bbiShowSettings;
	private DevExpress.XtraBars.BarButtonItem bbiCommandsRunner;
	private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
	private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
	private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
	private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
	private DevExpress.XtraBars.BarButtonItem barButtonItem1;
	private DevExpress.XtraBars.BarButtonItem barButtonItem2;
	private DevExpress.XtraBars.BarButtonItem barButtonItem3;
	private DevExpress.XtraBars.BarButtonItem barButtonItem4;
	private DevExpress.XtraBars.BarButtonItem barButtonItem5;
	private DevExpress.XtraBars.BarButtonItem bbiRollDice;
	private DevExpress.XtraBars.BarButtonItem bbiTicTacToe;
	private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
	private DevExpress.XtraBars.BarButtonItem bbiCoinFlip;
	private DevExpress.XtraBars.BarStaticItem bsiTime;
	private System.Windows.Forms.Timer mainTimer;
	private DevExpress.XtraBars.BarStaticItem bsiAppVersion;
	private DevExpress.XtraBars.BarSubItem bsiUserMenu;
	private DevExpress.XtraBars.BarButtonItem bbiLogout;
	private DevExpress.XtraBars.BarStaticItem bsiDatabase;
	private DevExpress.XtraBars.BarCheckItem bciTrackWindowsAppMode;
	private DevExpress.XtraBars.BarButtonItem bbiCustomColors;
	private DevExpress.XtraBars.BarButtonItem bbiCustomColors2;
	private DevExpress.XtraBars.BarCheckItem bciOriginalPalette;
	private DevExpress.XtraBars.BarCheckItem bciTrackWindowsAccentColor;
}