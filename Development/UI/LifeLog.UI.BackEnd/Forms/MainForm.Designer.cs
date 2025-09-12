namespace LifeLog.UI.BackEnd.Forms
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
			this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
			this.sqlBrowserView1 = new LifeLog.UI.Common.Views.SqlBrowserView();
			this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
			this.bsiUserMenu = new DevExpress.XtraBars.BarSubItem();
			this.bbiLogoutUser = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSettings = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.bsiStatusLabel = new DevExpress.XtraBars.BarStaticItem();
			this.bsiDatabase = new DevExpress.XtraBars.BarStaticItem();
			this.bsiAppVersion = new DevExpress.XtraBars.BarStaticItem();
			this.bsiTime = new DevExpress.XtraBars.BarStaticItem();
			this.navigationPaneEx = new LifeLog.Base.Components.NavigationPaneEx();
			this.npNotes = new LifeLog.Base.Components.NavigationPageEx();
			this.notesListView = new LifeLog.UI.BackEnd.Views.Notes.NotesListView();
			this.npImages = new LifeLog.Base.Components.NavigationPageEx();
			this.imagesListView1 = new LifeLog.UI.BackEnd.Views.Images.ImagesListView();
			this.npExternalPrograms = new LifeLog.Base.Components.NavigationPageEx();
			this.externalProgramsListView = new LifeLog.UI.BackEnd.Views.ExternalPrograms.ExternalProgramsListView();
			this.npUsers = new LifeLog.Base.Components.NavigationPageEx();
			this.usersListView = new LifeLog.UI.BackEnd.Views.Users.UsersListView();
			this.timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
			this.backstageViewControl1.SuspendLayout();
			this.backstageViewClientControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.navigationPaneEx)).BeginInit();
			this.navigationPaneEx.SuspendLayout();
			this.npNotes.SuspendLayout();
			this.npImages.SuspendLayout();
			this.npExternalPrograms.SuspendLayout();
			this.npUsers.SuspendLayout();
			this.SuspendLayout();
			// 
			// ribbon
			// 
			this.ribbon.ApplicationButtonDropDownControl = this.backstageViewControl1;
			this.ribbon.ApplicationCaption = "Life Log Backend";
			this.ribbon.ApplicationDocumentCaption = "Main";
			this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 23, 26, 23);
			this.ribbon.ExpandCollapseItem.Id = 0;
			this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bsiUserMenu,
            this.bbiLogoutUser,
            this.bbiSettings});
			this.ribbon.Location = new System.Drawing.Point(0, 0);
			this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ribbon.MaxItemId = 4;
			this.ribbon.Name = "ribbon";
			this.ribbon.OptionsMenuMinWidth = 283;
			this.ribbon.QuickToolbarItemLinks.Add(this.bbiSettings);
			this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
			this.ribbon.ShowPageKeyTipsMode = DevExpress.XtraBars.Ribbon.ShowPageKeyTipsMode.ShowOnMultiplePages;
			this.ribbon.ShowQatLocationSelector = false;
			this.ribbon.ShowToolbarCustomizeItem = false;
			this.ribbon.Size = new System.Drawing.Size(849, 32);
			this.ribbon.StatusBar = this.ribbonStatusBar;
			this.ribbon.Toolbar.ShowCustomizeItem = false;
			// 
			// backstageViewControl1
			// 
			this.backstageViewControl1.Appearance.ForeColor = System.Drawing.Color.White;
			this.backstageViewControl1.Appearance.Options.UseForeColor = true;
			this.backstageViewControl1.BackstageViewShowRibbonItems = ((DevExpress.XtraBars.Ribbon.BackstageViewShowRibbonItems)((((DevExpress.XtraBars.Ribbon.BackstageViewShowRibbonItems.Default | DevExpress.XtraBars.Ribbon.BackstageViewShowRibbonItems.FormButtons) 
            | DevExpress.XtraBars.Ribbon.BackstageViewShowRibbonItems.Title) 
            | DevExpress.XtraBars.Ribbon.BackstageViewShowRibbonItems.PageHeaderItems)));
			this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
			this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
			this.backstageViewControl1.Location = new System.Drawing.Point(114, 0);
			this.backstageViewControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.backstageViewControl1.Name = "backstageViewControl1";
			this.backstageViewControl1.Office2013StyleOptions.LeftPaneContentVerticalOffset = 0;
			this.backstageViewControl1.Office2013StyleOptions.RightPaneContentVerticalOffset = 49;
			this.backstageViewControl1.OwnerControl = this.ribbon;
			this.backstageViewControl1.SelectedTab = this.backstageViewTabItem1;
			this.backstageViewControl1.SelectedTabIndex = 0;
			this.backstageViewControl1.Size = new System.Drawing.Size(575, 32);
			this.backstageViewControl1.TabIndex = 1;
			this.backstageViewControl1.Text = "backstageViewControl1";
			// 
			// backstageViewClientControl1
			// 
			this.backstageViewClientControl1.Controls.Add(this.sqlBrowserView1);
			this.backstageViewClientControl1.Location = new System.Drawing.Point(181, 50);
			this.backstageViewClientControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.backstageViewClientControl1.Name = "backstageViewClientControl1";
			this.backstageViewClientControl1.Size = new System.Drawing.Size(376, 0);
			this.backstageViewClientControl1.TabIndex = 1;
			// 
			// sqlBrowserView1
			// 
			this.sqlBrowserView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sqlBrowserView1.Location = new System.Drawing.Point(0, 0);
			this.sqlBrowserView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sqlBrowserView1.Name = "sqlBrowserView1";
			this.sqlBrowserView1.Size = new System.Drawing.Size(376, 0);
			this.sqlBrowserView1.TabIndex = 0;
			// 
			// backstageViewTabItem1
			// 
			this.backstageViewTabItem1.Caption = "SQL Query";
			this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
			this.backstageViewTabItem1.ImageOptions.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("backstageViewTabItem1.ImageOptions.ItemNormal.SvgImage")));
			this.backstageViewTabItem1.Name = "backstageViewTabItem1";
			this.backstageViewTabItem1.Selected = true;
			// 
			// bsiUserMenu
			// 
			this.bsiUserMenu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bsiUserMenu.Caption = "<USER>";
			this.bsiUserMenu.Id = 1;
			this.bsiUserMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsiUserMenu.ImageOptions.SvgImage")));
			this.bsiUserMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiLogoutUser)});
			this.bsiUserMenu.Name = "bsiUserMenu";
			// 
			// bbiLogoutUser
			// 
			this.bbiLogoutUser.Caption = "Logout";
			this.bbiLogoutUser.Id = 2;
			this.bbiLogoutUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiLogoutUser.ImageOptions.SvgImage")));
			this.bbiLogoutUser.Name = "bbiLogoutUser";
			this.bbiLogoutUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLogoutUser_ItemClick);
			// 
			// bbiSettings
			// 
			this.bbiSettings.Caption = "Settings";
			this.bbiSettings.Id = 3;
			this.bbiSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSettings.ImageOptions.SvgImage")));
			this.bbiSettings.Name = "bbiSettings";
			this.bbiSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSettings_ItemClick);
			// 
			// ribbonStatusBar
			// 
			this.ribbonStatusBar.ItemLinks.Add(this.bsiStatusLabel);
			this.ribbonStatusBar.ItemLinks.Add(this.bsiDatabase);
			this.ribbonStatusBar.ItemLinks.Add(this.bsiAppVersion);
			this.ribbonStatusBar.ItemLinks.Add(this.bsiTime);
			this.ribbonStatusBar.ItemLinks.Add(this.bsiUserMenu);
			this.ribbonStatusBar.Location = new System.Drawing.Point(0, 496);
			this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ribbonStatusBar.Name = "ribbonStatusBar";
			this.ribbonStatusBar.Ribbon = this.ribbon;
			this.ribbonStatusBar.Size = new System.Drawing.Size(849, 24);
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
			// bsiTime
			// 
			this.bsiTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bsiTime.Caption = "<TIME>";
			this.bsiTime.Id = 13;
			this.bsiTime.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsiTime.ImageOptions.SvgImage")));
			this.bsiTime.Name = "bsiTime";
			this.bsiTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// navigationPaneEx
			// 
			this.navigationPaneEx.Controls.Add(this.npNotes);
			this.navigationPaneEx.Controls.Add(this.npImages);
			this.navigationPaneEx.Controls.Add(this.npExternalPrograms);
			this.navigationPaneEx.Controls.Add(this.npUsers);
			this.navigationPaneEx.Dock = System.Windows.Forms.DockStyle.Fill;
			this.navigationPaneEx.Location = new System.Drawing.Point(0, 32);
			this.navigationPaneEx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.navigationPaneEx.Name = "navigationPaneEx";
			this.navigationPaneEx.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
			this.navigationPaneEx.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npNotes,
            this.npImages,
            this.npExternalPrograms,
            this.npUsers});
			this.navigationPaneEx.RegularSize = new System.Drawing.Size(891, 552);
			this.navigationPaneEx.SelectedPage = this.npNotes;
			this.navigationPaneEx.Size = new System.Drawing.Size(849, 464);
			this.navigationPaneEx.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Expanded;
			this.navigationPaneEx.TabIndex = 2;
			this.navigationPaneEx.Text = "Tables";
			this.navigationPaneEx.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.navigationPaneEx_SelectedPageChanged);
			this.navigationPaneEx.SelectedPageChanging += new DevExpress.XtraBars.Navigation.SelectedPageChangingEventHandler(this.navigationPaneEx_SelectedPageChanging);
			// 
			// npNotes
			// 
			this.npNotes.BackgroundPadding = new System.Windows.Forms.Padding(0);
			this.npNotes.Caption = "Notes";
			this.npNotes.Controls.Add(this.notesListView);
			this.npNotes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("npNotes.ImageOptions.SvgImage")));
			this.npNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.npNotes.Name = "npNotes";
			this.npNotes.Size = new System.Drawing.Size(702, 464);
			// 
			// notesListView
			// 
			this.notesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.notesListView.Location = new System.Drawing.Point(0, 0);
			this.notesListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.notesListView.Name = "notesListView";
			this.notesListView.Size = new System.Drawing.Size(702, 464);
			this.notesListView.TabIndex = 0;
			// 
			// npImages
			// 
			this.npImages.BackgroundPadding = new System.Windows.Forms.Padding(0);
			this.npImages.Caption = " Images";
			this.npImages.Controls.Add(this.imagesListView1);
			this.npImages.ImageOptions.SvgImage = global::LifeLog.Base.Assets.Resources.insertimage;
			this.npImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.npImages.Name = "npImages";
			this.npImages.Size = new System.Drawing.Size(702, 464);
			// 
			// imagesListView1
			// 
			this.imagesListView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imagesListView1.Location = new System.Drawing.Point(0, 0);
			this.imagesListView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.imagesListView1.Name = "imagesListView1";
			this.imagesListView1.Size = new System.Drawing.Size(702, 464);
			this.imagesListView1.TabIndex = 0;
			// 
			// npExternalPrograms
			// 
			this.npExternalPrograms.BackgroundPadding = new System.Windows.Forms.Padding(0);
			this.npExternalPrograms.Caption = " External Programs";
			this.npExternalPrograms.Controls.Add(this.externalProgramsListView);
			this.npExternalPrograms.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("npExternalPrograms.ImageOptions.SvgImage")));
			this.npExternalPrograms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.npExternalPrograms.Name = "npExternalPrograms";
			this.npExternalPrograms.Size = new System.Drawing.Size(702, 464);
			// 
			// externalProgramsListView
			// 
			this.externalProgramsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.externalProgramsListView.Location = new System.Drawing.Point(0, 0);
			this.externalProgramsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.externalProgramsListView.Name = "externalProgramsListView";
			this.externalProgramsListView.Size = new System.Drawing.Size(702, 464);
			this.externalProgramsListView.TabIndex = 0;
			// 
			// npUsers
			// 
			this.npUsers.BackgroundPadding = new System.Windows.Forms.Padding(0);
			this.npUsers.Caption = "Users";
			this.npUsers.Controls.Add(this.usersListView);
			this.npUsers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("npUsers.ImageOptions.SvgImage")));
			this.npUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.npUsers.Name = "npUsers";
			this.npUsers.Size = new System.Drawing.Size(702, 464);
			// 
			// usersListView
			// 
			this.usersListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.usersListView.Location = new System.Drawing.Point(0, 0);
			this.usersListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.usersListView.Name = "usersListView";
			this.usersListView.Size = new System.Drawing.Size(702, 464);
			this.usersListView.TabIndex = 0;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 520);
			this.Controls.Add(this.backstageViewControl1);
			this.Controls.Add(this.navigationPaneEx);
			this.Controls.Add(this.ribbonStatusBar);
			this.Controls.Add(this.ribbon);
			this.IconOptions.Image = global::LifeLog.Base.Assets.Resources.icon;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Ribbon = this.ribbon;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StatusBar = this.ribbonStatusBar;
			this.Text = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
			this.backstageViewControl1.ResumeLayout(false);
			this.backstageViewClientControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.navigationPaneEx)).EndInit();
			this.navigationPaneEx.ResumeLayout(false);
			this.npNotes.ResumeLayout(false);
			this.npImages.ResumeLayout(false);
			this.npExternalPrograms.ResumeLayout(false);
			this.npUsers.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
		private Base.Components.NavigationPaneEx navigationPaneEx;
		private Base.Components.NavigationPageEx npNotes;
		private Base.Components.NavigationPageEx npImages;
		private Views.Images.ImagesListView imagesListView1;
		internal DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		public DevExpress.XtraBars.BarStaticItem bsiStatusLabel;
		private DevExpress.XtraBars.BarStaticItem bsiDatabase;
		private DevExpress.XtraBars.BarStaticItem bsiAppVersion;
		private DevExpress.XtraBars.BarStaticItem bsiTime;
		private System.Windows.Forms.Timer timer;
		private DevExpress.XtraBars.BarSubItem bsiUserMenu;
		private DevExpress.XtraBars.BarButtonItem bbiLogoutUser;
		private Base.Components.NavigationPageEx npExternalPrograms;
		private Views.ExternalPrograms.ExternalProgramsListView externalProgramsListView;
		private Base.Components.NavigationPageEx npUsers;
		private Views.Users.UsersListView usersListView;
		private Views.Notes.NotesListView notesListView;
		private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
		private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
		private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
		private DevExpress.XtraBars.BarButtonItem bbiSettings;
		private LifeLog.UI.Common.Views.SqlBrowserView sqlBrowserView1;
	}
}