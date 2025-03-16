namespace Life_Log.Views.Tables.PasswordTypes
{
    partial class PasswordTypesDetailView
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
            DevExpress.Utils.ContextButton contextButton3 = new DevExpress.Utils.ContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordTypesDetailView));
            DevExpress.Utils.ContextButton contextButton4 = new DevExpress.Utils.ContextButton();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.beId = new DevExpress.XtraEditors.ButtonEdit();
            this.teCreatedAt = new DevExpress.XtraEditors.ButtonEdit();
            this.teUpdatedAt = new DevExpress.XtraEditors.ButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.passwordTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            this.dataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCreatedAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUpdatedAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.Controls.Add(this.peImage);
            this.dataLayoutControl.Controls.Add(this.teName);
            this.dataLayoutControl.Controls.Add(this.beId);
            this.dataLayoutControl.Controls.Add(this.teCreatedAt);
            this.dataLayoutControl.Controls.Add(this.teUpdatedAt);
            this.dataLayoutControl.DataSource = this.passwordTypesBindingSource;
            this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl.Name = "dataLayoutControl";
            this.dataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(940, 261, 650, 400);
            this.dataLayoutControl.Root = this.Root;
            this.dataLayoutControl.Size = new System.Drawing.Size(955, 585);
            this.dataLayoutControl.TabIndex = 1;
            this.dataLayoutControl.Text = "layoutControl1";
            // 
            // peImage
            // 
            this.peImage.CausesValidation = false;
            this.peImage.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.passwordTypesBindingSource, "Image", true));
            this.peImage.EditValue = "";
            this.peImage.Location = new System.Drawing.Point(432, 35);
            this.peImage.MaximumSize = new System.Drawing.Size(120, 120);
            this.peImage.MinimumSize = new System.Drawing.Size(120, 120);
            this.peImage.Name = "peImage";
            contextButton3.Id = new System.Guid("d215da8d-71d1-4f61-bf4c-19ec05a82572");
            contextButton3.ImageOptionsCollection.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            contextButton3.ImageOptionsCollection.ItemNormal.SvgImageSize = new System.Drawing.Size(20, 20);
            contextButton3.Name = "Choose Image";
            contextButton3.Tag = "OPEN";
            contextButton4.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton4.Id = new System.Guid("0eb9e607-d1a4-4bdc-aa04-48ec1f0d0d1f");
            contextButton4.ImageOptionsCollection.ItemNormal.SvgImage = global::Life_Log.Properties.Resources.delete;
            contextButton4.ImageOptionsCollection.ItemNormal.SvgImageSize = new System.Drawing.Size(20, 20);
            contextButton4.Name = "Clear Image";
            contextButton4.Tag = "CLEAR";
            this.peImage.Properties.ContextButtons.Add(contextButton3);
            this.peImage.Properties.ContextButtons.Add(contextButton4);
            this.peImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peImage.Properties.Tag = "ImageData";
            this.peImage.Size = new System.Drawing.Size(120, 120);
            this.peImage.StyleController = this.dataLayoutControl;
            this.peImage.TabIndex = 9;
            // 
            // teName
            // 
            this.teName.CausesValidation = false;
            this.teName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.passwordTypesBindingSource, "Name", true));
            this.teName.Location = new System.Drawing.Point(52, 161);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(900, 30);
            this.teName.StyleController = this.dataLayoutControl;
            this.teName.TabIndex = 6;
            this.teName.Tag = "";
            // 
            // beId
            // 
            this.beId.CausesValidation = false;
            this.beId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.passwordTypesBindingSource, "Id", true));
            this.beId.Location = new System.Drawing.Point(82, 239);
            this.beId.Name = "beId";
            editorButtonImageOptions2.SvgImage = global::Life_Log.Properties.Resources.copy;
            editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(20, 20);
            this.beId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.beId.Properties.ReadOnly = true;
            this.beId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beId.Size = new System.Drawing.Size(870, 30);
            this.beId.StyleController = this.dataLayoutControl;
            this.beId.TabIndex = 13;
            // 
            // teCreatedAt
            // 
            this.teCreatedAt.CausesValidation = false;
            this.teCreatedAt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.passwordTypesBindingSource, "CreatedAt", true));
            this.teCreatedAt.Location = new System.Drawing.Point(82, 275);
            this.teCreatedAt.Name = "teCreatedAt";
            this.teCreatedAt.Properties.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
            this.teCreatedAt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teCreatedAt.Properties.ReadOnly = true;
            this.teCreatedAt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.teCreatedAt.Size = new System.Drawing.Size(392, 30);
            this.teCreatedAt.StyleController = this.dataLayoutControl;
            this.teCreatedAt.TabIndex = 16;
            // 
            // teUpdatedAt
            // 
            this.teUpdatedAt.CausesValidation = false;
            this.teUpdatedAt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.passwordTypesBindingSource, "UpdatedAt", true));
            this.teUpdatedAt.Location = new System.Drawing.Point(559, 275);
            this.teUpdatedAt.Name = "teUpdatedAt";
            this.teUpdatedAt.Properties.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
            this.teUpdatedAt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.teUpdatedAt.Properties.ReadOnly = true;
            this.teUpdatedAt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.teUpdatedAt.Size = new System.Drawing.Size(393, 30);
            this.teUpdatedAt.StyleController = this.dataLayoutControl;
            this.teUpdatedAt.TabIndex = 17;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1,
            this.layoutControlGroup4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(955, 585);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 308);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(955, 277);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
            this.layoutControlGroup1.ExpandButtonVisible = true;
            this.layoutControlGroup1.ExpandOnDoubleClick = true;
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(955, 194);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Main Data";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teName;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "Name";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 126);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(955, 36);
            this.layoutControlItem3.Text = "Name";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(33, 16);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem6,
            this.emptySpaceItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
            this.layoutControlGroup3.Size = new System.Drawing.Size(955, 126);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.BestFitWeight = 105;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(400, 126);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem6.Control = this.peImage;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.CustomizationFormText = "Icon";
            this.layoutControlItem6.Location = new System.Drawing.Point(400, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(155, 126);
            this.layoutControlItem6.Text = "Icon";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(24, 16);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.BestFitWeight = 105;
            this.emptySpaceItem3.Location = new System.Drawing.Point(555, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(400, 126);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Details";
            this.layoutControlGroup4.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
            this.layoutControlGroup4.ExpandButtonVisible = true;
            this.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup4.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 194);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup4.Size = new System.Drawing.Size(955, 114);
            this.layoutControlGroup4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.layoutControlGroup4.Text = "Details";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.beId;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "Id";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(955, 36);
            this.layoutControlItem7.Text = "Id";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(63, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.teCreatedAt;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(477, 36);
            this.layoutControlItem4.Text = "Created At";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(63, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.teUpdatedAt;
            this.layoutControlItem5.Location = new System.Drawing.Point(477, 36);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(478, 36);
            this.layoutControlItem5.Text = "Updated At";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(63, 16);
            // 
            // passwordTypesBindingSource
            // 
            this.passwordTypesBindingSource.DataSource = typeof(Data.Entities.PasswordTypes);
            // 
            // PasswordTypesDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl);
            this.Name = "PasswordTypesDetailView";
            this.Size = new System.Drawing.Size(955, 585);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            this.dataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCreatedAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUpdatedAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.ButtonEdit beId;
        private DevExpress.XtraEditors.ButtonEdit teCreatedAt;
        private DevExpress.XtraEditors.ButtonEdit teUpdatedAt;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource passwordTypesBindingSource;
    }
}
