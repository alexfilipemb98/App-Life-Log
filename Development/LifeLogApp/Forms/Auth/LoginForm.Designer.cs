namespace LifeLogApp.Forms.Auth;

partial class LoginForm
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
        components = new System.ComponentModel.Container();
        DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
        DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
        DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
        DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
        DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
        ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
        bbiDatabaseSettings = new DevExpress.XtraBars.BarButtonItem();
        bbiGoBack = new DevExpress.XtraBars.BarButtonItem();
        ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
        bsiStatusLabel = new DevExpress.XtraBars.BarStaticItem();
        bsiDatabase = new DevExpress.XtraBars.BarStaticItem();
        bsiAppVersion = new DevExpress.XtraBars.BarStaticItem();
        navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
        npLogin = new DevExpress.XtraBars.Navigation.NavigationPage();
        dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
        tsNewUser = new DevExpress.XtraEditors.ToggleSwitch();
        loginModelBindingSource = new System.Windows.Forms.BindingSource(components);
        label1 = new System.Windows.Forms.Label();
        pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
        teEmail = new DevExpress.XtraEditors.TextEdit();
        teUsername = new DevExpress.XtraEditors.TextEdit();
        bePassword = new DevExpress.XtraEditors.ButtonEdit();
        sbSubmit = new DevExpress.XtraEditors.SimpleButton();
        Root = new DevExpress.XtraLayout.LayoutControlGroup();
        layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
        esiBottom = new DevExpress.XtraLayout.EmptySpaceItem();
        layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
        simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
        esiBtnLeft = new DevExpress.XtraLayout.EmptySpaceItem();
        esiBtnRight = new DevExpress.XtraLayout.EmptySpaceItem();
        lciMain = new DevExpress.XtraLayout.LayoutControlGroup();
        layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
        lciLoginUsername = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
        esiTop = new DevExpress.XtraLayout.EmptySpaceItem();
        npDbSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
        databaseSettingsView = new LifeLogApp.Views.Settings.DatabaseSettingsView();
        dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
        ((System.ComponentModel.ISupportInitialize)navigationFrame).BeginInit();
        navigationFrame.SuspendLayout();
        npLogin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataLayoutControl).BeginInit();
        dataLayoutControl.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tsNewUser.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)loginModelBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)teEmail.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)teUsername.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bePassword.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)esiBottom).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)simpleSeparator1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)esiBtnLeft).BeginInit();
        ((System.ComponentModel.ISupportInitialize)esiBtnRight).BeginInit();
        ((System.ComponentModel.ISupportInitialize)lciMain).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)lciLoginUsername).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
        ((System.ComponentModel.ISupportInitialize)esiTop).BeginInit();
        npDbSettings.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dxErrorProvider).BeginInit();
        SuspendLayout();
        // 
        // ribbon
        // 
        ribbon.ApplicationCaption = "Life Log";
        ribbon.ApplicationDocumentCaption = " Login";
        ribbon.CaptionBarItemLinks.Add(bbiDatabaseSettings);
        ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(33, 34, 33, 34);
        ribbon.ExpandCollapseItem.Id = 0;
        ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { bbiDatabaseSettings, ribbon.ExpandCollapseItem, bbiGoBack });
        ribbon.Location = new System.Drawing.Point(0, 0);
        ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        ribbon.MaxItemId = 3;
        ribbon.Name = "ribbon";
        ribbon.OptionsMenuMinWidth = 377;
        ribbon.QuickToolbarItemLinks.Add(bbiGoBack);
        ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
        ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
        ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
        ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
        ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
        ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
        ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
        ribbon.ShowPageKeyTipsMode = DevExpress.XtraBars.Ribbon.ShowPageKeyTipsMode.Hide;
        ribbon.ShowQatLocationSelector = false;
        ribbon.ShowToolbarCustomizeItem = false;
        ribbon.Size = new System.Drawing.Size(698, 49);
        ribbon.StatusBar = ribbonStatusBar;
        ribbon.Toolbar.ShowCustomizeItem = false;
        // 
        // bbiDatabaseSettings
        // 
        bbiDatabaseSettings.Caption = "barButtonItem1";
        bbiDatabaseSettings.Id = 1;
        bbiDatabaseSettings.ImageOptions.SvgImage = Properties.Resources.managedatasource;
        bbiDatabaseSettings.Name = "bbiDatabaseSettings";
        bbiDatabaseSettings.ItemClick += bbiDatabaseSettings_ItemClick;
        // 
        // bbiGoBack
        // 
        bbiGoBack.Caption = "barButtonItem2";
        bbiGoBack.Id = 2;
        bbiGoBack.ImageOptions.SvgImage = Properties.Resources.undo;
        bbiGoBack.Name = "bbiGoBack";
        bbiGoBack.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        bbiGoBack.ItemClick += bbiGoBack_ItemClick;
        // 
        // ribbonStatusBar
        // 
        ribbonStatusBar.ItemLinks.Add(bsiStatusLabel);
        ribbonStatusBar.ItemLinks.Add(bsiDatabase);
        ribbonStatusBar.ItemLinks.Add(bsiAppVersion);
        ribbonStatusBar.Location = new System.Drawing.Point(0, 327);
        ribbonStatusBar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
        ribbonStatusBar.Name = "ribbonStatusBar";
        ribbonStatusBar.Ribbon = ribbon;
        ribbonStatusBar.Size = new System.Drawing.Size(698, 43);
        // 
        // bsiStatusLabel
        // 
        bsiStatusLabel.Caption = "<STATUS>";
        bsiStatusLabel.Id = 1;
        bsiStatusLabel.ImageOptions.SvgImage = Properties.Resources.thankyounote;
        bsiStatusLabel.Name = "bsiStatusLabel";
        bsiStatusLabel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
        // 
        // bsiDatabase
        // 
        bsiDatabase.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        bsiDatabase.Caption = "<DATABASE>";
        bsiDatabase.Id = 5;
        bsiDatabase.ImageOptions.SvgImage = Properties.Resources.actions_database;
        bsiDatabase.Name = "bsiDatabase";
        bsiDatabase.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
        // 
        // bsiAppVersion
        // 
        bsiAppVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        bsiAppVersion.Caption = "<VERSION>";
        bsiAppVersion.Id = 6;
        bsiAppVersion.ImageOptions.SvgImage = Properties.Resources.bo_fileattachment;
        bsiAppVersion.Name = "bsiAppVersion";
        bsiAppVersion.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
        // 
        // navigationFrame
        // 
        navigationFrame.Controls.Add(npLogin);
        navigationFrame.Controls.Add(npDbSettings);
        navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
        navigationFrame.Location = new System.Drawing.Point(0, 49);
        navigationFrame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        navigationFrame.Name = "navigationFrame";
        navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { npLogin, npDbSettings });
        navigationFrame.SelectedPage = npLogin;
        navigationFrame.Size = new System.Drawing.Size(698, 278);
        navigationFrame.TabIndex = 2;
        navigationFrame.Text = "navigationFrame1";
        // 
        // npLogin
        // 
        npLogin.Controls.Add(dataLayoutControl);
        npLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        npLogin.Name = "npLogin";
        npLogin.Size = new System.Drawing.Size(698, 278);
        // 
        // dataLayoutControl
        // 
        dataLayoutControl.Controls.Add(tsNewUser);
        dataLayoutControl.Controls.Add(label1);
        dataLayoutControl.Controls.Add(pictureEdit1);
        dataLayoutControl.Controls.Add(teEmail);
        dataLayoutControl.Controls.Add(teUsername);
        dataLayoutControl.Controls.Add(bePassword);
        dataLayoutControl.Controls.Add(sbSubmit);
        dataLayoutControl.DataSource = loginModelBindingSource;
        dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
        dataLayoutControl.Location = new System.Drawing.Point(0, 0);
        dataLayoutControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        dataLayoutControl.Name = "dataLayoutControl";
        dataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(886, 165, 650, 400);
        dataLayoutControl.Root = Root;
        dataLayoutControl.Size = new System.Drawing.Size(698, 278);
        dataLayoutControl.TabIndex = 0;
        dataLayoutControl.Text = "dataLayoutControl1";
        // 
        // tsNewUser
        // 
        tsNewUser.AutoSizeInLayoutControl = true;
        tsNewUser.CausesValidation = false;
        tsNewUser.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", loginModelBindingSource, "IsNew", true));
        tsNewUser.Location = new System.Drawing.Point(361, 16);
        tsNewUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        tsNewUser.MenuManager = ribbon;
        tsNewUser.Name = "tsNewUser";
        tsNewUser.Properties.AutoHeight = false;
        tsNewUser.Properties.AutoWidth = true;
        tsNewUser.Properties.OffText = "Off";
        tsNewUser.Properties.OnText = "On";
        tsNewUser.Properties.ShowText = false;
        tsNewUser.Size = new System.Drawing.Size(60, 24);
        tsNewUser.StyleController = dataLayoutControl;
        tsNewUser.TabIndex = 7;
        tsNewUser.Toggled += tsNewUser_Toggled;
        // 
        // loginModelBindingSource
        // 
        loginModelBindingSource.DataSource = typeof(Core.Models.LoginModel);
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        label1.Location = new System.Drawing.Point(16, 16);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(269, 24);
        label1.TabIndex = 6;
        label1.Text = "Don't have an account yet? ";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // pictureEdit1
        // 
        pictureEdit1.EditValue = Properties.Resources.app_background;
        pictureEdit1.Location = new System.Drawing.Point(433, 13);
        pictureEdit1.Margin = new System.Windows.Forms.Padding(0);
        pictureEdit1.MaximumSize = new System.Drawing.Size(252, 0);
        pictureEdit1.MenuManager = ribbon;
        pictureEdit1.MinimumSize = new System.Drawing.Size(252, 0);
        pictureEdit1.Name = "pictureEdit1";
        pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
        pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
        pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
        pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
        pictureEdit1.Size = new System.Drawing.Size(252, 252);
        pictureEdit1.StyleController = dataLayoutControl;
        pictureEdit1.TabIndex = 5;
        // 
        // teEmail
        // 
        teEmail.CausesValidation = false;
        teEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", loginModelBindingSource, "Email", true));
        teEmail.Location = new System.Drawing.Point(58, 107);
        teEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        teEmail.MenuManager = ribbon;
        teEmail.Name = "teEmail";
        teEmail.Properties.AdvancedModeOptions.Label = "Email";
        teEmail.Size = new System.Drawing.Size(363, 54);
        teEmail.StyleController = dataLayoutControl;
        teEmail.TabIndex = 2;
        teEmail.KeyDown += TextEdit_KeyDown;
        // 
        // teUsername
        // 
        teUsername.CausesValidation = false;
        teUsername.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", loginModelBindingSource, "Username", true));
        teUsername.Location = new System.Drawing.Point(58, 47);
        teUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        teUsername.MenuManager = ribbon;
        teUsername.Name = "teUsername";
        teUsername.Properties.AdvancedModeOptions.Label = "Username";
        teUsername.Size = new System.Drawing.Size(363, 54);
        teUsername.StyleController = dataLayoutControl;
        teUsername.TabIndex = 0;
        teUsername.KeyDown += TextEdit_KeyDown;
        // 
        // bePassword
        // 
        bePassword.CausesValidation = false;
        bePassword.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", loginModelBindingSource, "Password", true));
        bePassword.Location = new System.Drawing.Point(58, 167);
        bePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        bePassword.MenuManager = ribbon;
        bePassword.Name = "bePassword";
        bePassword.Properties.AdvancedModeOptions.Label = "Password";
        editorButtonImageOptions1.SvgImage = Properties.Resources.security_visibilityoff;
        editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(24, 24);
        bePassword.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
        bePassword.Properties.UseSystemPasswordChar = true;
        bePassword.Size = new System.Drawing.Size(363, 54);
        bePassword.StyleController = dataLayoutControl;
        bePassword.TabIndex = 3;
        bePassword.ButtonClick += bePassword_ButtonClick;
        bePassword.KeyDown += TextEdit_KeyDown;
        // 
        // sbSubmit
        // 
        sbSubmit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
        sbSubmit.Appearance.FontSizeDelta = 5;
        sbSubmit.Appearance.Options.UseBackColor = true;
        sbSubmit.Appearance.Options.UseFont = true;
        sbSubmit.Location = new System.Drawing.Point(133, 228);
        sbSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        sbSubmit.MaximumSize = new System.Drawing.Size(208, 0);
        sbSubmit.MinimumSize = new System.Drawing.Size(208, 0);
        sbSubmit.Name = "sbSubmit";
        sbSubmit.Size = new System.Drawing.Size(208, 34);
        sbSubmit.StyleController = dataLayoutControl;
        sbSubmit.TabIndex = 4;
        sbSubmit.Text = "Login";
        sbSubmit.Click += sbLogin_Click;
        // 
        // Root
        // 
        Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
        Root.GroupBordersVisible = false;
        Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, esiBottom, layoutControlItem5, simpleSeparator1, esiBtnLeft, esiBtnRight, lciMain, layoutControlItem6, layoutControlItem7, esiTop });
        Root.Name = "Root";
        Root.Size = new System.Drawing.Size(698, 278);
        Root.TextVisible = false;
        // 
        // layoutControlItem1
        // 
        layoutControlItem1.Control = sbSubmit;
        layoutControlItem1.Location = new System.Drawing.Point(117, 212);
        layoutControlItem1.Name = "layoutControlItem1";
        layoutControlItem1.Size = new System.Drawing.Size(214, 40);
        layoutControlItem1.TextVisible = false;
        // 
        // esiBottom
        // 
        esiBottom.Location = new System.Drawing.Point(0, 211);
        esiBottom.MinSize = new System.Drawing.Size(1, 1);
        esiBottom.Name = "esiBottom";
        esiBottom.Size = new System.Drawing.Size(411, 1);
        esiBottom.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
        // 
        // layoutControlItem5
        // 
        layoutControlItem5.Control = pictureEdit1;
        layoutControlItem5.Location = new System.Drawing.Point(420, 0);
        layoutControlItem5.Name = "layoutControlItem5";
        layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
        layoutControlItem5.Size = new System.Drawing.Size(252, 252);
        layoutControlItem5.TextVisible = false;
        // 
        // simpleSeparator1
        // 
        simpleSeparator1.Location = new System.Drawing.Point(411, 0);
        simpleSeparator1.Name = "simpleSeparator1";
        simpleSeparator1.Size = new System.Drawing.Size(9, 252);
        simpleSeparator1.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 0, 0);
        // 
        // esiBtnLeft
        // 
        esiBtnLeft.Location = new System.Drawing.Point(0, 212);
        esiBtnLeft.MinSize = new System.Drawing.Size(1, 1);
        esiBtnLeft.Name = "esiBtnLeft";
        esiBtnLeft.Size = new System.Drawing.Size(117, 40);
        esiBtnLeft.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
        // 
        // esiBtnRight
        // 
        esiBtnRight.Location = new System.Drawing.Point(331, 212);
        esiBtnRight.MinSize = new System.Drawing.Size(1, 1);
        esiBtnRight.Name = "esiBtnRight";
        esiBtnRight.Size = new System.Drawing.Size(80, 40);
        esiBtnRight.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
        // 
        // lciMain
        // 
        lciMain.GroupBordersVisible = false;
        lciMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, layoutControlItem4, lciLoginUsername });
        lciMain.Location = new System.Drawing.Point(0, 31);
        lciMain.Name = "lciMain";
        lciMain.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
        lciMain.OptionsItemText.TextToControlDistance = 1;
        lciMain.Size = new System.Drawing.Size(411, 180);
        // 
        // layoutControlItem2
        // 
        layoutControlItem2.Control = bePassword;
        layoutControlItem2.ImageOptions.SvgImage = Properties.Resources.security_key;
        layoutControlItem2.Location = new System.Drawing.Point(0, 120);
        layoutControlItem2.Name = "layoutControlItem2";
        layoutControlItem2.Size = new System.Drawing.Size(411, 60);
        layoutControlItem2.Text = " ";
        // 
        // layoutControlItem4
        // 
        layoutControlItem4.Control = teEmail;
        layoutControlItem4.ImageOptions.SvgImage = Properties.Resources.glyph_mail;
        layoutControlItem4.Location = new System.Drawing.Point(0, 60);
        layoutControlItem4.Name = "layoutControlItem4";
        layoutControlItem4.Size = new System.Drawing.Size(411, 60);
        layoutControlItem4.Text = " ";
        // 
        // lciLoginUsername
        // 
        lciLoginUsername.Control = teUsername;
        lciLoginUsername.ImageOptions.SvgImage = Properties.Resources.bo_person;
        lciLoginUsername.Location = new System.Drawing.Point(0, 0);
        lciLoginUsername.Name = "lciLoginUsername";
        lciLoginUsername.Size = new System.Drawing.Size(411, 60);
        lciLoginUsername.Text = " ";
        lciLoginUsername.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        // 
        // layoutControlItem6
        // 
        layoutControlItem6.Control = label1;
        layoutControlItem6.Location = new System.Drawing.Point(0, 0);
        layoutControlItem6.Name = "layoutControlItem6";
        layoutControlItem6.Size = new System.Drawing.Size(275, 30);
        layoutControlItem6.TextVisible = false;
        // 
        // layoutControlItem7
        // 
        layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
        layoutControlItem7.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
        layoutControlItem7.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
        layoutControlItem7.Control = tsNewUser;
        layoutControlItem7.Location = new System.Drawing.Point(275, 0);
        layoutControlItem7.Name = "layoutControlItem7";
        layoutControlItem7.Size = new System.Drawing.Size(136, 30);
        layoutControlItem7.Text = "New User";
        // 
        // esiTop
        // 
        esiTop.Location = new System.Drawing.Point(0, 30);
        esiTop.MinSize = new System.Drawing.Size(1, 1);
        esiTop.Name = "esiTop";
        esiTop.Size = new System.Drawing.Size(411, 1);
        esiTop.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
        // 
        // npDbSettings
        // 
        npDbSettings.Caption = "npDatabaseSettings";
        npDbSettings.Controls.Add(databaseSettingsView);
        npDbSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        npDbSettings.Name = "npDbSettings";
        npDbSettings.Size = new System.Drawing.Size(698, 278);
        // 
        // databaseSettingsView
        // 
        databaseSettingsView.Dock = System.Windows.Forms.DockStyle.Fill;
        databaseSettingsView.Location = new System.Drawing.Point(0, 0);
        databaseSettingsView.Margin = new System.Windows.Forms.Padding(4);
        databaseSettingsView.Name = "databaseSettingsView";
        databaseSettingsView.Size = new System.Drawing.Size(698, 278);
        databaseSettingsView.TabIndex = 0;
        // 
        // dxErrorProvider
        // 
        dxErrorProvider.ContainerControl = this;
        // 
        // LoginForm
        // 
        Appearance.Options.UseFont = true;
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(698, 370);
        Controls.Add(navigationFrame);
        Controls.Add(ribbonStatusBar);
        Controls.Add(ribbon);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        IconOptions.SvgImage = Properties.Resources.icon_svg;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Name = "LoginForm";
        Ribbon = ribbon;
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        StatusBar = ribbonStatusBar;
        Text = "LoginForm";
        Load += LoginForm_Load;
        Shown += LoginForm_Shown;
        ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
        ((System.ComponentModel.ISupportInitialize)navigationFrame).EndInit();
        navigationFrame.ResumeLayout(false);
        npLogin.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataLayoutControl).EndInit();
        dataLayoutControl.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)tsNewUser.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)loginModelBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)teEmail.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)teUsername.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)bePassword.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)Root).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
        ((System.ComponentModel.ISupportInitialize)esiBottom).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
        ((System.ComponentModel.ISupportInitialize)simpleSeparator1).EndInit();
        ((System.ComponentModel.ISupportInitialize)esiBtnLeft).EndInit();
        ((System.ComponentModel.ISupportInitialize)esiBtnRight).EndInit();
        ((System.ComponentModel.ISupportInitialize)lciMain).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
        ((System.ComponentModel.ISupportInitialize)lciLoginUsername).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
        ((System.ComponentModel.ISupportInitialize)esiTop).EndInit();
        npDbSettings.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dxErrorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    public DevExpress.XtraBars.BarStaticItem bsiStatusLabel;
    private DevExpress.XtraBars.BarStaticItem bsiDatabase;
    private DevExpress.XtraBars.BarStaticItem bsiAppVersion;
    private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
    private DevExpress.XtraBars.Navigation.NavigationPage npLogin;
    private DevExpress.XtraBars.Navigation.NavigationPage npDbSettings;
    private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
    private DevExpress.XtraEditors.SimpleButton sbSubmit;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.EmptySpaceItem esiBottom;
    private DevExpress.XtraEditors.TextEdit teUsername;
    private DevExpress.XtraEditors.ButtonEdit bePassword;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem lciLoginUsername;
    private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    private DevExpress.XtraEditors.TextEdit teEmail;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.EmptySpaceItem esiTop;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
    private DevExpress.XtraLayout.EmptySpaceItem esiBtnLeft;
    private DevExpress.XtraLayout.EmptySpaceItem esiBtnRight;
    private DevExpress.XtraLayout.LayoutControlGroup lciMain;
    private System.Windows.Forms.Label label1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraEditors.ToggleSwitch tsNewUser;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    private System.Windows.Forms.BindingSource loginModelBindingSource;
    private Views.Settings.DatabaseSettingsView databaseSettingsView;
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    private DevExpress.XtraBars.BarButtonItem bbiDatabaseSettings;
    private DevExpress.XtraBars.BarButtonItem bbiGoBack;
    internal DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
}