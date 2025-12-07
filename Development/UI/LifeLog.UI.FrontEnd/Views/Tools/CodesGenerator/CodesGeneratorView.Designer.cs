namespace LifeLog.UI.FrontEnd.Views.Tools.CodesGenerator
{
	partial class CodesGeneratorView
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
			DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar = new DevExpress.XtraBars.Bar();
			this.bbiGenCode = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.pcCode = new DevExpress.XtraEditors.PanelControl();
			this.barCodeControl = new DevExpress.XtraEditors.BarCodeControl();
			this.cbeSymbology = new DevExpress.XtraEditors.ComboBoxEdit();
			this.cbeCodeType = new DevExpress.XtraEditors.ComboBoxEdit();
			this.teTypeText = new DevExpress.XtraEditors.TextEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.lciCode = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcCode)).BeginInit();
			this.pcCode.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbeSymbology.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbeCodeType.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teTypeText.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciCode)).BeginInit();
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
            this.bbiGenCode});
			this.barManager.MainMenu = this.bar;
			this.barManager.MaxItemId = 3;
			// 
			// bar
			// 
			this.bar.BarName = "Main menu";
			this.bar.DockCol = 0;
			this.bar.DockRow = 0;
			this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiGenCode)});
			this.bar.OptionsBar.AllowQuickCustomization = false;
			this.bar.OptionsBar.DisableCustomization = true;
			this.bar.OptionsBar.DrawBorder = false;
			this.bar.OptionsBar.DrawDragBorder = false;
			this.bar.OptionsBar.MultiLine = true;
			this.bar.OptionsBar.UseWholeRow = true;
			this.bar.Text = "Main menu";
			// 
			// bbiGenCode
			// 
			this.bbiGenCode.Caption = "Gen. Code";
			this.bbiGenCode.Id = 0;
			this.bbiGenCode.ImageOptions.SvgImage = global::LifeLog.Base.Assets.Resources.actions_refresh;
			this.bbiGenCode.Name = "bbiGenCode";
			this.bbiGenCode.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.bbiGenCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGenCode_ItemClick);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.barDockControlTop.Size = new System.Drawing.Size(1006, 39);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 748);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.barDockControlBottom.Size = new System.Drawing.Size(1006, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 709);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1006, 39);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 709);
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.pcCode);
			this.layoutControl1.Controls.Add(this.cbeSymbology);
			this.layoutControl1.Controls.Add(this.cbeCodeType);
			this.layoutControl1.Controls.Add(this.teTypeText);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 39);
			this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(1006, 709);
			this.layoutControl1.TabIndex = 4;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// pcCode
			// 
			this.pcCode.Controls.Add(this.barCodeControl);
			this.pcCode.Location = new System.Drawing.Point(18, 203);
			this.pcCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pcCode.Name = "pcCode";
			this.pcCode.Size = new System.Drawing.Size(970, 20);
			this.pcCode.TabIndex = 9;
			// 
			// barCodeControl
			// 
			this.barCodeControl.AutoModule = true;
			this.barCodeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.barCodeControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.barCodeControl.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.barCodeControl.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.barCodeControl.Location = new System.Drawing.Point(2, 2);
			this.barCodeControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.barCodeControl.Name = "barCodeControl";
			this.barCodeControl.Padding = new System.Windows.Forms.Padding(12, 2, 12, 0);
			this.barCodeControl.Size = new System.Drawing.Size(966, 16);
			this.barCodeControl.Symbology = qrCodeGenerator1;
			this.barCodeControl.TabIndex = 6;
			// 
			// cbeSymbology
			// 
			this.cbeSymbology.EditValue = "QR CODE";
			this.cbeSymbology.Location = new System.Drawing.Point(99, 165);
			this.cbeSymbology.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbeSymbology.MenuManager = this.barManager;
			this.cbeSymbology.Name = "cbeSymbology";
			this.cbeSymbology.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbeSymbology.Properties.DropDownRows = 2;
			this.cbeSymbology.Properties.Items.AddRange(new object[] {
            "EAN 8",
            "EAN 13",
            "EAN 128",
            "QR CODE"});
			this.cbeSymbology.Size = new System.Drawing.Size(889, 30);
			this.cbeSymbology.StyleController = this.layoutControl1;
			this.cbeSymbology.TabIndex = 7;
			this.cbeSymbology.SelectedIndexChanged += new System.EventHandler(this.cbeSymbology_SelectedIndexChanged);
			// 
			// cbeCodeType
			// 
			this.cbeCodeType.EditValue = "TEXT";
			this.cbeCodeType.Location = new System.Drawing.Point(99, 52);
			this.cbeCodeType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbeCodeType.MenuManager = this.barManager;
			this.cbeCodeType.Name = "cbeCodeType";
			this.cbeCodeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbeCodeType.Properties.DropDownRows = 2;
			this.cbeCodeType.Properties.Items.AddRange(new object[] {
            "TEXT",
            "WIFI"});
			this.cbeCodeType.Size = new System.Drawing.Size(889, 30);
			this.cbeCodeType.StyleController = this.layoutControl1;
			this.cbeCodeType.TabIndex = 5;
			this.cbeCodeType.SelectedIndexChanged += new System.EventHandler(this.cbeCodeType_SelectedIndexChanged);
			// 
			// teTypeText
			// 
			this.teTypeText.Location = new System.Drawing.Point(99, 90);
			this.teTypeText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.teTypeText.MenuManager = this.barManager;
			this.teTypeText.Name = "teTypeText";
			this.teTypeText.Size = new System.Drawing.Size(889, 30);
			this.teTypeText.StyleController = this.layoutControl1;
			this.teTypeText.TabIndex = 4;
			this.teTypeText.EditValueChanged += new System.EventHandler(this.teTypeText_EditValueChanged);
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1006, 709);
			this.Root.TextVisible = false;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
			this.layoutControlGroup1.ExpandButtonVisible = true;
			this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.layoutControlGroup1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Size = new System.Drawing.Size(976, 108);
			this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Text = "Main";
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.cbeCodeType;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(976, 38);
			this.layoutControlItem2.Text = "Type";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(62, 16);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.teTypeText;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 38);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(976, 38);
			this.layoutControlItem1.Text = "Text";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 16);
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.lciCode});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 108);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup2.Size = new System.Drawing.Size(976, 569);
			this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
			this.layoutControlGroup2.Text = "Result";
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.cbeSymbology;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(976, 38);
			this.layoutControlItem4.Text = "Symbology";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(62, 16);
			// 
			// lciCode
			// 
			this.lciCode.Control = this.pcCode;
			this.lciCode.Location = new System.Drawing.Point(0, 38);
			this.lciCode.Name = "lciCode";
			this.lciCode.Size = new System.Drawing.Size(976, 494);
			this.lciCode.TextVisible = false;
			// 
			// CodesGeneratorView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "CodesGeneratorView";
			this.Size = new System.Drawing.Size(1006, 748);
			this.Load += new System.EventHandler(this.CodesGeneratorView_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pcCode)).EndInit();
			this.pcCode.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbeSymbology.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbeCodeType.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teTypeText.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciCode)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.Bar bar;
		private DevExpress.XtraBars.BarButtonItem bbiGenCode;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.ComboBoxEdit cbeCodeType;
		private DevExpress.XtraEditors.TextEdit teTypeText;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraEditors.ComboBoxEdit cbeSymbology;
		private DevExpress.XtraEditors.BarCodeControl barCodeControl;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraEditors.PanelControl pcCode;
		private DevExpress.XtraLayout.LayoutControlItem lciCode;
	}
}
