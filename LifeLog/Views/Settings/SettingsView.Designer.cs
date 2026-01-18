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
        backstageViewClientControl5 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        appSettingsView1 = new LifeLog.Views.Settings.AppSettingsView();
        backstageViewClientControl4 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        modulesSettingView1 = new LifeLog.Views.Settings.ModulesSettingView();
        backstageViewClientControl6 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        databaseSettingsView = new LifeLog.Views.Settings.DatabaseSettingsView();
        backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        sqlBrowserView1 = new LifeLog.Views.Sql.SqlBrowserView();
        backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        navigationPaneEx = new LifeLog.Components.NavigationPaneEx();
        npExternalPrograms = new LifeLog.Components.NavigationPageEx();
        externalProgramsList = new LifeLog.Views.ExternalPrograms.ExternalProgramsList();
        backstageViewClientControl3 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        bvtiApp = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        bvtiModules = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        backstageViewItemSeparator2 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
        bvtiDatabase = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        bvtiSqlRun = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        bvtiData = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        bvtiInfo = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        ((System.ComponentModel.ISupportInitialize)backstageViewControl).BeginInit();
        backstageViewControl.SuspendLayout();
        backstageViewClientControl5.SuspendLayout();
        backstageViewClientControl4.SuspendLayout();
        backstageViewClientControl6.SuspendLayout();
        backstageViewClientControl1.SuspendLayout();
        backstageViewClientControl2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)navigationPaneEx).BeginInit();
        navigationPaneEx.SuspendLayout();
        npExternalPrograms.SuspendLayout();
        SuspendLayout();
        // 
        // backstageViewControl
        // 
        backstageViewControl.Controls.Add(backstageViewClientControl5);
        backstageViewControl.Controls.Add(backstageViewClientControl4);
        backstageViewControl.Controls.Add(backstageViewClientControl6);
        backstageViewControl.Controls.Add(backstageViewClientControl1);
        backstageViewControl.Controls.Add(backstageViewClientControl2);
        backstageViewControl.Controls.Add(backstageViewClientControl3);
        backstageViewControl.Dock = DockStyle.Fill;
        backstageViewControl.Items.Add(bvtiApp);
        backstageViewControl.Items.Add(bvtiModules);
        backstageViewControl.Items.Add(backstageViewItemSeparator2);
        backstageViewControl.Items.Add(bvtiDatabase);
        backstageViewControl.Items.Add(bvtiSqlRun);
        backstageViewControl.Items.Add(bvtiData);
        backstageViewControl.Items.Add(bvtiInfo);
        backstageViewControl.LeftPaneMinWidth = 170;
        backstageViewControl.Location = new Point(0, 0);
        backstageViewControl.Name = "backstageViewControl";
        backstageViewControl.SelectedTab = bvtiData;
        backstageViewControl.SelectedTabIndex = 5;
        backstageViewControl.Size = new Size(1005, 612);
        backstageViewControl.TabIndex = 3;
        backstageViewControl.Text = "backstageViewControl1";
        backstageViewControl.SelectedTabChanged += backstageViewControl_SelectedTabChanged;
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
        // backstageViewClientControl6
        // 
        backstageViewClientControl6.Controls.Add(databaseSettingsView);
        backstageViewClientControl6.Location = new Point(170, 0);
        backstageViewClientControl6.Name = "backstageViewClientControl6";
        backstageViewClientControl6.Size = new Size(835, 612);
        backstageViewClientControl6.TabIndex = 6;
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
        navigationPaneEx.Controls.Add(npExternalPrograms);
        navigationPaneEx.Dock = DockStyle.Fill;
        navigationPaneEx.Location = new Point(0, 0);
        navigationPaneEx.Name = "navigationPaneEx";
        navigationPaneEx.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { npExternalPrograms });
        navigationPaneEx.RegularSize = new Size(858, 612);
        navigationPaneEx.SelectedPage = npExternalPrograms;
        navigationPaneEx.Size = new Size(835, 612);
        navigationPaneEx.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Expanded;
        navigationPaneEx.TabIndex = 0;
        navigationPaneEx.Text = "navigationPaneEx1";
        navigationPaneEx.SelectedPageChanged += navigationPaneEx_SelectedPageChanged;
        // 
        // npExternalPrograms
        // 
        npExternalPrograms.BackgroundPadding = new Padding(0);
        npExternalPrograms.Caption = "ExternalPrograms";
        npExternalPrograms.Controls.Add(externalProgramsList);
        npExternalPrograms.Name = "npExternalPrograms";
        npExternalPrograms.Size = new Size(699, 612);
        // 
        // externalProgramsList
        // 
        externalProgramsList.Dock = DockStyle.Fill;
        externalProgramsList.Location = new Point(0, 0);
        externalProgramsList.Name = "externalProgramsList";
        externalProgramsList.Size = new Size(699, 612);
        externalProgramsList.TabIndex = 0;
        // 
        // backstageViewClientControl3
        // 
        backstageViewClientControl3.Location = new Point(170, 0);
        backstageViewClientControl3.Name = "backstageViewClientControl3";
        backstageViewClientControl3.Size = new Size(835, 612);
        backstageViewClientControl3.TabIndex = 3;
        // 
        // bvtiApp
        // 
        bvtiApp.Caption = "App";
        bvtiApp.ContentControl = backstageViewClientControl5;
        bvtiApp.ImageOptions.ItemNormal.SvgImage = Properties.Resources.bo_address;
        bvtiApp.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        bvtiApp.Name = "bvtiApp";
        // 
        // bvtiModules
        // 
        bvtiModules.Caption = "Modules";
        bvtiModules.ContentControl = backstageViewClientControl4;
        bvtiModules.ImageOptions.ItemNormal.SvgImage = Properties.Resources.bo_security_permission_model;
        bvtiModules.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        bvtiModules.Name = "bvtiModules";
        // 
        // backstageViewItemSeparator2
        // 
        backstageViewItemSeparator2.Name = "backstageViewItemSeparator2";
        // 
        // bvtiDatabase
        // 
        bvtiDatabase.AppearanceHover.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        bvtiDatabase.AppearanceHover.Options.UseFont = true;
        bvtiDatabase.AppearanceSelected.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        bvtiDatabase.AppearanceSelected.Options.UseFont = true;
        bvtiDatabase.Caption = "Database";
        bvtiDatabase.ContentControl = backstageViewClientControl6;
        bvtiDatabase.ImageOptions.ItemNormal.SvgImage = Properties.Resources.editdatasource;
        bvtiDatabase.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        bvtiDatabase.Name = "bvtiDatabase";
        // 
        // bvtiSqlRun
        // 
        bvtiSqlRun.AppearanceHover.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        bvtiSqlRun.AppearanceHover.Options.UseFont = true;
        bvtiSqlRun.AppearanceSelected.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        bvtiSqlRun.AppearanceSelected.Options.UseFont = true;
        bvtiSqlRun.Caption = "Sql Run";
        bvtiSqlRun.ContentControl = backstageViewClientControl1;
        bvtiSqlRun.ImageOptions.ItemNormal.SvgImage = Properties.Resources.selectdatasource;
        bvtiSqlRun.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        bvtiSqlRun.Name = "bvtiSqlRun";
        // 
        // bvtiData
        // 
        bvtiData.AppearanceHover.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        bvtiData.AppearanceHover.Options.UseFont = true;
        bvtiData.AppearanceSelected.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        bvtiData.AppearanceSelected.Options.UseFont = true;
        bvtiData.Caption = "Data";
        bvtiData.ContentControl = backstageViewClientControl2;
        bvtiData.ImageOptions.ItemNormal.SvgImage = Properties.Resources.actions_database;
        bvtiData.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        bvtiData.Name = "bvtiData";
        bvtiData.Selected = true;
        // 
        // bvtiInfo
        // 
        bvtiInfo.Alignment = DevExpress.XtraBars.Ribbon.BackstageViewItemAlignment.Bottom;
        bvtiInfo.AppearanceHover.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        bvtiInfo.AppearanceHover.Options.UseFont = true;
        bvtiInfo.AppearanceSelected.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        bvtiInfo.AppearanceSelected.Options.UseFont = true;
        bvtiInfo.Caption = "About";
        bvtiInfo.ContentControl = backstageViewClientControl3;
        bvtiInfo.ImageOptions.ItemNormal.SvgImage = Properties.Resources.about;
        bvtiInfo.ImageOptions.ItemNormal.SvgImageSize = new Size(24, 24);
        bvtiInfo.Name = "bvtiInfo";
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
        backstageViewClientControl5.ResumeLayout(false);
        backstageViewClientControl4.ResumeLayout(false);
        backstageViewClientControl6.ResumeLayout(false);
        backstageViewClientControl1.ResumeLayout(false);
        backstageViewClientControl2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)navigationPaneEx).EndInit();
        navigationPaneEx.ResumeLayout(false);
        npExternalPrograms.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    public DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl3;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtiSqlRun;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtiData;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtiInfo;
    private Views.Sql.SqlBrowserView sqlBrowserView1;
    private Components.NavigationPaneEx navigationPaneEx;
    private Components.NavigationPageEx npExternalPrograms;
    private Views.ExternalPrograms.ExternalProgramsList externalProgramsList;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl4;
    private Views.Settings.ModulesSettingView modulesSettingView1;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtiModules;
    private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator2;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl5;
    private Views.Settings.AppSettingsView appSettingsView1;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtiApp;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl6;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bvtiDatabase;
    private Views.Settings.DatabaseSettingsView databaseSettingsView;
}
