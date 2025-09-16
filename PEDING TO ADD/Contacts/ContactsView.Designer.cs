namespace Life_Log.Views.Home.Main.Contacts
{
    partial class ContactsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsView));
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.bbiBack = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReload = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSearch = new DevExpress.XtraBars.BarEditItem();
            this.riscGridSearch = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.contactsDataModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tileView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colBirthday = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colNickname = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.npMain = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.npEdit = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.contactsDetailView = new Life_Log.Views.Home.Main.Contacts.ContactsDetailView();
            this.colIcon = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riscGridSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.npMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.npEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 3;
            this.bbiEdit.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.actions_edit;
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 4;
            this.bbiDelete.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.delete;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiReload,
            this.bbiNew,
            this.bbiSearch,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiBack,
            this.bbiSave});
            this.barManager.MainMenu = this.bar;
            this.barManager.MaxItemId = 17;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riscGridSearch});
            // 
            // bar
            // 
            this.bar.BarName = "Main menu";
            this.bar.DockCol = 0;
            this.bar.DockRow = 0;
            this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiBack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiReload, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSearch)});
            this.bar.OptionsBar.AllowQuickCustomization = false;
            this.bar.OptionsBar.DisableCustomization = true;
            this.bar.OptionsBar.DrawDragBorder = false;
            this.bar.OptionsBar.MultiLine = true;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.Text = "Main menu";
            // 
            // bbiBack
            // 
            this.bbiBack.Caption = "Back";
            this.bbiBack.DropDownEnabled = false;
            this.bbiBack.Id = 10;
            this.bbiBack.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.undo;
            this.bbiBack.Name = "bbiBack";
            this.bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBack_ItemClick);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 11;
            this.bbiSave.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.saveall;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 1;
            this.bbiNew.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.actions_add;
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiReload
            // 
            this.bbiReload.Caption = " Reload";
            this.bbiReload.Id = 0;
            this.bbiReload.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.refreshallpivottable;
            this.bbiReload.Name = "bbiReload";
            this.bbiReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReload_ItemClick);
            // 
            // bbiSearch
            // 
            this.bbiSearch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiSearch.Caption = "Search";
            this.bbiSearch.Edit = this.riscGridSearch;
            this.bbiSearch.EditWidth = 250;
            this.bbiSearch.Id = 2;
            this.bbiSearch.Name = "bbiSearch";
            this.bbiSearch.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // riscGridSearch
            // 
            this.riscGridSearch.AutoHeight = false;
            this.riscGridSearch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.riscGridSearch.Name = "riscGridSearch";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(941, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 492);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(941, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 453);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(941, 39);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 453);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.contactsDataModelBindingSource;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gridControl.Location = new System.Drawing.Point(16, 16);
            this.gridControl.MainView = this.tileView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gridControl.MenuManager = this.barManager;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(909, 421);
            this.gridControl.TabIndex = 5;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView});
            // 
            // contactsDataModelBindingSource
            // 
            this.contactsDataModelBindingSource.DataSource = typeof(Core.Models.Data.ContactsDataModel);
            // 
            // tileView
            // 
            this.tileView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAge,
            this.colBirthday,
            this.colNickname,
            this.colPhone,
            this.colEmail,
            this.colName,
            this.colAddress,
            this.colIcon});
            this.tileView.GridControl = this.gridControl;
            this.tileView.Name = "tileView";
            this.tileView.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.tileView.OptionsDragDrop.AllowDrag = true;
            this.tileView.OptionsFind.ShowClearButton = false;
            this.tileView.OptionsFind.ShowCloseButton = false;
            this.tileView.OptionsHtmlTemplate.ItemAutoHeight = true;
            this.tileView.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None;
            this.tileView.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0);
            this.tileView.OptionsTiles.ItemSize = new System.Drawing.Size(500, 120);
            this.tileView.OptionsTiles.RowCount = 0;
            this.tileView.TileHtmlTemplate.Styles = resources.GetString("tileView.TileHtmlTemplate.Styles");
            this.tileView.TileHtmlTemplate.Template = resources.GetString("tileView.TileHtmlTemplate.Template");
            this.tileView.ItemRightClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tileView_ItemRightClick);
            this.tileView.CustomItemTemplate += new DevExpress.XtraGrid.Views.Tile.TileViewCustomItemTemplateEventHandler(this.tileView_CustomItemTemplate);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colAge
            // 
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 1;
            // 
            // colBirthday
            // 
            this.colBirthday.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.colBirthday.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBirthday.FieldName = "Birthday";
            this.colBirthday.Name = "colBirthday";
            this.colBirthday.Visible = true;
            this.colBirthday.VisibleIndex = 2;
            // 
            // colNickname
            // 
            this.colNickname.FieldName = "Nickname";
            this.colNickname.Name = "colNickname";
            this.colNickname.Visible = true;
            this.colNickname.VisibleIndex = 3;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 6;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 7;
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.npMain);
            this.navigationFrame.Controls.Add(this.npEdit);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 39);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npMain,
            this.npEdit});
            this.navigationFrame.SelectedPage = this.npMain;
            this.navigationFrame.Size = new System.Drawing.Size(941, 453);
            this.navigationFrame.TabIndex = 16;
            this.navigationFrame.Text = "navigationFrame1";
            // 
            // npMain
            // 
            this.npMain.Controls.Add(this.layoutControl1);
            this.npMain.Name = "npMain";
            this.npMain.Size = new System.Drawing.Size(941, 453);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(941, 453);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(941, 453);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(915, 427);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // npEdit
            // 
            this.npEdit.Controls.Add(this.contactsDetailView);
            this.npEdit.Name = "npEdit";
            this.npEdit.Size = new System.Drawing.Size(941, 453);
            // 
            // contactsDetailView
            // 
            this.contactsDetailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactsDetailView.Location = new System.Drawing.Point(0, 0);
            this.contactsDetailView.Name = "contactsDetailView";
            this.contactsDetailView.Size = new System.Drawing.Size(941, 453);
            this.contactsDetailView.TabIndex = 0;
            // 
            // colIcon
            // 
            this.colIcon.FieldName = "Icon";
            this.colIcon.Name = "colIcon";
            this.colIcon.Visible = true;
            this.colIcon.VisibleIndex = 8;
            // 
            // ContactsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ContactsView";
            this.Size = new System.Drawing.Size(941, 492);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riscGridSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.npMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.npEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarButtonItem bbiBack;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiReload;
        private DevExpress.XtraBars.BarEditItem bbiSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl riscGridSearch;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage npMain;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.Navigation.NavigationPage npEdit;
        private System.Windows.Forms.BindingSource contactsDataModelBindingSource;
        private DevExpress.XtraGrid.Columns.TileViewColumn colId;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAge;
        private DevExpress.XtraGrid.Columns.TileViewColumn colBirthday;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNickname;
        private DevExpress.XtraGrid.Columns.TileViewColumn colPhone;
        private DevExpress.XtraGrid.Columns.TileViewColumn colEmail;
        private DevExpress.XtraGrid.Columns.TileViewColumn colName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAddress;
        private ContactsDetailView contactsDetailView;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIcon;
    }
}
