namespace Life_Log.Forms.Dialogs
{
    partial class ShowQrCodeForm
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barCodeControl = new DevExpress.XtraEditors.BarCodeControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(0);
            this.ribbonControl.MaximumSize = new System.Drawing.Size(0, 62);
            this.ribbonControl.MaxItemId = 1;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsMenuMinWidth = 385;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(229, 49);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // barCodeControl
            // 
            this.barCodeControl.Appearance.FontSizeDelta = 5;
            this.barCodeControl.Appearance.Options.UseFont = true;
            this.barCodeControl.AutoModule = true;
            this.barCodeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barCodeControl.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl.Location = new System.Drawing.Point(0, 49);
            this.barCodeControl.Margin = new System.Windows.Forms.Padding(0);
            this.barCodeControl.Name = "barCodeControl";
            this.barCodeControl.ShowText = false;
            this.barCodeControl.ShowToolTips = false;
            this.barCodeControl.Size = new System.Drawing.Size(229, 249);
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.barCodeControl.Symbology = qrCodeGenerator1;
            this.barCodeControl.TabIndex = 5;
            this.barCodeControl.Text = "toasdsdasdasd";
            this.barCodeControl.VerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.barCodeControl.VerticalTextAlignment = DevExpress.Utils.VertAlignment.Center;
            // 
            // ShowQrCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(229, 298);
            this.Controls.Add(this.barCodeControl);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = global::Life_Log.Properties.Resources.icon_svg;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(200, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 250);
            this.Name = "ShowQrCodeForm";
            this.Ribbon = this.ribbonControl;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Qr Code";
            this.Load += new System.EventHandler(this.ShowQrCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl;
    }
}