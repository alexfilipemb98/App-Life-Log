namespace Life_Log_App.Views.Tables.ExternalPrograms
{
    partial class ExternalProgramsListView
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
            this.bbiBack = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSearch = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiRunAdmin = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEnable = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCreateFile = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.npList = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gcExternalPrograms = new DevExpress.XtraGrid.GridControl();
            this.xpbsExternalPrograms = new DevExpress.Xpo.XPBindingSource(this.components);
            this.gvExternalPrograms = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArguments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.npDetail = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.externalProgramsDetailView = new Life_Log_App.Views.Tables.ExternalPrograms.ExternalProgramsDetailView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xpcExternalPrograms = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.npList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcExternalPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpbsExternalPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExternalPrograms)).BeginInit();
            this.npDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcExternalPrograms)).BeginInit();
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
            this.bbiRefresh,
            this.bbiBack,
            this.bbiEdit,
            this.bbiSave,
            this.bbiDelete,
            this.bbiRunAdmin,
            this.bbiEnable,
            this.bbiSearch,
            this.bbiCreateFile});
            this.barManager.MainMenu = this.bar;
            this.barManager.MaxItemId = 11;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemSearchControl1});
            // 
            // bar
            // 
            this.bar.BarName = "Main menu";
            this.bar.DockCol = 0;
            this.bar.DockRow = 0;
            this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiBack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiRefresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSearch, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar.OptionsBar.DrawBorder = false;
            this.bar.OptionsBar.DrawDragBorder = false;
            this.bar.OptionsBar.MultiLine = true;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.Text = "Main menu";
            // 
            // bbiBack
            // 
            this.bbiBack.Caption = "Back";
            this.bbiBack.Id = 2;
            this.bbiBack.ImageOptions.SvgImage = global::Life_Log_App.Properties.Resources.undo;
            this.bbiBack.Name = "bbiBack";
            this.bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBack_ItemClick);
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 0;
            this.bbiNew.ImageOptions.SvgImage = global::Life_Log_App.Properties.Resources.actions_add;
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 3;
            this.bbiEdit.ImageOptions.SvgImage = global::Life_Log_App.Properties.Resources.actions_edit;
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 5;
            this.bbiDelete.ImageOptions.SvgImage = global::Life_Log_App.Properties.Resources.delete;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 4;
            this.bbiSave.ImageOptions.SvgImage = global::Life_Log_App.Properties.Resources.saveall;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 1;
            this.bbiRefresh.ImageOptions.SvgImage = global::Life_Log_App.Properties.Resources.actions_refresh;
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // bbiSearch
            // 
            this.bbiSearch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiSearch.Caption = "Search";
            this.bbiSearch.Edit = this.repositoryItemSearchControl1;
            this.bbiSearch.EditWidth = 250;
            this.bbiSearch.Id = 9;
            this.bbiSearch.MaxWidth = 250;
            this.bbiSearch.MinWidth = 250;
            this.bbiSearch.Name = "bbiSearch";
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1016, 43);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 583);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1016, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 43);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 540);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1016, 43);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 540);
            // 
            // bbiRunAdmin
            // 
            this.bbiRunAdmin.Caption = "Run Admin";
            this.bbiRunAdmin.Id = 6;
            this.bbiRunAdmin.ImageOptions.SvgImage = global::Life_Log_App.Properties.Resources.bo_attention;
            this.bbiRunAdmin.Name = "bbiRunAdmin";
            // 
            // bbiEnable
            // 
            this.bbiEnable.Caption = "Disable";
            this.bbiEnable.Id = 7;
            this.bbiEnable.ImageOptions.SvgImage = global::Life_Log_App.Properties.Resources.actions_deletecircled;
            this.bbiEnable.Name = "bbiEnable";
            // 
            // bbiCreateFile
            // 
            this.bbiCreateFile.Caption = "Create File";
            this.bbiCreateFile.Id = 10;
            this.bbiCreateFile.ImageOptions.SvgImage = global::Life_Log_App.Properties.Resources.saveall;
            this.bbiCreateFile.Name = "bbiCreateFile";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 43);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1016, 540);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.navigationFrame);
            this.panelControl1.Location = new System.Drawing.Point(8, 8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1000, 524);
            this.panelControl1.TabIndex = 5;
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.npList);
            this.navigationFrame.Controls.Add(this.npDetail);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(2, 2);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npList,
            this.npDetail});
            this.navigationFrame.SelectedPage = this.npList;
            this.navigationFrame.Size = new System.Drawing.Size(996, 520);
            this.navigationFrame.TabIndex = 5;
            this.navigationFrame.Text = "navigationFrame1";
            // 
            // npList
            // 
            this.npList.Controls.Add(this.gcExternalPrograms);
            this.npList.Name = "npList";
            this.npList.Size = new System.Drawing.Size(996, 520);
            // 
            // gcExternalPrograms
            // 
            this.gcExternalPrograms.DataSource = this.xpbsExternalPrograms;
            this.gcExternalPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcExternalPrograms.Location = new System.Drawing.Point(0, 0);
            this.gcExternalPrograms.MainView = this.gvExternalPrograms;
            this.gcExternalPrograms.MenuManager = this.barManager;
            this.gcExternalPrograms.Name = "gcExternalPrograms";
            this.gcExternalPrograms.Size = new System.Drawing.Size(996, 520);
            this.gcExternalPrograms.TabIndex = 4;
            this.gcExternalPrograms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvExternalPrograms});
            // 
            // xpbsExternalPrograms
            // 
            this.xpbsExternalPrograms.DataSource = this.xpcExternalPrograms;
            // 
            // gvExternalPrograms
            // 
            this.gvExternalPrograms.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvExternalPrograms.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCreatedAt,
            this.colUpdatedAt,
            this.colFileExtension,
            this.colName,
            this.colArguments});
            this.gvExternalPrograms.CustomizationFormBounds = new System.Drawing.Rectangle(1084, 287, 259, 394);
            this.gvExternalPrograms.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvExternalPrograms.GridControl = this.gcExternalPrograms;
            this.gvExternalPrograms.Name = "gvExternalPrograms";
            this.gvExternalPrograms.OptionsBehavior.Editable = false;
            this.gvExternalPrograms.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvExternalPrograms.OptionsView.ShowGroupPanel = false;
            this.gvExternalPrograms.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
            this.colCreatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.GroupFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
            this.colCreatedAt.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreatedAt.MaxWidth = 150;
            this.colCreatedAt.MinWidth = 150;
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 2;
            this.colCreatedAt.Width = 150;
            // 
            // colUpdatedAt
            // 
            this.colUpdatedAt.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
            this.colUpdatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUpdatedAt.FieldName = "UpdatedAt";
            this.colUpdatedAt.GroupFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
            this.colUpdatedAt.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUpdatedAt.MaxWidth = 150;
            this.colUpdatedAt.MinWidth = 150;
            this.colUpdatedAt.Name = "colUpdatedAt";
            this.colUpdatedAt.Visible = true;
            this.colUpdatedAt.VisibleIndex = 3;
            this.colUpdatedAt.Width = 150;
            // 
            // colFileExtension
            // 
            this.colFileExtension.FieldName = "FileExtension";
            this.colFileExtension.MaxWidth = 150;
            this.colFileExtension.MinWidth = 100;
            this.colFileExtension.Name = "colFileExtension";
            this.colFileExtension.Visible = true;
            this.colFileExtension.VisibleIndex = 1;
            this.colFileExtension.Width = 100;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 546;
            // 
            // colArguments
            // 
            this.colArguments.FieldName = "Arguments";
            this.colArguments.Name = "colArguments";
            this.colArguments.Width = 185;
            // 
            // npDetail
            // 
            this.npDetail.Caption = "npDetail";
            this.npDetail.Controls.Add(this.externalProgramsDetailView);
            this.npDetail.Name = "npDetail";
            this.npDetail.Size = new System.Drawing.Size(996, 520);
            // 
            // externalProgramsDetailView
            // 
            this.externalProgramsDetailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.externalProgramsDetailView.Location = new System.Drawing.Point(0, 0);
            this.externalProgramsDetailView.Name = "externalProgramsDetailView";
            this.externalProgramsDetailView.Size = new System.Drawing.Size(996, 520);
            this.externalProgramsDetailView.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Root.Size = new System.Drawing.Size(1016, 540);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1006, 530);
            this.layoutControlItem2.TextVisible = false;
            // 
            // xpcExternalPrograms
            // 
            this.xpcExternalPrograms.ObjectType = typeof(Data.ORM.DataModelCode.ORM_ExternalPrograms);
            // 
            // ExternalProgramsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ExternalProgramsListView";
            this.Size = new System.Drawing.Size(1016, 583);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.npList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcExternalPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpbsExternalPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExternalPrograms)).EndInit();
            this.npDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpcExternalPrograms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarButtonItem bbiBack;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarEditItem bbiSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiRunAdmin;
        private DevExpress.XtraBars.BarButtonItem bbiEnable;
        private DevExpress.XtraBars.BarButtonItem bbiCreateFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage npList;
        private DevExpress.XtraGrid.GridControl gcExternalPrograms;
        private DevExpress.XtraGrid.Views.Grid.GridView gvExternalPrograms;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraBars.Navigation.NavigationPage npDetail;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Xpo.XPBindingSource xpbsExternalPrograms;
        private DevExpress.XtraGrid.Columns.GridColumn colFileExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colArguments;
        private ExternalProgramsDetailView externalProgramsDetailView;
        private DevExpress.Xpo.XPCollection xpcExternalPrograms;
    }
}
