namespace LifeLog.Views.Sql
{
    partial class SqlBrowserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlBrowserView));
            barManager = new DevExpress.XtraBars.BarManager(components);
            bar = new DevExpress.XtraBars.Bar();
            bbiExecute = new DevExpress.XtraBars.BarButtonItem();
            bbiStop = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            bbiCopyCellValue = new DevExpress.XtraBars.BarButtonItem();
            recSqlPromt = new DevExpress.XtraRichEdit.RichEditControl();
            popupMenuSqlText = new DevExpress.XtraBars.PopupMenu(components);
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            lblSqlInfo = new DevExpress.XtraEditors.LabelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            gridControl = new DevExpress.XtraGrid.GridControl();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            popupMenuGridResults = new DevExpress.XtraBars.PopupMenu(components);
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenuSqlText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenuGridResults).BeginInit();
            SuspendLayout();
            // 
            // barManager
            // 
            barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar });
            barManager.DockControls.Add(barDockControlTop);
            barManager.DockControls.Add(barDockControlBottom);
            barManager.DockControls.Add(barDockControlLeft);
            barManager.DockControls.Add(barDockControlRight);
            barManager.DockWindowTabFont = new Font("Segoe UI", 9F);
            barManager.Form = this;
            barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bbiExecute, bbiCopyCellValue, bbiStop });
            barManager.MainMenu = bar;
            barManager.MaxItemId = 3;
            // 
            // bar
            // 
            bar.BarName = "Main menu";
            bar.DockCol = 0;
            bar.DockRow = 0;
            bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, bbiExecute, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, bbiStop, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            bar.OptionsBar.AllowQuickCustomization = false;
            bar.OptionsBar.DisableCustomization = true;
            bar.OptionsBar.DrawBorder = false;
            bar.OptionsBar.DrawDragBorder = false;
            bar.OptionsBar.MinHeight = 35;
            bar.OptionsBar.MultiLine = true;
            bar.OptionsBar.UseWholeRow = true;
            bar.Text = "Main menu";
            // 
            // bbiExecute
            // 
            bbiExecute.Caption = "Execute";
            bbiExecute.Id = 0;
            bbiExecute.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("bbiExecute.ImageOptions.SvgImage");
            bbiExecute.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F5);
            bbiExecute.Name = "bbiExecute";
            bbiExecute.ItemClick += bbiExecute_ItemClick;
            // 
            // bbiStop
            // 
            bbiStop.Caption = "Stop";
            bbiStop.Enabled = false;
            bbiStop.Id = 2;
            bbiStop.ImageOptions.SvgImage = Properties.Resources.actions_forbid;
            bbiStop.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F6);
            bbiStop.Name = "bbiStop";
            bbiStop.ItemClick += bbiStop_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager;
            barDockControlTop.Margin = new Padding(3, 2, 3, 2);
            barDockControlTop.Size = new Size(870, 44);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 607);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Margin = new Padding(3, 2, 3, 2);
            barDockControlBottom.Size = new Size(870, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 44);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Margin = new Padding(3, 2, 3, 2);
            barDockControlLeft.Size = new Size(0, 563);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(870, 44);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Margin = new Padding(3, 2, 3, 2);
            barDockControlRight.Size = new Size(0, 563);
            // 
            // bbiCopyCellValue
            // 
            bbiCopyCellValue.Caption = "Copy Cell Value";
            bbiCopyCellValue.Id = 1;
            bbiCopyCellValue.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("bbiCopyCellValue.ImageOptions.SvgImage");
            bbiCopyCellValue.Name = "bbiCopyCellValue";
            bbiCopyCellValue.ItemClick += bbiCopyCellValue_ItemClick;
            // 
            // recSqlPromt
            // 
            recSqlPromt.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            recSqlPromt.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            recSqlPromt.Dock = DockStyle.Fill;
            recSqlPromt.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            recSqlPromt.Location = new Point(2, 2);
            recSqlPromt.Margin = new Padding(0);
            recSqlPromt.MenuManager = barManager;
            recSqlPromt.Name = "recSqlPromt";
            recSqlPromt.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            recSqlPromt.Size = new Size(852, 106);
            recSqlPromt.TabIndex = 4;
            recSqlPromt.Views.SimpleView.AdjustColorsToSkins = true;
            // 
            // popupMenuSqlText
            // 
            popupMenuSqlText.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(bbiExecute) });
            popupMenuSqlText.Manager = barManager;
            popupMenuSqlText.Name = "popupMenuSqlText";
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(lblSqlInfo);
            layoutControl1.Controls.Add(panelControl2);
            layoutControl1.Controls.Add(panelControl1);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 44);
            layoutControl1.Margin = new Padding(3, 2, 3, 2);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(447, 284, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(870, 563);
            layoutControl1.TabIndex = 4;
            layoutControl1.Text = "layoutControl1";
            // 
            // lblSqlInfo
            // 
            lblSqlInfo.Appearance.FontSizeDelta = 2;
            lblSqlInfo.Appearance.Options.UseFont = true;
            lblSqlInfo.Location = new Point(7, 539);
            lblSqlInfo.Name = "lblSqlInfo";
            lblSqlInfo.Size = new Size(856, 17);
            lblSqlInfo.StyleController = layoutControl1;
            lblSqlInfo.TabIndex = 7;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(gridControl);
            panelControl2.Location = new Point(7, 204);
            panelControl2.Margin = new Padding(0);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(856, 330);
            panelControl2.TabIndex = 6;
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridControl.Location = new Point(2, 2);
            gridControl.MainView = gridView;
            gridControl.Margin = new Padding(0);
            gridControl.MenuManager = barManager;
            gridControl.Name = "gridControl";
            gridControl.Size = new Size(852, 326);
            gridControl.TabIndex = 5;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridView.DetailHeight = 284;
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsEditForm.PopupEditFormWidth = 686;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowIndicator = false;
            gridView.RowClick += gridView_RowClick;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(recSqlPromt);
            panelControl1.Location = new Point(7, 42);
            panelControl1.Margin = new Padding(0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(856, 110);
            panelControl1.TabIndex = 5;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1, splitterItem1, layoutControlItem3, layoutControlGroup2 });
            Root.Name = "Root";
            Root.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 8, 4);
            Root.Size = new Size(870, 563);
            Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
            layoutControlGroup1.ExpandButtonVisible = true;
            layoutControlGroup1.ExpandOnDoubleClick = true;
            layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            layoutControlGroup1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2 });
            layoutControlGroup1.Location = new Point(0, 0);
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlGroup1.Size = new Size(862, 146);
            layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlGroup1.Text = "Query Sql";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = panelControl1;
            layoutControlItem2.Location = new Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlItem2.Size = new Size(862, 114);
            layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 2, 2);
            layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            splitterItem1.Location = new Point(0, 146);
            splitterItem1.Name = "splitterItem1";
            splitterItem1.Size = new Size(862, 16);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = lblSqlInfo;
            layoutControlItem3.Location = new Point(0, 528);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(862, 23);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            layoutControlGroup2.Location = new Point(0, 162);
            layoutControlGroup2.Name = "layoutControlGroup2";
            layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlGroup2.Size = new Size(862, 366);
            layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlGroup2.Text = "Results";
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = panelControl2;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlItem1.Size = new Size(862, 334);
            layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 2, 2);
            layoutControlItem1.TextVisible = false;
            // 
            // dxErrorProvider
            // 
            dxErrorProvider.ContainerControl = this;
            // 
            // popupMenuGridResults
            // 
            popupMenuGridResults.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(bbiCopyCellValue) });
            popupMenuGridResults.Manager = barManager;
            popupMenuGridResults.Name = "popupMenuGridResults";
            // 
            // SqlBrowserView
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SqlBrowserView";
            Size = new Size(870, 607);
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenuSqlText).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenuGridResults).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarButtonItem bbiExecute;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraRichEdit.RichEditControl recSqlPromt;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraBars.BarButtonItem bbiCopyCellValue;
        private DevExpress.XtraBars.PopupMenu popupMenuGridResults;
        private DevExpress.XtraBars.PopupMenu popupMenuSqlText;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraBars.BarButtonItem bbiStop;
        private DevExpress.XtraEditors.LabelControl lblSqlInfo;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
