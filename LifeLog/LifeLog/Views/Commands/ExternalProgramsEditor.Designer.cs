namespace LifeLog.Views.Commands;

partial class ExternalProgramsEditor
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
		layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
		textEdit2 = new DevExpress.XtraEditors.TextEdit();
		textEdit1 = new DevExpress.XtraEditors.TextEdit();
		pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
		gridControl1 = new DevExpress.XtraGrid.GridControl();
		gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		Root = new DevExpress.XtraLayout.LayoutControlGroup();
		layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
		layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
		layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
		layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
		layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
		layoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
		SuspendLayout();
		// 
		// layoutControl1
		// 
		layoutControl1.Controls.Add(textEdit2);
		layoutControl1.Controls.Add(textEdit1);
		layoutControl1.Controls.Add(pictureEdit1);
		layoutControl1.Controls.Add(gridControl1);
		layoutControl1.Dock = DockStyle.Fill;
		layoutControl1.Location = new Point(0, 0);
		layoutControl1.Name = "layoutControl1";
		layoutControl1.Root = Root;
		layoutControl1.Size = new Size(956, 538);
		layoutControl1.TabIndex = 1;
		layoutControl1.Text = "layoutControl1";
		// 
		// textEdit2
		// 
		textEdit2.Location = new Point(717, 443);
		textEdit2.Name = "textEdit2";
		textEdit2.Size = new Size(210, 30);
		textEdit2.StyleController = layoutControl1;
		textEdit2.TabIndex = 2;
		// 
		// textEdit1
		// 
		textEdit1.Location = new Point(717, 479);
		textEdit1.Name = "textEdit1";
		textEdit1.Size = new Size(210, 30);
		textEdit1.StyleController = layoutControl1;
		textEdit1.TabIndex = 3;
		// 
		// pictureEdit1
		// 
		pictureEdit1.Location = new Point(717, 56);
		pictureEdit1.Name = "pictureEdit1";
		pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
		pictureEdit1.Size = new Size(210, 381);
		pictureEdit1.StyleController = layoutControl1;
		pictureEdit1.TabIndex = 1;
		// 
		// gridControl1
		// 
		gridControl1.Location = new Point(17, 44);
		gridControl1.MainView = gridView1;
		gridControl1.Margin = new Padding(0);
		gridControl1.Name = "gridControl1";
		gridControl1.Size = new Size(558, 477);
		gridControl1.TabIndex = 0;
		gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
		// 
		// gridView1
		// 
		gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		gridView1.GridControl = gridControl1;
		gridView1.Name = "gridView1";
		gridView1.OptionsView.ShowGroupPanel = false;
		// 
		// Root
		// 
		Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		Root.GroupBordersVisible = false;
		Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1, layoutControlGroup2 });
		Root.Name = "Root";
		Root.Size = new Size(956, 538);
		Root.TextVisible = false;
		// 
		// layoutControlGroup1
		// 
		layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem4, layoutControlItem3, layoutControlItem2 });
		layoutControlGroup1.Location = new Point(566, 0);
		layoutControlGroup1.Name = "layoutControlGroup1";
		layoutControlGroup1.Size = new Size(364, 512);
		layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 0, 0, 0);
		// 
		// layoutControlItem4
		// 
		layoutControlItem4.Control = textEdit2;
		layoutControlItem4.Location = new Point(0, 387);
		layoutControlItem4.Name = "layoutControlItem4";
		layoutControlItem4.Size = new Size(335, 36);
		layoutControlItem4.TextSize = new Size(103, 15);
		// 
		// layoutControlItem3
		// 
		layoutControlItem3.Control = textEdit1;
		layoutControlItem3.Location = new Point(0, 423);
		layoutControlItem3.Name = "layoutControlItem3";
		layoutControlItem3.Size = new Size(335, 36);
		layoutControlItem3.TextSize = new Size(103, 15);
		// 
		// layoutControlItem2
		// 
		layoutControlItem2.Control = pictureEdit1;
		layoutControlItem2.Location = new Point(0, 0);
		layoutControlItem2.Name = "layoutControlItem2";
		layoutControlItem2.Size = new Size(335, 387);
		layoutControlItem2.TextSize = new Size(103, 15);
		// 
		// layoutControlGroup2
		// 
		layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
		layoutControlGroup2.Location = new Point(0, 0);
		layoutControlGroup2.Name = "layoutControlGroup2";
		layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
		layoutControlGroup2.Size = new Size(566, 512);
		layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
		// 
		// layoutControlItem1
		// 
		layoutControlItem1.Control = gridControl1;
		layoutControlItem1.Location = new Point(0, 0);
		layoutControlItem1.Name = "layoutControlItem1";
		layoutControlItem1.Size = new Size(564, 483);
		layoutControlItem1.TextVisible = false;
		// 
		// ExternalProgramsEditor
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(layoutControl1);
		Name = "ExternalProgramsEditor";
		Size = new Size(956, 538);
		((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
		layoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)Root).EndInit();
		((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private DevExpress.XtraLayout.LayoutControl layoutControl1;
	private DevExpress.XtraEditors.TextEdit textEdit2;
	private DevExpress.XtraEditors.TextEdit textEdit1;
	private DevExpress.XtraEditors.PictureEdit pictureEdit1;
	private DevExpress.XtraGrid.GridControl gridControl1;
	private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	private DevExpress.XtraLayout.LayoutControlGroup Root;
	private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
	private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
	private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
	private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
	private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
	private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
}
