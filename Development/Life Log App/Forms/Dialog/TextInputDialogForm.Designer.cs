namespace Life_Log_App.Forms.Dialog
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
            components = new System.ComponentModel.Container();
            ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            teText = new DevExpress.XtraEditors.TextEdit();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            sbOk = new DevExpress.XtraEditors.SimpleButton();
            dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teText.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl
            // 
            ribbonControl.ApplicationCaption = "Life Log";
            ribbonControl.ApplicationDocumentCaption = "Text Input";
            ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 39, 40, 39);
            ribbonControl.ExpandCollapseItem.Id = 0;
            ribbonControl.ItemPanelStyle = DevExpress.XtraBars.Ribbon.RibbonItemPanelStyle.Classic;
            ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl.ExpandCollapseItem });
            ribbonControl.Location = new System.Drawing.Point(0, 0);
            ribbonControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ribbonControl.MaxItemId = 9;
            ribbonControl.Name = "ribbonControl";
            ribbonControl.OptionsMenuMinWidth = 440;
            ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            ribbonControl.ShowQatLocationSelector = false;
            ribbonControl.ShowToolbarCustomizeItem = false;
            ribbonControl.Size = new System.Drawing.Size(398, 49);
            ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // teText
            // 
            teText.Location = new System.Drawing.Point(7, 13);
            teText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            teText.MenuManager = ribbonControl;
            teText.Name = "teText";
            teText.Properties.AdvancedModeOptions.Label = "Text";
            teText.Size = new System.Drawing.Size(384, 50);
            teText.StyleController = layoutControl1;
            teText.TabIndex = 0;
            teText.KeyDown += teText_KeyDown;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(sbOk);
            layoutControl1.Controls.Add(teText);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 49);
            layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(398, 110);
            layoutControl1.TabIndex = 4;
            layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, emptySpaceItem1 });
            Root.Name = "Root";
            Root.Padding = new DevExpress.XtraLayout.Utils.Padding(7, 7, 13, 7);
            Root.Size = new System.Drawing.Size(398, 110);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = teText;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlItem1.Size = new System.Drawing.Size(384, 50);
            layoutControlItem1.TextVisible = false;
            // 
            // sbOk
            // 
            sbOk.Appearance.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            sbOk.Appearance.Options.UseFont = true;
            sbOk.Cursor = System.Windows.Forms.Cursors.Hand;
            sbOk.ImageOptions.SvgImage = Properties.Resources.markcomplete;
            sbOk.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            sbOk.Location = new System.Drawing.Point(273, 67);
            sbOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            sbOk.MaximumSize = new System.Drawing.Size(114, 32);
            sbOk.MinimumSize = new System.Drawing.Size(114, 32);
            sbOk.Name = "sbOk";
            sbOk.Size = new System.Drawing.Size(114, 32);
            sbOk.StyleController = layoutControl1;
            sbOk.TabIndex = 2;
            sbOk.Text = "OK";
            sbOk.Click += sbOk_Click;
            // 
            // dxErrorProvider
            // 
            dxErrorProvider.ContainerControl = this;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = sbOk;
            layoutControlItem2.Location = new System.Drawing.Point(262, 50);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(122, 40);
            layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(0, 50);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(262, 40);
            // 
            // TextInputDialogForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(398, 159);
            Controls.Add(layoutControl1);
            Controls.Add(ribbonControl);
            Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            IconOptions.SvgImage = Properties.Resources.icon_svg;
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TextInputDialogForm";
            Ribbon = ribbonControl;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Text Input";
            ((System.ComponentModel.ISupportInitialize)ribbonControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)teText.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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