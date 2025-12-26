namespace LifeLog.Forms;

partial class MainForm
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
		ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
		backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
		backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
		backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
		bbiShowSettings = new DevExpress.XtraBars.BarButtonItem();
		bbiCommandsRunner = new DevExpress.XtraBars.BarButtonItem();
		ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
		ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
		ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
		ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
		ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
		barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
		((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
		((System.ComponentModel.ISupportInitialize)backstageViewControl1).BeginInit();
		backstageViewControl1.SuspendLayout();
		SuspendLayout();
		// 
		// ribbon
		// 
		ribbon.ApplicationButtonDropDownControl = backstageViewControl1;
		ribbon.CaptionBarItemLinks.Add(bbiShowSettings);
		ribbon.ExpandCollapseItem.Id = 0;
		ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bbiShowSettings, ribbon.ExpandCollapseItem, bbiCommandsRunner, barButtonItem2 });
		ribbon.Location = new Point(0, 0);
		ribbon.Margin = new Padding(4, 3, 4, 3);
		ribbon.MaxItemId = 5;
		ribbon.Name = "ribbon";
		ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2 });
		ribbon.Size = new Size(1102, 222);
		ribbon.StatusBar = ribbonStatusBar;
		// 
		// backstageViewControl1
		// 
		backstageViewControl1.Controls.Add(backstageViewClientControl1);
		backstageViewControl1.Items.Add(backstageViewTabItem1);
		backstageViewControl1.Location = new Point(248, 250);
		backstageViewControl1.Margin = new Padding(4, 3, 4, 3);
		backstageViewControl1.Name = "backstageViewControl1";
		backstageViewControl1.OwnerControl = ribbon;
		backstageViewControl1.SelectedTab = backstageViewTabItem1;
		backstageViewControl1.SelectedTabIndex = 0;
		backstageViewControl1.Size = new Size(646, 369);
		backstageViewControl1.TabIndex = 2;
		backstageViewControl1.Text = "backstageViewControl1";
		// 
		// backstageViewClientControl1
		// 
		backstageViewClientControl1.Location = new Point(170, 63);
		backstageViewClientControl1.Margin = new Padding(4, 3, 4, 3);
		backstageViewClientControl1.Name = "backstageViewClientControl1";
		backstageViewClientControl1.Size = new Size(475, 305);
		backstageViewClientControl1.TabIndex = 1;
		// 
		// backstageViewTabItem1
		// 
		backstageViewTabItem1.Caption = "Sql Browser";
		backstageViewTabItem1.ContentControl = backstageViewClientControl1;
		backstageViewTabItem1.ImageOptions.ItemNormal.SvgImage = Properties.Resources.selectdatasource;
		backstageViewTabItem1.Name = "backstageViewTabItem1";
		backstageViewTabItem1.Selected = true;
		// 
		// bbiShowSettings
		// 
		bbiShowSettings.Caption = "Settings";
		bbiShowSettings.Id = 2;
		bbiShowSettings.ImageOptions.SvgImage = Properties.Resources.yaxissettings;
		bbiShowSettings.Name = "bbiShowSettings";
		bbiShowSettings.ItemClick += bbiShowSettings_ItemClick;
		// 
		// bbiCommandsRunner
		// 
		bbiCommandsRunner.Caption = "Comnands Runner";
		bbiCommandsRunner.Id = 3;
		bbiCommandsRunner.ImageOptions.SvgImage = Properties.Resources.cli;
		bbiCommandsRunner.Name = "bbiCommandsRunner";
		// 
		// ribbonPage1
		// 
		ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
		ribbonPage1.ImageOptions.SvgImage = Properties.Resources.Home;
		ribbonPage1.Name = "ribbonPage1";
		ribbonPage1.Text = "Home";
		// 
		// ribbonPageGroup1
		// 
		ribbonPageGroup1.ItemLinks.Add(bbiCommandsRunner);
		ribbonPageGroup1.Name = "ribbonPageGroup1";
		ribbonPageGroup1.Text = "Main";
		// 
		// ribbonStatusBar
		// 
		ribbonStatusBar.Location = new Point(0, 624);
		ribbonStatusBar.Margin = new Padding(4, 3, 4, 3);
		ribbonStatusBar.Name = "ribbonStatusBar";
		ribbonStatusBar.Ribbon = ribbon;
		ribbonStatusBar.Size = new Size(1102, 39);
		// 
		// ribbonPage2
		// 
		ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
		ribbonPage2.Name = "ribbonPage2";
		ribbonPage2.Text = "ribbonPage2";
		// 
		// ribbonPageGroup2
		// 
		ribbonPageGroup2.ItemLinks.Add(barButtonItem2);
		ribbonPageGroup2.Name = "ribbonPageGroup2";
		ribbonPageGroup2.Text = "ribbonPageGroup2";
		// 
		// barButtonItem2
		// 
		barButtonItem2.Caption = "barButtonItem2";
		barButtonItem2.Id = 4;
		barButtonItem2.ImageOptions.SvgImage = Properties.Resources.actions_refresh;
		barButtonItem2.Name = "barButtonItem2";
		// 
		// MainForm
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1102, 663);
		Controls.Add(backstageViewControl1);
		Controls.Add(ribbonStatusBar);
		Controls.Add(ribbon);
		Margin = new Padding(4, 3, 4, 3);
		Name = "MainForm";
		Ribbon = ribbon;
		StatusBar = ribbonStatusBar;
		Text = "Mainorm";
		((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
		((System.ComponentModel.ISupportInitialize)backstageViewControl1).EndInit();
		backstageViewControl1.ResumeLayout(false);
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
	private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
	private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
	private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
	private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
	private Views.Sql.SqlBrowserView sqlBrowserView1;
	private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
	private DevExpress.XtraBars.BarButtonItem bbiShowSettings;
	private DevExpress.XtraBars.BarButtonItem barButtonItem1;
	private DevExpress.XtraBars.BarButtonItem bbiCommandsRunner;
	private DevExpress.XtraBars.BarButtonItem barButtonItem2;
	private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
	private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
}