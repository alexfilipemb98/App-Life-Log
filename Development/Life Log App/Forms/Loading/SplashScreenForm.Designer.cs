namespace Life_Log_App.Forms.Loading
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
            progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            labelVersion = new DevExpress.XtraEditors.LabelControl();
            SuspendLayout();
            // 
            // labelCopyright
            // 
            labelCopyright.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelCopyright.Appearance.BackColor = System.Drawing.Color.Transparent;
            labelCopyright.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            labelCopyright.Appearance.ForeColor = System.Drawing.Color.Transparent;
            labelCopyright.Appearance.Options.UseBackColor = true;
            labelCopyright.Appearance.Options.UseFont = true;
            labelCopyright.Appearance.Options.UseForeColor = true;
            labelCopyright.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            labelCopyright.Location = new System.Drawing.Point(5, 275);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new System.Drawing.Size(140, 19);
            labelCopyright.TabIndex = 6;
            labelCopyright.Text = "Copyright";
            // 
            // progressPanel
            // 
            progressPanel.AnimationElementImage = (System.Drawing.Image)resources.GetObject("progressPanel.AnimationElementImage");
            progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            progressPanel.Appearance.Options.UseBackColor = true;
            progressPanel.BackgroundImage = Life_Log_App.Properties.Resources.app_background;
            progressPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            progressPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            progressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            progressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            progressPanel.Location = new System.Drawing.Point(0, 0);
            progressPanel.Margin = new System.Windows.Forms.Padding(0);
            progressPanel.Name = "progressPanel";
            progressPanel.RingAnimationDiameter = 100;
            progressPanel.ShowCaption = false;
            progressPanel.ShowDescription = false;
            progressPanel.Size = new System.Drawing.Size(300, 300);
            progressPanel.TabIndex = 10;
            progressPanel.Text = "progressPanel1";
            progressPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // labelVersion
            // 
            labelVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelVersion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            labelVersion.Appearance.ForeColor = System.Drawing.Color.Transparent;
            labelVersion.Appearance.Options.UseFont = true;
            labelVersion.Appearance.Options.UseForeColor = true;
            labelVersion.Appearance.Options.UseTextOptions = true;
            labelVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelVersion.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            labelVersion.AppearanceDisabled.Options.UseBackColor = true;
            labelVersion.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            labelVersion.AppearanceHovered.Options.UseBackColor = true;
            labelVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelVersion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            labelVersion.Location = new System.Drawing.Point(155, 275);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new System.Drawing.Size(140, 19);
            labelVersion.TabIndex = 11;
            labelVersion.Text = "1.0.1.0";
            // 
            // SplashScreenForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(300, 300);
            Controls.Add(labelCopyright);
            Controls.Add(labelVersion);
            Controls.Add(progressPanel);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
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
