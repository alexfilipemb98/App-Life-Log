namespace LifeLog.Forms.Others
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainerForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            bbiTopMost = new DevExpress.XtraBars.BarToggleSwitchItem();
            panelControl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.CaptionBarItemLinks.Add(bbiTopMost);
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bbiTopMost, ribbon.ExpandCollapseItem });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 3;
            ribbon.Name = "ribbon";
            ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            ribbon.ShowQatLocationSelector = false;
            ribbon.ShowToolbarCustomizeItem = false;
            ribbon.Size = new Size(753, 65);
            ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiTopMost
            // 
            bbiTopMost.Caption = "Top Most";
            bbiTopMost.Id = 1;
            bbiTopMost.Name = "bbiTopMost";
            bbiTopMost.CheckedChanged += bbiTopMost_CheckedChanged;
            // 
            // panelControl
            // 
            panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl.Dock = DockStyle.Fill;
            panelControl.Location = new Point(0, 65);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(753, 331);
            panelControl.TabIndex = 2;
            // 
            // ContainerForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 396);
            Controls.Add(panelControl);
            Controls.Add(ribbon);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconOptions.Icon = (Icon)resources.GetObject("ContainerForm.IconOptions.Icon");
            Name = "ContainerForm";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form Container";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.PanelControl panelControl;
		private DevExpress.XtraBars.BarToggleSwitchItem bbiTopMost;
	}
}