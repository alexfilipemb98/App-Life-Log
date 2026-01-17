namespace LifeLog.Forms;

partial class SettingsView
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
        backstageViewControl = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
        backstageViewClientControl4 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        modulesSettingView1 = new LifeLog.Views.Settings.ModulesSettingView();
        backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        sqlBrowserView1 = new LifeLog.Views.Sql.SqlBrowserView();
        backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        navigationPaneEx = new LifeLog.Components.NavigationPaneEx();
        navigationPageExternalPrograms = new LifeLog.Components.NavigationPageEx();
        externalProgramsList = new LifeLog.Views.ExternalPrograms.ExternalProgramsList();
        backstageViewClientControl5 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        appSettingsView1 = new LifeLog.Views.Settings.AppSettingsView();
        backstageViewClientControl3 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        backstageViewTabItem5 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        backstageViewTabItem4 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        backstageViewItemSeparator2 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
        backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        backstageViewTabItem2 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        backstageViewTabItem3 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        backstageViewClientControl6 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        backstageViewTabItem6 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        databaseSettingsView = new LifeLog.Views.Settings.DatabaseSettingsView();
        ((System.ComponentModel.ISupportInitialize)backstageViewControl).BeginInit();
        backstageViewControl.SuspendLayout();
        backstageViewClientControl4.SuspendLayout();
        backstageViewClientControl1.SuspendLayout();
        backstageViewClientControl2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)navigationPaneEx).BeginInit();
        navigationPaneEx.SuspendLayout();
        navigationPageExternalPrograms.SuspendLayout();
        backstageViewClientControl5.SuspendLayout();
        backstageViewClientControl6.SuspendLayout();
        SuspendLayout();
        // 
        // backstageViewControl
        // 
        backstageViewControl.Controls.Add(backstageViewClientControl5);
        backstageViewControl.Controls.Add(backstageViewClientControl4);
        backstageViewControl.Controls.Add(backstageViewClientControl1);
        backstageViewControl.Controls.Add(backstageViewClientControl2);
        backstageViewControl.Controls.Add(backstageViewClientControl6);
        backstageViewControl.Controls.Add(backstageViewClientControl3);
        backstageViewControl.Dock = DockStyle.Fill;
        backstageViewControl.Items.Add(backstageViewTabItem5);
        backstageViewControl.Items.Add(backstageViewTabItem4);
        backstageViewControl.Items.Add(backstageViewItemSeparator2);
        backstageViewControl.Items.Add(backstageViewTabItem6);
        backstageViewControl.Items.Add(backstageViewTabItem1);
        backstageViewControl.Items.Add(backstageViewTabItem2);
        backstageViewControl.Items.Add(backstageViewTabItem3);
        backstageViewControl.LeftPaneMinWidth = 170;
        backstageViewControl.Location = new Point(0, 0);
        backstageViewControl.Name = "backstageViewControl";
        backstageViewControl.SelectedTab = backstageViewTabItem6;
        backstageViewControl.SelectedTabIndex = 3;
        backstageViewControl.Size = new Size(1005, 612);
        backstageViewControl.TabIndex = 3;
        backstageViewControl.Text = "backstageViewControl1";
        backstageViewControl.SelectedTabChanged += backstageViewControl_SelectedTabChanged;
        // 
        // backstageViewClientControl4
        // 
        backstageViewClientControl4.Controls.Add(modulesSettingView1);
        backstageViewClientControl4.Location = new Point(170, 0);
        backstageViewClientControl4.Name = "backstageViewClientControl4";
        backstageViewClientControl4.Size = new Size(835, 612);
        backstageViewClientControl4.TabIndex = 4;
        // 
        // modulesSettingView1
        // 
        modulesSettingView1.Dock = DockStyle.Fill;
        modulesSettingView1.Location = new Point(0, 0);
        modulesSettingView1.Name = "modulesSettingView1";
        modulesSettingView1.Size = new Size(835, 612);
        modulesSettingView1.TabIndex = 0;
        // 
        // backstageViewClientControl1
        // 
        backstageViewClientControl1.Controls.Add(sqlBrowserView1);
        backstageViewClientControl1.Location = new Point(170, 0);
        backstageViewClientControl1.Name = "backstageViewClientControl1";
        backstageViewClientControl1.Size = new Size(835, 612);
        backstageViewClientControl1.TabIndex = 1;
        // 
        // sqlBrowserView1
        // 
        sqlBrowserView1.Dock = DockStyle.Fill;
        sqlBrowserView1.Location = new Point(0, 0);
        sqlBrowserView1.Margin = new Padding(3, 2, 3, 2);
        sqlBrowserView1.Name = "sqlBrowserView1";
        sqlBrowserView1.Size = new Size(835, 612);
        sqlBrowserView1.TabIndex = 0;
        // 
        // backstageViewClientControl2
        // 
        backstageViewClientControl2.Controls.Add(navigationPaneEx);
        backstageViewClientControl2.Location = new Point(170, 0);
        backstageViewClientControl2.Name = "backstageViewClientControl2";
        backstageViewClientControl2.Size = new Size(835, 612);
        backstageViewClientControl2.TabIndex = 2;
        // 
        // navigationPaneEx
        // 
        navigationPaneEx.Controls.Add(navigationPageExternalPrograms);
        navigationPaneEx.Dock = DockStyle.Fill;
        navigationPaneEx.Location = new Point(0, 0);
        navigationPaneEx.Name = "navigationPaneEx";
        navigationPaneEx.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { navigationPageExternalPrograms });
        navigationPaneEx.RegularSize = new Size(858, 612);
        navigationPaneEx.SelectedPage = navigationPageExternalPrograms;
        navigationPaneEx.Size = new Size(835, 612);
        navigationPaneEx.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Expanded;
        navigationPaneEx.TabIndex = 0;
        navigationPaneEx.Text = "navigationPaneEx1";
        // 
        // navigationPageExternalPrograms
        // 
        navigationPageExternalPrograms.BackgroundPadding = new Padding(0);
        navigationPageExternalPrograms.Caption = "ExternalPrograms";
        navigationPageExternalPrograms.Controls.Add(externalProgramsList);
        navigationPageExternalPrograms.Name = "navigationPageExternalPrograms";
        navigationPageExternalPrograms.Size = new Size(699, 612);
        // 
        // externalProgramsList
        // 
        externalProgramsList.Dock = DockStyle.Fill;
        externalProgramsList.Location = new Point(0, 0);
        externalProgramsList.Name = "externalProgramsList";
        externalProgramsList.Size = new Size(699, 612);
        externalProgramsList.TabIndex = 0;
        // 
        // backstageViewClientControl5
        // 
        backstageViewClientControl5.Controls.Add(appSettingsView1);
        backstageViewClientControl5.Location = new Point(170, 0);
        backstageViewClientControl5.Name = "backstageViewClientControl5";
        backstageViewClientControl5.Size = new Size(835, 612);
        backstageViewClientControl5.TabIndex = 5;
        // 
        // appSettingsView1
        // 
        appSettingsView1.Dock = DockStyle.Fill;
        appSettingsView1.Location = new Point(0, 0);
        appSettingsView1.Name = "appSettingsView1";
        appSettingsView1.Size = new Size(835, 612);
        appSettingsView1.TabIndex = 0;
        // 
        // backstageViewClientControl3
        // 
        backstageViewClientControl3.Location = new Point(170, 0);
        backstageViewClientControl3.Name = "backstageViewClientControl3";
        backstageViewClientControl3.Size = new Size(835, 612);
        backstageViewClientControl3.TabIndex = 3;
        // 
        // backstageViewTabItem5
        // 
        backstageViewTabItem5.Caption = "App";
        backstageViewTabItem5.ContentControl = backstageViewClientControl5;
        backstageViewTabItem5.ImageOptions.ItemNormal.SvgImage = Properties.Resources.bo_address;
        backstageViewTabItem5.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        backstageViewTabItem5.Name = "backstageViewTabItem5";
        // 
        // backstageViewTabItem4
        // 
        backstageViewTabItem4.Caption = "Modules";
        backstageViewTabItem4.ContentControl = backstageViewClientControl4;
        backstageViewTabItem4.ImageOptions.ItemNormal.SvgImage = Properties.Resources.bo_security_permission_model;
        backstageViewTabItem4.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        backstageViewTabItem4.Name = "backstageViewTabItem4";
        // 
        // backstageViewItemSeparator2
        // 
        backstageViewItemSeparator2.Name = "backstageViewItemSeparator2";
        // 
        // backstageViewTabItem1
        // 
        backstageViewTabItem1.AppearanceHover.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        backstageViewTabItem1.AppearanceHover.Options.UseFont = true;
        backstageViewTabItem1.AppearanceSelected.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        backstageViewTabItem1.AppearanceSelected.Options.UseFont = true;
        backstageViewTabItem1.Caption = "Sql Run";
        backstageViewTabItem1.ContentControl = backstageViewClientControl1;
        backstageViewTabItem1.ImageOptions.ItemNormal.SvgImage = Properties.Resources.selectdatasource;
        backstageViewTabItem1.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        backstageViewTabItem1.Name = "backstageViewTabItem1";
        // 
        // backstageViewTabItem2
        // 
        backstageViewTabItem2.AppearanceHover.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        backstageViewTabItem2.AppearanceHover.Options.UseFont = true;
        backstageViewTabItem2.AppearanceSelected.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        backstageViewTabItem2.AppearanceSelected.Options.UseFont = true;
        backstageViewTabItem2.Caption = "Data";
        backstageViewTabItem2.ContentControl = backstageViewClientControl2;
        backstageViewTabItem2.ImageOptions.ItemNormal.SvgImage = Properties.Resources.actions_database;
        backstageViewTabItem2.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        backstageViewTabItem2.Name = "backstageViewTabItem2";
        // 
        // backstageViewTabItem3
        // 
        backstageViewTabItem3.Alignment = DevExpress.XtraBars.Ribbon.BackstageViewItemAlignment.Bottom;
        backstageViewTabItem3.AppearanceHover.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        backstageViewTabItem3.AppearanceHover.Options.UseFont = true;
        backstageViewTabItem3.AppearanceSelected.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        backstageViewTabItem3.AppearanceSelected.Options.UseFont = true;
        backstageViewTabItem3.Caption = "About";
        backstageViewTabItem3.ContentControl = backstageViewClientControl3;
        backstageViewTabItem3.ImageOptions.ItemNormal.SvgImage = Properties.Resources.about;
        backstageViewTabItem3.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        backstageViewTabItem3.Name = "backstageViewTabItem3";
        // 
        // backstageViewClientControl6
        // 
        backstageViewClientControl6.Controls.Add(databaseSettingsView);
        backstageViewClientControl6.Location = new Point(170, 0);
        backstageViewClientControl6.Name = "backstageViewClientControl6";
        backstageViewClientControl6.Size = new Size(835, 612);
        backstageViewClientControl6.TabIndex = 6;
        // 
        // backstageViewTabItem6
        // 
        backstageViewTabItem6.AppearanceHover.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        backstageViewTabItem6.AppearanceHover.Options.UseFont = true;
        backstageViewTabItem6.AppearanceSelected.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        backstageViewTabItem6.AppearanceSelected.Options.UseFont = true;
        backstageViewTabItem6.Caption = "Database";
        backstageViewTabItem6.ContentControl = backstageViewClientControl6;
        backstageViewTabItem6.ImageOptions.ItemNormal.SvgImage = Properties.Resources.editdatasource;
        backstageViewTabItem6.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        backstageViewTabItem6.Name = "backstageViewTabItem6";
        backstageViewTabItem6.Selected = true;
        // 
        // databaseSettingsView
        // 
        databaseSettingsView.Dock = DockStyle.Fill;
        databaseSettingsView.Location = new Point(0, 0);
        databaseSettingsView.Margin = new Padding(3, 2, 3, 2);
        databaseSettingsView.Name = "databaseSettingsView";
        databaseSettingsView.Size = new Size(835, 612);
        databaseSettingsView.TabIndex = 0;
        // 
        // SettingsView
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(backstageViewControl);
        Name = "SettingsView";
        Size = new Size(1005, 612);
        ((System.ComponentModel.ISupportInitialize)backstageViewControl).EndInit();
        backstageViewControl.ResumeLayout(false);
        backstageViewClientControl4.ResumeLayout(false);
        backstageViewClientControl1.ResumeLayout(false);
        backstageViewClientControl2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)navigationPaneEx).EndInit();
        navigationPaneEx.ResumeLayout(false);
        navigationPageExternalPrograms.ResumeLayout(false);
        backstageViewClientControl5.ResumeLayout(false);
        backstageViewClientControl6.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    public DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl3;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem2;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem3;
    private Views.Sql.SqlBrowserView sqlBrowserView1;
    private Components.NavigationPaneEx navigationPaneEx;
    private Components.NavigationPageEx navigationPageExternalPrograms;
    private Views.ExternalPrograms.ExternalProgramsList externalProgramsList;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl4;
    private Views.Settings.ModulesSettingView modulesSettingView1;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem4;
    private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator2;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl5;
    private Views.Settings.AppSettingsView appSettingsView1;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem5;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl6;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem6;
    private Views.Settings.DatabaseSettingsView databaseSettingsView;
}
