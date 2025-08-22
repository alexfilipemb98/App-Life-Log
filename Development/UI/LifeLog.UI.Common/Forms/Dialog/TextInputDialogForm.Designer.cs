namespace LifeLog.UI.Common.Forms.Dialog
{
    partial class TextInputDialogForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextInputDialogForm));
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.teText = new DevExpress.XtraEditors.TextEdit();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.sbOk = new DevExpress.XtraEditors.SimpleButton();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teText.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.ApplicationCaption = "Life Log";
			this.ribbonControl.ApplicationDocumentCaption = "Text Input";
			this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
			this.ribbonControl.ExpandCollapseItem.Id = 0;
			this.ribbonControl.ItemPanelStyle = DevExpress.XtraBars.Ribbon.RibbonItemPanelStyle.Classic;
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem});
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.Margin = new System.Windows.Forms.Padding(4);
			this.ribbonControl.MaxItemId = 9;
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
			this.ribbonControl.Size = new System.Drawing.Size(378, 49);
			this.ribbonControl.Toolbar.ShowCustomizeItem = false;
			// 
			// teText
			// 
			this.teText.Location = new System.Drawing.Point(6, 13);
			this.teText.Margin = new System.Windows.Forms.Padding(4);
			this.teText.MenuManager = this.ribbonControl;
			this.teText.Name = "teText";
			this.teText.Properties.AdvancedModeOptions.Label = "Text";
			this.teText.Size = new System.Drawing.Size(366, 50);
			this.teText.StyleController = this.layoutControl1;
			this.teText.TabIndex = 0;
			this.teText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teText_KeyDown);
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.sbOk);
			this.layoutControl1.Controls.Add(this.teText);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 49);
			this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(378, 108);
			this.layoutControl1.TabIndex = 4;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// sbOk
			// 
			this.sbOk.Appearance.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
			this.sbOk.Appearance.Options.UseFont = true;
			this.sbOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sbOk.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbOk.ImageOptions.SvgImage")));
			this.sbOk.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
			this.sbOk.Location = new System.Drawing.Point(269, 66);
			this.sbOk.Margin = new System.Windows.Forms.Padding(4);
			this.sbOk.MaximumSize = new System.Drawing.Size(100, 32);
			this.sbOk.MinimumSize = new System.Drawing.Size(100, 32);
			this.sbOk.Name = "sbOk";
			this.sbOk.Size = new System.Drawing.Size(100, 32);
			this.sbOk.StyleController = this.layoutControl1;
			this.sbOk.TabIndex = 2;
			this.sbOk.Text = "OK";
			this.sbOk.Click += new System.EventHandler(this.sbOk_Click);
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
			this.Root.Name = "Root";
			this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 13, 7);
			this.Root.Size = new System.Drawing.Size(378, 108);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.teText;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlItem1.Size = new System.Drawing.Size(366, 50);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.sbOk;
			this.layoutControlItem2.Location = new System.Drawing.Point(260, 50);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(106, 38);
			this.layoutControlItem2.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 50);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(260, 38);
			// 
			// dxErrorProvider
			// 
			this.dxErrorProvider.ContainerControl = this;
			// 
			// TextInputDialogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 157);
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.ribbonControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TextInputDialogForm.IconOptions.SvgImage")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TextInputDialogForm";
			this.Ribbon = this.ribbonControl;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "s";
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teText.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.TextEdit teText;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton sbOk;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}