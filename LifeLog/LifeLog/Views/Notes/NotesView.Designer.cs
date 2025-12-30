namespace LifeLog.Views.Notes
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
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar = new DevExpress.XtraBars.Bar();
			this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
			this.bbiImport = new DevExpress.XtraBars.BarButtonItem();
			this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
			this.bbiReload = new DevExpress.XtraBars.BarButtonItem();
			this.bbiTitle = new DevExpress.XtraBars.BarEditItem();
			this.riteTitleNote = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.bbiNotesColor = new DevExpress.XtraBars.BarEditItem();
			this.riceColorNote = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
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
			((System.ComponentModel.ISupportInitialize)(this.riteTitleNote)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.riceColorNote)).BeginInit();
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
            this.bbiExport,
            this.bbiImport,
            this.barSubItem1,
            this.bbiNotesColor,
            this.bbiTitle});
			this.barManager.MainMenu = this.bar;
			this.barManager.MaxItemId = 76;
			this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEditRichEdit1,
            this.repositoryItemRichEditFontSizeEdit1,
            this.repositoryItemRichEditStyleEdit1,
            this.riceColorNote,
            this.riteTitleNote});
			// 
			// bar
			// 
			this.bar.BarName = "Main menu";
			this.bar.DockCol = 0;
			this.bar.DockRow = 0;
			this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar.FloatLocation = new System.Drawing.Point(348, 85);
			this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiReload, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.bbiTitle, "", false, true, true, 203, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.bbiNotesColor, "", false, true, true, 77, null, DevExpress.XtraBars.BarItemPaintStyle.Standard)});
			this.bar.OptionsBar.DrawBorder = false;
			this.bar.OptionsBar.DrawDragBorder = false;
			this.bar.OptionsBar.MinHeight = 35;
			this.bar.OptionsBar.MultiLine = true;
			this.bar.OptionsBar.UseWholeRow = true;
			this.bar.Text = "Main menu";
			// 
			// barSubItem1
			// 
			this.barSubItem1.Caption = "File";
			this.barSubItem1.Id = 73;
			this.barSubItem1.ImageOptions.SvgImage = global::LifeLog.Properties.Resources.attachments;
			this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiImport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.barSubItem1.Name = "barSubItem1";
			// 
			// bbiExport
			// 
			this.bbiExport.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bbiExport.Caption = "Export";
			this.bbiExport.Id = 71;
			this.bbiExport.ImageOptions.SvgImage = global::LifeLog.Properties.Resources.exportas;
			this.bbiExport.Name = "bbiExport";
			this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
			// 
			// bbiImport
			// 
			this.bbiImport.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bbiImport.Caption = "Import";
			this.bbiImport.Id = 72;
			this.bbiImport.ImageOptions.SvgImage = global::LifeLog.Properties.Resources.import;
			this.bbiImport.Name = "bbiImport";
			this.bbiImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImport_ItemClick);
			// 
			// bbiNew
			// 
			this.bbiNew.Caption = "New";
			this.bbiNew.Id = 0;
			this.bbiNew.ImageOptions.SvgImage = global::LifeLog.Properties.Resources.actions_add;
			this.bbiNew.Name = "bbiNew";
			this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
			// 
			// bbiSave
			// 
			this.bbiSave.Caption = "Save";
			this.bbiSave.Id = 65;
			this.bbiSave.ImageOptions.SvgImage = global::LifeLog.Properties.Resources.saveall;
			this.bbiSave.Name = "bbiSave";
			this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
			// 
			// bbiReload
			// 
			this.bbiReload.Caption = "Reload";
			this.bbiReload.Id = 66;
			this.bbiReload.ImageOptions.SvgImage = global::LifeLog.Properties.Resources.actions_refresh;
			this.bbiReload.Name = "bbiReload";
			this.bbiReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReload_ItemClick);
			// 
			// bbiTitle
			// 
			this.bbiTitle.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bbiTitle.Caption = "Note Title";
			this.bbiTitle.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Stretch;
			this.bbiTitle.Edit = this.riteTitleNote;
			this.bbiTitle.EditWidth = 100;
			this.bbiTitle.Id = 75;
			this.bbiTitle.Name = "bbiTitle";
			this.bbiTitle.UseEditorPadding = false;
			this.bbiTitle.EditValueChanged += new System.EventHandler(this.bbiTitle_EditValueChanged);
			// 
			// riteTitleNote
			// 
			this.riteTitleNote.AutoHeight = false;
			this.riteTitleNote.MaxLength = 30;
			this.riteTitleNote.Name = "riteTitleNote";
			// 
			// bbiNotesColor
			// 
			this.bbiNotesColor.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bbiNotesColor.Caption = "Color";
			this.bbiNotesColor.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Near;
			this.bbiNotesColor.Edit = this.riceColorNote;
			this.bbiNotesColor.Id = 74;
			this.bbiNotesColor.Name = "bbiNotesColor";
			this.bbiNotesColor.EditValueChanged += new System.EventHandler(this.bbiNotesColor_EditValueChanged);
			// 
			// riceColorNote
			// 
			this.riceColorNote.AutoHeight = false;
			this.riceColorNote.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.riceColorNote.ColorAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.riceColorNote.ColorDialogType = DevExpress.XtraEditors.Popup.ColorDialogType.Advanced;
			this.riceColorNote.Name = "riceColorNote";
			this.riceColorNote.ShowAutomaticButton = false;
			this.riceColorNote.ShowMoreColorsButton = false;
			this.riceColorNote.ShowSystemColors = false;
			this.riceColorNote.ShowWebColors = false;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.barDockControlTop.Size = new System.Drawing.Size(923, 44);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 607);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.barDockControlBottom.Size = new System.Drawing.Size(923, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 44);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 563);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(923, 44);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 563);
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
			this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(809, 386, 650, 400);
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(923, 563);
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
			this.xtraTabControl.Size = new System.Drawing.Size(913, 548);
			this.xtraTabControl.TabIndex = 0;
			this.xtraTabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl_SelectedPageChanged);
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
			this.Root.Size = new System.Drawing.Size(923, 563);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.xtraTabControl;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem1.Size = new System.Drawing.Size(913, 548);
			this.layoutControlItem1.TextVisible = false;
			// 
			// NotesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "NotesView";
			this.Size = new System.Drawing.Size(923, 607);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.riteTitleNote)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.riceColorNote)).EndInit();
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
		private DevExpress.XtraBars.BarButtonItem bbiExport;
		private DevExpress.XtraBars.BarButtonItem bbiImport;
		private DevExpress.XtraBars.BarSubItem barSubItem1;
		private DevExpress.XtraBars.BarEditItem bbiNotesColor;
		private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit riceColorNote;
		private DevExpress.XtraBars.BarEditItem bbiTitle;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteTitleNote;
	}
}
