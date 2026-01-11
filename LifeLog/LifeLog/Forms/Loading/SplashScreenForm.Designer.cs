namespace LifeLog.Forms.Loading
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
            labelCopyright = new DevExpress.XtraEditors.LabelControl();
            labelVersion = new DevExpress.XtraEditors.LabelControl();
            progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            SuspendLayout();
            // 
            // labelCopyright
            // 
            labelCopyright.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelCopyright.Appearance.BackColor = Color.Transparent;
            labelCopyright.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            labelCopyright.Appearance.ForeColor = Color.Transparent;
            labelCopyright.Appearance.Options.UseBackColor = true;
            labelCopyright.Appearance.Options.UseFont = true;
            labelCopyright.Appearance.Options.UseForeColor = true;
            labelCopyright.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            labelCopyright.Location = new Point(12, 269);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(236, 19);
            labelCopyright.TabIndex = 6;
            labelCopyright.Text = "Copyright";
            // 
            // labelVersion
            // 
            labelVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelVersion.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            labelVersion.Appearance.ForeColor = Color.Transparent;
            labelVersion.Appearance.Options.UseFont = true;
            labelVersion.Appearance.Options.UseForeColor = true;
            labelVersion.Appearance.Options.UseTextOptions = true;
            labelVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelVersion.AppearanceDisabled.BackColor = Color.Transparent;
            labelVersion.AppearanceDisabled.Options.UseBackColor = true;
            labelVersion.AppearanceHovered.BackColor = Color.Transparent;
            labelVersion.AppearanceHovered.Options.UseBackColor = true;
            labelVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelVersion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            labelVersion.Location = new Point(254, 269);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(234, 19);
            labelVersion.TabIndex = 11;
            labelVersion.Text = "1.0.1.0";
            // 
            // progressPanel
            // 
            progressPanel.AnimationElementImage = LifeLog.Properties.Resources.WitheCircle10;
            progressPanel.Appearance.BackColor = Color.Transparent;
            progressPanel.Appearance.Options.UseBackColor = true;
            progressPanel.BackgroundImage = LifeLog.Properties.Resources.LoginBackground;
            progressPanel.BackgroundImageLayout = ImageLayout.Stretch;
            progressPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            progressPanel.ContentAlignment = ContentAlignment.MiddleCenter;
            progressPanel.Dock = DockStyle.Fill;
            progressPanel.Location = new Point(0, 0);
            progressPanel.Margin = new Padding(0);
            progressPanel.Name = "progressPanel";
            progressPanel.Padding = new Padding(0, 0, 0, 50);
            progressPanel.RingAnimationDiameter = 80;
            progressPanel.ShowCaption = false;
            progressPanel.ShowDescription = false;
            progressPanel.Size = new Size(500, 300);
            progressPanel.TabIndex = 10;
            progressPanel.Text = "progressPanel1";
            progressPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // SplashScreenForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(labelCopyright);
            Controls.Add(labelVersion);
            Controls.Add(progressPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 300);
            Name = "SplashScreenForm";
            Text = "frmSplashScreen";
            Load += frmSplashScreen_Load;
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        private DevExpress.XtraEditors.LabelControl labelVersion;
	}
}
