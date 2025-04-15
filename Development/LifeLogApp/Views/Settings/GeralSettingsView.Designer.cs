namespace LifeLogApp.Views.Settings
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
            components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            barManager = new DevExpress.XtraBars.BarManager(components);
            bar = new DevExpress.XtraBars.Bar();
            bbiSave = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            cbWindowSate = new DevExpress.XtraEditors.ComboBoxEdit();
            buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            sbResetSize = new DevExpress.XtraEditors.SimpleButton();
            seFormWidth = new DevExpress.XtraEditors.SpinEdit();
            seFormHeight = new DevExpress.XtraEditors.SpinEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toggleSwitch1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbWindowSate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seFormWidth.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seFormHeight.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
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
            barDockControlTop.Size = new System.Drawing.Size(1089, 41);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 604);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            barDockControlBottom.Size = new System.Drawing.Size(1089, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            barDockControlLeft.Size = new System.Drawing.Size(0, 563);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1089, 41);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            barDockControlRight.Size = new System.Drawing.Size(0, 563);
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(toggleSwitch1);
            layoutControl1.Controls.Add(cbWindowSate);
            layoutControl1.Controls.Add(buttonEdit1);
            layoutControl1.Controls.Add(sbResetSize);
            layoutControl1.Controls.Add(seFormWidth);
            layoutControl1.Controls.Add(seFormHeight);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 41);
            layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 216, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(1089, 563);
            layoutControl1.TabIndex = 4;
            layoutControl1.Text = "layoutControl1";
            // 
            // toggleSwitch1
            // 
            toggleSwitch1.AutoSizeInLayoutControl = true;
            toggleSwitch1.Location = new System.Drawing.Point(997, 117);
            toggleSwitch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            toggleSwitch1.MenuManager = barManager;
            toggleSwitch1.Name = "toggleSwitch1";
            toggleSwitch1.Properties.AutoWidth = true;
            toggleSwitch1.Properties.OffText = "Off";
            toggleSwitch1.Properties.OnText = "On";
            toggleSwitch1.Size = new System.Drawing.Size(84, 24);
            toggleSwitch1.StyleController = layoutControl1;
            toggleSwitch1.TabIndex = 9;
            // 
            // cbWindowSate
            // 
            cbWindowSate.Location = new System.Drawing.Point(864, 40);
            cbWindowSate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbWindowSate.MenuManager = barManager;
            cbWindowSate.Name = "cbWindowSate";
            cbWindowSate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbWindowSate.Size = new System.Drawing.Size(217, 34);
            cbWindowSate.StyleController = layoutControl1;
            cbWindowSate.TabIndex = 8;
            // 
            // buttonEdit1
            // 
            buttonEdit1.Location = new System.Drawing.Point(98, 112);
            buttonEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonEdit1.MenuManager = barManager;
            buttonEdit1.Name = "buttonEdit1";
            editorButtonImageOptions2.SvgImage = Properties.Resources.business_world;
            editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(20, 20);
            buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            buttonEdit1.Size = new System.Drawing.Size(839, 34);
            buttonEdit1.StyleController = layoutControl1;
            buttonEdit1.TabIndex = 7;
            // 
            // sbResetSize
            // 
            sbResetSize.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            sbResetSize.Appearance.Options.UseBackColor = true;
            sbResetSize.Location = new System.Drawing.Point(463, 40);
            sbResetSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            sbResetSize.Name = "sbResetSize";
            sbResetSize.Size = new System.Drawing.Size(103, 34);
            sbResetSize.StyleController = layoutControl1;
            sbResetSize.TabIndex = 6;
            sbResetSize.Text = "Reset Size";
            sbResetSize.Click += sbResetSize_Click;
            // 
            // seFormWidth
            // 
            seFormWidth.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seFormWidth.Location = new System.Drawing.Point(94, 40);
            seFormWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            seFormWidth.MenuManager = barManager;
            seFormWidth.Name = "seFormWidth";
            seFormWidth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seFormWidth.Properties.MaskSettings.Set("mask", "d");
            seFormWidth.Properties.UseMaskAsDisplayFormat = true;
            seFormWidth.Size = new System.Drawing.Size(135, 34);
            seFormWidth.StyleController = layoutControl1;
            seFormWidth.TabIndex = 5;
            // 
            // seFormHeight
            // 
            seFormHeight.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seFormHeight.Location = new System.Drawing.Point(321, 40);
            seFormHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            seFormHeight.MenuManager = barManager;
            seFormHeight.Name = "seFormHeight";
            seFormHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seFormHeight.Properties.MaskSettings.Set("mask", "d");
            seFormHeight.Properties.UseMaskAsDisplayFormat = true;
            seFormHeight.Size = new System.Drawing.Size(136, 34);
            seFormHeight.StyleController = layoutControl1;
            seFormHeight.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, layoutControlGroup1, layoutControlGroup2 });
            Root.Name = "Root";
            Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            Root.Size = new System.Drawing.Size(1089, 563);
            Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(0, 144);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(1079, 409);
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
            layoutControlGroup1.ExpandButtonVisible = true;
            layoutControlGroup1.ExpandOnDoubleClick = true;
            layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            layoutControlGroup1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem5, emptySpaceItem2 });
            layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
            layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlGroup1.Size = new System.Drawing.Size(1079, 72);
            layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlGroup1.Text = "Form ";
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.BestFitWeight = 50;
            layoutControlItem1.Control = seFormHeight;
            layoutControlItem1.Location = new System.Drawing.Point(227, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(228, 40);
            layoutControlItem1.Text = "Height";
            layoutControlItem1.TextSize = new System.Drawing.Size(70, 19);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.BestFitWeight = 50;
            layoutControlItem2.Control = seFormWidth;
            layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(227, 40);
            layoutControlItem2.Text = "Width";
            layoutControlItem2.TextSize = new System.Drawing.Size(70, 19);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = sbResetSize;
            layoutControlItem3.Location = new System.Drawing.Point(455, 0);
            layoutControlItem3.MaxSize = new System.Drawing.Size(109, 0);
            layoutControlItem3.MinSize = new System.Drawing.Size(109, 40);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(109, 40);
            layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = cbWindowSate;
            layoutControlItem5.Location = new System.Drawing.Point(770, 0);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(309, 40);
            layoutControlItem5.Text = "Start Mode";
            layoutControlItem5.TextSize = new System.Drawing.Size(70, 19);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.Location = new System.Drawing.Point(564, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(206, 40);
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem4, layoutControlItem6 });
            layoutControlGroup2.Location = new System.Drawing.Point(0, 72);
            layoutControlGroup2.Name = "layoutControlGroup2";
            layoutControlGroup2.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
            layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlGroup2.Size = new System.Drawing.Size(1079, 72);
            layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlGroup2.Text = "Api Intenal";
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = buttonEdit1;
            layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(935, 40);
            layoutControlItem4.Text = "Api Base Url";
            layoutControlItem4.TextSize = new System.Drawing.Size(74, 19);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            layoutControlItem6.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControlItem6.Control = toggleSwitch1;
            layoutControlItem6.Location = new System.Drawing.Point(935, 0);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(144, 40);
            layoutControlItem6.Text = "Active";
            layoutControlItem6.TextSize = new System.Drawing.Size(38, 19);
            // 
            // GeralSettingsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "GeralSettingsView";
            Size = new System.Drawing.Size(1089, 604);
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toggleSwitch1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbWindowSate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seFormWidth.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seFormHeight.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
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
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ComboBoxEdit cbWindowSate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    }
}
