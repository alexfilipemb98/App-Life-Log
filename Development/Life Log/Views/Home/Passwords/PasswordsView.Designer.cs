namespace Life_Log.Views.Home.Passwords
{
    partial class PasswordsView
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
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelele = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.bbiBack = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReload = new DevExpress.XtraBars.BarButtonItem();
            this.bsiMenuViews = new DevExpress.XtraBars.BarSubItem();
            this.bciDefaultView = new DevExpress.XtraBars.BarCheckItem();
            this.bciListView = new DevExpress.XtraBars.BarCheckItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.npEditor = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.passwordsDetailView = new Life_Log.Views.Home.Passwords.PasswordsDetailView();
            this.npList = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.passwordsListView = new Life_Log.Views.Home.Passwords.PasswordsListView();
            this.npMain = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.npEditor.SuspendLayout();
            this.npList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
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
            this.bbiEdit.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.actions_edit;
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelele
            // 
            this.bbiDelele.Caption = "Delete";
            this.bbiDelele.Id = 5;
            this.bbiDelele.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.delete;
            this.bbiDelele.Name = "bbiDelele";
            this.bbiDelele.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelele_ItemClick);
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
            this.bsiMenuViews,
            this.bciDefaultView,
            this.bciListView});
            this.barManager.MainMenu = this.bar;
            this.barManager.MaxItemId = 11;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bsiMenuViews, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar.OptionsBar.AllowQuickCustomization = false;
            this.bar.OptionsBar.DrawBorder = false;
            this.bar.OptionsBar.DrawDragBorder = false;
            this.bar.OptionsBar.MultiLine = true;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.Text = "Main menu";
            // 
            // bbiBack
            // 
            this.bbiBack.Caption = "Back";
            this.bbiBack.Id = 3;
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
            this.bbiNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 1;
            this.bbiSave.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.save;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiReload
            // 
            this.bbiReload.Caption = "Reload";
            this.bbiReload.GroupIndex = 1;
            this.bbiReload.Id = 2;
            this.bbiReload.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.actions_refresh;
            this.bbiReload.Name = "bbiReload";
            // 
            // bsiMenuViews
            // 
            this.bsiMenuViews.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiMenuViews.Caption = "View Mode";
            this.bsiMenuViews.Id = 6;
            this.bsiMenuViews.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.viewmergeddata;
            this.bsiMenuViews.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bciDefaultView),
            new DevExpress.XtraBars.LinkPersistInfo(this.bciListView)});
            this.bsiMenuViews.Name = "bsiMenuViews";
            // 
            // bciDefaultView
            // 
            this.bciDefaultView.BindableChecked = true;
            this.bciDefaultView.Caption = "Default";
            this.bciDefaultView.Checked = true;
            this.bciDefaultView.Id = 9;
            this.bciDefaultView.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.inserttreeview;
            this.bciDefaultView.Name = "bciDefaultView";
            this.bciDefaultView.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciDefaultView_CheckedChanged);
            // 
            // bciListView
            // 
            this.bciListView.Caption = "List";
            this.bciListView.Id = 10;
            this.bciListView.ImageOptions.SvgImage = global::Life_Log.Properties.Resources.listbullets;
            this.bciListView.Name = "bciListView";
            this.bciListView.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciListView_CheckedChanged);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(799, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 566);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(799, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 527);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(799, 39);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 527);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 39);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(799, 527);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.navigationFrame);
            this.panelControl1.Location = new System.Drawing.Point(5, 10);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(789, 512);
            this.panelControl1.TabIndex = 5;
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.npEditor);
            this.navigationFrame.Controls.Add(this.npList);
            this.navigationFrame.Controls.Add(this.npMain);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(2, 2);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(0);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npList,
            this.npMain,
            this.npEditor});
            this.navigationFrame.SelectedPage = this.npMain;
            this.navigationFrame.Size = new System.Drawing.Size(785, 508);
            this.navigationFrame.TabIndex = 4;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // npEditor
            // 
            this.npEditor.Controls.Add(this.passwordsDetailView);
            this.npEditor.Name = "npEditor";
            this.npEditor.Size = new System.Drawing.Size(785, 508);
            // 
            // passwordsDetailView
            // 
            this.passwordsDetailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordsDetailView.Location = new System.Drawing.Point(0, 0);
            this.passwordsDetailView.Name = "passwordsDetailView";
            this.passwordsDetailView.Size = new System.Drawing.Size(785, 508);
            this.passwordsDetailView.TabIndex = 1;
            // 
            // npList
            // 
            this.npList.Controls.Add(this.passwordsListView);
            this.npList.Name = "npList";
            this.npList.Size = new System.Drawing.Size(785, 508);
            // 
            // passwordsListView
            // 
            this.passwordsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordsListView.Location = new System.Drawing.Point(0, 0);
            this.passwordsListView.Name = "passwordsListView";
            this.passwordsListView.Size = new System.Drawing.Size(785, 508);
            this.passwordsListView.TabIndex = 0;
            // 
            // npMain
            // 
            this.npMain.Name = "npMain";
            this.npMain.Size = new System.Drawing.Size(785, 508);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 5);
            this.Root.Size = new System.Drawing.Size(799, 527);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(789, 512);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // PasswordsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PasswordsView";
            this.Size = new System.Drawing.Size(799, 566);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.npEditor.ResumeLayout(false);
            this.npList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelele;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarButtonItem bbiBack;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiReload;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage npList;
        private DevExpress.XtraBars.Navigation.NavigationPage npEditor;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.Navigation.NavigationPage npMain;
        private PasswordsDetailView passwordsDetailView;
        private PasswordsListView passwordsListView;
        private DevExpress.XtraBars.BarSubItem bsiMenuViews;
        public DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarCheckItem bciDefaultView;
        private DevExpress.XtraBars.BarCheckItem bciListView;
    }
}
