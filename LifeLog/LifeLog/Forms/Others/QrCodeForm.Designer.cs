namespace LifeLog.Forms.Others
{
    partial class QrCodeForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
			ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			barCodeControl = new DevExpress.XtraEditors.BarCodeControl();
			((System.ComponentModel.ISupportInitialize)ribbonControl).BeginInit();
			SuspendLayout();
			// 
			// ribbonControl
			// 
			ribbonControl.EmptyAreaImageOptions.ImagePadding = new Padding(35);
			ribbonControl.ExpandCollapseItem.Id = 0;
			ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl.ExpandCollapseItem });
			ribbonControl.Location = new Point(0, 0);
			ribbonControl.Margin = new Padding(0);
			ribbonControl.MaximumSize = new Size(0, 58);
			ribbonControl.MaxItemId = 1;
			ribbonControl.Name = "ribbonControl";
			ribbonControl.OptionsMenuMinWidth = 385;
			ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
			ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			ribbonControl.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
			ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
			ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			ribbonControl.ShowQatLocationSelector = false;
			ribbonControl.ShowToolbarCustomizeItem = false;
			ribbonControl.Size = new Size(229, 49);
			ribbonControl.Toolbar.ShowCustomizeItem = false;
			// 
			// barCodeControl
			// 
			barCodeControl.Appearance.FontSizeDelta = 5;
			barCodeControl.Appearance.Options.UseFont = true;
			barCodeControl.AutoModule = true;
			barCodeControl.Dock = DockStyle.Fill;
			barCodeControl.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
			barCodeControl.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
			barCodeControl.Location = new Point(0, 49);
			barCodeControl.Margin = new Padding(0);
			barCodeControl.Name = "barCodeControl";
			barCodeControl.ShowText = false;
			barCodeControl.ShowToolTips = false;
			barCodeControl.Size = new Size(229, 233);
			qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
			qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
			barCodeControl.Symbology = qrCodeGenerator1;
			barCodeControl.TabIndex = 5;
			barCodeControl.Text = "toasdsdasdasd";
			barCodeControl.VerticalAlignment = DevExpress.Utils.VertAlignment.Center;
			barCodeControl.VerticalTextAlignment = DevExpress.Utils.VertAlignment.Center;
			// 
			// QrCodeForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(229, 282);
			Controls.Add(barCodeControl);
			Controls.Add(ribbonControl);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			IconOptions.Image = Properties.Resources.icon;
			Margin = new Padding(4);
			MaximizeBox = false;
			MaximumSize = new Size(231, 283);
			MinimizeBox = false;
			MinimumSize = new Size(231, 283);
			Name = "QrCodeForm";
			Ribbon = ribbonControl;
			RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Qr Code";
			Load += ShowQrCode_Load;
			((System.ComponentModel.ISupportInitialize)ribbonControl).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl;
    }
}