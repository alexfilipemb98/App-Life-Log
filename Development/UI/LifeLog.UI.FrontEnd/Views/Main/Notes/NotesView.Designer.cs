namespace LifeLog.UI.FrontEnd.Views.Main.Notes
{
    partial class NotesView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesView));
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar = new DevExpress.XtraBars.Bar();
			this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
			this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
			this.bbiReload = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.repositoryItemFontEditRichEdit1 = new DevExpress.XtraRichEdit.UI.RepositoryItemFontEditRichEdit();
			this.repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
			this.repositoryItemRichEditStyleEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEditRichEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager
			// 
			this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar});
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiNew,
            this.bbiSave,
            this.bbiReload,
            this.bbiEdit});
			this.barManager.MainMenu = this.bar;
			this.barManager.MaxItemId = 71;
			this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEditRichEdit1,
            this.repositoryItemRichEditFontSizeEdit1,
            this.repositoryItemRichEditStyleEdit1});
			// 
			// bar
			// 
			this.bar.BarName = "Main menu";
			this.bar.DockCol = 0;
			this.bar.DockRow = 0;
			this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar.FloatLocation = new System.Drawing.Point(348, 85);
			this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiReload, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar.OptionsBar.DrawBorder = false;
			this.bar.OptionsBar.DrawDragBorder = false;
			this.bar.OptionsBar.MinHeight = 35;
			this.bar.OptionsBar.MultiLine = true;
			this.bar.OptionsBar.UseWholeRow = true;
			this.bar.Text = "Main menu";
			// 
			// bbiNew
			// 
			this.bbiNew.Caption = "New";
			this.bbiNew.Id = 0;
			this.bbiNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiNew.ImageOptions.SvgImage")));
			this.bbiNew.Name = "bbiNew";
			this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
			// 
			// bbiEdit
			// 
			this.bbiEdit.Caption = "Edit";
			this.bbiEdit.Id = 68;
			this.bbiEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEdit.ImageOptions.SvgImage")));
			this.bbiEdit.Name = "bbiEdit";
			this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
			// 
			// bbiSave
			// 
			this.bbiSave.Caption = "Save";
			this.bbiSave.Id = 65;
			this.bbiSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSave.ImageOptions.SvgImage")));
			this.bbiSave.Name = "bbiSave";
			this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
			// 
			// bbiReload
			// 
			this.bbiReload.Caption = "Reload";
			this.bbiReload.Id = 66;
			this.bbiReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiReload.ImageOptions.SvgImage")));
			this.bbiReload.Name = "bbiReload";
			this.bbiReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReload_ItemClick);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlTop.Size = new System.Drawing.Size(923, 44);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 645);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlBottom.Size = new System.Drawing.Size(923, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 44);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 601);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(923, 44);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 601);
			// 
			// repositoryItemFontEditRichEdit1
			// 
			this.repositoryItemFontEditRichEdit1.AutoHeight = false;
			this.repositoryItemFontEditRichEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemFontEditRichEdit1.Name = "repositoryItemFontEditRichEdit1";
			// 
			// repositoryItemRichEditFontSizeEdit1
			// 
			this.repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
			this.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
			// 
			// repositoryItemRichEditStyleEdit1
			// 
			this.repositoryItemRichEditStyleEdit1.AutoHeight = false;
			this.repositoryItemRichEditStyleEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1";
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.xtraTabControl);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 44);
			this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(809, 386, 650, 400);
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(923, 601);
			this.layoutControl1.TabIndex = 4;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// xtraTabControl
			// 
			this.xtraTabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.xtraTabControl.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.xtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
			this.xtraTabControl.Location = new System.Drawing.Point(5, 10);
			this.xtraTabControl.Margin = new System.Windows.Forms.Padding(0);
			this.xtraTabControl.MultiLine = DevExpress.Utils.DefaultBoolean.False;
			this.xtraTabControl.Name = "xtraTabControl";
			this.xtraTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
			this.xtraTabControl.Size = new System.Drawing.Size(913, 586);
			this.xtraTabControl.TabIndex = 0;
			this.xtraTabControl.CloseButtonClick += new System.EventHandler(this.xtraTabControl_CloseButtonClick);
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 5);
			this.Root.Size = new System.Drawing.Size(923, 601);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.xtraTabControl;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem1.Size = new System.Drawing.Size(913, 586);
			this.layoutControlItem1.TextVisible = false;
			// 
			// NotesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "NotesView";
			this.Size = new System.Drawing.Size(923, 645);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEditRichEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraRichEdit.UI.RepositoryItemFontEditRichEdit repositoryItemFontEditRichEdit1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit repositoryItemRichEditStyleEdit1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiReload;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
    }
}
