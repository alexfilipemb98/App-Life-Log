namespace LifeLog.UI.Resources
{
	partial class frm
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
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureEdit1.EditValue = global::LifeLog.Base.Assets.Resources.task;
			this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
			this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
			this.pictureEdit1.Size = new System.Drawing.Size(255, 203);
			this.pictureEdit1.TabIndex = 0;
			this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
			// 
			// frm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(255, 203);
			this.Controls.Add(this.pictureEdit1);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frm";
			this.Text = "frm";
			this.Load += new System.EventHandler(this.frm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
	}
}