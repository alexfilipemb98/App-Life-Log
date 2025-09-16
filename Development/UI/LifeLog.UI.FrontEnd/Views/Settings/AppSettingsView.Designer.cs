namespace LifeLog.UI.FrontEnd.Views.Settings
{
	partial class AppSettingsView
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
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
			this.bbiRunAdmin = new DevExpress.XtraBars.BarButtonItem();
			this.bbiEnable = new DevExpress.XtraBars.BarButtonItem();
			this.bbiCreateFile = new DevExpress.XtraBars.BarButtonItem();
			this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager
			// 
			this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
			this.barManager.DockControls.Add(this.barDockControl1);
			this.barManager.DockControls.Add(this.barDockControl2);
			this.barManager.DockControls.Add(this.barDockControl3);
			this.barManager.DockControls.Add(this.barDockControl4);
			this.barManager.Form = this;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiRunAdmin,
            this.bbiEnable,
            this.bbiCreateFile,
            this.bbiGuardar});
			this.barManager.MainMenu = this.bar1;
			this.barManager.MaxItemId = 12;
			this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2,
            this.repositoryItemSearchControl1});
			// 
			// bar1
			// 
			this.bar1.BarName = "Main menu";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiGuardar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar1.OptionsBar.DrawBorder = false;
			this.bar1.OptionsBar.DrawDragBorder = false;
			this.bar1.OptionsBar.MinHeight = 35;
			this.bar1.OptionsBar.MultiLine = true;
			this.bar1.OptionsBar.UseWholeRow = true;
			this.bar1.Text = "Main menu";
			// 
			// bbiGuardar
			// 
			this.bbiGuardar.Caption = "Save";
			this.bbiGuardar.Id = 11;
			this.bbiGuardar.ImageOptions.SvgImage = global::LifeLog.Base.Assets.Resources.saveall;
			this.bbiGuardar.Name = "bbiGuardar";
			// 
			// barDockControl1
			// 
			this.barDockControl1.CausesValidation = false;
			this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControl1.Location = new System.Drawing.Point(0, 0);
			this.barDockControl1.Manager = this.barManager;
			this.barDockControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.barDockControl1.Size = new System.Drawing.Size(1001, 44);
			// 
			// barDockControl2
			// 
			this.barDockControl2.CausesValidation = false;
			this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControl2.Location = new System.Drawing.Point(0, 629);
			this.barDockControl2.Manager = this.barManager;
			this.barDockControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.barDockControl2.Size = new System.Drawing.Size(1001, 0);
			// 
			// barDockControl3
			// 
			this.barDockControl3.CausesValidation = false;
			this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControl3.Location = new System.Drawing.Point(0, 44);
			this.barDockControl3.Manager = this.barManager;
			this.barDockControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.barDockControl3.Size = new System.Drawing.Size(0, 585);
			// 
			// barDockControl4
			// 
			this.barDockControl4.CausesValidation = false;
			this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControl4.Location = new System.Drawing.Point(1001, 44);
			this.barDockControl4.Manager = this.barManager;
			this.barDockControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.barDockControl4.Size = new System.Drawing.Size(0, 585);
			// 
			// bbiRunAdmin
			// 
			this.bbiRunAdmin.Caption = "Run Admin";
			this.bbiRunAdmin.Id = 6;
			this.bbiRunAdmin.Name = "bbiRunAdmin";
			// 
			// bbiEnable
			// 
			this.bbiEnable.Caption = "Disable";
			this.bbiEnable.Id = 7;
			this.bbiEnable.Name = "bbiEnable";
			// 
			// bbiCreateFile
			// 
			this.bbiCreateFile.Caption = "Create File";
			this.bbiCreateFile.Id = 10;
			this.bbiCreateFile.Name = "bbiCreateFile";
			// 
			// repositoryItemTextEdit2
			// 
			this.repositoryItemTextEdit2.AutoHeight = false;
			this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
			// 
			// repositoryItemSearchControl1
			// 
			this.repositoryItemSearchControl1.AutoHeight = false;
			this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
			this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
			// 
			// AppSettingsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.barDockControl3);
			this.Controls.Add(this.barDockControl4);
			this.Controls.Add(this.barDockControl2);
			this.Controls.Add(this.barDockControl1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "AppSettingsView";
			this.Size = new System.Drawing.Size(1001, 629);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.BarButtonItem bbiGuardar;
		private DevExpress.XtraBars.BarDockControl barDockControl1;
		private DevExpress.XtraBars.BarDockControl barDockControl2;
		private DevExpress.XtraBars.BarDockControl barDockControl3;
		private DevExpress.XtraBars.BarDockControl barDockControl4;
		private DevExpress.XtraBars.BarButtonItem bbiRunAdmin;
		private DevExpress.XtraBars.BarButtonItem bbiEnable;
		private DevExpress.XtraBars.BarButtonItem bbiCreateFile;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
	}
}
