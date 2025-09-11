namespace LifeLog.UI.FrontEnd.Views.Settings
{
	partial class ModulesSetting
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
			this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
			this.bbiRunAdmin = new DevExpress.XtraBars.BarButtonItem();
			this.bbiEnable = new DevExpress.XtraBars.BarButtonItem();
			this.bbiCreateFile = new DevExpress.XtraBars.BarButtonItem();
			this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.toggleSwitch11 = new DevExpress.XtraEditors.ToggleSwitch();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.toggleSwitch111 = new DevExpress.XtraEditors.ToggleSwitch();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch11.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch111.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.barButtonItem1});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar1.OptionsBar.DrawBorder = false;
			this.bar1.OptionsBar.DrawDragBorder = false;
			this.bar1.OptionsBar.MinHeight = 35;
			this.bar1.OptionsBar.MultiLine = true;
			this.bar1.OptionsBar.UseWholeRow = true;
			this.bar1.Text = "Main menu";
			// 
			// repositoryItemSearchControl1
			// 
			this.repositoryItemSearchControl1.AutoHeight = false;
			this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
			this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "Save";
			this.barButtonItem1.Id = 11;
			this.barButtonItem1.ImageOptions.SvgImage = global::LifeLog.UI.FrontEnd.Properties.Resources.saveall;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// barDockControl1
			// 
			this.barDockControl1.CausesValidation = false;
			this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControl1.Location = new System.Drawing.Point(0, 0);
			this.barDockControl1.Manager = this.barManager;
			this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControl1.Size = new System.Drawing.Size(959, 35);
			// 
			// barDockControl2
			// 
			this.barDockControl2.CausesValidation = false;
			this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControl2.Location = new System.Drawing.Point(0, 603);
			this.barDockControl2.Manager = this.barManager;
			this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControl2.Size = new System.Drawing.Size(959, 0);
			// 
			// barDockControl3
			// 
			this.barDockControl3.CausesValidation = false;
			this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControl3.Location = new System.Drawing.Point(0, 35);
			this.barDockControl3.Manager = this.barManager;
			this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControl3.Size = new System.Drawing.Size(0, 568);
			// 
			// barDockControl4
			// 
			this.barDockControl4.CausesValidation = false;
			this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControl4.Location = new System.Drawing.Point(959, 35);
			this.barDockControl4.Manager = this.barManager;
			this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControl4.Size = new System.Drawing.Size(0, 568);
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
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.toggleSwitch1);
			this.layoutControl1.Controls.Add(this.toggleSwitch11);
			this.layoutControl1.Controls.Add(this.toggleSwitch111);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 35);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(959, 568);
			this.layoutControl1.TabIndex = 4;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(959, 568);
			this.Root.TextVisible = false;
			// 
			// toggleSwitch1
			// 
			this.toggleSwitch1.AutoSizeInLayoutControl = true;
			this.toggleSwitch1.Location = new System.Drawing.Point(38, 91);
			this.toggleSwitch1.MenuManager = this.barManager;
			this.toggleSwitch1.Name = "toggleSwitch1";
			this.toggleSwitch1.Properties.AutoWidth = true;
			this.toggleSwitch1.Properties.OffText = "Off";
			this.toggleSwitch1.Properties.OnText = "On";
			this.toggleSwitch1.Properties.ShowText = false;
			this.toggleSwitch1.Size = new System.Drawing.Size(50, 18);
			this.toggleSwitch1.StyleController = this.layoutControl1;
			this.toggleSwitch1.TabIndex = 4;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
			this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.layoutControlItem1.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.layoutControlItem1.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
			this.layoutControlItem1.Control = this.toggleSwitch1;
			this.layoutControlItem1.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
			this.layoutControlItem1.ImageOptions.SvgImage = global::LifeLog.UI.FrontEnd.Properties.Resources.inserttextbox;
			this.layoutControlItem1.ImageOptions.SvgImageSize = new System.Drawing.Size(34, 34);
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(100, 77);
			this.layoutControlItem1.Text = "Notes";
			this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 52);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 104);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(939, 444);
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem3});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Size = new System.Drawing.Size(939, 104);
			this.layoutControlGroup1.Text = "Home Group";
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.Location = new System.Drawing.Point(300, 0);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(633, 77);
			// 
			// toggleSwitch11
			// 
			this.toggleSwitch11.AutoSizeInLayoutControl = true;
			this.toggleSwitch11.Location = new System.Drawing.Point(138, 91);
			this.toggleSwitch11.Name = "toggleSwitch11";
			this.toggleSwitch11.Properties.AutoWidth = true;
			this.toggleSwitch11.Properties.OffText = "Off";
			this.toggleSwitch11.Properties.OnText = "On";
			this.toggleSwitch11.Properties.ShowText = false;
			this.toggleSwitch11.Size = new System.Drawing.Size(50, 18);
			this.toggleSwitch11.StyleController = this.layoutControl1;
			this.toggleSwitch11.TabIndex = 4;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
			this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.layoutControlItem2.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
			this.layoutControlItem2.Control = this.toggleSwitch11;
			this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.layoutControlItem2.CustomizationFormText = "Notes";
			this.layoutControlItem2.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
			this.layoutControlItem2.ImageOptions.SvgImage = global::LifeLog.UI.FrontEnd.Properties.Resources.cli;
			this.layoutControlItem2.ImageOptions.SvgImageSize = new System.Drawing.Size(34, 34);
			this.layoutControlItem2.Location = new System.Drawing.Point(100, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(100, 77);
			this.layoutControlItem2.Text = " Commands Runner ";
			this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 52);
			// 
			// toggleSwitch111
			// 
			this.toggleSwitch111.AutoSizeInLayoutControl = true;
			this.toggleSwitch111.Location = new System.Drawing.Point(238, 91);
			this.toggleSwitch111.Name = "toggleSwitch111";
			this.toggleSwitch111.Properties.AutoWidth = true;
			this.toggleSwitch111.Properties.OffText = "Off";
			this.toggleSwitch111.Properties.OnText = "On";
			this.toggleSwitch111.Properties.ShowText = false;
			this.toggleSwitch111.Size = new System.Drawing.Size(50, 18);
			this.toggleSwitch111.StyleController = this.layoutControl1;
			this.toggleSwitch111.TabIndex = 4;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
			this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.layoutControlItem3.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.layoutControlItem3.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
			this.layoutControlItem3.Control = this.toggleSwitch111;
			this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.layoutControlItem3.CustomizationFormText = "Notes";
			this.layoutControlItem3.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter;
			this.layoutControlItem3.ImageOptions.SvgImage = global::LifeLog.UI.FrontEnd.Properties.Resources.security_key;
			this.layoutControlItem3.ImageOptions.SvgImageSize = new System.Drawing.Size(34, 34);
			this.layoutControlItem3.Location = new System.Drawing.Point(200, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(100, 77);
			this.layoutControlItem3.Text = "Passwords";
			this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem3.TextSize = new System.Drawing.Size(96, 52);
			// 
			// ModulesSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControl3);
			this.Controls.Add(this.barDockControl4);
			this.Controls.Add(this.barDockControl2);
			this.Controls.Add(this.barDockControl1);
			this.Name = "ModulesSetting";
			this.Size = new System.Drawing.Size(959, 603);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch11.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitch111.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
		private DevExpress.XtraBars.BarDockControl barDockControl1;
		private DevExpress.XtraBars.BarDockControl barDockControl2;
		private DevExpress.XtraBars.BarDockControl barDockControl3;
		private DevExpress.XtraBars.BarDockControl barDockControl4;
		private DevExpress.XtraBars.BarButtonItem bbiRunAdmin;
		private DevExpress.XtraBars.BarButtonItem bbiEnable;
		private DevExpress.XtraBars.BarButtonItem bbiCreateFile;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraEditors.ToggleSwitch toggleSwitch11;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.ToggleSwitch toggleSwitch111;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
	}
}
