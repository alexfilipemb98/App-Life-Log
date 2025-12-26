namespace LifeLog.Views.PdfMerger
{
    partial class PdfMergerView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfMergerView));
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar = new DevExpress.XtraBars.Bar();
			this.bbiProcess = new DevExpress.XtraBars.BarButtonItem();
			this.bbiOpenOutput = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.tsSearchSubFolders = new DevExpress.XtraEditors.ToggleSwitch();
			this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
			this.beOutputFolder = new DevExpress.XtraEditors.ButtonEdit();
			this.bePdfsFolder = new DevExpress.XtraEditors.ButtonEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tsSearchSubFolders.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.beOutputFolder.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bePdfsFolder.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
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
            this.bbiProcess,
            this.bbiOpenOutput});
			this.barManager.MainMenu = this.bar;
			this.barManager.MaxItemId = 4;
			// 
			// bar
			// 
			this.bar.BarName = "Main menu";
			this.bar.DockCol = 0;
			this.bar.DockRow = 0;
			this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiProcess),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiOpenOutput, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar.OptionsBar.AllowQuickCustomization = false;
			this.bar.OptionsBar.DisableCustomization = true;
			this.bar.OptionsBar.DrawBorder = false;
			this.bar.OptionsBar.DrawDragBorder = false;
			this.bar.OptionsBar.MultiLine = true;
			this.bar.OptionsBar.UseWholeRow = true;
			this.bar.Text = "Main menu";
			// 
			// bbiProcess
			// 
			this.bbiProcess.Caption = "Gen. PDF";
			this.bbiProcess.Id = 0;
			this.bbiProcess.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiProcess.ImageOptions.SvgImage")));
			this.bbiProcess.Name = "bbiProcess";
			this.bbiProcess.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.bbiProcess.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiProcess_ItemClick);
			// 
			// bbiOpenOutput
			// 
			this.bbiOpenOutput.Caption = "Open Output";
			this.bbiOpenOutput.Id = 3;
			this.bbiOpenOutput.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiOpenOutput.ImageOptions.SvgImage")));
			this.bbiOpenOutput.Name = "bbiOpenOutput";
			this.bbiOpenOutput.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiOpenOutput_ItemClick);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlTop.Size = new System.Drawing.Size(514, 24);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 363);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlBottom.Size = new System.Drawing.Size(514, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 339);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(514, 24);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 339);
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.tsSearchSubFolders);
			this.layoutControl1.Controls.Add(this.richEditControl);
			this.layoutControl1.Controls.Add(this.beOutputFolder);
			this.layoutControl1.Controls.Add(this.bePdfsFolder);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 24);
			this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(514, 339);
			this.layoutControl1.TabIndex = 4;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// tsSearchSubFolders
			// 
			this.tsSearchSubFolders.AutoSizeInLayoutControl = true;
			this.tsSearchSubFolders.Location = new System.Drawing.Point(459, 11);
			this.tsSearchSubFolders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tsSearchSubFolders.MenuManager = this.barManager;
			this.tsSearchSubFolders.Name = "tsSearchSubFolders";
			this.tsSearchSubFolders.Properties.AutoHeight = false;
			this.tsSearchSubFolders.Properties.OffText = "Off";
			this.tsSearchSubFolders.Properties.OnText = "On";
			this.tsSearchSubFolders.Properties.ShowText = false;
			this.tsSearchSubFolders.Size = new System.Drawing.Size(50, 18);
			this.tsSearchSubFolders.StyleController = this.layoutControl1;
			this.tsSearchSubFolders.TabIndex = 7;
			// 
			// richEditControl
			// 
			this.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
			this.richEditControl.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
			this.richEditControl.Location = new System.Drawing.Point(101, 68);
			this.richEditControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.richEditControl.MenuManager = this.barManager;
			this.richEditControl.Name = "richEditControl";
			this.richEditControl.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
			this.richEditControl.ReadOnly = true;
			this.richEditControl.Size = new System.Drawing.Size(408, 267);
			this.richEditControl.TabIndex = 6;
			// 
			// beOutputFolder
			// 
			this.beOutputFolder.Location = new System.Drawing.Point(101, 38);
			this.beOutputFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.beOutputFolder.MenuManager = this.barManager;
			this.beOutputFolder.Name = "beOutputFolder";
			editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
			editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(20, 20);
			this.beOutputFolder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.beOutputFolder.Size = new System.Drawing.Size(408, 28);
			this.beOutputFolder.StyleController = this.layoutControl1;
			this.beOutputFolder.TabIndex = 5;
			this.beOutputFolder.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beOutputFolder_ButtonClick);
			// 
			// bePdfsFolder
			// 
			this.bePdfsFolder.Location = new System.Drawing.Point(101, 4);
			this.bePdfsFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bePdfsFolder.MenuManager = this.barManager;
			this.bePdfsFolder.Name = "bePdfsFolder";
			editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
			editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(24, 24);
			this.bePdfsFolder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.bePdfsFolder.Size = new System.Drawing.Size(260, 32);
			this.bePdfsFolder.StyleController = this.layoutControl1;
			this.bePdfsFolder.TabIndex = 4;
			this.bePdfsFolder.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bePdfsFolder_ButtonClick);
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
			this.Root.Name = "Root";
			this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 3, 3);
			this.Root.Size = new System.Drawing.Size(514, 339);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.bePdfsFolder;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(358, 34);
			this.layoutControlItem1.Text = "Pdfs Folder";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.beOutputFolder;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(506, 30);
			this.layoutControlItem2.Text = "Output Folder";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
			this.layoutControlItem3.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.layoutControlItem3.Control = this.richEditControl;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 64);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(506, 269);
			this.layoutControlItem3.Text = "Status";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(87, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
			this.layoutControlItem4.Control = this.tsSearchSubFolders;
			this.layoutControlItem4.Location = new System.Drawing.Point(358, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(148, 34);
			this.layoutControlItem4.Text = "Search Subfolders";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(87, 13);
			// 
			// dxErrorProvider
			// 
			this.dxErrorProvider.ContainerControl = this;
			// 
			// PdfMergerView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "PdfMergerView";
			this.Size = new System.Drawing.Size(514, 363);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tsSearchSubFolders.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.beOutputFolder.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bePdfsFolder.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarButtonItem bbiProcess;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl;
        private DevExpress.XtraEditors.ButtonEdit beOutputFolder;
        private DevExpress.XtraEditors.ButtonEdit bePdfsFolder;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.BarButtonItem bbiOpenOutput;
        private DevExpress.XtraEditors.ToggleSwitch tsSearchSubFolders;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}
