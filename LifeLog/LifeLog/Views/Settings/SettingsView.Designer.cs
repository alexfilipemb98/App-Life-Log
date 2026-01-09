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
        components = new System.ComponentModel.Container();
        backstageViewControl = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
        backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        sqlBrowserView1 = new LifeLog.Views.Sql.SqlBrowserView();
        backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        navigationPaneEx = new LifeLog.Components.NavigationPaneEx();
        navigationPageExternalPrograms = new LifeLog.Components.NavigationPageEx();
        externalProgramsList = new LifeLog.Views.ExternalPrograms.ExternalProgramsList();
        navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
        backstageViewClientControl3 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
        backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
        backstageViewTabItem2 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        backstageViewTabItem3 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
        sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(components);
        ((System.ComponentModel.ISupportInitialize)backstageViewControl).BeginInit();
        backstageViewControl.SuspendLayout();
        backstageViewClientControl1.SuspendLayout();
        backstageViewClientControl2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)navigationPaneEx).BeginInit();
        navigationPaneEx.SuspendLayout();
        navigationPageExternalPrograms.SuspendLayout();
        SuspendLayout();
        // 
        // backstageViewControl
        // 
        backstageViewControl.Controls.Add(backstageViewClientControl1);
        backstageViewControl.Controls.Add(backstageViewClientControl2);
        backstageViewControl.Controls.Add(backstageViewClientControl3);
        backstageViewControl.Dock = DockStyle.Fill;
        backstageViewControl.Items.Add(backstageViewTabItem1);
        backstageViewControl.Items.Add(backstageViewItemSeparator1);
        backstageViewControl.Items.Add(backstageViewTabItem2);
        backstageViewControl.Items.Add(backstageViewTabItem3);
        backstageViewControl.LeftPaneMinWidth = 170;
        backstageViewControl.Location = new Point(0, 0);
        backstageViewControl.Name = "backstageViewControl";
        backstageViewControl.SelectedTab = backstageViewTabItem2;
        backstageViewControl.SelectedTabIndex = 2;
        backstageViewControl.Size = new Size(1005, 612);
        backstageViewControl.TabIndex = 3;
        backstageViewControl.Text = "backstageViewControl1";
        // 
        // backstageViewClientControl1
        // 
        backstageViewClientControl1.Controls.Add(sqlBrowserView1);
        backstageViewClientControl1.Location = new Point(147, 0);
        backstageViewClientControl1.Name = "backstageViewClientControl1";
        backstageViewClientControl1.Size = new Size(858, 612);
        backstageViewClientControl1.TabIndex = 1;
        // 
        // sqlBrowserView1
        // 
        sqlBrowserView1.Dock = DockStyle.Fill;
        sqlBrowserView1.Location = new Point(0, 0);
        sqlBrowserView1.Margin = new Padding(3, 2, 3, 2);
        sqlBrowserView1.Name = "sqlBrowserView1";
        sqlBrowserView1.Size = new Size(858, 612);
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
        navigationPaneEx.Controls.Add(navigationPage1);
        navigationPaneEx.Dock = DockStyle.Fill;
        navigationPaneEx.Location = new Point(0, 0);
        navigationPaneEx.Name = "navigationPaneEx";
        navigationPaneEx.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { navigationPageExternalPrograms, navigationPage1 });
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
        // navigationPage1
        // 
        navigationPage1.Caption = "navigationPage1";
        navigationPage1.Name = "navigationPage1";
        navigationPage1.Size = new Size(689, 541);
        // 
        // backstageViewClientControl3
        // 
        backstageViewClientControl3.Location = new Point(147, 0);
        backstageViewClientControl3.Name = "backstageViewClientControl3";
        backstageViewClientControl3.Size = new Size(858, 612);
        backstageViewClientControl3.TabIndex = 3;
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
        backstageViewTabItem1.Name = "backstageViewTabItem1";
        // 
        // backstageViewItemSeparator1
        // 
        backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
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
        backstageViewTabItem2.Name = "backstageViewTabItem2";
        backstageViewTabItem2.Selected = true;
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
        backstageViewTabItem3.Name = "backstageViewTabItem3";
        // 
        // sqlDataSource1
        // 
        sqlDataSource1.Name = "sqlDataSource1";
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
        backstageViewClientControl1.ResumeLayout(false);
        backstageViewClientControl2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)navigationPaneEx).EndInit();
        navigationPaneEx.ResumeLayout(false);
        navigationPageExternalPrograms.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    public DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl3;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
    private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem2;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem3;
    private Views.Sql.SqlBrowserView sqlBrowserView1;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private Components.NavigationPaneEx navigationPaneEx;
    private Components.NavigationPageEx navigationPageExternalPrograms;
    private Views.ExternalPrograms.ExternalProgramsList externalProgramsList;
    private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
}
