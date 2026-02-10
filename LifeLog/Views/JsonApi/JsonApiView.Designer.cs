namespace LifeLog.Views.JsonApi
{
    partial class JsonApiView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonApiView));
			barManager = new DevExpress.XtraBars.BarManager(components);
			bar = new DevExpress.XtraBars.Bar();
			bbiOpenFile = new DevExpress.XtraBars.BarButtonItem();
			bbiStart = new DevExpress.XtraBars.BarButtonItem();
			bbiStop = new DevExpress.XtraBars.BarButtonItem();
			bsiTime = new DevExpress.XtraBars.BarStaticItem();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			btnBrowserApi = new DevExpress.XtraEditors.SimpleButton();
			seApiPort = new DevExpress.XtraEditors.SpinEdit();
			textEdit2 = new DevExpress.XtraEditors.TextEdit();
			textEdit1 = new DevExpress.XtraEditors.TextEdit();
			Root = new DevExpress.XtraLayout.LayoutControlGroup();
			emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			timer = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
			layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)seApiPort.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)Root).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
			SuspendLayout();
			// 
			// barManager
			// 
			barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar });
			barManager.DockControls.Add(barDockControlTop);
			barManager.DockControls.Add(barDockControlBottom);
			barManager.DockControls.Add(barDockControlLeft);
			barManager.DockControls.Add(barDockControlRight);
			barManager.Form = this;
			barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bbiOpenFile, bbiStart, bbiStop, bsiTime });
			barManager.MainMenu = bar;
			barManager.MaxItemId = 5;
			// 
			// bar
			// 
			bar.BarName = "Main menu";
			bar.DockCol = 0;
			bar.DockRow = 0;
			bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(bbiOpenFile), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, bbiStart, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, bbiStop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, bsiTime, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
			bar.OptionsBar.AllowQuickCustomization = false;
			bar.OptionsBar.DrawBorder = false;
			bar.OptionsBar.DrawDragBorder = false;
			bar.OptionsBar.MultiLine = true;
			bar.OptionsBar.RotateWhenVertical = false;
			bar.OptionsBar.UseWholeRow = true;
			bar.Text = "Main menu";
			// 
			// bbiOpenFile
			// 
			bbiOpenFile.Caption = "Open File";
			bbiOpenFile.Id = 0;
			bbiOpenFile.ImageOptions.SvgImage = Properties.Resources.open2;
			bbiOpenFile.Name = "bbiOpenFile";
			bbiOpenFile.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			bbiOpenFile.ItemClick += bbiOpenFile_ItemClick;
			// 
			// bbiStart
			// 
			bbiStart.Caption = "Start";
			bbiStart.Enabled = false;
			bbiStart.Id = 2;
			bbiStart.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("bbiStart.ImageOptions.SvgImage");
			bbiStart.Name = "bbiStart";
			bbiStart.ItemClick += bbiStart_ItemClick;
			// 
			// bbiStop
			// 
			bbiStop.Caption = "Stop";
			bbiStop.Enabled = false;
			bbiStop.Id = 3;
			bbiStop.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("bbiStop.ImageOptions.SvgImage");
			bbiStop.Name = "bbiStop";
			bbiStop.ItemClick += bbiStop_ItemClick;
			// 
			// bsiTime
			// 
			bsiTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			bsiTime.Caption = "00:00:00";
			bsiTime.Id = 4;
			bsiTime.ImageOptions.SvgImage = Properties.Resources.time;
			bsiTime.Name = "bsiTime";
			bsiTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = DockStyle.Top;
			barDockControlTop.Location = new Point(0, 0);
			barDockControlTop.Manager = barManager;
			barDockControlTop.Size = new Size(851, 39);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = DockStyle.Bottom;
			barDockControlBottom.Location = new Point(0, 626);
			barDockControlBottom.Manager = barManager;
			barDockControlBottom.Size = new Size(851, 0);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = DockStyle.Left;
			barDockControlLeft.Location = new Point(0, 39);
			barDockControlLeft.Manager = barManager;
			barDockControlLeft.Size = new Size(0, 587);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = DockStyle.Right;
			barDockControlRight.Location = new Point(851, 39);
			barDockControlRight.Manager = barManager;
			barDockControlRight.Size = new Size(0, 587);
			// 
			// layoutControl1
			// 
			layoutControl1.Controls.Add(btnBrowserApi);
			layoutControl1.Controls.Add(seApiPort);
			layoutControl1.Controls.Add(textEdit2);
			layoutControl1.Controls.Add(textEdit1);
			layoutControl1.Dock = DockStyle.Fill;
			layoutControl1.Location = new Point(0, 39);
			layoutControl1.Name = "layoutControl1";
			layoutControl1.Root = Root;
			layoutControl1.Size = new Size(851, 587);
			layoutControl1.TabIndex = 4;
			layoutControl1.Text = "layoutControl1";
			// 
			// btnBrowserApi
			// 
			btnBrowserApi.ImageOptions.SvgImage = Properties.Resources.business_world;
			btnBrowserApi.ImageOptions.SvgImageSize = new Size(20, 20);
			btnBrowserApi.Location = new Point(268, 48);
			btnBrowserApi.Name = "btnBrowserApi";
			btnBrowserApi.Size = new Size(28, 28);
			btnBrowserApi.StyleController = layoutControl1;
			btnBrowserApi.TabIndex = 2;
			btnBrowserApi.Click += btnBrowserApi_Click;
			// 
			// seApiPort
			// 
			seApiPort.EditValue = new decimal(new int[] { 5550, 0, 0, 0 });
			seApiPort.Location = new Point(119, 48);
			seApiPort.MenuManager = barManager;
			seApiPort.Name = "seApiPort";
			seApiPort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
			seApiPort.Properties.MaxValue = new decimal(new int[] { 65535, 0, 0, 0 });
			seApiPort.Properties.MinValue = new decimal(new int[] { 1024, 0, 0, 0 });
			seApiPort.Size = new Size(143, 28);
			seApiPort.StyleController = layoutControl1;
			seApiPort.TabIndex = 0;
			// 
			// textEdit2
			// 
			textEdit2.Location = new Point(122, 151);
			textEdit2.MenuManager = barManager;
			textEdit2.Name = "textEdit2";
			textEdit2.Size = new Size(710, 28);
			textEdit2.StyleController = layoutControl1;
			textEdit2.TabIndex = 4;
			// 
			// textEdit1
			// 
			textEdit1.Location = new Point(122, 117);
			textEdit1.MenuManager = barManager;
			textEdit1.Name = "textEdit1";
			textEdit1.Size = new Size(710, 28);
			textEdit1.StyleController = layoutControl1;
			textEdit1.TabIndex = 3;
			// 
			// Root
			// 
			Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			Root.GroupBordersVisible = false;
			Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, layoutControlGroup1, layoutControlGroup2 });
			Root.Name = "Root";
			Root.Size = new Size(851, 587);
			Root.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			emptySpaceItem1.Location = new Point(0, 172);
			emptySpaceItem1.Name = "emptySpaceItem1";
			emptySpaceItem1.Size = new Size(825, 389);
			// 
			// layoutControlGroup1
			// 
			layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, layoutControlItem1 });
			layoutControlGroup1.Location = new Point(0, 66);
			layoutControlGroup1.Name = "layoutControlGroup1";
			layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			layoutControlGroup1.Size = new Size(825, 106);
			layoutControlGroup1.Text = "File";
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = textEdit2;
			layoutControlItem2.Location = new Point(0, 34);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new Size(819, 34);
			layoutControlItem2.TextSize = new Size(87, 13);
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = textEdit1;
			layoutControlItem1.Location = new Point(0, 0);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new Size(819, 34);
			layoutControlItem1.TextSize = new Size(87, 13);
			// 
			// layoutControlGroup2
			// 
			layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3, layoutControlItem4, emptySpaceItem2 });
			layoutControlGroup2.Location = new Point(0, 0);
			layoutControlGroup2.Name = "layoutControlGroup2";
			layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			layoutControlGroup2.Size = new Size(825, 66);
			layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			layoutControlGroup2.Text = "Api Settings";
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = seApiPort;
			layoutControlItem3.Location = new Point(0, 0);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new Size(252, 34);
			layoutControlItem3.Text = "ApiPort";
			layoutControlItem3.TextSize = new Size(87, 13);
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = btnBrowserApi;
			layoutControlItem4.Location = new Point(252, 0);
			layoutControlItem4.MaxSize = new Size(34, 34);
			layoutControlItem4.MinSize = new Size(34, 34);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new Size(34, 34);
			layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			layoutControlItem4.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			emptySpaceItem2.Location = new Point(286, 0);
			emptySpaceItem2.Name = "emptySpaceItem2";
			emptySpaceItem2.Size = new Size(539, 34);
			// 
			// timer
			// 
			timer.Interval = 10;
			timer.Tick += timer_Tick;
			// 
			// JsonApiView
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(layoutControl1);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Name = "JsonApiView";
			Size = new Size(851, 626);
			((System.ComponentModel.ISupportInitialize)barManager).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
			layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)seApiPort.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)Root).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarButtonItem bbiOpenFile;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraBars.BarButtonItem bbiStart;
		private DevExpress.XtraBars.BarButtonItem bbiStop;
		private DevExpress.XtraBars.BarStaticItem bsiTime;
		private DevExpress.XtraEditors.SpinEdit seApiPort;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraEditors.SimpleButton btnBrowserApi;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private System.Windows.Forms.Timer timer;
	}
}
