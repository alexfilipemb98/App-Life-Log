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
        components = new System.ComponentModel.Container();
        gridControl = new DevExpress.XtraGrid.GridControl();
        externalProgramsDTOBindingSource = new BindingSource(components);
        gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
        colId = new DevExpress.XtraGrid.Columns.GridColumn();
        colName = new DevExpress.XtraGrid.Columns.GridColumn();
        colFileExtension = new DevExpress.XtraGrid.Columns.GridColumn();
        colPathToProgram = new DevExpress.XtraGrid.Columns.GridColumn();
        colArguments = new DevExpress.XtraGrid.Columns.GridColumn();
        colImageData = new DevExpress.XtraGrid.Columns.GridColumn();
        colImageExtension = new DevExpress.XtraGrid.Columns.GridColumn();
        colIsSvg = new DevExpress.XtraGrid.Columns.GridColumn();
        colSvgImage = new DevExpress.XtraGrid.Columns.GridColumn();
        colBitImage = new DevExpress.XtraGrid.Columns.GridColumn();
        colIcon = new DevExpress.XtraGrid.Columns.GridColumn();
        externalProgramsEditor = new ExternalProgramsEditor();
        ((System.ComponentModel.ISupportInitialize)navigationFrameBase).BeginInit();
        navigationFrameBase.SuspendLayout();
        npListBase.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)panelControlBase).BeginInit();
        panelControlBase.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)RootBase).BeginInit();
        npEditBase.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)layoutControlBase).BeginInit();
        layoutControlBase.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)layoutControlItemBase).BeginInit();
        ((System.ComponentModel.ISupportInitialize)riscBase).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
        ((System.ComponentModel.ISupportInitialize)externalProgramsDTOBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
        SuspendLayout();
        // 
        // navigationFrameBase
        // 
        navigationFrameBase.Size = new Size(903, 446);
        // 
        // npListBase
        // 
        npListBase.Controls.Add(gridControl);
        npListBase.Size = new Size(903, 446);
        // 
        // panelControlBase
        // 
        panelControlBase.Size = new Size(907, 450);
        // 
        // RootBase
        // 
        RootBase.Size = new Size(921, 468);
        // 
        // npEditBase
        // 
        npEditBase.Controls.Add(externalProgramsEditor);
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
        // riscBase
        // 
        riscBase.Client = gridControl;
        riscBase.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
        // 
        // gridControl
        // 
        gridControl.DataSource = externalProgramsDTOBindingSource;
        gridControl.Dock = DockStyle.Fill;
        gridControl.Location = new Point(0, 0);
        gridControl.MainView = gridView;
        gridControl.Name = "gridControl";
        gridControl.Size = new Size(903, 446);
        gridControl.TabIndex = 0;
        gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
        // 
        // externalProgramsDTOBindingSource
        // 
        externalProgramsDTOBindingSource.DataSource = typeof(Data.DTOs.ExternalProgramsDTO);
        // 
        // gridView
        // 
        gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colName, colFileExtension, colPathToProgram, colArguments, colImageData, colImageExtension, colIsSvg, colSvgImage, colBitImage, colIcon });
        gridView.GridControl = gridControl;
        gridView.Name = "gridView";
        gridView.OptionsView.ShowGroupPanel = false;
        gridView.OptionsView.ShowIndicator = false;
        // 
        // colId
        // 
        colId.FieldName = "Id";
        colId.Name = "colId";
        // 
        // colName
        // 
        colName.FieldName = "Name";
        colName.Name = "colName";
        colName.Visible = true;
        colName.VisibleIndex = 1;
        colName.Width = 203;
        // 
        // colFileExtension
        // 
        colFileExtension.FieldName = "FileExtension";
        colFileExtension.Name = "colFileExtension";
        colFileExtension.Visible = true;
        colFileExtension.VisibleIndex = 2;
        colFileExtension.Width = 160;
        // 
        // colPathToProgram
        // 
        colPathToProgram.FieldName = "PathToProgram";
        colPathToProgram.Name = "colPathToProgram";
        colPathToProgram.Visible = true;
        colPathToProgram.VisibleIndex = 3;
        colPathToProgram.Width = 183;
        // 
        // colArguments
        // 
        colArguments.FieldName = "Arguments";
        colArguments.Name = "colArguments";
        colArguments.Visible = true;
        colArguments.VisibleIndex = 4;
        colArguments.Width = 273;
        // 
        // colImageData
        // 
        colImageData.Caption = "Image";
        colImageData.FieldName = "ImageData";
        colImageData.Name = "colImageData";
        colImageData.Visible = true;
        colImageData.VisibleIndex = 0;
        colImageData.Width = 84;
        // 
        // colImageExtension
        // 
        colImageExtension.FieldName = "ImageExtension";
        colImageExtension.Name = "colImageExtension";
        // 
        // colIsSvg
        // 
        colIsSvg.FieldName = "IsSvg";
        colIsSvg.Name = "colIsSvg";
        colIsSvg.OptionsColumn.ReadOnly = true;
        // 
        // colSvgImage
        // 
        colSvgImage.FieldName = "SvgImage";
        colSvgImage.Name = "colSvgImage";
        colSvgImage.OptionsColumn.ReadOnly = true;
        // 
        // colBitImage
        // 
        colBitImage.FieldName = "BitImage";
        colBitImage.Name = "colBitImage";
        colBitImage.OptionsColumn.ReadOnly = true;
        // 
        // colIcon
        // 
        colIcon.FieldName = "Icon";
        colIcon.Name = "colIcon";
        // 
        // externalProgramsEditor
        // 
        externalProgramsEditor.Dock = DockStyle.Fill;
        externalProgramsEditor.Location = new Point(0, 0);
        externalProgramsEditor.Name = "externalProgramsEditor";
        externalProgramsEditor.Size = new Size(903, 446);
        externalProgramsEditor.TabIndex = 0;
        // 
        // ExternalProgramsList
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        Name = "ExternalProgramsList";
        Size = new Size(921, 512);
        ((System.ComponentModel.ISupportInitialize)navigationFrameBase).EndInit();
        navigationFrameBase.ResumeLayout(false);
        npListBase.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)panelControlBase).EndInit();
        panelControlBase.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)RootBase).EndInit();
        npEditBase.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)layoutControlBase).EndInit();
        layoutControlBase.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)layoutControlItemBase).EndInit();
        ((System.ComponentModel.ISupportInitialize)riscBase).EndInit();
        ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
        ((System.ComponentModel.ISupportInitialize)externalProgramsDTOBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridControl;
	private DevExpress.XtraGrid.Views.Grid.GridView gridView;
    private BindingSource externalProgramsDTOBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colId;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colFileExtension;
    private DevExpress.XtraGrid.Columns.GridColumn colPathToProgram;
    private DevExpress.XtraGrid.Columns.GridColumn colArguments;
    private DevExpress.XtraGrid.Columns.GridColumn colImageData;
    private DevExpress.XtraGrid.Columns.GridColumn colImageExtension;
    private DevExpress.XtraGrid.Columns.GridColumn colIsSvg;
    private DevExpress.XtraGrid.Columns.GridColumn colSvgImage;
    private DevExpress.XtraGrid.Columns.GridColumn colBitImage;
    private DevExpress.XtraGrid.Columns.GridColumn colIcon;
    private ExternalProgramsEditor externalProgramsEditor;
}
