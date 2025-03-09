namespace Life_Log.Forms
{
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiMenuUser = new DevExpress.XtraBars.BarSubItem();
            this.bbiLogout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHomeNotes = new DevExpress.XtraBars.BarButtonItem();
            this.bsiAppVersion = new DevExpress.XtraBars.BarStaticItem();
            this.btsiSetTopMost = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.bbiHomeCommands = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTablesExternalPrograms = new DevExpress.XtraBars.BarButtonItem();
            this.bsiTime = new DevExpress.XtraBars.BarStaticItem();
            this.bsiSizse = new DevExpress.XtraBars.BarStaticItem();
            this.bsiDatabase = new DevExpress.XtraBars.BarButtonItem();
            this.bsiStatusLabel = new DevExpress.XtraBars.BarStaticItem();
            this.bbiTablesImages = new DevExpress.XtraBars.BarButtonItem();
            this.bbiToolsSqlBrowser = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHomePasswords = new DevExpress.XtraBars.BarButtonItem();
            this.bbiToolsGenereatePassword = new DevExpress.XtraBars.BarButtonItem();
            this.bciThemeLight = new DevExpress.XtraBars.BarCheckItem();
            this.bciThemeDark = new DevExpress.XtraBars.BarCheckItem();
            this.bciThemeSystem = new DevExpress.XtraBars.BarCheckItem();
            this.bbiSettingsApp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTestCode = new DevExpress.XtraBars.BarButtonItem();
            this.bbiToolsThreeSimpleRule = new DevExpress.XtraBars.BarButtonItem();
            this.bbiToolsHostsEditor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEntertainmentTicTacToe = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEntretainmentCoinFlip = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEntretainmentDice = new DevExpress.XtraBars.BarButtonItem();
            this.bbiToolsRdpLaucherView = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTablesVersions = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgHomeMain = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTestButtons = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.npHomeNotesView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.notesView = new Life_Log.Views.Home.Notes.NotesView();
            this.npTableExternalPrograms = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.externalProgramsListView = new Life_Log.Views.Tables.ExternalPrograms.ExternalProgramsListView();
            this.npHomeDashboardView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.npTableImages = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.imagesListView = new Life_Log.Views.Tables.Images.ImagesListView();
            this.npHomeCommadsView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.commandsListView = new Life_Log.Views.Home.Commands.CommandsListView();
            this.npSqlBrowserView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.sqlBrowserView = new Life_Log.Views.Tools.SqlBrowser.SqlBrowserView();
            this.npHomePasswordsView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.passwordsView = new Life_Log.Views.Home.Passwords.PasswordsView();
            this.npToolsPasswordGeneratorView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.passwordGeneratorView = new Life_Log.Views.Tools.PasswordGenerator.PasswordGeneratorView();
            this.npSettingsView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.settingsView = new Life_Log.Views.Settings.SettingsView();
            this.npToolsHotsEditorView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.hostsEditorView = new Life_Log.Views.Tools.HostsEditor.HostsEditorView();
            this.npEntertainmentTicTacToeView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ticTacToeGameView = new Life_Log.Views.Entertainment.TicTacToe.TicTacToeGameView();
            this.npEntertainmentCoinFlipView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.coinFlipGameView = new Life_Log.Views.Entertainment.Games.CoinFlip.CoinFlipGameView();
            this.npEntertainmentDiceView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.diceGameView1 = new Life_Log.Views.Entertainment.Games.Dice.DiceGameView();
            this.npToolsRdpLaucherView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.rdpLaucherView = new Life_Log.Views.Tools.RdpLaucher.RdpLauncherListView();
            this.npTableVersionsView = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.versionsListView = new Life_Log.Views.Tables.Versions.VersionsListView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.npHomeNotesView.SuspendLayout();
            this.npTableExternalPrograms.SuspendLayout();
            this.npTableImages.SuspendLayout();
            this.npHomeCommadsView.SuspendLayout();
            this.npSqlBrowserView.SuspendLayout();
            this.npHomePasswordsView.SuspendLayout();
            this.npToolsPasswordGeneratorView.SuspendLayout();
            this.npSettingsView.SuspendLayout();
            this.npToolsHotsEditorView.SuspendLayout();
            this.npEntertainmentTicTacToeView.SuspendLayout();
            this.npEntertainmentCoinFlipView.SuspendLayout();
            this.npEntertainmentDiceView.SuspendLayout();
            this.npToolsRdpLaucherView.SuspendLayout();
            this.npTableVersionsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationCaption = "Life Log";
            this.ribbon.ApplicationDocumentCaption = "Main Form";
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bsiMenuUser,
            this.ribbon.ExpandCollapseItem,
            this.bbiHomeNotes,
            this.bsiAppVersion,
            this.btsiSetTopMost,
            this.bbiHomeCommands,
            this.bbiTablesExternalPrograms,
            this.bsiTime,
            this.bsiSizse,
            this.bsiDatabase,
            this.bsiStatusLabel,
            this.bbiTablesImages,
            this.bbiToolsSqlBrowser,
            this.bbiHomePasswords,
            this.bbiToolsGenereatePassword,
            this.bciThemeLight,
            this.bciThemeDark,
            this.bciThemeSystem,
            this.bbiSettingsApp,
            this.bbiTestCode,
            this.bbiToolsThreeSimpleRule,
            this.bbiToolsHostsEditor,
            this.bbiEntertainmentTicTacToe,
            this.bbiEntretainmentCoinFlip,
            this.bbiEntretainmentDice,
            this.bbiToolsRdpLaucherView,
            this.bbiTablesVersions,
            this.bbiLogout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ribbon.MaxItemId = 30;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsSearchMenu.SearchItemPosition = DevExpress.XtraBars.Ribbon.SearchItemPosition.Caption;
            this.ribbon.PageHeaderItemLinks.Add(this.btsiSetTopMost);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage4,
            this.ribbonPage2,
            this.ribbonPage6,
            this.ribbonPage5});
            this.ribbon.Size = new System.Drawing.Size(998, 202);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bsiMenuUser
            // 
            this.bsiMenuUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiMenuUser.Caption = "UserName";
            this.bsiMenuUser.Id = 27;
            this.bsiMenuUser.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.actions_user;
            this.bsiMenuUser.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiLogout, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bsiMenuUser.Name = "bsiMenuUser";
            this.bsiMenuUser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.bsiMenuUser.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.False;
            // 
            // bbiLogout
            // 
            this.bbiLogout.Caption = "Logout";
            this.bbiLogout.Id = 28;
            this.bbiLogout.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.power_button_red;
            this.bbiLogout.Name = "bbiLogout";
            // 
            // bbiHomeNotes
            // 
            this.bbiHomeNotes.Caption = "Notes";
            this.bbiHomeNotes.Id = 1;
            this.bbiHomeNotes.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.bo_document;
            this.bbiHomeNotes.Name = "bbiHomeNotes";
            this.bbiHomeNotes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHomeNotes_ItemClick);
            // 
            // bsiAppVersion
            // 
            this.bsiAppVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiAppVersion.Caption = "v0.0.0.0";
            this.bsiAppVersion.Id = 2;
            this.bsiAppVersion.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.bo_fileattachment;
            this.bsiAppVersion.Name = "bsiAppVersion";
            this.bsiAppVersion.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btsiSetTopMost
            // 
            this.btsiSetTopMost.Caption = "Top Most";
            this.btsiSetTopMost.Id = 4;
            this.btsiSetTopMost.Name = "btsiSetTopMost";
            this.btsiSetTopMost.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsiSetTopMost_CheckedChanged);
            // 
            // bbiHomeCommands
            // 
            this.bbiHomeCommands.Caption = "Commands";
            this.bbiHomeCommands.Id = 5;
            this.bbiHomeCommands.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.showallfieldcodes;
            this.bbiHomeCommands.Name = "bbiHomeCommands";
            this.bbiHomeCommands.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHomeCommands_ItemClick);
            // 
            // bbiTablesExternalPrograms
            // 
            this.bbiTablesExternalPrograms.Caption = "External Programs";
            this.bbiTablesExternalPrograms.Id = 6;
            this.bbiTablesExternalPrograms.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.inserttable;
            this.bbiTablesExternalPrograms.Name = "bbiTablesExternalPrograms";
            this.bbiTablesExternalPrograms.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTablesExternalPrograms_ItemClick);
            // 
            // bsiTime
            // 
            this.bsiTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiTime.Caption = "2025/01/09 22:54:23";
            this.bsiTime.Id = 7;
            this.bsiTime.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.time;
            this.bsiTime.Name = "bsiTime";
            this.bsiTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bsiSizse
            // 
            this.bsiSizse.Caption = "1000h X 700w";
            this.bsiSizse.Id = 8;
            this.bsiSizse.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.fittopage;
            this.bsiSizse.Name = "bsiSizse";
            this.bsiSizse.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bsiDatabase
            // 
            this.bsiDatabase.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiDatabase.Caption = "Database";
            this.bsiDatabase.Id = 9;
            this.bsiDatabase.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.actions_database;
            this.bsiDatabase.Name = "bsiDatabase";
            // 
            // bsiStatusLabel
            // 
            this.bsiStatusLabel.Caption = "From Loaded";
            this.bsiStatusLabel.Id = 10;
            this.bsiStatusLabel.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.topbottomrules;
            this.bsiStatusLabel.Name = "bsiStatusLabel";
            this.bsiStatusLabel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiTablesImages
            // 
            this.bbiTablesImages.Caption = "Images";
            this.bbiTablesImages.Id = 11;
            this.bbiTablesImages.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.inserttable;
            this.bbiTablesImages.Name = "bbiTablesImages";
            this.bbiTablesImages.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTablesImages_ItemClick);
            // 
            // bbiToolsSqlBrowser
            // 
            this.bbiToolsSqlBrowser.Caption = "SQL \r\nBrowser";
            this.bbiToolsSqlBrowser.Id = 12;
            this.bbiToolsSqlBrowser.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.sql_reporting;
            this.bbiToolsSqlBrowser.Name = "bbiToolsSqlBrowser";
            this.bbiToolsSqlBrowser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiToolsSqlBrowser_ItemClick);
            // 
            // bbiHomePasswords
            // 
            this.bbiHomePasswords.Caption = "Passwords";
            this.bbiHomePasswords.Id = 13;
            this.bbiHomePasswords.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.password_Icon;
            this.bbiHomePasswords.Name = "bbiHomePasswords";
            this.bbiHomePasswords.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHomePasswords_ItemClick);
            // 
            // bbiToolsGenereatePassword
            // 
            this.bbiToolsGenereatePassword.Caption = "Generate \r\nPasswords";
            this.bbiToolsGenereatePassword.Id = 14;
            this.bbiToolsGenereatePassword.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.bo_resume;
            this.bbiToolsGenereatePassword.Name = "bbiToolsGenereatePassword";
            this.bbiToolsGenereatePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiToolsGenereatePassword_ItemClick);
            // 
            // bciThemeLight
            // 
            this.bciThemeLight.Caption = "Light";
            this.bciThemeLight.Id = 15;
            this.bciThemeLight.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.sun;
            this.bciThemeLight.Name = "bciThemeLight";
            this.bciThemeLight.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciThemeLight_CheckedChanged);
            // 
            // bciThemeDark
            // 
            this.bciThemeDark.Caption = "Dark";
            this.bciThemeDark.Id = 16;
            this.bciThemeDark.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.moon;
            this.bciThemeDark.Name = "bciThemeDark";
            this.bciThemeDark.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciThemeDark_CheckedChanged);
            // 
            // bciThemeSystem
            // 
            this.bciThemeSystem.Caption = "System";
            this.bciThemeSystem.Id = 17;
            this.bciThemeSystem.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.planet;
            this.bciThemeSystem.Name = "bciThemeSystem";
            this.bciThemeSystem.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciThemeSystem_CheckedChanged);
            // 
            // bbiSettingsApp
            // 
            this.bbiSettingsApp.Caption = "App \r\nSettings";
            this.bbiSettingsApp.Id = 18;
            this.bbiSettingsApp.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.yaxissettings;
            this.bbiSettingsApp.Name = "bbiSettingsApp";
            this.bbiSettingsApp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSettingsApp_ItemClick);
            // 
            // bbiTestCode
            // 
            this.bbiTestCode.Caption = "TEST";
            this.bbiTestCode.Id = 19;
            this.bbiTestCode.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.prioritized;
            this.bbiTestCode.Name = "bbiTestCode";
            this.bbiTestCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTestCode_ItemClick);
            // 
            // bbiToolsThreeSimpleRule
            // 
            this.bbiToolsThreeSimpleRule.Caption = "Three Simple Rule";
            this.bbiToolsThreeSimpleRule.Id = 20;
            this.bbiToolsThreeSimpleRule.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.chartstockopenhighlowclose;
            this.bbiToolsThreeSimpleRule.Name = "bbiToolsThreeSimpleRule";
            this.bbiToolsThreeSimpleRule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiToolsThreeSimpleRule_ItemClick);
            // 
            // bbiToolsHostsEditor
            // 
            this.bbiToolsHostsEditor.Caption = "Hosts Editor";
            this.bbiToolsHostsEditor.Id = 21;
            this.bbiToolsHostsEditor.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.richeditbookmark;
            this.bbiToolsHostsEditor.Name = "bbiToolsHostsEditor";
            this.bbiToolsHostsEditor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiToolsHostsEditor_ItemClick);
            // 
            // bbiEntertainmentTicTacToe
            // 
            this.bbiEntertainmentTicTacToe.Caption = "Tic Tac Toe";
            this.bbiEntertainmentTicTacToe.Id = 22;
            this.bbiEntertainmentTicTacToe.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.tic_tac_toe;
            this.bbiEntertainmentTicTacToe.Name = "bbiEntertainmentTicTacToe";
            this.bbiEntertainmentTicTacToe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEntertainmentTicTacToe_ItemClick);
            // 
            // bbiEntretainmentCoinFlip
            // 
            this.bbiEntretainmentCoinFlip.Caption = "Coin Flip";
            this.bbiEntretainmentCoinFlip.Id = 23;
            this.bbiEntretainmentCoinFlip.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.coin_flip;
            this.bbiEntretainmentCoinFlip.Name = "bbiEntretainmentCoinFlip";
            this.bbiEntretainmentCoinFlip.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEntretainmentCoinFlip_ItemClick);
            // 
            // bbiEntretainmentDice
            // 
            this.bbiEntretainmentDice.Caption = "Dice";
            this.bbiEntretainmentDice.Id = 24;
            this.bbiEntretainmentDice.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.dice_dice;
            this.bbiEntretainmentDice.Name = "bbiEntretainmentDice";
            this.bbiEntretainmentDice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEntretainmentDice_ItemClick);
            // 
            // bbiToolsRdpLaucherView
            // 
            this.bbiToolsRdpLaucherView.Caption = "Rdp \r\nConnection";
            this.bbiToolsRdpLaucherView.Id = 25;
            this.bbiToolsRdpLaucherView.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.bo_category1;
            this.bbiToolsRdpLaucherView.Name = "bbiToolsRdpLaucherView";
            this.bbiToolsRdpLaucherView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiToolsRdpLaucherView_ItemClick);
            // 
            // bbiTablesVersions
            // 
            this.bbiTablesVersions.Caption = "Versions";
            this.bbiTablesVersions.Id = 26;
            this.bbiTablesVersions.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.inserttable;
            this.bbiTablesVersions.Name = "bbiTablesVersions";
            this.bbiTablesVersions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTablesVersions_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgHomeMain});
            this.ribbonPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage1.ImageOptions.SvgImage")));
            this.ribbonPage1.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = " Home";
            // 
            // rpgHomeMain
            // 
            this.rpgHomeMain.ItemLinks.Add(this.bbiHomeCommands);
            this.rpgHomeMain.ItemLinks.Add(this.bbiHomeNotes);
            this.rpgHomeMain.ItemLinks.Add(this.bbiHomePasswords);
            this.rpgHomeMain.Name = "rpgHomeMain";
            this.rpgHomeMain.Text = "Main";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage4.ImageOptions.SvgImage")));
            this.ribbonPage4.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = " Tools";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiToolsSqlBrowser);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiToolsGenereatePassword);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiToolsThreeSimpleRule);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiToolsHostsEditor);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiToolsRdpLaucherView);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Actions";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6});
            this.ribbonPage2.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.DuplexLandscapeOneSidedMirrored;
            this.ribbonPage2.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = " Tables";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiTablesExternalPrograms);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiTablesImages);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tables";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.bbiTablesVersions);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Views";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage6.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.Game;
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = " Entertainment";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.bbiEntertainmentTicTacToe);
            this.ribbonPageGroup5.ItemLinks.Add(this.bbiEntretainmentCoinFlip);
            this.ribbonPageGroup5.ItemLinks.Add(this.bbiEntretainmentDice);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Actions";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup3,
            this.rpgTestButtons});
            this.ribbonPage5.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.Setting;
            this.ribbonPage5.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = " Settings";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiSettingsApp);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Actions";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bciThemeLight);
            this.ribbonPageGroup3.ItemLinks.Add(this.bciThemeDark);
            this.ribbonPageGroup3.ItemLinks.Add(this.bciThemeSystem);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Theme";
            // 
            // rpgTestButtons
            // 
            this.rpgTestButtons.ItemLinks.Add(this.bbiTestCode);
            this.rpgTestButtons.Name = "rpgTestButtons";
            this.rpgTestButtons.Text = "TEST";
            this.rpgTestButtons.Visible = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiDatabase);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiTime);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiAppVersion);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiMenuUser, true);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiSizse);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiStatusLabel);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 610);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(998, 39);
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.panelControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 202);
            this.layoutControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(998, 408);
            this.layoutControl.TabIndex = 2;
            this.layoutControl.Text = "layoutControl1";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.navigationFrame);
            this.panelControl.Location = new System.Drawing.Point(16, 16);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(966, 376);
            this.panelControl.TabIndex = 5;
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.npHomeNotesView);
            this.navigationFrame.Controls.Add(this.npTableExternalPrograms);
            this.navigationFrame.Controls.Add(this.npHomeDashboardView);
            this.navigationFrame.Controls.Add(this.npTableImages);
            this.navigationFrame.Controls.Add(this.npHomeCommadsView);
            this.navigationFrame.Controls.Add(this.npSqlBrowserView);
            this.navigationFrame.Controls.Add(this.npHomePasswordsView);
            this.navigationFrame.Controls.Add(this.npToolsPasswordGeneratorView);
            this.navigationFrame.Controls.Add(this.npSettingsView);
            this.navigationFrame.Controls.Add(this.npToolsHotsEditorView);
            this.navigationFrame.Controls.Add(this.npEntertainmentTicTacToeView);
            this.navigationFrame.Controls.Add(this.npEntertainmentCoinFlipView);
            this.navigationFrame.Controls.Add(this.npEntertainmentDiceView);
            this.navigationFrame.Controls.Add(this.npToolsRdpLaucherView);
            this.navigationFrame.Controls.Add(this.npTableVersionsView);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(2, 2);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(0);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npSettingsView,
            this.npHomeDashboardView,
            this.npHomeNotesView,
            this.npTableExternalPrograms,
            this.npTableImages,
            this.npHomeCommadsView,
            this.npSqlBrowserView,
            this.npHomePasswordsView,
            this.npToolsPasswordGeneratorView,
            this.npToolsHotsEditorView,
            this.npEntertainmentTicTacToeView,
            this.npEntertainmentCoinFlipView,
            this.npEntertainmentDiceView,
            this.npToolsRdpLaucherView,
            this.npTableVersionsView});
            this.navigationFrame.SelectedPage = this.npHomeDashboardView;
            this.navigationFrame.Size = new System.Drawing.Size(962, 372);
            this.navigationFrame.TabIndex = 4;
            this.navigationFrame.Text = "Navigation Frame";
            // 
            // npHomeNotesView
            // 
            this.npHomeNotesView.Caption = "npHomeNotesView";
            this.npHomeNotesView.Controls.Add(this.notesView);
            this.npHomeNotesView.Margin = new System.Windows.Forms.Padding(0);
            this.npHomeNotesView.Name = "npHomeNotesView";
            this.npHomeNotesView.Size = new System.Drawing.Size(962, 372);
            // 
            // notesView
            // 
            this.notesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesView.Location = new System.Drawing.Point(0, 0);
            this.notesView.Margin = new System.Windows.Forms.Padding(0);
            this.notesView.Name = "notesView";
            this.notesView.Size = new System.Drawing.Size(962, 372);
            this.notesView.TabIndex = 0;
            // 
            // npTableExternalPrograms
            // 
            this.npTableExternalPrograms.Caption = "npTableExternalPrograms";
            this.npTableExternalPrograms.Controls.Add(this.externalProgramsListView);
            this.npTableExternalPrograms.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.npTableExternalPrograms.Name = "npTableExternalPrograms";
            this.npTableExternalPrograms.Size = new System.Drawing.Size(962, 372);
            // 
            // externalProgramsListView
            // 
            this.externalProgramsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.externalProgramsListView.Location = new System.Drawing.Point(0, 0);
            this.externalProgramsListView.Margin = new System.Windows.Forms.Padding(0);
            this.externalProgramsListView.Name = "externalProgramsListView";
            this.externalProgramsListView.Size = new System.Drawing.Size(962, 372);
            this.externalProgramsListView.TabIndex = 0;
            // 
            // npHomeDashboardView
            // 
            this.npHomeDashboardView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.npHomeDashboardView.Name = "npHomeDashboardView";
            this.npHomeDashboardView.Size = new System.Drawing.Size(962, 372);
            // 
            // npTableImages
            // 
            this.npTableImages.Caption = "npTableImages";
            this.npTableImages.Controls.Add(this.imagesListView);
            this.npTableImages.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.npTableImages.Name = "npTableImages";
            this.npTableImages.Size = new System.Drawing.Size(962, 372);
            // 
            // imagesListView
            // 
            this.imagesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesListView.Location = new System.Drawing.Point(0, 0);
            this.imagesListView.Margin = new System.Windows.Forms.Padding(0);
            this.imagesListView.Name = "imagesListView";
            this.imagesListView.Size = new System.Drawing.Size(962, 372);
            this.imagesListView.TabIndex = 0;
            // 
            // npHomeCommadsView
            // 
            this.npHomeCommadsView.Caption = "npHomeCommadsView";
            this.npHomeCommadsView.Controls.Add(this.commandsListView);
            this.npHomeCommadsView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.npHomeCommadsView.Name = "npHomeCommadsView";
            this.npHomeCommadsView.Size = new System.Drawing.Size(962, 372);
            // 
            // commandsListView
            // 
            this.commandsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsListView.Location = new System.Drawing.Point(0, 0);
            this.commandsListView.Margin = new System.Windows.Forms.Padding(0);
            this.commandsListView.Name = "commandsListView";
            this.commandsListView.Size = new System.Drawing.Size(962, 372);
            this.commandsListView.TabIndex = 0;
            // 
            // npSqlBrowserView
            // 
            this.npSqlBrowserView.Caption = "npSqlBrowserView";
            this.npSqlBrowserView.Controls.Add(this.sqlBrowserView);
            this.npSqlBrowserView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.npSqlBrowserView.Name = "npSqlBrowserView";
            this.npSqlBrowserView.Size = new System.Drawing.Size(962, 372);
            // 
            // sqlBrowserView
            // 
            this.sqlBrowserView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlBrowserView.Location = new System.Drawing.Point(0, 0);
            this.sqlBrowserView.Margin = new System.Windows.Forms.Padding(0);
            this.sqlBrowserView.Name = "sqlBrowserView";
            this.sqlBrowserView.Size = new System.Drawing.Size(962, 372);
            this.sqlBrowserView.TabIndex = 0;
            // 
            // npHomePasswordsView
            // 
            this.npHomePasswordsView.Caption = "npHomePasswordsView";
            this.npHomePasswordsView.Controls.Add(this.passwordsView);
            this.npHomePasswordsView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.npHomePasswordsView.Name = "npHomePasswordsView";
            this.npHomePasswordsView.Size = new System.Drawing.Size(962, 372);
            // 
            // passwordsView
            // 
            this.passwordsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordsView.Location = new System.Drawing.Point(0, 0);
            this.passwordsView.Margin = new System.Windows.Forms.Padding(0);
            this.passwordsView.Name = "passwordsView";
            this.passwordsView.Size = new System.Drawing.Size(962, 372);
            this.passwordsView.TabIndex = 0;
            // 
            // npToolsPasswordGeneratorView
            // 
            this.npToolsPasswordGeneratorView.Caption = "npToolsPasswordGeneratorView";
            this.npToolsPasswordGeneratorView.Controls.Add(this.passwordGeneratorView);
            this.npToolsPasswordGeneratorView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.npToolsPasswordGeneratorView.Name = "npToolsPasswordGeneratorView";
            this.npToolsPasswordGeneratorView.Size = new System.Drawing.Size(962, 372);
            // 
            // passwordGeneratorView
            // 
            this.passwordGeneratorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordGeneratorView.Location = new System.Drawing.Point(0, 0);
            this.passwordGeneratorView.Margin = new System.Windows.Forms.Padding(0);
            this.passwordGeneratorView.Name = "passwordGeneratorView";
            this.passwordGeneratorView.Size = new System.Drawing.Size(962, 372);
            this.passwordGeneratorView.TabIndex = 0;
            // 
            // npSettingsView
            // 
            this.npSettingsView.Caption = "npSettingsView";
            this.npSettingsView.Controls.Add(this.settingsView);
            this.npSettingsView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.npSettingsView.Name = "npSettingsView";
            this.npSettingsView.Size = new System.Drawing.Size(962, 372);
            // 
            // settingsView
            // 
            this.settingsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsView.Location = new System.Drawing.Point(0, 0);
            this.settingsView.Margin = new System.Windows.Forms.Padding(0);
            this.settingsView.Name = "settingsView";
            this.settingsView.Size = new System.Drawing.Size(962, 372);
            this.settingsView.TabIndex = 0;
            // 
            // npToolsHotsEditorView
            // 
            this.npToolsHotsEditorView.Caption = "npToolsHotsEditorView";
            this.npToolsHotsEditorView.Controls.Add(this.hostsEditorView);
            this.npToolsHotsEditorView.Name = "npToolsHotsEditorView";
            this.npToolsHotsEditorView.Size = new System.Drawing.Size(962, 372);
            // 
            // hostsEditorView
            // 
            this.hostsEditorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostsEditorView.Location = new System.Drawing.Point(0, 0);
            this.hostsEditorView.Margin = new System.Windows.Forms.Padding(0);
            this.hostsEditorView.Name = "hostsEditorView";
            this.hostsEditorView.Size = new System.Drawing.Size(962, 372);
            this.hostsEditorView.TabIndex = 0;
            // 
            // npEntertainmentTicTacToeView
            // 
            this.npEntertainmentTicTacToeView.Caption = "npEntertainmentTicTacToeView";
            this.npEntertainmentTicTacToeView.Controls.Add(this.ticTacToeGameView);
            this.npEntertainmentTicTacToeView.Name = "npEntertainmentTicTacToeView";
            this.npEntertainmentTicTacToeView.Size = new System.Drawing.Size(962, 372);
            // 
            // ticTacToeGameView
            // 
            this.ticTacToeGameView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticTacToeGameView.Location = new System.Drawing.Point(0, 0);
            this.ticTacToeGameView.Margin = new System.Windows.Forms.Padding(0);
            this.ticTacToeGameView.Name = "ticTacToeGameView";
            this.ticTacToeGameView.Size = new System.Drawing.Size(962, 372);
            this.ticTacToeGameView.TabIndex = 0;
            // 
            // npEntertainmentCoinFlipView
            // 
            this.npEntertainmentCoinFlipView.Caption = "npEntertainmentCoinFlipView";
            this.npEntertainmentCoinFlipView.Controls.Add(this.coinFlipGameView);
            this.npEntertainmentCoinFlipView.Name = "npEntertainmentCoinFlipView";
            this.npEntertainmentCoinFlipView.Size = new System.Drawing.Size(962, 372);
            // 
            // coinFlipGameView
            // 
            this.coinFlipGameView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coinFlipGameView.Location = new System.Drawing.Point(0, 0);
            this.coinFlipGameView.Margin = new System.Windows.Forms.Padding(0);
            this.coinFlipGameView.Name = "coinFlipGameView";
            this.coinFlipGameView.Size = new System.Drawing.Size(962, 372);
            this.coinFlipGameView.TabIndex = 0;
            // 
            // npEntertainmentDiceView
            // 
            this.npEntertainmentDiceView.Caption = "npEntertainmentDiceView";
            this.npEntertainmentDiceView.Controls.Add(this.diceGameView1);
            this.npEntertainmentDiceView.Name = "npEntertainmentDiceView";
            this.npEntertainmentDiceView.Size = new System.Drawing.Size(962, 372);
            // 
            // diceGameView1
            // 
            this.diceGameView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diceGameView1.Location = new System.Drawing.Point(0, 0);
            this.diceGameView1.Margin = new System.Windows.Forms.Padding(0);
            this.diceGameView1.Name = "diceGameView1";
            this.diceGameView1.Size = new System.Drawing.Size(962, 372);
            this.diceGameView1.TabIndex = 0;
            // 
            // npToolsRdpLaucherView
            // 
            this.npToolsRdpLaucherView.Caption = "npToolsRdpLaucherView";
            this.npToolsRdpLaucherView.Controls.Add(this.rdpLaucherView);
            this.npToolsRdpLaucherView.Name = "npToolsRdpLaucherView";
            this.npToolsRdpLaucherView.Size = new System.Drawing.Size(962, 372);
            // 
            // rdpLaucherView
            // 
            this.rdpLaucherView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdpLaucherView.Location = new System.Drawing.Point(0, 0);
            this.rdpLaucherView.Name = "rdpLaucherView";
            this.rdpLaucherView.Size = new System.Drawing.Size(962, 372);
            this.rdpLaucherView.TabIndex = 0;
            // 
            // npTableVersionsView
            // 
            this.npTableVersionsView.Caption = "npTableVersionsView";
            this.npTableVersionsView.Controls.Add(this.versionsListView);
            this.npTableVersionsView.Name = "npTableVersionsView";
            this.npTableVersionsView.Size = new System.Drawing.Size(962, 372);
            // 
            // versionsListView
            // 
            this.versionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionsListView.Location = new System.Drawing.Point(0, 0);
            this.versionsListView.Margin = new System.Windows.Forms.Padding(0);
            this.versionsListView.Name = "versionsListView";
            this.versionsListView.Size = new System.Drawing.Size(962, 372);
            this.versionsListView.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(998, 408);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(972, 382);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Text = "ribbonPage7";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 649);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = global::Life_Log.Properties.Resources.icon_svg;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "RibbonForm1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.npHomeNotesView.ResumeLayout(false);
            this.npTableExternalPrograms.ResumeLayout(false);
            this.npTableImages.ResumeLayout(false);
            this.npHomeCommadsView.ResumeLayout(false);
            this.npSqlBrowserView.ResumeLayout(false);
            this.npHomePasswordsView.ResumeLayout(false);
            this.npToolsPasswordGeneratorView.ResumeLayout(false);
            this.npSettingsView.ResumeLayout(false);
            this.npToolsHotsEditorView.ResumeLayout(false);
            this.npEntertainmentTicTacToeView.ResumeLayout(false);
            this.npEntertainmentCoinFlipView.ResumeLayout(false);
            this.npEntertainmentDiceView.ResumeLayout(false);
            this.npToolsRdpLaucherView.ResumeLayout(false);
            this.npTableVersionsView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHomeMain;
        private DevExpress.XtraBars.BarButtonItem bbiHomeNotes;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage npHomeNotesView;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Views.Home.Notes.NotesView notesView;
        private DevExpress.XtraBars.Navigation.NavigationPage npHomeDashboardView;
        private DevExpress.XtraBars.BarStaticItem bsiAppVersion;
        private DevExpress.XtraBars.BarToggleSwitchItem btsiSetTopMost;
        private DevExpress.XtraBars.BarButtonItem bbiHomeCommands;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem bbiTablesExternalPrograms;
        private DevExpress.XtraBars.Navigation.NavigationPage npTableExternalPrograms;
        private Views.Tables.ExternalPrograms.ExternalProgramsListView externalProgramsListView;
        private DevExpress.XtraBars.BarStaticItem bsiTime;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraBars.BarStaticItem bsiSizse;
        private DevExpress.XtraBars.BarButtonItem bsiDatabase;
        public DevExpress.XtraBars.BarStaticItem bsiStatusLabel;
        private DevExpress.XtraBars.BarButtonItem bbiTablesImages;
        private DevExpress.XtraBars.Navigation.NavigationPage npTableImages;
        private Views.Tables.Images.ImagesListView imagesListView;
        private DevExpress.XtraBars.Navigation.NavigationPage npHomeCommadsView;
        private Views.Home.Commands.CommandsListView commandsListView;
        private DevExpress.XtraBars.BarButtonItem bbiToolsSqlBrowser;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Navigation.NavigationPage npSqlBrowserView;
        private Views.Tools.SqlBrowser.SqlBrowserView sqlBrowserView;
        private DevExpress.XtraBars.BarButtonItem bbiHomePasswords;
        private DevExpress.XtraBars.Navigation.NavigationPage npHomePasswordsView;
        private Views.Home.Passwords.PasswordsView passwordsView;
        private DevExpress.XtraBars.BarButtonItem bbiToolsGenereatePassword;
        private DevExpress.XtraBars.Navigation.NavigationPage npToolsPasswordGeneratorView;
        private Views.Tools.PasswordGenerator.PasswordGeneratorView passwordGeneratorView;
        private DevExpress.XtraBars.BarCheckItem bciThemeLight;
        private DevExpress.XtraBars.BarCheckItem bciThemeDark;
        private DevExpress.XtraBars.BarCheckItem bciThemeSystem;
        private DevExpress.XtraBars.BarButtonItem bbiSettingsApp;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Navigation.NavigationPage npSettingsView;
        private Views.Settings.SettingsView settingsView;
        private DevExpress.XtraBars.BarButtonItem bbiTestCode;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTestButtons;
        public DevExpress.XtraLayout.LayoutControl layoutControl;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        public DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiToolsThreeSimpleRule;
        private DevExpress.XtraBars.BarButtonItem bbiToolsHostsEditor;
        private DevExpress.XtraBars.Navigation.NavigationPage npToolsHotsEditorView;
        private Views.Tools.HostsEditor.HostsEditorView hostsEditorView;
        private DevExpress.XtraBars.BarButtonItem bbiEntertainmentTicTacToe;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraBars.Navigation.NavigationPage npEntertainmentTicTacToeView;
        private Views.Entertainment.TicTacToe.TicTacToeGameView ticTacToeGameView;
        private DevExpress.XtraBars.BarButtonItem bbiEntretainmentCoinFlip;
        private DevExpress.XtraBars.Navigation.NavigationPage npEntertainmentCoinFlipView;
        private Views.Entertainment.Games.CoinFlip.CoinFlipGameView coinFlipGameView;
        private DevExpress.XtraBars.BarButtonItem bbiEntretainmentDice;
        private DevExpress.XtraBars.Navigation.NavigationPage npEntertainmentDiceView;
        private Views.Entertainment.Games.Dice.DiceGameView diceGameView1;
        private DevExpress.XtraBars.BarButtonItem bbiToolsRdpLaucherView;
        private DevExpress.XtraBars.Navigation.NavigationPage npToolsRdpLaucherView;
        private Views.Tools.RdpLaucher.RdpLauncherListView rdpLaucherView;
        private DevExpress.XtraBars.Navigation.NavigationPage npTableVersionsView;
        private Views.Tables.Versions.VersionsListView versionsListView;
        private DevExpress.XtraBars.BarButtonItem bbiTablesVersions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarSubItem bsiMenuUser;
        private DevExpress.XtraBars.BarButtonItem bbiLogout;
    }
}