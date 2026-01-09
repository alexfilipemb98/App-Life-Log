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
        bbiShowSettings = new DevExpress.XtraBars.BarButtonItem();
        bbiCommandsRunner = new LifeLog.Components.BarButtonItemEx();
        skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
        skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
        bbiPasswordGenerator = new LifeLog.Components.BarButtonItemEx();
        bbiPdfMerger = new LifeLog.Components.BarButtonItemEx();
        bbiGradesCalculador = new LifeLog.Components.BarButtonItemEx();
        bbiConvertText = new LifeLog.Components.BarButtonItemEx();
        bbiCodeGenerator = new LifeLog.Components.BarButtonItemEx();
        bbiRollDice = new LifeLog.Components.BarButtonItemEx();
        bbiTicTacToe = new LifeLog.Components.BarButtonItemEx();
        bbiCoinFlip = new LifeLog.Components.BarButtonItemEx();
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
        bbiFormOut = new DevExpress.XtraBars.BarButtonItem();
        bbiThreeSimpleRule = new DevExpress.XtraBars.BarButtonItem();
        bbiTestCode = new DevExpress.XtraBars.BarButtonItem();
        btsiTopMost = new DevExpress.XtraBars.BarToggleSwitchItem();
        bbiNotes = new LifeLog.Components.BarButtonItemEx();
        bbiTasks = new LifeLog.Components.BarButtonItemEx();
        bbiPasswords = new LifeLog.Components.BarButtonItemEx();
        ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
        ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
        ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
        ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
        ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
        mainTimer = new System.Windows.Forms.Timer(components);
        layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
        panelControl1 = new DevExpress.XtraEditors.PanelControl();
        navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
        npDashboard = new DevExpress.XtraBars.Navigation.NavigationPage();
        Root = new DevExpress.XtraLayout.LayoutControlGroup();
        layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
        ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
        layoutControl1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
        panelControl1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)navigationFrame).BeginInit();
        navigationFrame.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
        SuspendLayout();
        // 
        // ribbon
        // 
        ribbon.ApplicationCaption = "Life Log";
        ribbon.ApplicationDocumentCaption = "Main";
        ribbon.CaptionBarItemLinks.Add(bbiShowSettings);
        ribbon.EmptyAreaImageOptions.ImagePadding = new Padding(26);
        ribbon.ExpandCollapseItem.Id = 0;
        ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bbiShowSettings, ribbon.ExpandCollapseItem, bbiCommandsRunner, skinDropDownButtonItem1, skinPaletteRibbonGalleryBarItem1, bbiPasswordGenerator, bbiPdfMerger, bbiGradesCalculador, bbiConvertText, bbiCodeGenerator, bbiRollDice, bbiTicTacToe, bbiCoinFlip, bsiTime, bsiAppVersion, bsiUserMenu, bbiLogout, bsiDatabase, bciTrackWindowsAppMode, bbiCustomColors, bbiCustomColors2, bciOriginalPalette, bciTrackWindowsAccentColor, bbiFormOut, bbiThreeSimpleRule, bbiTestCode, btsiTopMost, bbiNotes, bbiTasks, bbiPasswords });
        ribbon.Location = new Point(0, 0);
        ribbon.MaxItemId = 35;
        ribbon.Name = "ribbon";
        ribbon.OptionsMenuMinWidth = 283;
        ribbon.PageHeaderItemLinks.Add(btsiTopMost);
        ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage4, ribbonPage2, ribbonPage3 });
        ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office365;
        ribbon.Size = new Size(945, 209);
        ribbon.StatusBar = ribbonStatusBar;
        ribbon.ItemClick += ribbon_ItemClick;
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
        bbiCommandsRunner.TargetViewTypeName = "LifeLog.Views.Commands.CommandsView";
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
        // bbiPasswordGenerator
        // 
        bbiPasswordGenerator.Caption = "Password Generator";
        bbiPasswordGenerator.Id = 8;
        bbiPasswordGenerator.ImageOptions.SvgImage = Properties.Resources.bo_resume;
        bbiPasswordGenerator.Name = "bbiPasswordGenerator";
        bbiPasswordGenerator.TargetViewTypeName = "LifeLog.Views.PasswordGenerator.PasswordGeneratorView";
        // 
        // bbiPdfMerger
        // 
        bbiPdfMerger.Caption = "Pdf \r\nMerger";
        bbiPdfMerger.Id = 9;
        bbiPdfMerger.ImageOptions.SvgImage = Properties.Resources.documentpdf;
        bbiPdfMerger.Name = "bbiPdfMerger";
        bbiPdfMerger.TargetViewTypeName = "LifeLog.Views.PdfMerger.PdfMergerView";
        // 
        // bbiGradesCalculador
        // 
        bbiGradesCalculador.Caption = "Grades\r\nCalculator";
        bbiGradesCalculador.Id = 10;
        bbiGradesCalculador.ImageOptions.SvgImage = Properties.Resources.calculator;
        bbiGradesCalculador.Name = "bbiGradesCalculador";
        bbiGradesCalculador.TargetViewTypeName = "LifeLog.Views.GradesCalculator.GradesCalculatorView";
        // 
        // bbiConvertText
        // 
        bbiConvertText.Caption = "Convert\r\nText";
        bbiConvertText.Id = 11;
        bbiConvertText.ImageOptions.SvgImage = Properties.Resources.changetextcase;
        bbiConvertText.Name = "bbiConvertText";
        bbiConvertText.TargetViewTypeName = "LifeLog.Views.ConvertCase.ConvertCaseView";
        // 
        // bbiCodeGenerator
        // 
        bbiCodeGenerator.Caption = "Code\r\nGenerator";
        bbiCodeGenerator.Id = 12;
        bbiCodeGenerator.ImageOptions.SvgImage = Properties.Resources.barcode;
        bbiCodeGenerator.Name = "bbiCodeGenerator";
        bbiCodeGenerator.TargetViewTypeName = "LifeLog.Views.CodesGenerator.CodesGeneratorView";
        // 
        // bbiRollDice
        // 
        bbiRollDice.Caption = "Roll Dice";
        bbiRollDice.Id = 13;
        bbiRollDice.ImageOptions.SvgImage = Properties.Resources.dice_dice;
        bbiRollDice.Name = "bbiRollDice";
        bbiRollDice.TargetViewTypeName = "LifeLog.Views.Dice.DiceGameView";
        // 
        // bbiTicTacToe
        // 
        bbiTicTacToe.Caption = "Tic Tac Toe";
        bbiTicTacToe.Id = 14;
        bbiTicTacToe.ImageOptions.SvgImage = Properties.Resources.tic_tac_toe;
        bbiTicTacToe.Name = "bbiTicTacToe";
        bbiTicTacToe.TargetViewTypeName = "LifeLog.Views.TicTacToe.TicTacToeGameView";
        // 
        // bbiCoinFlip
        // 
        bbiCoinFlip.Caption = "Coin Flip";
        bbiCoinFlip.Id = 16;
        bbiCoinFlip.ImageOptions.SvgImage = Properties.Resources.coin_flip;
        bbiCoinFlip.Name = "bbiCoinFlip";
        bbiCoinFlip.TargetViewTypeName = "LifeLog.Views.CoinFlip.CoinFlipGameView";
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
        // bbiFormOut
        // 
        bbiFormOut.Caption = "Form\r\nOut";
        bbiFormOut.Id = 27;
        bbiFormOut.ImageOptions.SvgImage = Properties.Resources.box_out;
        bbiFormOut.Name = "bbiFormOut";
        bbiFormOut.ItemClick += bbiFormOut_ItemClick;
        // 
        // bbiThreeSimpleRule
        // 
        bbiThreeSimpleRule.Caption = "Three \r\nSimple \r\nRule";
        bbiThreeSimpleRule.Id = 28;
        bbiThreeSimpleRule.ImageOptions.SvgImage = Properties.Resources.above_average;
        bbiThreeSimpleRule.Name = "bbiThreeSimpleRule";
        bbiThreeSimpleRule.ItemClick += bbiThreeSimpleRule_ItemClick;
        // 
        // bbiTestCode
        // 
        bbiTestCode.Caption = "Test\r\nCode";
        bbiTestCode.Id = 29;
        bbiTestCode.ImageOptions.SvgImage = Properties.Resources.bo_attention;
        bbiTestCode.Name = "bbiTestCode";
        bbiTestCode.ItemClick += bbiTestCode_ItemClick;
        // 
        // btsiTopMost
        // 
        btsiTopMost.Caption = "Top Most";
        btsiTopMost.Id = 30;
        btsiTopMost.Name = "btsiTopMost";
        btsiTopMost.CheckedChanged += btsiTopMost_CheckedChanged;
        // 
        // bbiNotes
        // 
        bbiNotes.Caption = "Notes";
        bbiNotes.Id = 31;
        bbiNotes.ImageOptions.SvgImage = Properties.Resources.inserttextbox;
        bbiNotes.Name = "bbiNotes";
        bbiNotes.TargetViewTypeName = "LifeLog.Views.Notes.NotesView";
        // 
        // bbiTasks
        // 
        bbiTasks.Caption = "Tasks";
        bbiTasks.Id = 33;
        bbiTasks.ImageOptions.SvgImage = Properties.Resources.task;
        bbiTasks.Name = "bbiTasks";
        bbiTasks.TargetViewTypeName = "LifeLog.Views.Tasks.TasksView";
        // 
        // bbiPasswords
        // 
        bbiPasswords.Caption = "Passwords";
        bbiPasswords.Id = 34;
        bbiPasswords.ImageOptions.SvgImage = Properties.Resources.security_key;
        bbiPasswords.Name = "bbiPasswords";
        bbiPasswords.TargetViewTypeName = "LifeLog.Views.Passwords.PasswordsView";
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
        ribbonPageGroup1.ItemLinks.Add(bbiNotes);
        ribbonPageGroup1.ItemLinks.Add(bbiCommandsRunner);
        ribbonPageGroup1.ItemLinks.Add(bbiPasswords);
        ribbonPageGroup1.ItemLinks.Add(bbiTasks);
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
        ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2, ribbonPageGroup5 });
        ribbonPage2.ImageOptions.SvgImage = Properties.Resources.DeveloperTools;
        ribbonPage2.ImageOptions.SvgImageSize = new Size(25, 25);
        ribbonPage2.Name = "ribbonPage2";
        ribbonPage2.Text = "Tools";
        // 
        // ribbonPageGroup2
        // 
        ribbonPageGroup2.ItemLinks.Add(bbiPasswordGenerator);
        ribbonPageGroup2.ItemLinks.Add(bbiPdfMerger);
        ribbonPageGroup2.ItemLinks.Add(bbiGradesCalculador);
        ribbonPageGroup2.ItemLinks.Add(bbiConvertText);
        ribbonPageGroup2.ItemLinks.Add(bbiCodeGenerator);
        ribbonPageGroup2.Name = "ribbonPageGroup2";
        ribbonPageGroup2.Text = "Tools";
        // 
        // ribbonPageGroup5
        // 
        ribbonPageGroup5.ItemLinks.Add(bbiFormOut);
        ribbonPageGroup5.ItemLinks.Add(bbiThreeSimpleRule);
        ribbonPageGroup5.Name = "ribbonPageGroup5";
        ribbonPageGroup5.Text = "Functions";
        // 
        // ribbonPage3
        // 
        ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3, ribbonPageGroup6 });
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
        // ribbonPageGroup6
        // 
        ribbonPageGroup6.ItemLinks.Add(bbiTestCode);
        ribbonPageGroup6.Name = "ribbonPageGroup6";
        ribbonPageGroup6.Text = "Test";
        // 
        // ribbonStatusBar
        // 
        ribbonStatusBar.ItemLinks.Add(bsiDatabase);
        ribbonStatusBar.ItemLinks.Add(bsiAppVersion);
        ribbonStatusBar.ItemLinks.Add(bsiTime);
        ribbonStatusBar.ItemLinks.Add(bsiUserMenu);
        ribbonStatusBar.Location = new Point(0, 538);
        ribbonStatusBar.Name = "ribbonStatusBar";
        ribbonStatusBar.Ribbon = ribbon;
        ribbonStatusBar.Size = new Size(945, 37);
        // 
        // mainTimer
        // 
        mainTimer.Enabled = true;
        mainTimer.Interval = 1000;
        mainTimer.Tick += mainTimer_Tick;
        // 
        // layoutControl1
        // 
        layoutControl1.Controls.Add(panelControl1);
        layoutControl1.Dock = DockStyle.Fill;
        layoutControl1.Location = new Point(0, 209);
        layoutControl1.Name = "layoutControl1";
        layoutControl1.Root = Root;
        layoutControl1.Size = new Size(945, 329);
        layoutControl1.TabIndex = 5;
        layoutControl1.Text = "layoutControl1";
        // 
        // panelControl1
        // 
        panelControl1.Controls.Add(navigationFrame);
        panelControl1.Location = new Point(16, 16);
        panelControl1.Name = "panelControl1";
        panelControl1.Size = new Size(913, 297);
        panelControl1.TabIndex = 4;
        // 
        // navigationFrame
        // 
        navigationFrame.Controls.Add(npDashboard);
        navigationFrame.Dock = DockStyle.Fill;
        navigationFrame.Location = new Point(2, 2);
        navigationFrame.Name = "navigationFrame";
        navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { npDashboard });
        navigationFrame.SelectedPage = npDashboard;
        navigationFrame.Size = new Size(909, 293);
        navigationFrame.TabIndex = 0;
        navigationFrame.Text = "navigationFrame1";
        // 
        // npDashboard
        // 
        npDashboard.Caption = "npDashboard";
        npDashboard.Name = "npDashboard";
        npDashboard.Size = new Size(909, 293);
        // 
        // Root
        // 
        Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
        Root.GroupBordersVisible = false;
        Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
        Root.Name = "Root";
        Root.Size = new Size(945, 329);
        Root.TextVisible = false;
        // 
        // layoutControlItem1
        // 
        layoutControlItem1.Control = panelControl1;
        layoutControlItem1.Location = new Point(0, 0);
        layoutControlItem1.Name = "layoutControlItem1";
        layoutControlItem1.Size = new Size(919, 303);
        layoutControlItem1.TextVisible = false;
        // 
        // MainForm
        // 
        Appearance.Options.UseFont = true;
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(945, 575);
        Controls.Add(layoutControl1);
        Controls.Add(ribbon);
        Controls.Add(ribbonStatusBar);
        Name = "MainForm";
        Ribbon = ribbon;
        StartPosition = FormStartPosition.CenterScreen;
        StatusBar = ribbonStatusBar;
        Text = "Mainorm";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
        layoutControl1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
        panelControl1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)navigationFrame).EndInit();
        navigationFrame.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)Root).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
	private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
	private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
	private DevExpress.XtraBars.BarButtonItem bbiShowSettings;
	private LifeLog.Components.BarButtonItemEx bbiCommandsRunner;
	private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
	private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
	private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
	private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
	private LifeLog.Components.BarButtonItemEx bbiPasswordGenerator;
	private LifeLog.Components.BarButtonItemEx bbiPdfMerger;
	private LifeLog.Components.BarButtonItemEx bbiGradesCalculador;
	private LifeLog.Components.BarButtonItemEx bbiConvertText;
	private LifeLog.Components.BarButtonItemEx bbiCodeGenerator;
	private LifeLog.Components.BarButtonItemEx bbiRollDice;
	private LifeLog.Components.BarButtonItemEx bbiTicTacToe;
	private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
	private LifeLog.Components.BarButtonItemEx bbiCoinFlip;
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
	private DevExpress.XtraLayout.LayoutControl layoutControl1;
	private DevExpress.XtraLayout.LayoutControlGroup Root;
	private DevExpress.XtraEditors.PanelControl panelControl1;
	private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
	private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	private DevExpress.XtraBars.BarButtonItem bbiFormOut;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
	private DevExpress.XtraBars.BarButtonItem bbiThreeSimpleRule;
	private DevExpress.XtraBars.BarButtonItem bbiTestCode;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
	private DevExpress.XtraBars.BarToggleSwitchItem btsiTopMost;
	private DevExpress.XtraBars.Navigation.NavigationPage npDashboard;
	private LifeLog.Components.BarButtonItemEx bbiNotes;
	private LifeLog.Components.BarButtonItemEx bbiTasks;
	private LifeLog.Components.BarButtonItemEx bbiPasswords;
}