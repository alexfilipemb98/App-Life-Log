namespace Life_Log.Views.Home.Commands
{
    partial class CommandsListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandsListView));
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
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.npMain = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.commandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tileView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colExternalProgram = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colType = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCommand = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colIsEnabled = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCreatedAt = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colUpdatedAt = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colEditingMode = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colIcon = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colIdExternalProgram = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.listboxPrograms = new DevExpress.XtraEditors.ListBoxControl();
            this.externalProgramsEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.npEditor = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.commandsDetailView = new Life_Log.Views.Home.Commands.CommandsDetailView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.npMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listboxPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalProgramsEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.npEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
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
            this.bbiBack.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.undo;
            this.bbiBack.Name = "bbiBack";
            this.bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBack_ItemClick);
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 0;
            this.bbiNew.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.actions_add;
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
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
            this.bbiDelete.Id = 5;
            this.bbiDelete.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.delete;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 4;
            this.bbiSave.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.save;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 1;
            this.bbiRefresh.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.actions_refresh;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
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
            this.repositoryItemSearchControl1.Client = this.gridControl;
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(892, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 570);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(892, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 531);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(892, 39);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
            // 
            // bbiRunAdmin
            // 
            this.bbiRunAdmin.Caption = "Run Admin";
            this.bbiRunAdmin.Id = 6;
            this.bbiRunAdmin.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.bo_attention;
            this.bbiRunAdmin.Name = "bbiRunAdmin";
            this.bbiRunAdmin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRunAdmin_ItemClick);
            // 
            // bbiEnable
            // 
            this.bbiEnable.Caption = "Disable";
            this.bbiEnable.Id = 7;
            this.bbiEnable.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.actions_deletecircled;
            this.bbiEnable.Name = "bbiEnable";
            this.bbiEnable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEnable_ItemClick);
            // 
            // bbiCreateFile
            // 
            this.bbiCreateFile.Caption = "Create File";
            this.bbiCreateFile.Id = 10;
            this.bbiCreateFile.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.addfile;
            this.bbiCreateFile.Name = "bbiCreateFile";
            this.bbiCreateFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCreateFile_ItemClick);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.navigationFrame);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 39);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(892, 531);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.npMain);
            this.navigationFrame.Controls.Add(this.npEditor);
            this.navigationFrame.Location = new System.Drawing.Point(5, 10);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(0);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npMain,
            this.npEditor});
            this.navigationFrame.SelectedPage = this.npMain;
            this.navigationFrame.Size = new System.Drawing.Size(882, 516);
            this.navigationFrame.TabIndex = 4;
            this.navigationFrame.Text = "navigationFrame1";
            // 
            // npMain
            // 
            this.npMain.Controls.Add(this.layoutControl2);
            this.npMain.Margin = new System.Windows.Forms.Padding(0);
            this.npMain.Name = "npMain";
            this.npMain.Size = new System.Drawing.Size(882, 516);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gridControl);
            this.layoutControl2.Controls.Add(this.listboxPrograms);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(882, 516);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gridControl
            // 
            this.gridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl.DataSource = this.commandsBindingSource;
            this.gridControl.Location = new System.Drawing.Point(93, 3);
            this.gridControl.MainView = this.tileView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl.MenuManager = this.barManager;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(786, 510);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView});
            // 
            // commandsBindingSource
            // 
            this.commandsBindingSource.DataSource = typeof(Data.Entities.CommandsEntity);
            // 
            // tileView
            // 
            this.tileView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExternalProgram,
            this.colName,
            this.colDescription,
            this.colType,
            this.colCommand,
            this.colIsEnabled,
            this.colId,
            this.colCreatedAt,
            this.colUpdatedAt,
            this.colEditingMode,
            this.colIcon,
            this.colIdExternalProgram});
            this.tileView.GridControl = this.gridControl;
            this.tileView.Name = "tileView";
            this.tileView.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.tileView.OptionsDragDrop.AllowDrag = true;
            this.tileView.OptionsHtmlTemplate.ItemAutoHeight = true;
            this.tileView.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None;
            this.tileView.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileView.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0);
            this.tileView.OptionsTiles.ItemSize = new System.Drawing.Size(248, 110);
            this.tileView.OptionsTiles.Padding = new System.Windows.Forms.Padding(5);
            this.tileView.OptionsTiles.RowCount = 0;
            this.tileView.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tileView.TileHtmlTemplate.Styles = resources.GetString("tileView.TileHtmlTemplate.Styles");
            this.tileView.TileHtmlTemplate.Template = resources.GetString("tileView.TileHtmlTemplate.Template");
            this.tileView.ItemDoubleClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tileView_ItemDoubleClick);
            this.tileView.ItemRightClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tileView_ItemRightClick);
            this.tileView.CustomItemTemplate += new DevExpress.XtraGrid.Views.Tile.TileViewCustomItemTemplateEventHandler(this.tileView_CustomItemTemplate);
            // 
            // colExternalProgram
            // 
            this.colExternalProgram.FieldName = "ExternalProgram";
            this.colExternalProgram.Name = "colExternalProgram";
            this.colExternalProgram.Visible = true;
            this.colExternalProgram.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
            // 
            // colCommand
            // 
            this.colCommand.FieldName = "Command";
            this.colCommand.Name = "colCommand";
            this.colCommand.Visible = true;
            this.colCommand.VisibleIndex = 4;
            // 
            // colIsEnabled
            // 
            this.colIsEnabled.FieldName = "IsEnabled";
            this.colIsEnabled.Name = "colIsEnabled";
            this.colIsEnabled.Visible = true;
            this.colIsEnabled.VisibleIndex = 5;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 6;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.FieldName = "CreatedAt";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Visible = true;
            this.colCreatedAt.VisibleIndex = 7;
            // 
            // colUpdatedAt
            // 
            this.colUpdatedAt.FieldName = "UpdatedAt";
            this.colUpdatedAt.Name = "colUpdatedAt";
            this.colUpdatedAt.Visible = true;
            this.colUpdatedAt.VisibleIndex = 8;
            // 
            // colEditingMode
            // 
            this.colEditingMode.FieldName = "EditingMode";
            this.colEditingMode.Name = "colEditingMode";
            this.colEditingMode.Visible = true;
            this.colEditingMode.VisibleIndex = 9;
            // 
            // colIcon
            // 
            this.colIcon.FieldName = "Icon";
            this.colIcon.Name = "colIcon";
            this.colIcon.Visible = true;
            this.colIcon.VisibleIndex = 10;
            // 
            // colIdExternalProgram
            // 
            this.colIdExternalProgram.FieldName = "IdExternalProgram";
            this.colIdExternalProgram.Name = "colIdExternalProgram";
            this.colIdExternalProgram.Visible = true;
            this.colIdExternalProgram.VisibleIndex = 11;
            // 
            // listboxPrograms
            // 
            this.listboxPrograms.Cursor = System.Windows.Forms.Cursors.Default;
            this.listboxPrograms.DataSource = this.externalProgramsEntityBindingSource;
            this.listboxPrograms.DisplayMember = "Name";
            this.listboxPrograms.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.listboxPrograms.HtmlTemplates.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.htmlTemplate1});
            this.listboxPrograms.ItemHeight = 75;
            this.listboxPrograms.Location = new System.Drawing.Point(3, 8);
            this.listboxPrograms.Margin = new System.Windows.Forms.Padding(0);
            this.listboxPrograms.MinimumSize = new System.Drawing.Size(84, 84);
            this.listboxPrograms.Name = "listboxPrograms";
            this.listboxPrograms.Size = new System.Drawing.Size(84, 500);
            this.listboxPrograms.StyleController = this.layoutControl2;
            this.listboxPrograms.TabIndex = 1;
            this.listboxPrograms.ValueMember = "Id";
            this.listboxPrograms.SelectedIndexChanged += new System.EventHandler(this.listboxPrograms_SelectedIndexChanged);
            this.listboxPrograms.CustomItemTemplate += new DevExpress.XtraEditors.CustomItemTemplateEventHandler(this.listBoxControl1_CustomItemTemplate);
            // 
            // externalProgramsEntityBindingSource
            // 
            this.externalProgramsEntityBindingSource.DataSource = typeof(Data.Entities.ExternalProgramsEntity);
            // 
            // htmlTemplate1
            // 
            this.htmlTemplate1.Name = "htmlTemplate1";
            this.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles");
            this.htmlTemplate1.Template = "<div class=\"contact\">\r\n    <div class=\"contact-avatar\">\r\n        <img class=\"phot" +
    "o\" src=\"${Icon}\" />\r\n    </div>\r\n</div>\r\n<div class=\'selection\'></div>";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(882, 516);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.listboxPrograms;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(90, 516);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl;
            this.layoutControlItem3.Location = new System.Drawing.Point(90, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(792, 516);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // npEditor
            // 
            this.npEditor.Controls.Add(this.commandsDetailView);
            this.npEditor.Name = "npEditor";
            this.npEditor.Size = new System.Drawing.Size(882, 516);
            // 
            // commandsDetailView
            // 
            this.commandsDetailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsDetailView.Location = new System.Drawing.Point(0, 0);
            this.commandsDetailView.Name = "commandsDetailView";
            this.commandsDetailView.Size = new System.Drawing.Size(882, 516);
            this.commandsDetailView.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 5);
            this.Root.Size = new System.Drawing.Size(892, 531);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.navigationFrame;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(882, 516);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEnable),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCreateFile, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRunAdmin),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete, true)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // CommandsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CommandsListView";
            this.Size = new System.Drawing.Size(892, 570);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.npMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listboxPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalProgramsEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.npEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage npMain;
        private DevExpress.XtraBars.Navigation.NavigationPage npEditor;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource commandsBindingSource;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView;
        private DevExpress.XtraGrid.Columns.TileViewColumn colExternalProgram;
        private DevExpress.XtraGrid.Columns.TileViewColumn colName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDescription;
        private DevExpress.XtraGrid.Columns.TileViewColumn colType;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCommand;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIsEnabled;
        private DevExpress.XtraGrid.Columns.TileViewColumn colId;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCreatedAt;
        private DevExpress.XtraGrid.Columns.TileViewColumn colUpdatedAt;
        private DevExpress.XtraGrid.Columns.TileViewColumn colEditingMode;
        private DevExpress.XtraBars.BarButtonItem bbiBack;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private CommandsDetailView commandsDetailView;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIcon;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIdExternalProgram;
        private DevExpress.XtraBars.BarButtonItem bbiRunAdmin;
        private DevExpress.XtraEditors.ListBoxControl listboxPrograms;
        private DevExpress.Utils.Html.HtmlTemplate htmlTemplate1;
        private System.Windows.Forms.BindingSource externalProgramsEntityBindingSource;
        private DevExpress.XtraBars.BarButtonItem bbiEnable;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.BarEditItem bbiSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem bbiCreateFile;
    }
}
