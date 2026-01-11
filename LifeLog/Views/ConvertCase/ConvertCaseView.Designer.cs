namespace LifeLog.Views.ConvertCase
{
    partial class ConvertCaseView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertCaseView));
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar = new DevExpress.XtraBars.Bar();
			this.bbiCopyText = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.cbUpperCase = new DevExpress.XtraEditors.CheckButton();
			this.cbInvertCase = new DevExpress.XtraEditors.CheckButton();
			this.cbAlternativeCase = new DevExpress.XtraEditors.CheckButton();
			this.cbTitleCase = new DevExpress.XtraEditors.CheckButton();
			this.cbSentenceCase = new DevExpress.XtraEditors.CheckButton();
			this.cbLowerCase = new DevExpress.XtraEditors.CheckButton();
			this.meTextSource = new DevExpress.XtraEditors.MemoEdit();
			this.meTextResult = new DevExpress.XtraEditors.MemoEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.meTextSource.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.meTextResult.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
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
            this.bbiCopyText});
			this.barManager.MainMenu = this.bar;
			this.barManager.MaxItemId = 12;
			// 
			// bar
			// 
			this.bar.BarName = "Main menu";
			this.bar.DockCol = 0;
			this.bar.DockRow = 0;
			this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCopyText, true)});
			this.bar.OptionsBar.AllowQuickCustomization = false;
			this.bar.OptionsBar.DrawDragBorder = false;
			this.bar.OptionsBar.MultiLine = true;
			this.bar.OptionsBar.UseWholeRow = true;
			this.bar.Text = "\\";
			// 
			// bbiCopyText
			// 
			this.bbiCopyText.Caption = "Copy to Clipboard";
			this.bbiCopyText.Id = 0;
			this.bbiCopyText.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiCopyText.ImageOptions.SvgImage")));
			this.bbiCopyText.Name = "bbiCopyText";
			this.bbiCopyText.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.bbiCopyText.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCopyText_ItemClick);
			// 
			// barBaseDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Size = new System.Drawing.Size(1201, 24);
			// 
			// barBaseDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 713);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(1201, 0);
			// 
			// barBaseDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 689);
			// 
			// barBaseDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1201, 24);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 689);
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.cbUpperCase);
			this.layoutControl1.Controls.Add(this.cbInvertCase);
			this.layoutControl1.Controls.Add(this.cbAlternativeCase);
			this.layoutControl1.Controls.Add(this.cbTitleCase);
			this.layoutControl1.Controls.Add(this.cbSentenceCase);
			this.layoutControl1.Controls.Add(this.cbLowerCase);
			this.layoutControl1.Controls.Add(this.meTextSource);
			this.layoutControl1.Controls.Add(this.meTextResult);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 24);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(1201, 689);
			this.layoutControl1.TabIndex = 4;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// cbUpperCase
			// 
			this.cbUpperCase.Location = new System.Drawing.Point(454, 236);
			this.cbUpperCase.Name = "cbUpperCase";
			this.cbUpperCase.Size = new System.Drawing.Size(146, 22);
			this.cbUpperCase.StyleController = this.layoutControl1;
			this.cbUpperCase.TabIndex = 12;
			this.cbUpperCase.Text = "UPPER CASE";
			this.cbUpperCase.CheckedChanged += new System.EventHandler(this.cbText_CheckedChanged);
			// 
			// cbInvertCase
			// 
			this.cbInvertCase.Location = new System.Drawing.Point(902, 236);
			this.cbInvertCase.Name = "cbInvertCase";
			this.cbInvertCase.Size = new System.Drawing.Size(143, 22);
			this.cbInvertCase.StyleController = this.layoutControl1;
			this.cbInvertCase.TabIndex = 11;
			this.cbInvertCase.Text = "InVeRsE CaSe";
			this.cbInvertCase.CheckedChanged += new System.EventHandler(this.cbText_CheckedChanged);
			// 
			// cbAlternativeCase
			// 
			this.cbAlternativeCase.Location = new System.Drawing.Point(752, 236);
			this.cbAlternativeCase.Name = "cbAlternativeCase";
			this.cbAlternativeCase.Size = new System.Drawing.Size(146, 22);
			this.cbAlternativeCase.StyleController = this.layoutControl1;
			this.cbAlternativeCase.TabIndex = 10;
			this.cbAlternativeCase.Text = "aLtErNaTiNg cAsE";
			this.cbAlternativeCase.CheckedChanged += new System.EventHandler(this.cbText_CheckedChanged);
			// 
			// cbTitleCase
			// 
			this.cbTitleCase.Location = new System.Drawing.Point(604, 236);
			this.cbTitleCase.Name = "cbTitleCase";
			this.cbTitleCase.Size = new System.Drawing.Size(144, 22);
			this.cbTitleCase.StyleController = this.layoutControl1;
			this.cbTitleCase.TabIndex = 9;
			this.cbTitleCase.Text = "Title Case";
			this.cbTitleCase.CheckedChanged += new System.EventHandler(this.cbText_CheckedChanged);
			// 
			// cbSentenceCase
			// 
			this.cbSentenceCase.Location = new System.Drawing.Point(155, 236);
			this.cbSentenceCase.Name = "cbSentenceCase";
			this.cbSentenceCase.Size = new System.Drawing.Size(146, 22);
			this.cbSentenceCase.StyleController = this.layoutControl1;
			this.cbSentenceCase.TabIndex = 8;
			this.cbSentenceCase.Text = "Sentence case";
			this.cbSentenceCase.CheckedChanged += new System.EventHandler(this.cbText_CheckedChanged);
			// 
			// cbLowerCase
			// 
			this.cbLowerCase.Location = new System.Drawing.Point(305, 236);
			this.cbLowerCase.Name = "cbLowerCase";
			this.cbLowerCase.Size = new System.Drawing.Size(145, 22);
			this.cbLowerCase.StyleController = this.layoutControl1;
			this.cbLowerCase.TabIndex = 7;
			this.cbLowerCase.Text = "lower case";
			this.cbLowerCase.CheckedChanged += new System.EventHandler(this.cbText_CheckedChanged);
			// 
			// meTextSource
			// 
			this.meTextSource.Location = new System.Drawing.Point(6, 32);
			this.meTextSource.Margin = new System.Windows.Forms.Padding(0);
			this.meTextSource.MenuManager = this.barManager;
			this.meTextSource.Name = "meTextSource";
			this.meTextSource.Properties.AdvancedModeOptions.Label = "Enter your text and choose the case you want to convert it to.";
			this.meTextSource.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.meTextSource.Size = new System.Drawing.Size(1189, 200);
			this.meTextSource.StyleController = this.layoutControl1;
			this.meTextSource.TabIndex = 5;
			this.meTextSource.EditValueChanged += new System.EventHandler(this.meTextSource_EditValueChanged);
			// 
			// meTextResult
			// 
			this.meTextResult.Location = new System.Drawing.Point(7, 287);
			this.meTextResult.Margin = new System.Windows.Forms.Padding(0);
			this.meTextResult.MenuManager = this.barManager;
			this.meTextResult.Name = "meTextResult";
			this.meTextResult.Properties.AdvancedModeOptions.Label = "Text result";
			this.meTextResult.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.meTextResult.Properties.ReadOnly = true;
			this.meTextResult.Properties.UseReadOnlyAppearance = false;
			this.meTextResult.Size = new System.Drawing.Size(1187, 395);
			this.meTextResult.StyleController = this.layoutControl1;
			this.meTextResult.TabIndex = 4;
			// 
			// BaseRoot
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
			this.Root.Name = "Root";
			this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 8, 4);
			this.Root.Size = new System.Drawing.Size(1201, 689);
			this.Root.TextVisible = false;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
			this.layoutControlGroup1.ExpandButtonVisible = true;
			this.layoutControlGroup1.ExpandOnDoubleClick = true;
			this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.layoutControlGroup1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Size = new System.Drawing.Size(1193, 226);
			this.layoutControlGroup1.Text = "Texto Normal";
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.meTextSource;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem2.Size = new System.Drawing.Size(1189, 200);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
			this.layoutControlGroup2.ExpandButtonVisible = true;
			this.layoutControlGroup2.ExpandOnDoubleClick = true;
			this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.layoutControlGroup2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 252);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup2.Size = new System.Drawing.Size(1193, 425);
			this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 5, 3);
			this.layoutControlGroup2.Text = "Texto Convertido";
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.meTextResult;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem1.Size = new System.Drawing.Size(1187, 395);
			this.layoutControlItem1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(1043, 226);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(150, 26);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.cbLowerCase;
			this.layoutControlItem4.Location = new System.Drawing.Point(299, 226);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(149, 26);
			this.layoutControlItem4.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 226);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(149, 26);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.cbSentenceCase;
			this.layoutControlItem3.Location = new System.Drawing.Point(149, 226);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(150, 26);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.cbTitleCase;
			this.layoutControlItem5.Location = new System.Drawing.Point(598, 226);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(148, 26);
			this.layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.cbAlternativeCase;
			this.layoutControlItem6.Location = new System.Drawing.Point(746, 226);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(150, 26);
			this.layoutControlItem6.TextVisible = false;
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.cbInvertCase;
			this.layoutControlItem7.Location = new System.Drawing.Point(896, 226);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(147, 26);
			this.layoutControlItem7.TextVisible = false;
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.cbUpperCase;
			this.layoutControlItem8.Location = new System.Drawing.Point(448, 226);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(150, 26);
			this.layoutControlItem8.TextVisible = false;
			// 
			// ConvertCaseView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "ConvertCaseView";
			this.Size = new System.Drawing.Size(1201, 713);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.meTextSource.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.meTextResult.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.MemoEdit meTextResult;
        private DevExpress.XtraBars.BarButtonItem bbiCopyText;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.MemoEdit meTextSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.CheckButton cbLowerCase;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraEditors.CheckButton cbSentenceCase;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraEditors.CheckButton cbTitleCase;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraEditors.CheckButton cbAlternativeCase;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraEditors.CheckButton cbInvertCase;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraEditors.CheckButton cbUpperCase;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
	}
}
