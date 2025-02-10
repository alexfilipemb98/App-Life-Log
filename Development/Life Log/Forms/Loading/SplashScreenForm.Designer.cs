namespace Life_Log.Forms.Loading
{
    partial class SplashScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.labelVersion = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCopyright.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelCopyright.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Appearance.Options.UseBackColor = true;
            this.labelCopyright.Appearance.Options.UseFont = true;
            this.labelCopyright.Appearance.Options.UseForeColor = true;
            this.labelCopyright.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelCopyright.Location = new System.Drawing.Point(5, 275);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(140, 19);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Copyright";
            // 
            // progressPanel
            // 
            this.progressPanel.AnimationElementImage = ((System.Drawing.Image)(resources.GetObject("progressPanel.AnimationElementImage")));
            this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Appearance.Options.UseBackColor = true;
            this.progressPanel.BackgroundImage = global::Life_Log.Properties.Resources.app_background;
            this.progressPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.progressPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.progressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPanel.Location = new System.Drawing.Point(0, 0);
            this.progressPanel.Margin = new System.Windows.Forms.Padding(0);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.RingAnimationDiameter = 100;
            this.progressPanel.ShowCaption = false;
            this.progressPanel.ShowDescription = false;
            this.progressPanel.Size = new System.Drawing.Size(300, 300);
            this.progressPanel.TabIndex = 10;
            this.progressPanel.Text = "progressPanel1";
            this.progressPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelVersion.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Appearance.Options.UseFont = true;
            this.labelVersion.Appearance.Options.UseForeColor = true;
            this.labelVersion.Appearance.Options.UseTextOptions = true;
            this.labelVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelVersion.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.AppearanceDisabled.Options.UseBackColor = true;
            this.labelVersion.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.AppearanceHovered.Options.UseBackColor = true;
            this.labelVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelVersion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelVersion.Location = new System.Drawing.Point(155, 275);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(140, 19);
            this.labelVersion.TabIndex = 11;
            this.labelVersion.Text = "1.0.1.0";
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.progressPanel);
            this.InactiveGlowColor = System.Drawing.Color.Transparent;
            this.Name = "SplashScreenForm";
            this.Text = "frmSplashScreen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        private DevExpress.XtraEditors.LabelControl labelVersion;
    }
}
