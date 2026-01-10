namespace LifeLog.Views.ExternalPrograms;

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
        components = new System.ComponentModel.Container();
        DevExpress.Utils.ContextButton contextButton1 = new DevExpress.Utils.ContextButton();
        DevExpress.Utils.ContextButton contextButton2 = new DevExpress.Utils.ContextButton();
        layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
        txtArgs = new DevExpress.XtraEditors.TextEdit();
        txtFileExt = new DevExpress.XtraEditors.TextEdit();
        txtPath = new DevExpress.XtraEditors.TextEdit();
        txtName = new DevExpress.XtraEditors.TextEdit();
        peIcon = new DevExpress.XtraEditors.PictureEdit();
        Root = new DevExpress.XtraLayout.LayoutControlGroup();
        layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
        emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
        layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
        esiLeft = new DevExpress.XtraLayout.EmptySpaceItem();
        esiRight = new DevExpress.XtraLayout.EmptySpaceItem();
        dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
        layoutControl1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)txtArgs.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)txtFileExt.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)txtPath.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)peIcon.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)esiLeft).BeginInit();
        ((System.ComponentModel.ISupportInitialize)esiRight).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dxErrorProvider).BeginInit();
        SuspendLayout();
        // 
        // layoutControl1
        // 
        layoutControl1.Controls.Add(txtArgs);
        layoutControl1.Controls.Add(txtFileExt);
        layoutControl1.Controls.Add(txtPath);
        layoutControl1.Controls.Add(txtName);
        layoutControl1.Controls.Add(peIcon);
        layoutControl1.Dock = DockStyle.Fill;
        layoutControl1.Location = new Point(0, 0);
        layoutControl1.Name = "layoutControl1";
        layoutControl1.Root = Root;
        layoutControl1.Size = new Size(807, 636);
        layoutControl1.TabIndex = 0;
        layoutControl1.Text = "layoutControl1";
        // 
        // txtArgs
        // 
        txtArgs.Location = new Point(66, 234);
        txtArgs.Name = "txtArgs";
        txtArgs.Size = new Size(725, 28);
        txtArgs.StyleController = layoutControl1;
        txtArgs.TabIndex = 4;
        // 
        // txtFileExt
        // 
        txtFileExt.Location = new Point(605, 200);
        txtFileExt.Name = "txtFileExt";
        txtFileExt.Size = new Size(186, 28);
        txtFileExt.StyleController = layoutControl1;
        txtFileExt.TabIndex = 3;
        // 
        // txtPath
        // 
        txtPath.Location = new Point(66, 200);
        txtPath.Name = "txtPath";
        txtPath.Size = new Size(483, 28);
        txtPath.StyleController = layoutControl1;
        txtPath.TabIndex = 2;
        // 
        // txtName
        // 
        txtName.Location = new Point(66, 166);
        txtName.Name = "txtName";
        txtName.Size = new Size(725, 28);
        txtName.StyleController = layoutControl1;
        txtName.TabIndex = 0;
        // 
        // peIcon
        // 
        peIcon.Location = new Point(301, 16);
        peIcon.Name = "peIcon";
        contextButton1.Id = new Guid("cdbf002f-e3f2-418a-b9ce-f843a8eb3116");
        contextButton1.ImageOptionsCollection.ItemNormal.SvgImage = Properties.Resources.open2;
        contextButton1.Name = "btnOpenFolder";
        contextButton2.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
        contextButton2.Id = new Guid("13bf5252-1ec0-4b3d-ba95-2412ff58d747");
        contextButton2.ImageOptionsCollection.ItemNormal.SvgImage = Properties.Resources.del;
        contextButton2.Name = "btnClear";
        peIcon.Properties.ContextButtons.Add(contextButton1);
        peIcon.Properties.ContextButtons.Add(contextButton2);
        peIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
        peIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
        peIcon.Size = new Size(144, 144);
        peIcon.StyleController = layoutControl1;
        peIcon.TabIndex = 1;
        peIcon.ContextButtonClick += peIcon_ContextButtonClick;
        // 
        // Root
        // 
        Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
        Root.GroupBordersVisible = false;
        Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, esiLeft, esiRight });
        Root.Name = "Root";
        Root.Size = new Size(807, 636);
        Root.TextVisible = false;
        // 
        // layoutControlItem1
        // 
        layoutControlItem1.Control = peIcon;
        layoutControlItem1.Location = new Point(285, 0);
        layoutControlItem1.MaxSize = new Size(150, 150);
        layoutControlItem1.MinSize = new Size(150, 150);
        layoutControlItem1.Name = "layoutControlItem1";
        layoutControlItem1.Size = new Size(150, 150);
        layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
        layoutControlItem1.TextVisible = false;
        // 
        // emptySpaceItem1
        // 
        emptySpaceItem1.Location = new Point(0, 252);
        emptySpaceItem1.Name = "emptySpaceItem1";
        emptySpaceItem1.Size = new Size(781, 358);
        // 
        // layoutControlItem2
        // 
        layoutControlItem2.Control = txtName;
        layoutControlItem2.Location = new Point(0, 150);
        layoutControlItem2.Name = "layoutControlItem2";
        layoutControlItem2.Size = new Size(781, 34);
        layoutControlItem2.Text = "Name";
        layoutControlItem2.TextSize = new Size(34, 13);
        // 
        // layoutControlItem3
        // 
        layoutControlItem3.Control = txtPath;
        layoutControlItem3.Location = new Point(0, 184);
        layoutControlItem3.Name = "layoutControlItem3";
        layoutControlItem3.Size = new Size(539, 34);
        layoutControlItem3.Text = "Path";
        layoutControlItem3.TextSize = new Size(34, 13);
        // 
        // layoutControlItem4
        // 
        layoutControlItem4.BestFitWeight = 45;
        layoutControlItem4.Control = txtFileExt;
        layoutControlItem4.Location = new Point(539, 184);
        layoutControlItem4.Name = "layoutControlItem4";
        layoutControlItem4.Size = new Size(242, 34);
        layoutControlItem4.Text = "File Ext";
        layoutControlItem4.TextSize = new Size(34, 13);
        // 
        // layoutControlItem5
        // 
        layoutControlItem5.Control = txtArgs;
        layoutControlItem5.Location = new Point(0, 218);
        layoutControlItem5.Name = "layoutControlItem5";
        layoutControlItem5.Size = new Size(781, 34);
        layoutControlItem5.Text = "Args";
        layoutControlItem5.TextSize = new Size(34, 13);
        // 
        // esiLeft
        // 
        esiLeft.BestFitWeight = 50;
        esiLeft.Location = new Point(0, 0);
        esiLeft.Name = "esiLeft";
        esiLeft.Size = new Size(285, 150);
        // 
        // esiRight
        // 
        esiRight.BestFitWeight = 50;
        esiRight.Location = new Point(435, 0);
        esiRight.Name = "esiRight";
        esiRight.Size = new Size(346, 150);
        // 
        // dxErrorProvider
        // 
        dxErrorProvider.ContainerControl = this;
        // 
        // ExternalProgramsEditor
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(layoutControl1);
        Name = "ExternalProgramsEditor";
        Size = new Size(807, 636);
        Resize += ExternalProgramsEditor_Resize;
        ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
        layoutControl1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)txtArgs.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)txtFileExt.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)txtPath.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)peIcon.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)Root).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
        ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
        ((System.ComponentModel.ISupportInitialize)esiLeft).EndInit();
        ((System.ComponentModel.ISupportInitialize)esiRight).EndInit();
        ((System.ComponentModel.ISupportInitialize)dxErrorProvider).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraEditors.TextEdit txtArgs;
    private DevExpress.XtraEditors.TextEdit txtFileExt;
    private DevExpress.XtraEditors.TextEdit txtPath;
    private DevExpress.XtraEditors.TextEdit txtName;
    private DevExpress.XtraEditors.PictureEdit peIcon;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.EmptySpaceItem esiLeft;
    private DevExpress.XtraLayout.EmptySpaceItem esiRight;
    private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
}
