namespace LifeLog.UI.BackEnd.Bases
{
	partial class BaseView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseView));
			this.barManagerBase = new DevExpress.XtraBars.BarManager(this.components);
			this.barBase = new DevExpress.XtraBars.Bar();
			this.bbiBack = new DevExpress.XtraBars.BarButtonItem();
			this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
			this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
			this.bbiDelele = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
			this.bbiReload = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSearch = new DevExpress.XtraBars.BarEditItem();
			this.riscBase = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
			this.npList = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.lcBase = new DevExpress.XtraLayout.LayoutControl();
			this.pcBase = new DevExpress.XtraEditors.PanelControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lciBase = new DevExpress.XtraLayout.LayoutControlItem();
			this.npEdit = new DevExpress.XtraBars.Navigation.NavigationPage();
			((System.ComponentModel.ISupportInitialize)(this.barManagerBase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.riscBase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
			this.navigationFrame.SuspendLayout();
			this.npList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lcBase)).BeginInit();
			this.lcBase.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcBase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciBase)).BeginInit();
			this.SuspendLayout();
			// 
			// barManagerBase
			// 
			this.barManagerBase.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barBase});
			this.barManagerBase.DockControls.Add(this.barDockControlTop);
			this.barManagerBase.DockControls.Add(this.barDockControlBottom);
			this.barManagerBase.DockControls.Add(this.barDockControlLeft);
			this.barManagerBase.DockControls.Add(this.barDockControlRight);
			this.barManagerBase.Form = this;
			this.barManagerBase.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiNew,
            this.bbiSave,
            this.bbiReload,
            this.bbiBack,
            this.bbiEdit,
            this.bbiDelele,
            this.bbiSearch});
			this.barManagerBase.MainMenu = this.barBase;
			this.barManagerBase.MaxItemId = 8;
			this.barManagerBase.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riscBase});
			// 
			// barBase
			// 
			this.barBase.BarName = "Main menu";
			this.barBase.DockCol = 0;
			this.barBase.DockRow = 0;
			this.barBase.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.barBase.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiBack, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNew),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiDelele, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiReload, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.bbiSearch, "", true, true, true, 250, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.barBase.OptionsBar.AllowQuickCustomization = false;
			this.barBase.OptionsBar.DrawBorder = false;
			this.barBase.OptionsBar.DrawDragBorder = false;
			this.barBase.OptionsBar.MinHeight = 35;
			this.barBase.OptionsBar.MultiLine = true;
			this.barBase.OptionsBar.UseWholeRow = true;
			this.barBase.Text = "Main menu";
			// 
			// bbiBack
			// 
			this.bbiBack.Caption = "Back";
			this.bbiBack.Id = 3;
			this.bbiBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiBack.ImageOptions.SvgImage")));
			this.bbiBack.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
			this.bbiBack.Name = "bbiBack";
			this.bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			this.bbiBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBack_ItemClick);
			// 
			// bbiNew
			// 
			this.bbiNew.Caption = "New";
			this.bbiNew.Id = 0;
			this.bbiNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiNew.ImageOptions.SvgImage")));
			this.bbiNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
			this.bbiNew.Name = "bbiNew";
			this.bbiNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
			// 
			// bbiEdit
			// 
			this.bbiEdit.Caption = "Edit";
			this.bbiEdit.Id = 4;
			this.bbiEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEdit.ImageOptions.SvgImage")));
			this.bbiEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
			this.bbiEdit.Name = "bbiEdit";
			this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
			// 
			// bbiDelele
			// 
			this.bbiDelele.Caption = "Delete";
			this.bbiDelele.Id = 5;
			this.bbiDelele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiDelele.ImageOptions.SvgImage")));
			this.bbiDelele.Name = "bbiDelele";
			this.bbiDelele.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelele_ItemClick);
			// 
			// bbiSave
			// 
			this.bbiSave.Caption = "Save";
			this.bbiSave.Id = 1;
			this.bbiSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSave.ImageOptions.SvgImage")));
			this.bbiSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
			this.bbiSave.Name = "bbiSave";
			this.bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
			// 
			// bbiReload
			// 
			this.bbiReload.Caption = "Reload";
			this.bbiReload.GroupIndex = 1;
			this.bbiReload.Id = 2;
			this.bbiReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiReload.ImageOptions.SvgImage")));
			this.bbiReload.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
			this.bbiReload.Name = "bbiReload";
			this.bbiReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReload_ItemClick);
			// 
			// bbiSearch
			// 
			this.bbiSearch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bbiSearch.Caption = "Search";
			this.bbiSearch.Edit = this.riscBase;
			this.bbiSearch.EditWidth = 250;
			this.bbiSearch.Id = 7;
			this.bbiSearch.MaxWidth = 250;
			this.bbiSearch.MinWidth = 250;
			this.bbiSearch.Name = "bbiSearch";
			// 
			// riscBase
			// 
			this.riscBase.AutoHeight = false;
			this.riscBase.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
			this.riscBase.Name = "riscBase";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManagerBase;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControlTop.Size = new System.Drawing.Size(1064, 35);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 823);
			this.barDockControlBottom.Manager = this.barManagerBase;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControlBottom.Size = new System.Drawing.Size(1064, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 35);
			this.barDockControlLeft.Manager = this.barManagerBase;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 788);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1064, 35);
			this.barDockControlRight.Manager = this.barManagerBase;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 788);
			// 
			// navigationFrame
			// 
			this.navigationFrame.Controls.Add(this.npList);
			this.navigationFrame.Controls.Add(this.npEdit);
			this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.navigationFrame.Location = new System.Drawing.Point(0, 35);
			this.navigationFrame.Name = "navigationFrame";
			this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npList,
            this.npEdit});
			this.navigationFrame.SelectedPage = this.npList;
			this.navigationFrame.Size = new System.Drawing.Size(1064, 788);
			this.navigationFrame.TabIndex = 4;
			this.navigationFrame.Text = "navigationFrame1";
			// 
			// npList
			// 
			this.npList.Controls.Add(this.lcBase);
			this.npList.Name = "npList";
			this.npList.Size = new System.Drawing.Size(1064, 788);
			// 
			// lcBase
			// 
			this.lcBase.Controls.Add(this.pcBase);
			this.lcBase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lcBase.Location = new System.Drawing.Point(0, 0);
			this.lcBase.Name = "lcBase";
			this.lcBase.Root = this.Root;
			this.lcBase.Size = new System.Drawing.Size(1064, 788);
			this.lcBase.TabIndex = 0;
			this.lcBase.Text = "layoutControl1";
			// 
			// pcBase
			// 
			this.pcBase.Location = new System.Drawing.Point(6, 10);
			this.pcBase.Name = "pcBase";
			this.pcBase.Size = new System.Drawing.Size(1052, 772);
			this.pcBase.TabIndex = 4;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBase});
			this.Root.Name = "Root";
			this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 8, 4);
			this.Root.Size = new System.Drawing.Size(1064, 788);
			this.Root.TextVisible = false;
			// 
			// lciBase
			// 
			this.lciBase.Control = this.pcBase;
			this.lciBase.Location = new System.Drawing.Point(0, 0);
			this.lciBase.Name = "lciBase";
			this.lciBase.Size = new System.Drawing.Size(1056, 776);
			this.lciBase.TextVisible = false;
			// 
			// npEdit
			// 
			this.npEdit.Name = "npEdit";
			this.npEdit.Size = new System.Drawing.Size(1064, 788);
			// 
			// BaseView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.navigationFrame);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "BaseView";
			this.Size = new System.Drawing.Size(1064, 823);
			((System.ComponentModel.ISupportInitialize)(this.barManagerBase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.riscBase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
			this.navigationFrame.ResumeLayout(false);
			this.npList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lcBase)).EndInit();
			this.lcBase.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pcBase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciBase)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraBars.BarButtonItem bbiBack;
		private DevExpress.XtraBars.BarButtonItem bbiNew;
		private DevExpress.XtraBars.BarButtonItem bbiEdit;
		private DevExpress.XtraBars.BarButtonItem bbiDelele;
		private DevExpress.XtraBars.BarButtonItem bbiSave;
		private DevExpress.XtraBars.BarButtonItem bbiReload;
		private DevExpress.XtraBars.BarEditItem bbiSearch;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		public DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
		public DevExpress.XtraBars.Navigation.NavigationPage npList;
		public DevExpress.XtraBars.Navigation.NavigationPage npEdit;
		public DevExpress.XtraLayout.LayoutControl lcBase;
		public DevExpress.XtraEditors.PanelControl pcBase;
		public DevExpress.XtraLayout.LayoutControlItem lciBase;
		public DevExpress.XtraLayout.LayoutControlGroup Root;
		public DevExpress.XtraEditors.Repository.RepositoryItemSearchControl riscBase;
		public DevExpress.XtraBars.BarManager barManagerBase;
		public DevExpress.XtraBars.Bar barBase;
	}
}
