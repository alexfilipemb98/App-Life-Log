namespace LifeLog.UI.BackEnd.Views.Notes
{
	partial class NotesListView
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
			this.components = new System.ComponentModel.Container();
			this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.notesModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colText = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUpdatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.bsImages = new DevExpress.Xpo.XPBindingSource(this.components);
			this.bsImages1 = new DevExpress.Xpo.XPBindingSource(this.components);
			this.notesDetailView = new LifeLog.UI.BackEnd.Views.Notes.NotesDetailView();
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
			this.navigationFrame.SuspendLayout();
			this.npList.SuspendLayout();
			this.npEdit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lcBase)).BeginInit();
			this.lcBase.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcBase)).BeginInit();
			this.pcBase.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lciBase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.riscBase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.notesModelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsImages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsImages1)).BeginInit();
			this.SuspendLayout();
			// 
			// navigationFrame
			// 
			this.navigationFrame.Location = new System.Drawing.Point(0, 35);
			this.navigationFrame.SelectedPage = this.npList;
			this.navigationFrame.Size = new System.Drawing.Size(769, 401);
			// 
			// npList
			// 
			this.npList.Size = new System.Drawing.Size(769, 401);
			// 
			// npEdit
			// 
			this.npEdit.Controls.Add(this.notesDetailView);
			this.npEdit.Size = new System.Drawing.Size(769, 401);
			// 
			// lcBase
			// 
			this.lcBase.Size = new System.Drawing.Size(769, 401);
			this.lcBase.Controls.SetChildIndex(this.pcBase, 0);
			// 
			// pcBase
			// 
			this.pcBase.Controls.Add(this.gridControl);
			this.pcBase.Size = new System.Drawing.Size(757, 385);
			// 
			// lciBase
			// 
			this.lciBase.Size = new System.Drawing.Size(761, 389);
			// 
			// Root
			// 
			this.Root.Size = new System.Drawing.Size(769, 401);
			// 
			// riscBase
			// 
			this.riscBase.Client = this.gridControl;
			// 
			// popupMenu
			// 
			this.popupMenu.Name = "popupMenu";
			// 
			// gridControl
			// 
			this.gridControl.DataSource = this.notesModelBindingSource;
			this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl.Location = new System.Drawing.Point(2, 2);
			this.gridControl.MainView = this.gridView;
			this.gridControl.Name = "gridControl";
			this.gridControl.Size = new System.Drawing.Size(753, 381);
			this.gridControl.TabIndex = 0;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// notesModelBindingSource
			// 
			this.notesModelBindingSource.DataSource = typeof(LifeLog.Data.Models.NotesModel);
			// 
			// gridView
			// 
			this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTitle,
            this.colText,
            this.colColor,
            this.colUser,
            this.colId,
            this.colCreatedAt,
            this.colUpdatedAt});
			this.gridView.GridControl = this.gridControl;
			this.gridView.Name = "gridView";
			this.gridView.OptionsBehavior.Editable = false;
			this.gridView.OptionsView.ShowGroupPanel = false;
			this.gridView.OptionsView.ShowIndicator = false;
			// 
			// colTitle
			// 
			this.colTitle.FieldName = "Title";
			this.colTitle.Name = "colTitle";
			this.colTitle.Visible = true;
			this.colTitle.VisibleIndex = 0;
			this.colTitle.Width = 183;
			// 
			// colText
			// 
			this.colText.FieldName = "Text";
			this.colText.Name = "colText";
			// 
			// colColor
			// 
			this.colColor.FieldName = "Color";
			this.colColor.Name = "colColor";
			this.colColor.Visible = true;
			this.colColor.VisibleIndex = 1;
			this.colColor.Width = 142;
			// 
			// colUser
			// 
			this.colUser.FieldName = "User.Username";
			this.colUser.Name = "colUser";
			this.colUser.Visible = true;
			this.colUser.VisibleIndex = 2;
			this.colUser.Width = 188;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// colCreatedAt
			// 
			this.colCreatedAt.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
			this.colCreatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colCreatedAt.FieldName = "CreatedAt";
			this.colCreatedAt.MaxWidth = 120;
			this.colCreatedAt.Name = "colCreatedAt";
			this.colCreatedAt.Visible = true;
			this.colCreatedAt.VisibleIndex = 3;
			this.colCreatedAt.Width = 120;
			// 
			// colUpdatedAt
			// 
			this.colUpdatedAt.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
			this.colUpdatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colUpdatedAt.FieldName = "UpdatedAt";
			this.colUpdatedAt.MaxWidth = 120;
			this.colUpdatedAt.Name = "colUpdatedAt";
			this.colUpdatedAt.Visible = true;
			this.colUpdatedAt.VisibleIndex = 4;
			this.colUpdatedAt.Width = 120;
			// 
			// notesDetailView
			// 
			this.notesDetailView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.notesDetailView.Location = new System.Drawing.Point(0, 0);
			this.notesDetailView.Name = "notesDetailView";
			this.notesDetailView.Size = new System.Drawing.Size(769, 401);
			this.notesDetailView.TabIndex = 0;
			// 
			// NotesListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "NotesListView";
			this.Size = new System.Drawing.Size(769, 436);
			((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
			this.navigationFrame.ResumeLayout(false);
			this.npList.ResumeLayout(false);
			this.npEdit.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lcBase)).EndInit();
			this.lcBase.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pcBase)).EndInit();
			this.pcBase.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lciBase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.riscBase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.notesModelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsImages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsImages1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DevExpress.XtraBars.PopupMenu popupMenu;
		private DevExpress.XtraGrid.GridControl gridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private System.Windows.Forms.BindingSource notesModelBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colTitle;
		private DevExpress.XtraGrid.Columns.GridColumn colText;
		private DevExpress.XtraGrid.Columns.GridColumn colColor;
		private DevExpress.XtraGrid.Columns.GridColumn colUser;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
		private DevExpress.XtraGrid.Columns.GridColumn colUpdatedAt;
		private DevExpress.Xpo.XPBindingSource bsImages;
		private DevExpress.Xpo.XPBindingSource bsImages1;
		private NotesDetailView notesDetailView;
	}
}
