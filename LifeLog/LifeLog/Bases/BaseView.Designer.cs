namespace LifeLog.Bases
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
            components = new System.ComponentModel.Container();
            barManagerBase = new DevExpress.XtraBars.BarManager(components);
            barBase = new DevExpress.XtraBars.Bar();
            bbiBaseBack = new DevExpress.XtraBars.BarButtonItem();
            bbiBaseNew = new DevExpress.XtraBars.BarButtonItem();
            bbiBaseEdit = new DevExpress.XtraBars.BarButtonItem();
            bbiBaseDelele = new DevExpress.XtraBars.BarButtonItem();
            bbiBaseSave = new DevExpress.XtraBars.BarButtonItem();
            bbiBaseReload = new DevExpress.XtraBars.BarButtonItem();
            bbiBaseSearch = new DevExpress.XtraBars.BarEditItem();
            riscBase = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            barBaseDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barBaseDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barBaseDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barBaseDockControlRight = new DevExpress.XtraBars.BarDockControl();
            panelControlBase = new DevExpress.XtraEditors.PanelControl();
            navigationFrameBase = new DevExpress.XtraBars.Navigation.NavigationFrame();
            npListBase = new DevExpress.XtraBars.Navigation.NavigationPage();
            npEditBase = new DevExpress.XtraBars.Navigation.NavigationPage();
            layoutControlBase = new DevExpress.XtraLayout.LayoutControl();
            RootBase = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItemBase = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)barManagerBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)riscBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControlBase).BeginInit();
            panelControlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)navigationFrameBase).BeginInit();
            navigationFrameBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControlBase).BeginInit();
            layoutControlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RootBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemBase).BeginInit();
            SuspendLayout();
            // 
            // barManagerBase
            // 
            barManagerBase.Bars.AddRange(new DevExpress.XtraBars.Bar[] { barBase });
            barManagerBase.DockControls.Add(barBaseDockControlTop);
            barManagerBase.DockControls.Add(barBaseDockControlBottom);
            barManagerBase.DockControls.Add(barBaseDockControlLeft);
            barManagerBase.DockControls.Add(barBaseDockControlRight);
            barManagerBase.Form = this;
            barManagerBase.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bbiBaseNew, bbiBaseSave, bbiBaseReload, bbiBaseBack, bbiBaseEdit, bbiBaseDelele, bbiBaseSearch });
            barManagerBase.MainMenu = barBase;
            barManagerBase.MaxItemId = 8;
            barManagerBase.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { riscBase });
            // 
            // barBase
            // 
            barBase.BarName = "Main menu";
            barBase.DockCol = 0;
            barBase.DockRow = 0;
            barBase.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            barBase.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, bbiBaseBack, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(bbiBaseNew), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, bbiBaseEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, bbiBaseDelele, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, bbiBaseSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, bbiBaseReload, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width, bbiBaseSearch, "", true, true, true, 250, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            barBase.OptionsBar.AllowQuickCustomization = false;
            barBase.OptionsBar.DrawBorder = false;
            barBase.OptionsBar.DrawDragBorder = false;
            barBase.OptionsBar.MinHeight = 35;
            barBase.OptionsBar.MultiLine = true;
            barBase.OptionsBar.UseWholeRow = true;
            barBase.Text = "Main menu";
            // 
            // bbiBaseBack
            // 
            bbiBaseBack.Caption = "Back";
            bbiBaseBack.Id = 3;
            bbiBaseBack.ImageOptions.SvgImage = Properties.Resources.undo;
            bbiBaseBack.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.B);
            bbiBaseBack.Name = "bbiBaseBack";
            bbiBaseBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            bbiBaseBack.ItemClick += bbiBack_ItemClick;
            // 
            // bbiBaseNew
            // 
            bbiBaseNew.Caption = "New";
            bbiBaseNew.Id = 0;
            bbiBaseNew.ImageOptions.SvgImage = Properties.Resources.actions_add;
            bbiBaseNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.N);
            bbiBaseNew.Name = "bbiBaseNew";
            bbiBaseNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            bbiBaseNew.ItemClick += bbiNew_ItemClick;
            // 
            // bbiBaseEdit
            // 
            bbiBaseEdit.Caption = "Edit";
            bbiBaseEdit.Id = 4;
            bbiBaseEdit.ImageOptions.SvgImage = Properties.Resources.actions_edit;
            bbiBaseEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.N);
            bbiBaseEdit.Name = "bbiBaseEdit";
            bbiBaseEdit.ItemClick += bbiEdit_ItemClick;
            // 
            // bbiBaseDelele
            // 
            bbiBaseDelele.Caption = "Delete";
            bbiBaseDelele.Id = 5;
            bbiBaseDelele.ImageOptions.SvgImage = Properties.Resources.del;
            bbiBaseDelele.Name = "bbiBaseDelele";
            bbiBaseDelele.ItemClick += bbiDelele_ItemClick;
            // 
            // bbiBaseSave
            // 
            bbiBaseSave.Caption = "Save";
            bbiBaseSave.Id = 1;
            bbiBaseSave.ImageOptions.SvgImage = Properties.Resources.saveall;
            bbiBaseSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.S);
            bbiBaseSave.Name = "bbiBaseSave";
            bbiBaseSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            bbiBaseSave.ItemClick += bbiSave_ItemClick;
            // 
            // bbiBaseReload
            // 
            bbiBaseReload.Caption = "Reload";
            bbiBaseReload.GroupIndex = 1;
            bbiBaseReload.Id = 2;
            bbiBaseReload.ImageOptions.SvgImage = Properties.Resources.actions_refresh;
            bbiBaseReload.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.R);
            bbiBaseReload.Name = "bbiBaseReload";
            bbiBaseReload.ItemClick += bbiReload_ItemClick;
            // 
            // bbiBaseSearch
            // 
            bbiBaseSearch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            bbiBaseSearch.Caption = "Search";
            bbiBaseSearch.Edit = riscBase;
            bbiBaseSearch.EditWidth = 250;
            bbiBaseSearch.Id = 7;
            bbiBaseSearch.MaxWidth = 250;
            bbiBaseSearch.MinWidth = 250;
            bbiBaseSearch.Name = "bbiBaseSearch";
            // 
            // riscBase
            // 
            riscBase.AutoHeight = false;
            riscBase.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Repository.ClearButton(), new DevExpress.XtraEditors.Repository.SearchButton() });
            riscBase.Name = "riscBase";
            // 
            // barBaseDockControlTop
            // 
            barBaseDockControlTop.CausesValidation = false;
            barBaseDockControlTop.Dock = DockStyle.Top;
            barBaseDockControlTop.Location = new Point(0, 0);
            barBaseDockControlTop.Manager = barManagerBase;
            barBaseDockControlTop.Margin = new Padding(3, 2, 3, 2);
            barBaseDockControlTop.Size = new Size(943, 44);
            // 
            // barBaseDockControlBottom
            // 
            barBaseDockControlBottom.CausesValidation = false;
            barBaseDockControlBottom.Dock = DockStyle.Bottom;
            barBaseDockControlBottom.Location = new Point(0, 479);
            barBaseDockControlBottom.Manager = barManagerBase;
            barBaseDockControlBottom.Margin = new Padding(3, 2, 3, 2);
            barBaseDockControlBottom.Size = new Size(943, 0);
            // 
            // barBaseDockControlLeft
            // 
            barBaseDockControlLeft.CausesValidation = false;
            barBaseDockControlLeft.Dock = DockStyle.Left;
            barBaseDockControlLeft.Location = new Point(0, 44);
            barBaseDockControlLeft.Manager = barManagerBase;
            barBaseDockControlLeft.Margin = new Padding(3, 2, 3, 2);
            barBaseDockControlLeft.Size = new Size(0, 435);
            // 
            // barBaseDockControlRight
            // 
            barBaseDockControlRight.CausesValidation = false;
            barBaseDockControlRight.Dock = DockStyle.Right;
            barBaseDockControlRight.Location = new Point(943, 44);
            barBaseDockControlRight.Manager = barManagerBase;
            barBaseDockControlRight.Margin = new Padding(3, 2, 3, 2);
            barBaseDockControlRight.Size = new Size(0, 435);
            // 
            // panelControlBase
            // 
            panelControlBase.Controls.Add(navigationFrameBase);
            panelControlBase.Location = new Point(7, 11);
            panelControlBase.Name = "panelControlBase";
            panelControlBase.Size = new Size(929, 417);
            panelControlBase.TabIndex = 4;
            // 
            // navigationFrameBase
            // 
            navigationFrameBase.Controls.Add(npListBase);
            navigationFrameBase.Controls.Add(npEditBase);
            navigationFrameBase.Dock = DockStyle.Fill;
            navigationFrameBase.Location = new Point(2, 2);
            navigationFrameBase.Name = "navigationFrameBase";
            navigationFrameBase.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { npListBase, npEditBase });
            navigationFrameBase.SelectedPage = npListBase;
            navigationFrameBase.Size = new Size(925, 413);
            navigationFrameBase.TabIndex = 0;
            navigationFrameBase.Text = "navigationFrame1";
            // 
            // npListBase
            // 
            npListBase.Caption = "npListBase";
            npListBase.Name = "npListBase";
            npListBase.Size = new Size(925, 413);
            // 
            // npEditBase
            // 
            npEditBase.Caption = "npEditBase";
            npEditBase.Name = "npEditBase";
            npEditBase.Size = new Size(925, 413);
            // 
            // layoutControlBase
            // 
            layoutControlBase.Controls.Add(panelControlBase);
            layoutControlBase.Dock = DockStyle.Fill;
            layoutControlBase.Location = new Point(0, 44);
            layoutControlBase.Name = "layoutControlBase";
            layoutControlBase.Root = RootBase;
            layoutControlBase.Size = new Size(943, 435);
            layoutControlBase.TabIndex = 9;
            layoutControlBase.Text = "layoutControl1";
            // 
            // RootBase
            // 
            RootBase.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            RootBase.GroupBordersVisible = false;
            RootBase.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItemBase });
            RootBase.Name = "RootBase";
            RootBase.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 8, 4);
            RootBase.Size = new Size(943, 435);
            RootBase.TextVisible = false;
            // 
            // layoutControlItemBase
            // 
            layoutControlItemBase.Control = panelControlBase;
            layoutControlItemBase.Location = new Point(0, 0);
            layoutControlItemBase.Name = "layoutControlItemBase";
            layoutControlItemBase.Size = new Size(935, 423);
            layoutControlItemBase.TextVisible = false;
            // 
            // BaseView
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(layoutControlBase);
            Controls.Add(barBaseDockControlLeft);
            Controls.Add(barBaseDockControlRight);
            Controls.Add(barBaseDockControlBottom);
            Controls.Add(barBaseDockControlTop);
            Name = "BaseView";
            Size = new Size(943, 479);
            ((System.ComponentModel.ISupportInitialize)barManagerBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)riscBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControlBase).EndInit();
            panelControlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)navigationFrameBase).EndInit();
            navigationFrameBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControlBase).EndInit();
            layoutControlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RootBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemBase).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarDockControl barBaseDockControlTop;
		private DevExpress.XtraBars.BarDockControl barBaseDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barBaseDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barBaseDockControlRight;
		protected DevExpress.XtraBars.Navigation.NavigationFrame navigationFrameBase;
		protected DevExpress.XtraBars.Navigation.NavigationPage npListBase;
		protected DevExpress.XtraBars.BarButtonItem bbiBaseBack;
		protected DevExpress.XtraBars.BarButtonItem bbiBaseNew;
		protected DevExpress.XtraBars.BarButtonItem bbiBaseEdit;
		protected DevExpress.XtraBars.BarButtonItem bbiBaseDelele;
		protected DevExpress.XtraBars.BarButtonItem bbiBaseSave;
		protected DevExpress.XtraBars.BarButtonItem bbiBaseReload;
		protected DevExpress.XtraBars.BarEditItem bbiBaseSearch;
		protected DevExpress.XtraBars.BarManager barManagerBase;
		protected DevExpress.XtraEditors.PanelControl panelControlBase;
		protected DevExpress.XtraLayout.LayoutControlGroup RootBase;
		protected DevExpress.XtraBars.Navigation.NavigationPage npEditBase;
		protected DevExpress.XtraLayout.LayoutControl layoutControlBase;
		protected DevExpress.XtraLayout.LayoutControlItem layoutControlItemBase;
		protected DevExpress.XtraBars.Bar barBase;
		protected DevExpress.XtraEditors.Repository.RepositoryItemSearchControl riscBase;
    }
}
