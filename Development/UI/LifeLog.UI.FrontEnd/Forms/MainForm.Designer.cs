namespace LifeLog.UI.FrontEnd.Forms
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
			this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
			this.backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
			this.databaseSettingsView1 = new LifeLog.UI.Common.Views.DatabaseSettingsView();
			this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
			this.modulesSetting = new LifeLog.UI.FrontEnd.Views.Settings.ModulesSetting();
			this.bvtiDatabaseSettings = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
			this.bvtiModulesSettings = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
			this.bbiSettingsApp = new DevExpress.XtraBars.BarButtonItem();
			this.bbiNotes = new DevExpress.XtraBars.BarButtonItem();
			this.bbiRollDice = new DevExpress.XtraBars.BarButtonItem();
			this.bbiFlipCoin = new DevExpress.XtraBars.BarButtonItem();
			this.bbiTicTacToe = new DevExpress.XtraBars.BarButtonItem();
			this.bbiPasswordGenerator = new DevExpress.XtraBars.BarButtonItem();
			this.btsiTopMost = new DevExpress.XtraBars.BarToggleSwitchItem();
			this.bbiPdfMerger = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
			this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
			this.bsiTime = new DevExpress.XtraBars.BarStaticItem();
			this.bsiUserMenu = new DevExpress.XtraBars.BarSubItem();
			this.bbiLogoutUser = new DevExpress.XtraBars.BarButtonItem();
			this.bbiGradesCalculador = new DevExpress.XtraBars.BarButtonItem();
			this.bbiFormOut = new DevExpress.XtraBars.BarButtonItem();
			this.bbiCommandsRunner = new DevExpress.XtraBars.BarButtonItem();
			this.Passwords = new DevExpress.XtraBars.BarButtonItem();
			this.bbiWeather = new DevExpress.XtraBars.BarButtonItem();
			this.bbiConvertText = new DevExpress.XtraBars.BarButtonItem();
			this.bbiThreeSimpleRule = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.rpgHome = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.bsiStatusLabel = new DevExpress.XtraBars.BarStaticItem();
			this.bsiDatabase = new DevExpress.XtraBars.BarStaticItem();
			this.bsiAppVersion = new DevExpress.XtraBars.BarStaticItem();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
			this.npHome = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
			this.backstageViewControl1.SuspendLayout();
			this.backstageViewClientControl2.SuspendLayout();
			this.backstageViewClientControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
			this.navigationFrame.SuspendLayout();
			this.npHome.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbon
			// 
			this.ribbon.ApplicationButtonDropDownControl = this.backstageViewControl1;
			this.ribbon.ApplicationCaption = "Frontend";
			this.ribbon.ApplicationDocumentCaption = "Main";
			this.ribbon.CaptionBarItemLinks.Add(this.bbiSettingsApp);
			this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.ribbon.ExpandCollapseItem.Id = 0;
			this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiSettingsApp,
            this.ribbon.ExpandCollapseItem,
            this.bbiNotes,
            this.bbiRollDice,
            this.bbiFlipCoin,
            this.bbiTicTacToe,
            this.bbiPasswordGenerator,
            this.btsiTopMost,
            this.bbiPdfMerger,
            this.barButtonItem1,
            this.skinDropDownButtonItem1,
            this.skinPaletteRibbonGalleryBarItem1,
            this.bsiTime,
            this.bsiUserMenu,
            this.bbiLogoutUser,
            this.bbiGradesCalculador,
            this.bbiFormOut,
            this.bbiCommandsRunner,
            this.Passwords,
            this.bbiWeather,
            this.bbiConvertText,
            this.bbiThreeSimpleRule});
			this.ribbon.Location = new System.Drawing.Point(0, 0);
			this.ribbon.Margin = new System.Windows.Forms.Padding(4);
			this.ribbon.MaxItemId = 23;
			this.ribbon.Name = "ribbon";
			this.ribbon.OptionsMenuMinWidth = 385;
			this.ribbon.OptionsSearchMenu.SearchItemPosition = DevExpress.XtraBars.Ribbon.SearchItemPosition.Caption;
			this.ribbon.PageHeaderItemLinks.Add(this.btsiTopMost);
			this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage4,
            this.ribbonPage6});
			this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
			this.ribbon.ShowToolbarCustomizeItem = false;
			this.ribbon.Size = new System.Drawing.Size(1322, 177);
			this.ribbon.StatusBar = this.ribbonStatusBar;
			this.ribbon.Toolbar.ShowCustomizeItem = false;
			this.ribbon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClickAsync);
			// 
			// backstageViewControl1
			// 
			this.backstageViewControl1.Controls.Add(this.backstageViewClientControl2);
			this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
			this.backstageViewControl1.Items.Add(this.bvtiDatabaseSettings);
			this.backstageViewControl1.Items.Add(this.bvtiModulesSettings);
			this.backstageViewControl1.Location = new System.Drawing.Point(26, 34);
			this.backstageViewControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.backstageViewControl1.Name = "backstageViewControl1";
			this.backstageViewControl1.OwnerControl = this.ribbon;
			this.backstageViewControl1.SelectedTab = this.bvtiDatabaseSettings;
			this.backstageViewControl1.SelectedTabIndex = 0;
			this.backstageViewControl1.Size = new System.Drawing.Size(669, 251);
			this.backstageViewControl1.TabIndex = 5;
			this.backstageViewControl1.Text = "Settings";
			// 
			// backstageViewClientControl2
			// 
			this.backstageViewClientControl2.Controls.Add(this.databaseSettingsView1);
			this.backstageViewClientControl2.Location = new System.Drawing.Point(137, 63);
			this.backstageViewClientControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.backstageViewClientControl2.Name = "backstageViewClientControl2";
			this.backstageViewClientControl2.Size = new System.Drawing.Size(531, 187);
			this.backstageViewClientControl2.TabIndex = 2;
			// 
			// databaseSettingsView1
			// 
			this.databaseSettingsView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.databaseSettingsView1.Location = new System.Drawing.Point(0, 0);
			this.databaseSettingsView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.databaseSettingsView1.Name = "databaseSettingsView1";
			this.databaseSettingsView1.Size = new System.Drawing.Size(531, 187);
			this.databaseSettingsView1.TabIndex = 0;
			// 
			// backstageViewClientControl1
			// 
			this.backstageViewClientControl1.Controls.Add(this.modulesSetting);
			this.backstageViewClientControl1.Location = new System.Drawing.Point(137, 63);
			this.backstageViewClientControl1.Name = "backstageViewClientControl1";
			this.backstageViewClientControl1.Size = new System.Drawing.Size(531, 187);
			this.backstageViewClientControl1.TabIndex = 3;
			// 
			// modulesSetting
			// 
			this.modulesSetting.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modulesSetting.Location = new System.Drawing.Point(0, 0);
			this.modulesSetting.Name = "modulesSetting";
			this.modulesSetting.Size = new System.Drawing.Size(531, 187);
			this.modulesSetting.TabIndex = 0;
			// 
			// bvtiDatabaseSettings
			// 
			this.bvtiDatabaseSettings.Caption = "Database";
			this.bvtiDatabaseSettings.ContentControl = this.backstageViewClientControl2;
			this.bvtiDatabaseSettings.Name = "bvtiDatabaseSettings";
			this.bvtiDatabaseSettings.Selected = true;
			// 
			// bvtiModulesSettings
			// 
			this.bvtiModulesSettings.Caption = "Modules";
			this.bvtiModulesSettings.ContentControl = this.backstageViewClientControl1;
			this.bvtiModulesSettings.Name = "bvtiModulesSettings";
			// 
			// bbiSettingsApp
			// 
			this.bbiSettingsApp.Caption = "Settings";
			this.bbiSettingsApp.Id = 8;
			this.bbiSettingsApp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSettingsApp.ImageOptions.SvgImage")));
			this.bbiSettingsApp.Name = "bbiSettingsApp";
			this.bbiSettingsApp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSettingsApp_ItemClick);
			// 
			// bbiNotes
			// 
			this.bbiNotes.Caption = "Notes";
			this.bbiNotes.Id = 1;
			this.bbiNotes.ImageOptions.SvgImage = global::LifeLog.Base.Assets.Resources.inserttextbox;
			this.bbiNotes.Name = "bbiNotes";
			this.bbiNotes.Tag = "Main.Notes.NotesView";
			// 
			// bbiRollDice
			// 
			this.bbiRollDice.Caption = "Roll Dice";
			this.bbiRollDice.Id = 2;
			this.bbiRollDice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiRollDice.ImageOptions.SvgImage")));
			this.bbiRollDice.Name = "bbiRollDice";
			this.bbiRollDice.Tag = "Entertainment.Dice.DiceGameView";
			// 
			// bbiFlipCoin
			// 
			this.bbiFlipCoin.Caption = "Coin Filp";
			this.bbiFlipCoin.Id = 3;
			this.bbiFlipCoin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiFlipCoin.ImageOptions.SvgImage")));
			this.bbiFlipCoin.Name = "bbiFlipCoin";
			this.bbiFlipCoin.Tag = "Entertainment.CoinFlip.CoinFlipGameView";
			// 
			// bbiTicTacToe
			// 
			this.bbiTicTacToe.Caption = "Tic Tac Toe";
			this.bbiTicTacToe.Id = 4;
			this.bbiTicTacToe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiTicTacToe.ImageOptions.SvgImage")));
			this.bbiTicTacToe.Name = "bbiTicTacToe";
			this.bbiTicTacToe.Tag = "Entertainment.TicTacToe.TicTacToeGameView";
			// 
			// bbiPasswordGenerator
			// 
			this.bbiPasswordGenerator.Caption = "Password Generator";
			this.bbiPasswordGenerator.Id = 5;
			this.bbiPasswordGenerator.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiPasswordGenerator.ImageOptions.SvgImage")));
			this.bbiPasswordGenerator.Name = "bbiPasswordGenerator";
			this.bbiPasswordGenerator.Tag = "Tools.PasswordGenerator.PasswordGeneratorView";
			// 
			// btsiTopMost
			// 
			this.btsiTopMost.Caption = "Top Most";
			this.btsiTopMost.Id = 6;
			this.btsiTopMost.Name = "btsiTopMost";
			this.btsiTopMost.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsiTopMost_CheckedChanged);
			// 
			// bbiPdfMerger
			// 
			this.bbiPdfMerger.Caption = "Pdf Merger";
			this.bbiPdfMerger.Id = 7;
			this.bbiPdfMerger.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiPdfMerger.ImageOptions.SvgImage")));
			this.bbiPdfMerger.Name = "bbiPdfMerger";
			this.bbiPdfMerger.Tag = "Tools.PdfMerger.PdfMergerView";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "barButtonItem1";
			this.barButtonItem1.Id = 9;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// skinDropDownButtonItem1
			// 
			this.skinDropDownButtonItem1.Id = 11;
			this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
			// 
			// skinPaletteRibbonGalleryBarItem1
			// 
			this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
			this.skinPaletteRibbonGalleryBarItem1.Id = 12;
			this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
			// 
			// bsiTime
			// 
			this.bsiTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bsiTime.Caption = "<TIME>";
			this.bsiTime.Id = 13;
			this.bsiTime.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsiTime.ImageOptions.SvgImage")));
			this.bsiTime.Name = "bsiTime";
			this.bsiTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// bsiUserMenu
			// 
			this.bsiUserMenu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bsiUserMenu.Caption = "<USER>";
			this.bsiUserMenu.Id = 14;
			this.bsiUserMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsiUserMenu.ImageOptions.SvgImage")));
			this.bsiUserMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiLogoutUser)});
			this.bsiUserMenu.Name = "bsiUserMenu";
			// 
			// bbiLogoutUser
			// 
			this.bbiLogoutUser.Caption = "Logout";
			this.bbiLogoutUser.Id = 15;
			this.bbiLogoutUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiLogoutUser.ImageOptions.SvgImage")));
			this.bbiLogoutUser.Name = "bbiLogoutUser";
			this.bbiLogoutUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLogoutUser_ItemClick);
			// 
			// bbiGradesCalculador
			// 
			this.bbiGradesCalculador.Caption = "Grades\r\nCalculator";
			this.bbiGradesCalculador.Id = 16;
			this.bbiGradesCalculador.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiGradesCalculador.ImageOptions.SvgImage")));
			this.bbiGradesCalculador.Name = "bbiGradesCalculador";
			this.bbiGradesCalculador.Tag = "Tools.GradesCalculator.GradesCalculatorView";
			// 
			// bbiFormOut
			// 
			this.bbiFormOut.Caption = "Form Out";
			this.bbiFormOut.Id = 17;
			this.bbiFormOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiFormOut.ImageOptions.SvgImage")));
			this.bbiFormOut.Name = "bbiFormOut";
			this.bbiFormOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFormOut_ItemClick);
			// 
			// bbiCommandsRunner
			// 
			this.bbiCommandsRunner.Caption = "Commands\r\nRunner";
			this.bbiCommandsRunner.Id = 18;
			this.bbiCommandsRunner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiCommandsRunner.ImageOptions.SvgImage")));
			this.bbiCommandsRunner.Name = "bbiCommandsRunner";
			this.bbiCommandsRunner.Tag = "Main.CommandsRunner.CommandsRunnerView";
			// 
			// Passwords
			// 
			this.Passwords.Caption = "Passwords";
			this.Passwords.Id = 19;
			this.Passwords.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Passwords.ImageOptions.SvgImage")));
			this.Passwords.Name = "Passwords";
			this.Passwords.Tag = "Main.Passwords.PasswordsView";
			// 
			// bbiWeather
			// 
			this.bbiWeather.Caption = "Weather";
			this.bbiWeather.Id = 20;
			this.bbiWeather.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiWeather.ImageOptions.SvgImage")));
			this.bbiWeather.Name = "bbiWeather";
			this.bbiWeather.Tag = "Main.Weather.WeatherView";
			// 
			// bbiConvertText
			// 
			this.bbiConvertText.Caption = "Convert Text";
			this.bbiConvertText.Id = 21;
			this.bbiConvertText.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiConvertText.ImageOptions.SvgImage")));
			this.bbiConvertText.Name = "bbiConvertText";
			this.bbiConvertText.Tag = "Tools.ConvertCase.ConvertCaseView";
			// 
			// bbiThreeSimpleRule
			// 
			this.bbiThreeSimpleRule.Caption = "Three Simple Rule";
			this.bbiThreeSimpleRule.Id = 22;
			this.bbiThreeSimpleRule.ImageOptions.SvgImage = global::LifeLog.Base.Assets.Resources.above_average;
			this.bbiThreeSimpleRule.Name = "bbiThreeSimpleRule";
			this.bbiThreeSimpleRule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThreeSimpleRule_ItemClick);
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgHome});
			this.ribbonPage1.ImageOptions.SvgImage = global::LifeLog.Base.Assets.Resources.Home;
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Home";
			// 
			// rpgHome
			// 
			this.rpgHome.ItemLinks.Add(this.bbiNotes);
			this.rpgHome.ItemLinks.Add(this.bbiCommandsRunner);
			this.rpgHome.ItemLinks.Add(this.Passwords);
			this.rpgHome.ItemLinks.Add(this.bbiWeather);
			this.rpgHome.Name = "rpgHome";
			this.rpgHome.Text = "Main";
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
			this.ribbonPage2.ImageOptions.SvgImage = global::LifeLog.Base.Assets.Resources.Game;
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "Entertainment";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.bbiRollDice);
			this.ribbonPageGroup2.ItemLinks.Add(this.bbiFlipCoin);
			this.ribbonPageGroup2.ItemLinks.Add(this.bbiTicTacToe);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Games";
			// 
			// ribbonPage4
			// 
			this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
			this.ribbonPage4.ImageOptions.SvgImage = global::LifeLog.Base.Assets.Resources.DeveloperTools;
			this.ribbonPage4.Name = "ribbonPage4";
			this.ribbonPage4.Text = "Tools";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.bbiPasswordGenerator);
			this.ribbonPageGroup1.ItemLinks.Add(this.bbiPdfMerger);
			this.ribbonPageGroup1.ItemLinks.Add(this.bbiGradesCalculador);
			this.ribbonPageGroup1.ItemLinks.Add(this.bbiConvertText);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Tools";
			// 
			// ribbonPageGroup5
			// 
			this.ribbonPageGroup5.ItemLinks.Add(this.bbiFormOut);
			this.ribbonPageGroup5.ItemLinks.Add(this.bbiThreeSimpleRule);
			this.ribbonPageGroup5.Name = "ribbonPageGroup5";
			this.ribbonPageGroup5.Text = "Functions";
			// 
			// ribbonPage6
			// 
			this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
			this.ribbonPage6.ImageOptions.SvgImage = global::LifeLog.Base.Assets.Resources.Setting;
			this.ribbonPage6.Name = "ribbonPage6";
			this.ribbonPage6.Text = "Settings";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.bbiSettingsApp);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "Settings";
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.ItemLinks.Add(this.skinDropDownButtonItem1);
			this.ribbonPageGroup4.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
			this.ribbonPageGroup4.Name = "ribbonPageGroup4";
			this.ribbonPageGroup4.Text = "Theme";
			// 
			// ribbonStatusBar
			// 
			this.ribbonStatusBar.ItemLinks.Add(this.bsiStatusLabel);
			this.ribbonStatusBar.ItemLinks.Add(this.bsiDatabase);
			this.ribbonStatusBar.ItemLinks.Add(this.bsiAppVersion);
			this.ribbonStatusBar.ItemLinks.Add(this.bsiTime);
			this.ribbonStatusBar.ItemLinks.Add(this.bsiUserMenu);
			this.ribbonStatusBar.Location = new System.Drawing.Point(0, 702);
			this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ribbonStatusBar.Name = "ribbonStatusBar";
			this.ribbonStatusBar.Ribbon = this.ribbon;
			this.ribbonStatusBar.Size = new System.Drawing.Size(1322, 24);
			// 
			// bsiStatusLabel
			// 
			this.bsiStatusLabel.Caption = "<STATUS>";
			this.bsiStatusLabel.Id = 7;
			this.bsiStatusLabel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsiStatusLabel.ImageOptions.SvgImage")));
			this.bsiStatusLabel.Name = "bsiStatusLabel";
			this.bsiStatusLabel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// bsiDatabase
			// 
			this.bsiDatabase.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bsiDatabase.Caption = "<DATABASE>";
			this.bsiDatabase.Id = 9;
			this.bsiDatabase.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsiDatabase.ImageOptions.SvgImage")));
			this.bsiDatabase.Name = "bsiDatabase";
			this.bsiDatabase.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// bsiAppVersion
			// 
			this.bsiAppVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bsiAppVersion.Caption = "<VERSION>";
			this.bsiAppVersion.Id = 10;
			this.bsiAppVersion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsiAppVersion.ImageOptions.SvgImage")));
			this.bsiAppVersion.Name = "bsiAppVersion";
			this.bsiAppVersion.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.panelControl1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 177);
			this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(1322, 525);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.navigationFrame);
			this.panelControl1.Location = new System.Drawing.Point(12, 12);
			this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1298, 501);
			this.panelControl1.TabIndex = 4;
			// 
			// navigationFrame
			// 
			this.navigationFrame.Controls.Add(this.npHome);
			this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.navigationFrame.Location = new System.Drawing.Point(2, 2);
			this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.navigationFrame.Name = "navigationFrame";
			this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npHome});
			this.navigationFrame.SelectedPage = this.npHome;
			this.navigationFrame.Size = new System.Drawing.Size(1294, 497);
			this.navigationFrame.TabIndex = 0;
			this.navigationFrame.Text = "navigationFrame1";
			// 
			// npHome
			// 
			this.npHome.Controls.Add(this.backstageViewControl1);
			this.npHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.npHome.Name = "npHome";
			this.npHome.Size = new System.Drawing.Size(1294, 497);
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1322, 525);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.panelControl1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1302, 505);
			this.layoutControlItem1.TextVisible = false;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// ribbonPage3
			// 
			this.ribbonPage3.Name = "ribbonPage3";
			this.ribbonPage3.Text = "ribbonPage3";
			// 
			// ribbonPage5
			// 
			this.ribbonPage5.Name = "ribbonPage5";
			this.ribbonPage5.Text = "ribbonPage5";
			// 
			// ribbonPage7
			// 
			this.ribbonPage7.Name = "ribbonPage7";
			this.ribbonPage7.Text = "ribbonPage7";
			// 
			// MainForm
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1322, 726);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.ribbonStatusBar);
			this.Controls.Add(this.ribbon);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.IconOptions.Image = global::LifeLog.Base.Assets.Resources.icon;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Ribbon = this.ribbon;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar;
			this.Text = "FrontEnd - ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
			this.backstageViewControl1.ResumeLayout(false);
			this.backstageViewClientControl2.ResumeLayout(false);
			this.backstageViewClientControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
			this.navigationFrame.ResumeLayout(false);
			this.npHome.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHome;
		private DevExpress.XtraBars.BarButtonItem bbiNotes;
		internal DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		private DevExpress.XtraBars.BarStaticItem bsiDatabase;
		private DevExpress.XtraBars.BarStaticItem bsiAppVersion;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
		private DevExpress.XtraBars.Navigation.NavigationPage npHome;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		public DevExpress.XtraBars.BarStaticItem bsiStatusLabel;
		private System.Windows.Forms.Timer timer;
		private DevExpress.XtraBars.BarButtonItem bbiRollDice;
		private DevExpress.XtraBars.BarButtonItem bbiFlipCoin;
		private DevExpress.XtraBars.BarButtonItem bbiTicTacToe;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
		private DevExpress.XtraBars.BarButtonItem bbiPasswordGenerator;
		private DevExpress.XtraBars.BarToggleSwitchItem btsiTopMost;
		private DevExpress.XtraBars.BarButtonItem bbiPdfMerger;
		private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
		private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
		private Common.Views.DatabaseSettingsView databaseSettingsView1;
		private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtiDatabaseSettings;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
		private DevExpress.XtraBars.BarButtonItem bbiSettingsApp;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
		private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.BarStaticItem bsiTime;
		private DevExpress.XtraBars.BarSubItem bsiUserMenu;
		private DevExpress.XtraBars.BarButtonItem bbiLogoutUser;
		private DevExpress.XtraBars.BarButtonItem bbiGradesCalculador;
		private DevExpress.XtraBars.BarButtonItem bbiFormOut;
		private DevExpress.XtraBars.BarButtonItem bbiCommandsRunner;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private DevExpress.XtraBars.BarButtonItem Passwords;
		private DevExpress.XtraBars.BarButtonItem bbiWeather;
		private DevExpress.XtraBars.BarButtonItem bbiConvertText;
		private DevExpress.XtraBars.BarButtonItem bbiThreeSimpleRule;
		private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
		private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtiModulesSettings;
		private Views.Settings.ModulesSetting modulesSetting;
	}
}