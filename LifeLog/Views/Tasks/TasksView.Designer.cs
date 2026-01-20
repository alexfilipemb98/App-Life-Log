namespace LifeLog.Views.Tasks
{
	partial class TasksView
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
			this.gcTasks = new DevExpress.XtraGrid.GridControl();
			this.tasksModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gvTasks = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsDone = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUpdatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.lcTextsTasks = new DevExpress.XtraEditors.LabelControl();
			this.pbcTotal = new DevExpress.XtraEditors.ProgressBarControl();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar = new DevExpress.XtraBars.Bar();
			this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
			this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.gcTasks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tasksModelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvTasks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbcTotal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// gcTasks
			// 
			this.gcTasks.DataSource = this.tasksModelBindingSource;
			this.gcTasks.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.gcTasks.Location = new System.Drawing.Point(8, 105);
			this.gcTasks.MainView = this.gvTasks;
			this.gcTasks.Margin = new System.Windows.Forms.Padding(4);
			this.gcTasks.Name = "gcTasks";
			this.gcTasks.Size = new System.Drawing.Size(847, 483);
			this.gcTasks.TabIndex = 0;
			this.gcTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTasks});
			// 
			// tasksModelBindingSource
			// 
			this.tasksModelBindingSource.DataSource = typeof(LifeLog.Data.Entities.Todo);
			// 
			// gvTasks
			// 
			this.gvTasks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription,
            this.colIsDone,
            this.colId,
            this.colCreatedAt,
            this.colUpdatedAt});
			this.gvTasks.DetailHeight = 431;
			this.gvTasks.GridControl = this.gcTasks;
			this.gvTasks.Name = "gvTasks";
			this.gvTasks.OptionsEditForm.PopupEditFormWidth = 933;
			this.gvTasks.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
			this.gvTasks.OptionsView.ShowGroupPanel = false;
			this.gvTasks.OptionsView.ShowIndicator = false;
			this.gvTasks.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvTasks_InitNewRow);
			this.gvTasks.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvTasks_RowUpdated);
			// 
			// colDescription
			// 
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 1;
			this.colDescription.Width = 492;
			// 
			// colIsDone
			// 
			this.colIsDone.Caption = "Done";
			this.colIsDone.FieldName = "IsDone";
			this.colIsDone.Name = "colIsDone";
			this.colIsDone.Visible = true;
			this.colIsDone.VisibleIndex = 0;
			this.colIsDone.Width = 55;
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
			this.colCreatedAt.Name = "colCreatedAt";
			this.colCreatedAt.Width = 153;
			// 
			// colUpdatedAt
			// 
			this.colUpdatedAt.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
			this.colUpdatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colUpdatedAt.FieldName = "UpdatedAt";
			this.colUpdatedAt.Name = "colUpdatedAt";
			this.colUpdatedAt.Width = 139;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.lcTextsTasks);
			this.layoutControl1.Controls.Add(this.pbcTotal);
			this.layoutControl1.Controls.Add(this.gcTasks);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 39);
			this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(863, 596);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// lcTextsTasks
			// 
			this.lcTextsTasks.AllowHtmlString = true;
			this.lcTextsTasks.Location = new System.Drawing.Point(772, 48);
			this.lcTextsTasks.Margin = new System.Windows.Forms.Padding(4);
			this.lcTextsTasks.Name = "lcTextsTasks";
			this.lcTextsTasks.Size = new System.Drawing.Size(80, 16);
			this.lcTextsTasks.StyleController = this.layoutControl1;
			this.lcTextsTasks.TabIndex = 5;
			this.lcTextsTasks.Text = "<b> 1 / 4 </b> (25%)";
			// 
			// pbcTotal
			// 
			this.pbcTotal.Location = new System.Drawing.Point(11, 48);
			this.pbcTotal.Margin = new System.Windows.Forms.Padding(4);
			this.pbcTotal.MenuManager = this.barManager;
			this.pbcTotal.Name = "pbcTotal";
			this.pbcTotal.Size = new System.Drawing.Size(755, 16);
			this.pbcTotal.StyleController = this.layoutControl1;
			this.pbcTotal.TabIndex = 4;
			// 
			// barManager
			// 
			this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar});
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiRefresh,
            this.bbiSave});
			this.barManager.MainMenu = this.bar;
			this.barManager.MaxItemId = 4;
			// 
			// bar
			// 
			this.bar.BarName = "Main menu";
			this.bar.DockCol = 0;
			this.bar.DockRow = 0;
			this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSave, "", true, true, false, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar.OptionsBar.AllowQuickCustomization = false;
			this.bar.OptionsBar.DisableCustomization = true;
			this.bar.OptionsBar.DrawBorder = false;
			this.bar.OptionsBar.DrawDragBorder = false;
			this.bar.OptionsBar.MultiLine = true;
			this.bar.OptionsBar.UseWholeRow = true;
			this.bar.Text = "Main menu";
			// 
			// bbiRefresh
			// 
			this.bbiRefresh.Caption = "Refresh";
			this.bbiRefresh.Id = 0;
			this.bbiRefresh.ImageOptions.SvgImage = global::LifeLog.Properties.Resources.actions_refresh;
			this.bbiRefresh.Name = "bbiRefresh";
			this.bbiRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
			// 
			// bbiSave
			// 
			this.bbiSave.Caption = "Save";
			this.bbiSave.Id = 3;
			this.bbiSave.ImageOptions.SvgImage = global::LifeLog.Properties.Resources.saveall;
			this.bbiSave.Name = "bbiSave";
			// 
			// barBaseDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlTop.Size = new System.Drawing.Size(863, 39);
			// 
			// barBaseDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 635);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlBottom.Size = new System.Drawing.Size(863, 0);
			// 
			// barBaseDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 596);
			// 
			// barBaseDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(863, 39);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 596);
			// 
			// BaseRoot
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
			this.Root.Name = "Root";
			this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 5);
			this.Root.Size = new System.Drawing.Size(863, 596);
			this.Root.TextVisible = false;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 60);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Size = new System.Drawing.Size(853, 521);
			this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Text = "Tasks";
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gcTasks;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(853, 489);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup2.Size = new System.Drawing.Size(853, 60);
			this.layoutControlGroup2.Text = "Progress";
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.lcTextsTasks;
			this.layoutControlItem3.Location = new System.Drawing.Point(761, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(86, 22);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.pbcTotal;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(761, 22);
			this.layoutControlItem2.TextVisible = false;
			// 
			// TasksView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TasksView";
			this.Size = new System.Drawing.Size(863, 635);
			((System.ComponentModel.ISupportInitialize)(this.gcTasks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tasksModelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvTasks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbcTotal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gcTasks;
		private DevExpress.XtraGrid.Views.Grid.GridView gvTasks;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.Bar bar;
		private DevExpress.XtraBars.BarButtonItem bbiRefresh;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private System.Windows.Forms.BindingSource tasksModelBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colIsDone;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colCreatedAt;
		private DevExpress.XtraGrid.Columns.GridColumn colUpdatedAt;
		private DevExpress.XtraEditors.LabelControl lcTextsTasks;
		private DevExpress.XtraEditors.ProgressBarControl pbcTotal;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraBars.BarButtonItem bbiSave;
	}
}
