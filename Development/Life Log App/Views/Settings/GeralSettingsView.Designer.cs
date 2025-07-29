namespace Life_Log_App.Views.Settings
{
    partial class GeralSettingsView
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.appConfigsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbWindowSate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.beApiUrl = new DevExpress.XtraEditors.ButtonEdit();
            this.sbResetSize = new DevExpress.XtraEditors.SimpleButton();
            this.seFormWidth = new DevExpress.XtraEditors.SpinEdit();
            this.seFormHeight = new DevExpress.XtraEditors.SpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appConfigsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbWindowSate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beApiUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFormWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFormHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar.OptionsBar.AllowQuickCustomization = false;
            this.bar.OptionsBar.DisableCustomization = true;
            this.bar.OptionsBar.DrawBorder = false;
            this.bar.OptionsBar.DrawDragBorder = false;
            this.bar.OptionsBar.MultiLine = true;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.Text = "Main menu";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 3;
            this.bbiSave.ImageOptions.SvgImage = global::Life_Log_App.Properties.Resources.saveall;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1089, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 604);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1089, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 563);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1089, 41);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 563);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.toggleSwitch1);
            this.layoutControl1.Controls.Add(this.cbWindowSate);
            this.layoutControl1.Controls.Add(this.beApiUrl);
            this.layoutControl1.Controls.Add(this.sbResetSize);
            this.layoutControl1.Controls.Add(this.seFormWidth);
            this.layoutControl1.Controls.Add(this.seFormHeight);
            this.layoutControl1.DataSource = this.appConfigsModelBindingSource;
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 41);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 216, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1089, 563);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.AutoSizeInLayoutControl = true;
            this.toggleSwitch1.CausesValidation = false;
            this.toggleSwitch1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appConfigsModelBindingSource, "InternalApiEnabled", true));
            this.toggleSwitch1.Location = new System.Drawing.Point(994, 173);
            this.toggleSwitch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toggleSwitch1.MenuManager = this.barManager;
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.AutoWidth = true;
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(84, 24);
            this.toggleSwitch1.StyleController = this.layoutControl1;
            this.toggleSwitch1.TabIndex = 9;
            // 
            // appConfigsModelBindingSource
            // 
            this.appConfigsModelBindingSource.DataSource = typeof(Models.AppConfigsModel);
            // 
            // cbWindowSate
            // 
            this.cbWindowSate.CausesValidation = false;
            this.cbWindowSate.Location = new System.Drawing.Point(863, 43);
            this.cbWindowSate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbWindowSate.MenuManager = this.barManager;
            this.cbWindowSate.Name = "cbWindowSate";
            this.cbWindowSate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbWindowSate.Size = new System.Drawing.Size(215, 34);
            this.cbWindowSate.StyleController = this.layoutControl1;
            this.cbWindowSate.TabIndex = 8;
            // 
            // beApiUrl
            // 
            this.beApiUrl.CausesValidation = false;
            this.beApiUrl.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appConfigsModelBindingSource, "InternalApiUrl", true));
            this.beApiUrl.Location = new System.Drawing.Point(101, 168);
            this.beApiUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.beApiUrl.MenuManager = this.barManager;
            this.beApiUrl.Name = "beApiUrl";
            editorButtonImageOptions2.SvgImage = global::Life_Log_App.Properties.Resources.business_world;
            editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(20, 20);
            this.beApiUrl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beApiUrl.Size = new System.Drawing.Size(833, 34);
            this.beApiUrl.StyleController = this.layoutControl1;
            this.beApiUrl.TabIndex = 7;
            this.beApiUrl.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beApiUrl_ButtonClick);
            // 
            // sbResetSize
            // 
            this.sbResetSize.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.sbResetSize.Appearance.Options.UseBackColor = true;
            this.sbResetSize.Location = new System.Drawing.Point(464, 43);
            this.sbResetSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbResetSize.Name = "sbResetSize";
            this.sbResetSize.Size = new System.Drawing.Size(103, 34);
            this.sbResetSize.StyleController = this.layoutControl1;
            this.sbResetSize.TabIndex = 6;
            this.sbResetSize.Text = "Reset Size";
            this.sbResetSize.Click += new System.EventHandler(this.sbResetSize_Click);
            // 
            // seFormWidth
            // 
            this.seFormWidth.CausesValidation = false;
            this.seFormWidth.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appConfigsModelBindingSource, "MainFormWidth", true));
            this.seFormWidth.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seFormWidth.Location = new System.Drawing.Point(97, 43);
            this.seFormWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seFormWidth.MenuManager = this.barManager;
            this.seFormWidth.Name = "seFormWidth";
            this.seFormWidth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seFormWidth.Properties.MaskSettings.Set("mask", "d");
            this.seFormWidth.Properties.UseMaskAsDisplayFormat = true;
            this.seFormWidth.Size = new System.Drawing.Size(134, 34);
            this.seFormWidth.StyleController = this.layoutControl1;
            this.seFormWidth.TabIndex = 5;
            // 
            // seFormHeight
            // 
            this.seFormHeight.CausesValidation = false;
            this.seFormHeight.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appConfigsModelBindingSource, "MainFormHeight", true));
            this.seFormHeight.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seFormHeight.Location = new System.Drawing.Point(323, 43);
            this.seFormHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seFormHeight.MenuManager = this.barManager;
            this.seFormHeight.Name = "seFormHeight";
            this.seFormHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seFormHeight.Properties.MaskSettings.Set("mask", "d");
            this.seFormHeight.Properties.UseMaskAsDisplayFormat = true;
            this.seFormHeight.Size = new System.Drawing.Size(135, 34);
            this.seFormHeight.StyleController = this.layoutControl1;
            this.seFormHeight.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Root.Size = new System.Drawing.Size(1089, 563);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 203);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1079, 350);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
            this.layoutControlGroup1.ExpandButtonVisible = true;
            this.layoutControlGroup1.ExpandOnDoubleClick = true;
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1079, 118);
            this.layoutControlGroup1.Text = "Form ";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.BestFitWeight = 50;
            this.layoutControlItem1.Control = this.seFormHeight;
            this.layoutControlItem1.Location = new System.Drawing.Point(226, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(227, 40);
            this.layoutControlItem1.Text = "Height";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.BestFitWeight = 50;
            this.layoutControlItem2.Control = this.seFormWidth;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(226, 40);
            this.layoutControlItem2.Text = "Width";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbResetSize;
            this.layoutControlItem3.Location = new System.Drawing.Point(453, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(109, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(109, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(109, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbWindowSate;
            this.layoutControlItem5.Location = new System.Drawing.Point(766, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(307, 40);
            this.layoutControlItem5.Text = "Start Mode";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(70, 19);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(562, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(204, 40);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 118);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(1079, 85);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 10, 3);
            this.layoutControlGroup2.Text = "Api Intenal";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.beApiUrl;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(929, 40);
            this.layoutControlItem4.Text = "Api Base Url";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(74, 19);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem6.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem6.Control = this.toggleSwitch1;
            this.layoutControlItem6.Location = new System.Drawing.Point(929, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(144, 40);
            this.layoutControlItem6.Text = "Active";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(38, 19);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.appConfigsModelBindingSource, "LastEmail", true));
            this.textEdit1.Location = new System.Drawing.Point(97, 83);
            this.textEdit1.MenuManager = this.barManager;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(981, 34);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textEdit1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(1073, 40);
            this.layoutControlItem7.Text = "Login Email";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(70, 19);
            // 
            // GeralSettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GeralSettingsView";
            this.Size = new System.Drawing.Size(1089, 604);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appConfigsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbWindowSate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beApiUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFormWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFormHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraDataLayout.DataLayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton sbResetSize;
        private DevExpress.XtraEditors.SpinEdit seFormWidth;
        private DevExpress.XtraEditors.SpinEdit seFormHeight;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ButtonEdit beApiUrl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ComboBoxEdit cbWindowSate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private System.Windows.Forms.BindingSource appConfigsModelBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}
