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
			this.bbiTopMost = new DevExpress.XtraBars.BarToggleSwitchItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbon
			// 
			this.ribbon.CaptionBarItemLinks.Add(this.bbiTopMost);
			this.ribbon.ExpandCollapseItem.Id = 0;
			this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiTopMost});
			this.ribbon.Location = new System.Drawing.Point(0, 0);
			this.ribbon.MaxItemId = 2;
			this.ribbon.Name = "ribbon";
			this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
			this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.ribbon.ShowQatLocationSelector = false;
			this.ribbon.ShowToolbarCustomizeItem = false;
			this.ribbon.Size = new System.Drawing.Size(753, 32);
			this.ribbon.Toolbar.ShowCustomizeItem = false;
			// 
			// panelControl
			// 
			this.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl.Location = new System.Drawing.Point(0, 32);
			this.panelControl.Name = "panelControl";
			this.panelControl.Size = new System.Drawing.Size(753, 364);
			this.panelControl.TabIndex = 2;
			// 
			// bbiTopMost
			// 
			this.bbiTopMost.Caption = "Top Most";
			this.bbiTopMost.Id = 1;
			this.bbiTopMost.Name = "bbiTopMost";
			this.bbiTopMost.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTopMost_CheckedChanged);
			// 
			// ContainerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 396);
			this.Controls.Add(this.panelControl);
			this.Controls.Add(this.ribbon);
			this.IconOptions.Image = global::LifeLog.Base.Assets.Resources.icon;
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
		private DevExpress.XtraBars.BarToggleSwitchItem bbiTopMost;
	}
}