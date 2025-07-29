namespace LifeLog.UI.BackEnd.Views.Notes
{
	partial class NotesListView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesListView));
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
			this.npMain = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.bsNotes = new DevExpress.Xpo.XPBindingSource(this.components);
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUpdatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSaving = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEditingMode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsValid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.npEditor = new DevExpress.XtraBars.Navigation.NavigationPage();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
			this.bbiDelele = new DevExpress.XtraBars.BarButtonItem();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar = new DevExpress.XtraBars.Bar();
			this.bbiBack = new DevExpress.XtraBars.BarButtonItem();
			this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
			this.bbiReload = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSearch = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
			this.navigationFrame.SuspendLayout();
			this.npMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsNotes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.panelControl1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 44);
			this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(897, 526);
			this.layoutControl1.TabIndex = 6;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.navigationFrame);
			this.panelControl1.Location = new System.Drawing.Point(5, 10);
			this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(887, 511);
			this.panelControl1.TabIndex = 6;
			// 
			// navigationFrame
			// 
			this.navigationFrame.Controls.Add(this.npMain);
			this.navigationFrame.Controls.Add(this.npEditor);
			this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.navigationFrame.Location = new System.Drawing.Point(2, 2);
			this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.navigationFrame.Name = "navigationFrame";
			this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npMain,
            this.npEditor});
			this.navigationFrame.SelectedPage = this.npMain;
			this.navigationFrame.Size = new System.Drawing.Size(883, 507);
			this.navigationFrame.TabIndex = 5;
			this.navigationFrame.Text = "navigationFrame1";
			// 
			// npMain
			// 
			this.npMain.Caption = "npMain";
			this.npMain.Controls.Add(this.gridControl);
			this.npMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.npMain.Name = "npMain";
			this.npMain.Size = new System.Drawing.Size(883, 507);
			// 
			// gridControl
			// 
			this.gridControl.DataSource = this.bsNotes;
			this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.gridControl.Location = new System.Drawing.Point(0, 0);
			this.gridControl.MainView = this.gridView;
			this.gridControl.Margin = new System.Windows.Forms.Padding(0);
			this.gridControl.Name = "gridControl";
			this.gridControl.Size = new System.Drawing.Size(883, 507);
			this.gridControl.TabIndex = 4;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// bsNotes
			// 
			this.bsNotes.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
			this.bsNotes.ObjectType = typeof(LifeLog.Data.Database.Entities.NotesEntity);
			// 
			// gridView
			// 
			this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCreatedAt,
            this.colUpdatedAt,
            this.colSaving,
            this.colEditingMode,
            this.colIsValid,
            this.gridColumn1,
            this.colUser,
            this.colTitle,
            this.colUserId});
			this.gridView.DetailHeight = 371;
			this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView.GridControl = this.gridControl;
			this.gridView.Name = "gridView";
			this.gridView.OptionsBehavior.Editable = false;
			this.gridView.OptionsDetail.EnableMasterViewMode = false;
			this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView.OptionsView.ShowGroupPanel = false;
			this.gridView.OptionsView.ShowIndicator = false;
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
			this.colCreatedAt.Name = "colCreatedAt";
			this.colCreatedAt.Visible = true;
			this.colCreatedAt.VisibleIndex = 1;
			this.colCreatedAt.Width = 151;
			// 
			// colUpdatedAt
			// 
			this.colUpdatedAt.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
			this.colUpdatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colUpdatedAt.FieldName = "UpdatedAt";
			this.colUpdatedAt.Name = "colUpdatedAt";
			this.colUpdatedAt.Visible = true;
			this.colUpdatedAt.VisibleIndex = 2;
			this.colUpdatedAt.Width = 150;
			// 
			// colSaving
			// 
			this.colSaving.FieldName = "Saving";
			this.colSaving.Name = "colSaving";
			// 
			// colEditingMode
			// 
			this.colEditingMode.FieldName = "EditingMode";
			this.colEditingMode.Name = "colEditingMode";
			this.colEditingMode.OptionsColumn.ReadOnly = true;
			// 
			// colIsValid
			// 
			this.colIsValid.FieldName = "IsValid";
			this.colIsValid.Name = "colIsValid";
			this.colIsValid.OptionsColumn.ReadOnly = true;
			// 
			// gridColumn1
			// 
			this.gridColumn1.FieldName = "User!Key";
			this.gridColumn1.Name = "gridColumn1";
			// 
			// colUser
			// 
			this.colUser.FieldName = "User";
			this.colUser.Name = "colUser";
			// 
			// colTitle
			// 
			this.colTitle.FieldName = "Title";
			this.colTitle.Name = "colTitle";
			this.colTitle.Visible = true;
			this.colTitle.VisibleIndex = 0;
			this.colTitle.Width = 582;
			// 
			// colUserId
			// 
			this.colUserId.FieldName = "UserId";
			this.colUserId.Name = "colUserId";
			this.colUserId.OptionsColumn.ReadOnly = true;
			// 
			// npEditor
			// 
			this.npEditor.Caption = "npEditor";
			this.npEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.npEditor.Name = "npEditor";
			this.npEditor.Size = new System.Drawing.Size(883, 507);
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 5);
			this.Root.Size = new System.Drawing.Size(897, 526);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.panelControl1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem1.Size = new System.Drawing.Size(887, 511);
			this.layoutControlItem1.TextVisible = false;
			// 
			// popupMenu
			// 
			this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelele)});
			this.popupMenu.Manager = this.barManager;
			this.popupMenu.Name = "popupMenu";
			// 
			// bbiEdit
			// 
			this.bbiEdit.Caption = "Edit";
			this.bbiEdit.Id = 4;
			this.bbiEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEdit.ImageOptions.SvgImage")));
			this.bbiEdit.Name = "bbiEdit";
			// 
			// bbiDelele
			// 
			this.bbiDelele.Caption = "Delete";
			this.bbiDelele.Id = 5;
			this.bbiDelele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiDelele.ImageOptions.SvgImage")));
			this.bbiDelele.Name = "bbiDelele";
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
            this.bbiBack,
            this.bbiEdit,
            this.bbiDelele,
            this.bbiSearch});
			this.barManager.MainMenu = this.bar;
			this.barManager.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiBack, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNew),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiDelele, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiReload, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.bbiSearch, "", true, true, true, 250, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar.OptionsBar.AllowQuickCustomization = false;
			this.bar.OptionsBar.DrawBorder = false;
			this.bar.OptionsBar.DrawDragBorder = false;
			this.bar.OptionsBar.MinHeight = 35;
			this.bar.OptionsBar.MultiLine = true;
			this.bar.OptionsBar.UseWholeRow = true;
			this.bar.Text = "Main menu";
			// 
			// bbiBack
			// 
			this.bbiBack.Caption = "Back";
			this.bbiBack.Id = 3;
			this.bbiBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiBack.ImageOptions.SvgImage")));
			this.bbiBack.Name = "bbiBack";
			this.bbiBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			// 
			// bbiNew
			// 
			this.bbiNew.Caption = "New";
			this.bbiNew.Id = 0;
			this.bbiNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiNew.ImageOptions.SvgImage")));
			this.bbiNew.Name = "bbiNew";
			this.bbiNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// bbiSave
			// 
			this.bbiSave.Caption = "Save";
			this.bbiSave.Id = 1;
			this.bbiSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSave.ImageOptions.SvgImage")));
			this.bbiSave.Name = "bbiSave";
			this.bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			// 
			// bbiReload
			// 
			this.bbiReload.Caption = "Reload";
			this.bbiReload.GroupIndex = 1;
			this.bbiReload.Id = 2;
			this.bbiReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiReload.ImageOptions.SvgImage")));
			this.bbiReload.Name = "bbiReload";
			// 
			// bbiSearch
			// 
			this.bbiSearch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.bbiSearch.Caption = "Search";
			this.bbiSearch.Edit = this.repositoryItemSearchControl1;
			this.bbiSearch.EditWidth = 250;
			this.bbiSearch.Id = 7;
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
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlTop.Size = new System.Drawing.Size(897, 44);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 570);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlBottom.Size = new System.Drawing.Size(897, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 44);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 526);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(897, 44);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 526);
			// 
			// repositoryItemTextEdit1
			// 
			this.repositoryItemTextEdit1.AutoHeight = false;
			this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
			// 
			// NotesListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "NotesListView";
			this.Size = new System.Drawing.Size(897, 570);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
			this.navigationFrame.ResumeLayout(false);
			this.npMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsNotes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
		private DevExpress.XtraBars.Navigation.NavigationPage npMain;
		private DevExpress.XtraGrid.GridControl gridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private DevExpress.XtraBars.Navigation.NavigationPage npEditor;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraBars.PopupMenu popupMenu;
		private DevExpress.XtraBars.BarButtonItem bbiEdit;
		private DevExpress.XtraBars.BarButtonItem bbiDelele;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.Bar bar;
		private DevExpress.XtraBars.BarButtonItem bbiBack;
		private DevExpress.XtraBars.BarButtonItem bbiNew;
		private DevExpress.XtraBars.BarButtonItem bbiSave;
		private DevExpress.XtraBars.BarButtonItem bbiReload;
		private DevExpress.XtraBars.BarEditItem bbiSearch;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
		private DevExpress.Xpo.XPBindingSource bsNotes;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
		private DevExpress.XtraGrid.Columns.GridColumn colUpdatedAt;
		private DevExpress.XtraGrid.Columns.GridColumn colSaving;
		private DevExpress.XtraGrid.Columns.GridColumn colEditingMode;
		private DevExpress.XtraGrid.Columns.GridColumn colIsValid;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn colUser;
		private DevExpress.XtraGrid.Columns.GridColumn colTitle;
		private DevExpress.XtraGrid.Columns.GridColumn colUserId;
	}
}
