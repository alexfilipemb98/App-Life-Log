namespace LifeLogApp.Views.Settings;

partial class ModulleSettingsView
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
        barManager = new DevExpress.XtraBars.BarManager(components);
        bar = new DevExpress.XtraBars.Bar();
        bbiSave = new DevExpress.XtraBars.BarButtonItem();
        barDockControlTop = new DevExpress.XtraBars.BarDockControl();
        barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
        barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
        barDockControlRight = new DevExpress.XtraBars.BarDockControl();
        dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
        toggleSwitch2 = new DevExpress.XtraEditors.ToggleSwitch();
        moduleSettingsXPBindingSource = new DevExpress.Xpo.XPBindingSource(components);
        xpModuleSettings = new DevExpress.Xpo.XPCollection(components);
        unitOfWork1 = new DevExpress.Xpo.UnitOfWork(components);
        toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
        Root = new DevExpress.XtraLayout.LayoutControlGroup();
        emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
        layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
        layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
        emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
        layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
        toggleSwitch3 = new DevExpress.XtraEditors.ToggleSwitch();
        layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
        emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
        toggleSwitch4 = new DevExpress.XtraEditors.ToggleSwitch();
        layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
        toggleSwitch5 = new DevExpress.XtraEditors.ToggleSwitch();
        layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
        ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
        dataLayoutControl1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)toggleSwitch2.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)moduleSettingsXPBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)xpModuleSettings).BeginInit();
        ((System.ComponentModel.ISupportInitialize)unitOfWork1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)toggleSwitch1.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
        ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)toggleSwitch3.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)toggleSwitch4.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)toggleSwitch5.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
        SuspendLayout();
        // 
        // barManager
        // 
        barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar });
        barManager.DockControls.Add(barDockControlTop);
        barManager.DockControls.Add(barDockControlBottom);
        barManager.DockControls.Add(barDockControlLeft);
        barManager.DockControls.Add(barDockControlRight);
        barManager.Form = this;
        barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bbiSave });
        barManager.MainMenu = bar;
        barManager.MaxItemId = 4;
        // 
        // bar
        // 
        bar.BarName = "Main menu";
        bar.DockCol = 0;
        bar.DockRow = 0;
        bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
        bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, bbiSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
        bar.OptionsBar.AllowQuickCustomization = false;
        bar.OptionsBar.DisableCustomization = true;
        bar.OptionsBar.DrawBorder = false;
        bar.OptionsBar.DrawDragBorder = false;
        bar.OptionsBar.MultiLine = true;
        bar.OptionsBar.UseWholeRow = true;
        bar.Text = "Main menu";
        // 
        // bbiSave
        // 
        bbiSave.Caption = "Save";
        bbiSave.Id = 3;
        bbiSave.ImageOptions.SvgImage = Properties.Resources.saveall;
        bbiSave.Name = "bbiSave";
        bbiSave.ItemClick += bbiSave_ItemClick;
        // 
        // barDockControlTop
        // 
        barDockControlTop.CausesValidation = false;
        barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
        barDockControlTop.Location = new System.Drawing.Point(0, 0);
        barDockControlTop.Manager = barManager;
        barDockControlTop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
        barDockControlTop.Size = new System.Drawing.Size(1040, 41);
        // 
        // barDockControlBottom
        // 
        barDockControlBottom.CausesValidation = false;
        barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        barDockControlBottom.Location = new System.Drawing.Point(0, 560);
        barDockControlBottom.Manager = barManager;
        barDockControlBottom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
        barDockControlBottom.Size = new System.Drawing.Size(1040, 0);
        // 
        // barDockControlLeft
        // 
        barDockControlLeft.CausesValidation = false;
        barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
        barDockControlLeft.Location = new System.Drawing.Point(0, 41);
        barDockControlLeft.Manager = barManager;
        barDockControlLeft.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
        barDockControlLeft.Size = new System.Drawing.Size(0, 519);
        // 
        // barDockControlRight
        // 
        barDockControlRight.CausesValidation = false;
        barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
        barDockControlRight.Location = new System.Drawing.Point(1040, 41);
        barDockControlRight.Manager = barManager;
        barDockControlRight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
        barDockControlRight.Size = new System.Drawing.Size(0, 519);
        // 
        // dataLayoutControl1
        // 
        dataLayoutControl1.Controls.Add(toggleSwitch5);
        dataLayoutControl1.Controls.Add(toggleSwitch4);
        dataLayoutControl1.Controls.Add(toggleSwitch3);
        dataLayoutControl1.Controls.Add(toggleSwitch2);
        dataLayoutControl1.Controls.Add(toggleSwitch1);
        dataLayoutControl1.DataSource = moduleSettingsXPBindingSource;
        dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        dataLayoutControl1.Location = new System.Drawing.Point(0, 41);
        dataLayoutControl1.Name = "dataLayoutControl1";
        dataLayoutControl1.Root = Root;
        dataLayoutControl1.Size = new System.Drawing.Size(1040, 519);
        dataLayoutControl1.TabIndex = 4;
        dataLayoutControl1.Text = "dataLayoutControl1";
        // 
        // toggleSwitch2
        // 
        toggleSwitch2.AutoSizeInLayoutControl = true;
        toggleSwitch2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", moduleSettingsXPBindingSource, "EnablePasswords", true));
        toggleSwitch2.Location = new System.Drawing.Point(253, 51);
        toggleSwitch2.MenuManager = barManager;
        toggleSwitch2.Name = "toggleSwitch2";
        toggleSwitch2.Properties.AutoWidth = true;
        toggleSwitch2.Properties.OffText = "Off";
        toggleSwitch2.Properties.OnText = "On";
        toggleSwitch2.Properties.ShowText = false;
        toggleSwitch2.Size = new System.Drawing.Size(60, 24);
        toggleSwitch2.StyleController = dataLayoutControl1;
        toggleSwitch2.TabIndex = 2;
        // 
        // moduleSettingsXPBindingSource
        // 
        moduleSettingsXPBindingSource.DataSource = xpModuleSettings;
        // 
        // xpModuleSettings
        // 
        xpModuleSettings.DisplayableProperties = "User;EnableNotes;Id;CreatedAt;UpdatedAt;EdittingMode;SavingMode;EnablePasswords;EnableCoinFilp;EnableDiceRoll;EnableTicTacToe";
        xpModuleSettings.ObjectType = typeof(Data.ORM.DataModelCode.ORM_ModuleSettings);
        xpModuleSettings.Session = unitOfWork1;
        // 
        // toggleSwitch1
        // 
        toggleSwitch1.AutoSizeInLayoutControl = true;
        toggleSwitch1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", moduleSettingsXPBindingSource, "EnableNotes", true));
        toggleSwitch1.Location = new System.Drawing.Point(103, 51);
        toggleSwitch1.MenuManager = barManager;
        toggleSwitch1.Name = "toggleSwitch1";
        toggleSwitch1.Properties.AutoWidth = true;
        toggleSwitch1.Properties.OffText = "Off";
        toggleSwitch1.Properties.OnText = "On";
        toggleSwitch1.Properties.ShowText = false;
        toggleSwitch1.Size = new System.Drawing.Size(60, 24);
        toggleSwitch1.StyleController = dataLayoutControl1;
        toggleSwitch1.TabIndex = 0;
        // 
        // Root
        // 
        Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
        Root.GroupBordersVisible = false;
        Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, layoutControlGroup1, layoutControlGroup2 });
        Root.Name = "Root";
        Root.Size = new System.Drawing.Size(1040, 519);
        Root.TextVisible = false;
        // 
        // emptySpaceItem1
        // 
        emptySpaceItem1.Location = new System.Drawing.Point(0, 143);
        emptySpaceItem1.Name = "emptySpaceItem1";
        emptySpaceItem1.Size = new System.Drawing.Size(1014, 350);
        // 
        // layoutControlGroup1
        // 
        layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
        layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, emptySpaceItem2 });
        layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
        layoutControlGroup1.Name = "layoutControlGroup1";
        layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
        layoutControlGroup1.Size = new System.Drawing.Size(1014, 68);
        layoutControlGroup1.Text = "Modules";
        // 
        // layoutControlItem1
        // 
        layoutControlItem1.Control = toggleSwitch1;
        layoutControlItem1.Location = new System.Drawing.Point(0, 0);
        layoutControlItem1.Name = "layoutControlItem1";
        layoutControlItem1.Size = new System.Drawing.Size(150, 30);
        layoutControlItem1.Text = "Notes";
        layoutControlItem1.TextSize = new System.Drawing.Size(68, 19);
        // 
        // layoutControlItem2
        // 
        layoutControlItem2.Control = toggleSwitch2;
        layoutControlItem2.Location = new System.Drawing.Point(150, 0);
        layoutControlItem2.Name = "layoutControlItem2";
        layoutControlItem2.Size = new System.Drawing.Size(150, 30);
        layoutControlItem2.Text = "Passwords";
        layoutControlItem2.TextSize = new System.Drawing.Size(68, 19);
        // 
        // emptySpaceItem2
        // 
        emptySpaceItem2.Location = new System.Drawing.Point(300, 0);
        emptySpaceItem2.Name = "emptySpaceItem2";
        emptySpaceItem2.Size = new System.Drawing.Size(708, 30);
        // 
        // layoutControlItem3
        // 
        layoutControlItem3.Control = toggleSwitch1;
        layoutControlItem3.Location = new System.Drawing.Point(0, 0);
        layoutControlItem3.Name = "layoutControlItem1";
        layoutControlItem3.Size = new System.Drawing.Size(146, 30);
        layoutControlItem3.Text = "Notes";
        layoutControlItem3.TextSize = new System.Drawing.Size(64, 19);
        // 
        // toggleSwitch3
        // 
        toggleSwitch3.AutoSizeInLayoutControl = true;
        toggleSwitch3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", moduleSettingsXPBindingSource, "EnableNotes", true));
        toggleSwitch3.Location = new System.Drawing.Point(103, 126);
        toggleSwitch3.MenuManager = barManager;
        toggleSwitch3.Name = "toggleSwitch3";
        toggleSwitch3.Properties.AutoWidth = true;
        toggleSwitch3.Properties.OffText = "Off";
        toggleSwitch3.Properties.OnText = "On";
        toggleSwitch3.Properties.ShowText = false;
        toggleSwitch3.Size = new System.Drawing.Size(60, 24);
        toggleSwitch3.StyleController = dataLayoutControl1;
        toggleSwitch3.TabIndex = 3;
        // 
        // layoutControlItem4
        // 
        layoutControlItem4.Control = toggleSwitch3;
        layoutControlItem4.Location = new System.Drawing.Point(0, 0);
        layoutControlItem4.Name = "layoutControlItem4";
        layoutControlItem4.Size = new System.Drawing.Size(150, 30);
        layoutControlItem4.Text = "Tic Tac Toe";
        layoutControlItem4.TextSize = new System.Drawing.Size(68, 19);
        // 
        // layoutControlGroup2
        // 
        layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
        layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem4, emptySpaceItem3, layoutControlItem5, layoutControlItem6 });
        layoutControlGroup2.Location = new System.Drawing.Point(0, 68);
        layoutControlGroup2.Name = "layoutControlGroup2";
        layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
        layoutControlGroup2.Size = new System.Drawing.Size(1014, 75);
        layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 10, 3);
        layoutControlGroup2.Text = "Entertainment";
        // 
        // emptySpaceItem3
        // 
        emptySpaceItem3.Location = new System.Drawing.Point(450, 0);
        emptySpaceItem3.Name = "emptySpaceItem3";
        emptySpaceItem3.Size = new System.Drawing.Size(558, 30);
        // 
        // toggleSwitch4
        // 
        toggleSwitch4.AutoSizeInLayoutControl = true;
        toggleSwitch4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", moduleSettingsXPBindingSource, "EnableNotes", true));
        toggleSwitch4.Location = new System.Drawing.Point(253, 126);
        toggleSwitch4.MenuManager = barManager;
        toggleSwitch4.Name = "toggleSwitch4";
        toggleSwitch4.Properties.AutoWidth = true;
        toggleSwitch4.Properties.OffText = "Off";
        toggleSwitch4.Properties.OnText = "On";
        toggleSwitch4.Properties.ShowText = false;
        toggleSwitch4.Size = new System.Drawing.Size(60, 24);
        toggleSwitch4.StyleController = dataLayoutControl1;
        toggleSwitch4.TabIndex = 4;
        // 
        // layoutControlItem5
        // 
        layoutControlItem5.Control = toggleSwitch4;
        layoutControlItem5.Location = new System.Drawing.Point(150, 0);
        layoutControlItem5.Name = "layoutControlItem5";
        layoutControlItem5.Size = new System.Drawing.Size(150, 30);
        layoutControlItem5.Text = "Dice Roll";
        layoutControlItem5.TextSize = new System.Drawing.Size(68, 19);
        // 
        // toggleSwitch5
        // 
        toggleSwitch5.AutoSizeInLayoutControl = true;
        toggleSwitch5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", moduleSettingsXPBindingSource, "EnableNotes", true));
        toggleSwitch5.Location = new System.Drawing.Point(403, 126);
        toggleSwitch5.MenuManager = barManager;
        toggleSwitch5.Name = "toggleSwitch5";
        toggleSwitch5.Properties.AutoWidth = true;
        toggleSwitch5.Properties.OffText = "Off";
        toggleSwitch5.Properties.OnText = "On";
        toggleSwitch5.Properties.ShowText = false;
        toggleSwitch5.Size = new System.Drawing.Size(60, 24);
        toggleSwitch5.StyleController = dataLayoutControl1;
        toggleSwitch5.TabIndex = 5;
        // 
        // layoutControlItem6
        // 
        layoutControlItem6.Control = toggleSwitch5;
        layoutControlItem6.Location = new System.Drawing.Point(300, 0);
        layoutControlItem6.Name = "layoutControlItem6";
        layoutControlItem6.Size = new System.Drawing.Size(150, 30);
        layoutControlItem6.Text = "Coin Filp";
        layoutControlItem6.TextSize = new System.Drawing.Size(68, 19);
        // 
        // ModulleSettingsView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(dataLayoutControl1);
        Controls.Add(barDockControlLeft);
        Controls.Add(barDockControlRight);
        Controls.Add(barDockControlBottom);
        Controls.Add(barDockControlTop);
        Margin = new System.Windows.Forms.Padding(4);
        Name = "ModulleSettingsView";
        Size = new System.Drawing.Size(1040, 560);
        ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
        dataLayoutControl1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)toggleSwitch2.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)moduleSettingsXPBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)xpModuleSettings).EndInit();
        ((System.ComponentModel.ISupportInitialize)unitOfWork1).EndInit();
        ((System.ComponentModel.ISupportInitialize)toggleSwitch1.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)Root).EndInit();
        ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
        ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
        ((System.ComponentModel.ISupportInitialize)toggleSwitch3.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
        ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
        ((System.ComponentModel.ISupportInitialize)toggleSwitch4.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
        ((System.ComponentModel.ISupportInitialize)toggleSwitch5.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraBars.BarManager barManager;
    private DevExpress.XtraBars.Bar bar;
    private DevExpress.XtraBars.BarButtonItem bbiSave;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.Xpo.XPBindingSource moduleSettingsXPBindingSource;
    private DevExpress.Xpo.XPCollection xpModuleSettings;
    private DevExpress.Xpo.UnitOfWork unitOfWork1;
    private DevExpress.XtraEditors.ToggleSwitch toggleSwitch2;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.ToggleSwitch toggleSwitch5;
    private DevExpress.XtraEditors.ToggleSwitch toggleSwitch4;
    private DevExpress.XtraEditors.ToggleSwitch toggleSwitch3;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
}
