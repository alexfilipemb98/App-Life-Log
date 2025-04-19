using DevExpress.Utils.Extensions;
using LifeLogApp.Views.Main.Passwords;

namespace LifeLogApp.Forms;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
        backstageViewControl = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
        backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        recentItemControl1 = new DevExpress.XtraBars.Ribbon.RecentItemControl();
        recentStackPanel2 = new DevExpress.XtraBars.Ribbon.RecentStackPanel();
        recentStackPanel1 = new DevExpress.XtraBars.Ribbon.RecentStackPanel();
        backstageViewControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
        backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        backstageViewClientControl3 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        backstageViewClientControl4 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
        btviAppSettings = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        bvtiDatabaseSettings = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        backstageViewItemSeparator2 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
        backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        backstageViewTabItem2 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
        skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
        skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
        btsTopMost = new DevExpress.XtraBars.BarToggleSwitchItem();
        lblTime = new DevExpress.XtraBars.BarStaticItem();
        bbiNotesView = new DevExpress.XtraBars.BarButtonItem();
        bsiStatusLabel = new DevExpress.XtraBars.BarStaticItem();
        bbiAppSettings = new DevExpress.XtraBars.BarButtonItem();
        bbiPasswordsView = new DevExpress.XtraBars.BarButtonItem();
        barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
        barSubItem1 = new DevExpress.XtraBars.BarSubItem();
        bbiCoinFlipView = new DevExpress.XtraBars.BarButtonItem();
        bbiTicTacToeView = new DevExpress.XtraBars.BarButtonItem();
        bbiDiceRollView = new DevExpress.XtraBars.BarButtonItem();
        rpHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
        ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        rpEntertainment = new DevExpress.XtraBars.Ribbon.RibbonPage();
        ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
        ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
        notesView = new LifeLogApp.Views.Main.Notes.NotesView();
        layoutControl = new DevExpress.XtraLayout.LayoutControl();
        panelControl = new DevExpress.XtraEditors.PanelControl();
        navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
        npNotesView = new DevExpress.XtraBars.Navigation.NavigationPage();
        npHomeView = new DevExpress.XtraBars.Navigation.NavigationPage();
        npPasswordView = new DevExpress.XtraBars.Navigation.NavigationPage();
        passwordView = new PasswordView();
        npCoinFilpView = new DevExpress.XtraBars.Navigation.NavigationPage();
        coinFlipGameView = new LifeLogApp.Views.Entertainment.CoinFlip.CoinFlipGameView();
        npTicTacToeView = new DevExpress.XtraBars.Navigation.NavigationPage();
        ticTacToeGameView = new LifeLogApp.Views.Entertainment.TicTacToe.TicTacToeGameView();
        npDiceRollView = new DevExpress.XtraBars.Navigation.NavigationPage();
        diceGameView = new LifeLogApp.Views.Entertainment.Dice.DiceGameView();
        Root = new DevExpress.XtraLayout.LayoutControlGroup();
        layoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
        timer = new System.Windows.Forms.Timer(components);
        ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
        ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
        ((System.ComponentModel.ISupportInitialize)backstageViewControl).BeginInit();
        backstageViewControl.SuspendLayout();
        backstageViewClientControl1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)recentItemControl1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)backstageViewControl2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
        layoutControl.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)panelControl).BeginInit();
        panelControl.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)navigationFrame).BeginInit();
        navigationFrame.SuspendLayout();
        npNotesView.SuspendLayout();
        npPasswordView.SuspendLayout();
        npCoinFilpView.SuspendLayout();
        npTicTacToeView.SuspendLayout();
        npDiceRollView.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem).BeginInit();
        SuspendLayout();
        // 
        // ribbon
        // 
        ribbon.ApplicationButtonDropDownControl = backstageViewControl;
        ribbon.ApplicationDocumentCaption = "Main";
        ribbon.ExpandCollapseItem.Id = 0;
        ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, skinDropDownButtonItem1, skinRibbonGalleryBarItem1, skinPaletteDropDownButtonItem1, btsTopMost, lblTime, bbiNotesView, bsiStatusLabel, bbiAppSettings, bbiPasswordsView, barStaticItem1, barSubItem1, bbiCoinFlipView, bbiTicTacToeView, bbiDiceRollView });
        ribbon.Location = new System.Drawing.Point(0, 0);
        ribbon.MaxItemId = 16;
        ribbon.Name = "ribbon";
        ribbon.PageHeaderItemLinks.Add(btsTopMost);
        ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { rpHome, rpEntertainment, ribbonPage2 });
        ribbon.QuickToolbarItemLinks.Add(bbiAppSettings);
        ribbon.Size = new System.Drawing.Size(1015, 237);
        ribbon.StatusBar = ribbonStatusBar;
        // 
        // backstageViewControl
        // 
        backstageViewControl.Controls.Add(backstageViewClientControl1);
        backstageViewControl.Controls.Add(backstageViewClientControl2);
        backstageViewControl.Controls.Add(backstageViewClientControl3);
        backstageViewControl.Controls.Add(backstageViewClientControl4);
        backstageViewControl.Items.Add(backstageViewItemSeparator1);
        backstageViewControl.Items.Add(btviAppSettings);
        backstageViewControl.Items.Add(bvtiDatabaseSettings);
        backstageViewControl.Items.Add(backstageViewItemSeparator2);
        backstageViewControl.Items.Add(backstageViewTabItem1);
        backstageViewControl.Items.Add(backstageViewTabItem2);
        backstageViewControl.Location = new System.Drawing.Point(524, 53);
        backstageViewControl.Name = "backstageViewControl";
        backstageViewControl.OwnerControl = ribbon;
        backstageViewControl.SelectedTab = bvtiDatabaseSettings;
        backstageViewControl.SelectedTabIndex = 2;
        backstageViewControl.Size = new System.Drawing.Size(300, 196);
        backstageViewControl.TabIndex = 5;
        backstageViewControl.Text = "backstageViewControl1";
        backstageViewControl.SelectedTabChanged += backstageViewControl_SelectedTabChanged;
        backstageViewControl.Showing += backstageViewControl_Showing;
        backstageViewControl.Hiding += backstageViewControl_Hiding;
        // 
        // backstageViewClientControl1
        // 
        backstageViewClientControl1.Controls.Add(recentItemControl1);
        backstageViewClientControl1.Controls.Add(backstageViewControl2);
        backstageViewClientControl1.Location = new System.Drawing.Point(231, 62);
        backstageViewClientControl1.Name = "backstageViewClientControl1";
        backstageViewClientControl1.Size = new System.Drawing.Size(52, 134);
        backstageViewClientControl1.TabIndex = 1;
        // 
        // recentItemControl1
        // 
        recentItemControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        recentItemControl1.DefaultContentPanel = recentStackPanel2;
        recentItemControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        recentItemControl1.Location = new System.Drawing.Point(0, 0);
        recentItemControl1.MainPanel = recentStackPanel1;
        recentItemControl1.Name = "recentItemControl1";
        recentItemControl1.Size = new System.Drawing.Size(370, 134);
        recentItemControl1.TabIndex = 1;
        recentItemControl1.Title = "Title";
        // 
        // recentStackPanel2
        // 
        recentStackPanel2.Name = "recentStackPanel2";
        // 
        // recentStackPanel1
        // 
        recentStackPanel1.Name = "recentStackPanel1";
        // 
        // backstageViewControl2
        // 
        backstageViewControl2.Dock = System.Windows.Forms.DockStyle.Fill;
        backstageViewControl2.Location = new System.Drawing.Point(0, 0);
        backstageViewControl2.Name = "backstageViewControl2";
        backstageViewControl2.Size = new System.Drawing.Size(52, 134);
        backstageViewControl2.TabIndex = 2;
        // 
        // backstageViewClientControl2
        // 
        backstageViewClientControl2.Location = new System.Drawing.Point(245, 63);
        backstageViewClientControl2.Name = "backstageViewClientControl2";
        backstageViewClientControl2.Size = new System.Drawing.Size(422, 265);
        backstageViewClientControl2.TabIndex = 2;
        // 
        // backstageViewClientControl3
        // 
        backstageViewClientControl3.Location = new System.Drawing.Point(218, 63);
        backstageViewClientControl3.Name = "backstageViewClientControl3";
        backstageViewClientControl3.Size = new System.Drawing.Size(549, 301);
        backstageViewClientControl3.TabIndex = 3;
        // 
        // backstageViewClientControl4
        // 
        backstageViewClientControl4.Location = new System.Drawing.Point(245, 63);
        backstageViewClientControl4.Name = "backstageViewClientControl4";
        backstageViewClientControl4.Size = new System.Drawing.Size(37, 132);
        backstageViewClientControl4.TabIndex = 4;
        // 
        // backstageViewItemSeparator1
        // 
        backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
        // 
        // btviAppSettings
        // 
        btviAppSettings.Caption = "App Settings";
        btviAppSettings.ContentControl = backstageViewClientControl2;
        btviAppSettings.ImageOptions.ItemNormal.SvgImage = Properties.Resources.yaxissettings;
        btviAppSettings.Name = "btviAppSettings";
        // 
        // bvtiDatabaseSettings
        // 
        bvtiDatabaseSettings.Caption = "Database Settings";
        bvtiDatabaseSettings.ContentControl = backstageViewClientControl1;
        bvtiDatabaseSettings.ImageOptions.ItemNormal.SvgImage = Properties.Resources.managedatasource;
        bvtiDatabaseSettings.Name = "bvtiDatabaseSettings";
        bvtiDatabaseSettings.Selected = true;
        // 
        // backstageViewItemSeparator2
        // 
        backstageViewItemSeparator2.Name = "backstageViewItemSeparator2";
        // 
        // backstageViewTabItem1
        // 
        backstageViewTabItem1.Alignment = DevExpress.XtraBars.Ribbon.BackstageViewItemAlignment.Bottom;
        backstageViewTabItem1.Caption = "About";
        backstageViewTabItem1.ContentControl = backstageViewClientControl3;
        backstageViewTabItem1.ImageOptions.ItemNormal.SvgImage = Properties.Resources.about;
        backstageViewTabItem1.Name = "backstageViewTabItem1";
        // 
        // backstageViewTabItem2
        // 
        backstageViewTabItem2.Caption = "Module Configuration";
        backstageViewTabItem2.ContentControl = backstageViewClientControl4;
        backstageViewTabItem2.ImageOptions.ItemNormal.SvgImage = Properties.Resources.fitboundstocontainer;
        backstageViewTabItem2.Name = "backstageViewTabItem2";
        // 
        // skinDropDownButtonItem1
        // 
        skinDropDownButtonItem1.ActAsDropDown = true;
        skinDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
        skinDropDownButtonItem1.Id = 1;
        skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
        // 
        // skinRibbonGalleryBarItem1
        // 
        skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
        skinRibbonGalleryBarItem1.Id = 2;
        skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
        // 
        // skinPaletteDropDownButtonItem1
        // 
        skinPaletteDropDownButtonItem1.ActAsDropDown = true;
        skinPaletteDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
        skinPaletteDropDownButtonItem1.Id = 3;
        skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
        // 
        // btsTopMost
        // 
        btsTopMost.Caption = "Top Most";
        btsTopMost.Id = 4;
        btsTopMost.Name = "btsTopMost";
        btsTopMost.CheckedChanged += btsTopMost_CheckedChanged;
        // 
        // lblTime
        // 
        lblTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        lblTime.Caption = "<TIME>";
        lblTime.Id = 5;
        lblTime.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("lblTime.ImageOptions.SvgImage");
        lblTime.Name = "lblTime";
        lblTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
        // 
        // bbiNotesView
        // 
        bbiNotesView.Caption = "Notes";
        bbiNotesView.Id = 6;
        bbiNotesView.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("bbiNotesView.ImageOptions.SvgImage");
        bbiNotesView.Name = "bbiNotesView";
        bbiNotesView.ItemClick += bbiNotesView_ItemClick;
        // 
        // bsiStatusLabel
        // 
        bsiStatusLabel.Caption = "<STATUS>";
        bsiStatusLabel.Id = 7;
        bsiStatusLabel.ImageOptions.SvgImage = Properties.Resources.thankyounote;
        bsiStatusLabel.Name = "bsiStatusLabel";
        bsiStatusLabel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
        // 
        // bbiAppSettings
        // 
        bbiAppSettings.Caption = "Settings";
        bbiAppSettings.Id = 8;
        bbiAppSettings.ImageOptions.SvgImage = Properties.Resources.properties;
        bbiAppSettings.Name = "bbiAppSettings";
        bbiAppSettings.ItemClick += bbiAppSettings_ItemClick;
        // 
        // bbiPasswordsView
        // 
        bbiPasswordsView.Caption = "Passwords";
        bbiPasswordsView.Id = 10;
        bbiPasswordsView.ImageOptions.SvgImage = Properties.Resources.security_key;
        bbiPasswordsView.Name = "bbiPasswordsView";
        bbiPasswordsView.ItemClick += bbiPasswordsView_ItemClick;
        // 
        // barStaticItem1
        // 
        barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        barStaticItem1.Caption = "barStaticItem1";
        barStaticItem1.Id = 11;
        barStaticItem1.Name = "barStaticItem1";
        // 
        // barSubItem1
        // 
        barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        barSubItem1.Caption = "<USER>";
        barSubItem1.Id = 12;
        barSubItem1.ImageOptions.SvgImage = Properties.Resources.actions_user;
        barSubItem1.Name = "barSubItem1";
        // 
        // bbiCoinFlipView
        // 
        bbiCoinFlipView.Caption = "Coin Flip";
        bbiCoinFlipView.Id = 13;
        bbiCoinFlipView.ImageOptions.SvgImage = Properties.Resources.coin_flip;
        bbiCoinFlipView.Name = "bbiCoinFlipView";
        bbiCoinFlipView.ItemClick += bbiCoinFlipView_ItemClick;
        // 
        // bbiTicTacToeView
        // 
        bbiTicTacToeView.Caption = "Tic Tac Toe";
        bbiTicTacToeView.Id = 14;
        bbiTicTacToeView.ImageOptions.SvgImage = Properties.Resources.tic_tac_toe;
        bbiTicTacToeView.Name = "bbiTicTacToeView";
        bbiTicTacToeView.ItemClick += bbiTicTacToeView_ItemClick;
        // 
        // bbiDiceRollView
        // 
        bbiDiceRollView.Caption = "Dice Roll";
        bbiDiceRollView.Id = 15;
        bbiDiceRollView.ImageOptions.SvgImage = Properties.Resources.dice_dice;
        bbiDiceRollView.Name = "bbiDiceRollView";
        bbiDiceRollView.ItemClick += bbiDiceRollView_ItemClick;
        // 
        // rpHome
        // 
        rpHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
        rpHome.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("rpHome.ImageOptions.SvgImage");
        rpHome.Name = "rpHome";
        rpHome.Text = "Home";
        // 
        // ribbonPageGroup1
        // 
        ribbonPageGroup1.ItemLinks.Add(bbiNotesView);
        ribbonPageGroup1.ItemLinks.Add(bbiPasswordsView);
        ribbonPageGroup1.Name = "ribbonPageGroup1";
        ribbonPageGroup1.Text = "Main";
        // 
        // rpEntertainment
        // 
        rpEntertainment.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4 });
        rpEntertainment.ImageOptions.SvgImage = Properties.Resources.actions_send;
        rpEntertainment.Name = "rpEntertainment";
        rpEntertainment.Text = "Entertainment";
        // 
        // ribbonPageGroup4
        // 
        ribbonPageGroup4.ItemLinks.Add(bbiCoinFlipView);
        ribbonPageGroup4.ItemLinks.Add(bbiTicTacToeView);
        ribbonPageGroup4.ItemLinks.Add(bbiDiceRollView);
        ribbonPageGroup4.Name = "ribbonPageGroup4";
        ribbonPageGroup4.Text = "Games";
        // 
        // ribbonPage2
        // 
        ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2, ribbonPageGroup3 });
        ribbonPage2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ribbonPage2.ImageOptions.SvgImage");
        ribbonPage2.Name = "ribbonPage2";
        ribbonPage2.Text = "Settings";
        // 
        // ribbonPageGroup2
        // 
        ribbonPageGroup2.ItemLinks.Add(skinDropDownButtonItem1);
        ribbonPageGroup2.ItemLinks.Add(skinPaletteDropDownButtonItem1);
        ribbonPageGroup2.Name = "ribbonPageGroup2";
        ribbonPageGroup2.Text = "Theme";
        // 
        // ribbonPageGroup3
        // 
        ribbonPageGroup3.ItemLinks.Add(bbiAppSettings);
        ribbonPageGroup3.Name = "ribbonPageGroup3";
        ribbonPageGroup3.Text = "App Settings";
        // 
        // ribbonStatusBar
        // 
        ribbonStatusBar.ItemLinks.Add(barStaticItem1);
        ribbonStatusBar.ItemLinks.Add(lblTime);
        ribbonStatusBar.ItemLinks.Add(bsiStatusLabel);
        ribbonStatusBar.ItemLinks.Add(barSubItem1);
        ribbonStatusBar.Location = new System.Drawing.Point(0, 595);
        ribbonStatusBar.Name = "ribbonStatusBar";
        ribbonStatusBar.Ribbon = ribbon;
        ribbonStatusBar.Size = new System.Drawing.Size(1015, 43);
        // 
        // notesView
        // 
        notesView.Dock = System.Windows.Forms.DockStyle.Fill;
        notesView.Location = new System.Drawing.Point(0, 0);
        notesView.Margin = new System.Windows.Forms.Padding(0);
        notesView.Name = "notesView";
        notesView.Size = new System.Drawing.Size(979, 322);
        notesView.TabIndex = 0;
        // 
        // layoutControl
        // 
        layoutControl.Controls.Add(panelControl);
        layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
        layoutControl.Location = new System.Drawing.Point(0, 237);
        layoutControl.Name = "layoutControl";
        layoutControl.Root = Root;
        layoutControl.Size = new System.Drawing.Size(1015, 358);
        layoutControl.TabIndex = 2;
        layoutControl.Text = "layoutControl1";
        // 
        // panelControl
        // 
        panelControl.Controls.Add(navigationFrame);
        panelControl.Location = new System.Drawing.Point(16, 16);
        panelControl.Name = "panelControl";
        panelControl.Size = new System.Drawing.Size(983, 326);
        panelControl.TabIndex = 4;
        // 
        // navigationFrame
        // 
        navigationFrame.Controls.Add(npNotesView);
        navigationFrame.Controls.Add(npHomeView);
        navigationFrame.Controls.Add(npPasswordView);
        navigationFrame.Controls.Add(npCoinFilpView);
        navigationFrame.Controls.Add(npTicTacToeView);
        navigationFrame.Controls.Add(npDiceRollView);
        navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
        navigationFrame.Location = new System.Drawing.Point(2, 2);
        navigationFrame.Name = "navigationFrame";
        navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { npHomeView, npNotesView, npPasswordView, npCoinFilpView, npTicTacToeView, npDiceRollView });
        navigationFrame.SelectedPage = npHomeView;
        navigationFrame.Size = new System.Drawing.Size(979, 322);
        navigationFrame.TabIndex = 1;
        navigationFrame.Text = "navigationFrame1";
        // 
        // npNotesView
        // 
        npNotesView.Caption = "npNotesView";
        npNotesView.Controls.Add(notesView);
        npNotesView.Name = "npNotesView";
        npNotesView.Size = new System.Drawing.Size(979, 322);
        // 
        // npHomeView
        // 
        npHomeView.Caption = "npHomeView";
        npHomeView.Name = "npHomeView";
        npHomeView.Size = new System.Drawing.Size(979, 322);
        // 
        // npPasswordView
        // 
        npPasswordView.Caption = "npPasswordView";
        npPasswordView.Controls.Add(passwordView);
        npPasswordView.Name = "npPasswordView";
        npPasswordView.Size = new System.Drawing.Size(979, 322);
        // 
        // passwordView
        // 
        passwordView.Dock = System.Windows.Forms.DockStyle.Fill;
        passwordView.Location = new System.Drawing.Point(0, 0);
        passwordView.Margin = new System.Windows.Forms.Padding(4);
        passwordView.Name = "passwordView";
        passwordView.Size = new System.Drawing.Size(979, 322);
        passwordView.TabIndex = 0;
        // 
        // npCoinFilpView
        // 
        npCoinFilpView.Caption = "npCoinFilpView";
        npCoinFilpView.Controls.Add(coinFlipGameView);
        npCoinFilpView.Name = "npCoinFilpView";
        npCoinFilpView.Size = new System.Drawing.Size(979, 322);
        // 
        // coinFlipGameView
        // 
        coinFlipGameView.Dock = System.Windows.Forms.DockStyle.Fill;
        coinFlipGameView.Location = new System.Drawing.Point(0, 0);
        coinFlipGameView.Margin = new System.Windows.Forms.Padding(5);
        coinFlipGameView.Name = "coinFlipGameView";
        coinFlipGameView.Size = new System.Drawing.Size(979, 322);
        coinFlipGameView.TabIndex = 0;
        // 
        // npTicTacToeView
        // 
        npTicTacToeView.Caption = "npTicTacToeView";
        npTicTacToeView.Controls.Add(ticTacToeGameView);
        npTicTacToeView.Name = "npTicTacToeView";
        npTicTacToeView.Size = new System.Drawing.Size(979, 322);
        // 
        // ticTacToeGameView
        // 
        ticTacToeGameView.Dock = System.Windows.Forms.DockStyle.Fill;
        ticTacToeGameView.Location = new System.Drawing.Point(0, 0);
        ticTacToeGameView.Margin = new System.Windows.Forms.Padding(5);
        ticTacToeGameView.Name = "ticTacToeGameView";
        ticTacToeGameView.Size = new System.Drawing.Size(979, 322);
        ticTacToeGameView.TabIndex = 0;
        // 
        // npDiceRollView
        // 
        npDiceRollView.Caption = "npDiceRollView";
        npDiceRollView.Controls.Add(diceGameView);
        npDiceRollView.Name = "npDiceRollView";
        npDiceRollView.Size = new System.Drawing.Size(979, 322);
        // 
        // diceGameView
        // 
        diceGameView.Dock = System.Windows.Forms.DockStyle.Fill;
        diceGameView.Location = new System.Drawing.Point(0, 0);
        diceGameView.Margin = new System.Windows.Forms.Padding(5);
        diceGameView.Name = "diceGameView";
        diceGameView.Size = new System.Drawing.Size(979, 322);
        diceGameView.TabIndex = 0;
        // 
        // Root
        // 
        Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
        Root.GroupBordersVisible = false;
        Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem });
        Root.Name = "Root";
        Root.Size = new System.Drawing.Size(1015, 358);
        Root.TextVisible = false;
        // 
        // layoutControlItem
        // 
        layoutControlItem.Control = panelControl;
        layoutControlItem.Location = new System.Drawing.Point(0, 0);
        layoutControlItem.Name = "layoutControlItem";
        layoutControlItem.Size = new System.Drawing.Size(989, 332);
        layoutControlItem.TextVisible = false;
        // 
        // timer
        // 
        timer.Enabled = true;
        timer.Interval = 1000;
        timer.Tick += timer_Tick;
        // 
        // ribbonPage4
        // 
        ribbonPage4.Name = "ribbonPage4";
        ribbonPage4.Text = "ribbonPage4";
        // 
        // MainForm
        // 
        Appearance.Options.UseFont = true;
        AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1015, 638);
        Controls.Add(backstageViewControl);
        Controls.Add(layoutControl);
        Controls.Add(ribbonStatusBar);
        Controls.Add(ribbon);
        Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        IconOptions.SvgImage = Properties.Resources.icon_svg;
        MinimumSize = new System.Drawing.Size(350, 400);
        Name = "MainForm";
        Ribbon = ribbon;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        StatusBar = ribbonStatusBar;
        Text = "Life Log";
        FormClosing += MainForm_FormClosing;
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
        ((System.ComponentModel.ISupportInitialize)backstageViewControl).EndInit();
        backstageViewControl.ResumeLayout(false);
        backstageViewClientControl1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)recentItemControl1).EndInit();
        ((System.ComponentModel.ISupportInitialize)backstageViewControl2).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
        layoutControl.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)panelControl).EndInit();
        panelControl.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)navigationFrame).EndInit();
        navigationFrame.ResumeLayout(false);
        npNotesView.ResumeLayout(false);
        npPasswordView.ResumeLayout(false);
        npCoinFilpView.ResumeLayout(false);
        npTicTacToeView.ResumeLayout(false);
        npDiceRollView.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)Root).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonPage rpHome;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
    private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
    private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraBars.BarToggleSwitchItem btsTopMost;
    private DevExpress.XtraLayout.LayoutControl layoutControl;
    private DevExpress.XtraEditors.PanelControl panelControl;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem;
    private DevExpress.XtraBars.BarStaticItem lblTime;
    private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
    private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
    private DevExpress.XtraBars.Navigation.NavigationPage npNotesView;
    private System.Windows.Forms.Timer timer;
    private DevExpress.XtraBars.BarButtonItem bbiNotesView;
    private DevExpress.XtraBars.Navigation.NavigationPage npHomeView;
    internal DevExpress.XtraBars.BarStaticItem bsiStatusLabel;
    private DevExpress.XtraBars.BarButtonItem bbiAppSettings;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    private Views.Main.Notes.NotesView notesView;
    private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
    private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtiDatabaseSettings;
    private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator2;
    private Views.Settings.DatabaseSettingsView databaseSettingsView;
    private DevExpress.XtraBars.Ribbon.RecentItemControl recentItemControl1;
    private DevExpress.XtraBars.Ribbon.RecentStackPanel recentStackPanel2;
    private DevExpress.XtraBars.Ribbon.RecentStackPanel recentStackPanel1;
    private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl2;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
    private Views.Settings.GeralSettingsView geralSettingsView;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem btviAppSettings;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl3;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl4;
    private Views.Settings.ModulleSettingsView modulleSettings1;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem2;
    private DevExpress.XtraBars.BarButtonItem bbiPasswordsView;
    private DevExpress.XtraBars.Navigation.NavigationPage npPasswordView;
    private Views.Main.Passwords.PasswordView passwordView;
    private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    private DevExpress.XtraBars.BarSubItem barSubItem1;
    private DevExpress.XtraBars.BarButtonItem bbiCoinFlipView;
    private DevExpress.XtraBars.BarButtonItem bbiTicTacToeView;
    private DevExpress.XtraBars.BarButtonItem bbiDiceRollView;
    private DevExpress.XtraBars.Ribbon.RibbonPage rpEntertainment;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
    private DevExpress.XtraBars.Navigation.NavigationPage npCoinFilpView;
    private Views.Entertainment.CoinFlip.CoinFlipGameView coinFlipGameView;
    private DevExpress.XtraBars.Navigation.NavigationPage npTicTacToeView;
    private DevExpress.XtraBars.Navigation.NavigationPage npDiceRollView;
    private Views.Entertainment.TicTacToe.TicTacToeGameView ticTacToeGameView;
    private Views.Entertainment.Dice.DiceGameView diceGameView;
}