namespace LifeLog.Forms.Others;

partial class PictureForm
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
        pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
        ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
        SuspendLayout();
        // 
        // pictureEdit1
        // 
        pictureEdit1.Dock = DockStyle.Fill;
        pictureEdit1.EditValue = Properties.Resources.placeholder;
        pictureEdit1.Location = new Point(0, 0);
        pictureEdit1.Name = "pictureEdit1";
        pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
        pictureEdit1.Size = new Size(298, 268);
        pictureEdit1.TabIndex = 0;
        // 
        // PictureForm
        // 
        Appearance.Options.UseFont = true;
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(298, 268);
        Controls.Add(pictureEdit1);
        Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Name = "PictureForm";
        Text = "PictureForm";
        ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DevExpress.XtraEditors.PictureEdit pictureEdit1;
}