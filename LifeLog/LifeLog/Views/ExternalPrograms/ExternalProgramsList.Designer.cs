namespace LifeLog.Views.ExternalPrograms;

partial class ExternalProgramsList
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

	#region Component Designer generated code

	/// <summary> 
	/// Required method for Designer support - do not modify 
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		gridControl1 = new DevExpress.XtraGrid.GridControl();
		gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		((System.ComponentModel.ISupportInitialize)navigationFrameBase).BeginInit();
		navigationFrameBase.SuspendLayout();
		npListBase.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)panelControlBase).BeginInit();
		panelControlBase.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)RootBase).BeginInit();
		((System.ComponentModel.ISupportInitialize)layoutControlBase).BeginInit();
		layoutControlBase.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)layoutControlItemBase).BeginInit();
		((System.ComponentModel.ISupportInitialize)riscBase).BeginInit();
		((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
		SuspendLayout();
		// 
		// navigationFrameBase
		// 
		navigationFrameBase.Size = new Size(903, 446);
		// 
		// npListBase
		// 
		npListBase.Controls.Add(gridControl1);
		npListBase.Size = new Size(903, 446);
		// 
		// panelControlBase
		// 
		panelControlBase.Location = new Point(7, 11);
		panelControlBase.Size = new Size(907, 450);
		// 
		// RootBase
		// 
		RootBase.Size = new Size(921, 468);
		// 
		// npEditBase
		// 
		npEditBase.Size = new Size(903, 446);
		// 
		// layoutControlBase
		// 
		layoutControlBase.Location = new Point(0, 44);
		layoutControlBase.OptionsPrint.AppearanceGroupCaption.BackColor = Color.LightGray;
		layoutControlBase.OptionsPrint.AppearanceGroupCaption.Font = new Font("Tahoma", 10.25F);
		layoutControlBase.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
		layoutControlBase.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
		layoutControlBase.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
		layoutControlBase.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		layoutControlBase.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
		layoutControlBase.Size = new Size(921, 468);
		layoutControlBase.Controls.SetChildIndex(panelControlBase, 0);
		// 
		// layoutControlItemBase
		// 
		layoutControlItemBase.Size = new Size(913, 456);
		// 
		// gridControl1
		// 
		gridControl1.Dock = DockStyle.Fill;
		gridControl1.Location = new Point(0, 0);
		gridControl1.MainView = gridView1;
		gridControl1.Name = "gridControl1";
		gridControl1.Size = new Size(903, 446);
		gridControl1.TabIndex = 0;
		gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
		// 
		// gridView1
		// 
		gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		gridView1.GridControl = gridControl1;
		gridView1.Name = "gridView1";
		// 
		// ExternalProgramsList
		// 
		AutoScaleDimensions = new SizeF(6F, 13F);
		AutoScaleMode = AutoScaleMode.Font;
		Name = "ExternalProgramsListcs";
		Size = new Size(921, 512);
		((System.ComponentModel.ISupportInitialize)navigationFrameBase).EndInit();
		navigationFrameBase.ResumeLayout(false);
		npListBase.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)panelControlBase).EndInit();
		panelControlBase.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)RootBase).EndInit();
		((System.ComponentModel.ISupportInitialize)layoutControlBase).EndInit();
		layoutControlBase.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)layoutControlItemBase).EndInit();
		((System.ComponentModel.ISupportInitialize)riscBase).EndInit();
		((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private DevExpress.XtraGrid.GridControl gridControl1;
	private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
}
