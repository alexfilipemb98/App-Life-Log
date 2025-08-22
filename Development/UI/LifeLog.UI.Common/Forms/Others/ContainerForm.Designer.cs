namespace LifeLog.UI.Common.Forms.Others
{
    partial class ContainerForm
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
			this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.panelControl = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbon
			// 
			this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
			this.ribbon.ExpandCollapseItem.Id = 0;
			this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
			this.ribbon.Location = new System.Drawing.Point(0, 0);
			this.ribbon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ribbon.MaxItemId = 1;
			this.ribbon.Name = "ribbon";
			this.ribbon.OptionsMenuMinWidth = 385;
			this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbon.ShowQatLocationSelector = false;
			this.ribbon.ShowToolbarCustomizeItem = false;
			this.ribbon.Size = new System.Drawing.Size(879, 49);
			this.ribbon.Toolbar.ShowCustomizeItem = false;
			// 
			// panelControl
			// 
			this.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl.Location = new System.Drawing.Point(0, 49);
			this.panelControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelControl.Name = "panelControl";
			this.panelControl.Size = new System.Drawing.Size(879, 439);
			this.panelControl.TabIndex = 2;
			// 
			// ContainerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 488);
			this.Controls.Add(this.panelControl);
			this.Controls.Add(this.ribbon);
			this.IconOptions.Image = global::LifeLog.UI.Common.Properties.Resources.icon;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ContainerForm";
			this.Ribbon = this.ribbon;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form Container";
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.PanelControl panelControl;
    }
}