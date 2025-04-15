namespace LifeLogApp.Forms.Dialog
{
    partial class MessageBoxDialogForm
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
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.sbNo = new DevExpress.XtraEditors.SimpleButton();
            this.lcButtons = new DevExpress.XtraLayout.LayoutControl();
            this.sbOk = new DevExpress.XtraEditors.SimpleButton();
            this.sbYes = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.esiButtonLeft = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciBtnYesNo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.esiButtonRight = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciBtnOk = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.lcMessage = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgDetails = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcButtons)).BeginInit();
            this.lcButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiButtonLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiButtonRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationCaption = "Life Log";
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowPageKeyTipsMode = DevExpress.XtraBars.Ribbon.ShowPageKeyTipsMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(448, 49);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // sbNo
            // 
            this.sbNo.Appearance.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbNo.Appearance.Options.UseFont = true;
            this.sbNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.sbNo.ImageOptions.SvgImage = global::LifeLogApp.Properties.Resources.delete;
            this.sbNo.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.sbNo.Location = new System.Drawing.Point(214, 5);
            this.sbNo.MaximumSize = new System.Drawing.Size(100, 30);
            this.sbNo.MinimumSize = new System.Drawing.Size(100, 30);
            this.sbNo.Name = "sbNo";
            this.sbNo.Size = new System.Drawing.Size(100, 30);
            this.sbNo.StyleController = this.lcButtons;
            this.sbNo.TabIndex = 3;
            this.sbNo.Text = "NO";
            // 
            // lcButtons
            // 
            this.lcButtons.Controls.Add(this.sbOk);
            this.lcButtons.Controls.Add(this.sbYes);
            this.lcButtons.Controls.Add(this.sbNo);
            this.lcButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lcButtons.Location = new System.Drawing.Point(0, 130);
            this.lcButtons.MaximumSize = new System.Drawing.Size(0, 40);
            this.lcButtons.MinimumSize = new System.Drawing.Size(0, 40);
            this.lcButtons.Name = "lcButtons";
            this.lcButtons.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(871, 413, 650, 400);
            this.lcButtons.Root = this.Root;
            this.lcButtons.Size = new System.Drawing.Size(448, 40);
            this.lcButtons.TabIndex = 10;
            this.lcButtons.Text = "layoutControl1";
            // 
            // sbOk
            // 
            this.sbOk.Appearance.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.sbOk.Appearance.Options.UseFont = true;
            this.sbOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbOk.ImageOptions.SvgImage = global::LifeLogApp.Properties.Resources.markcomplete;
            this.sbOk.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.sbOk.Location = new System.Drawing.Point(314, 5);
            this.sbOk.MaximumSize = new System.Drawing.Size(100, 30);
            this.sbOk.MinimumSize = new System.Drawing.Size(100, 30);
            this.sbOk.Name = "sbOk";
            this.sbOk.Size = new System.Drawing.Size(100, 30);
            this.sbOk.StyleController = this.lcButtons;
            this.sbOk.TabIndex = 5;
            this.sbOk.Text = "OK";
            // 
            // sbYes
            // 
            this.sbYes.Appearance.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.sbYes.Appearance.Options.UseFont = true;
            this.sbYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.sbYes.ImageOptions.SvgImage = global::LifeLogApp.Properties.Resources.markcomplete;
            this.sbYes.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.sbYes.Location = new System.Drawing.Point(104, 5);
            this.sbYes.MaximumSize = new System.Drawing.Size(100, 30);
            this.sbYes.MinimumSize = new System.Drawing.Size(100, 30);
            this.sbYes.Name = "sbYes";
            this.sbYes.Size = new System.Drawing.Size(100, 30);
            this.sbYes.StyleController = this.lcButtons;
            this.sbYes.TabIndex = 4;
            this.sbYes.Text = "YES";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.esiButtonLeft,
            this.lciBtnYesNo,
            this.esiButtonRight,
            this.lciBtnOk});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Root.Size = new System.Drawing.Size(448, 40);
            this.Root.TextVisible = false;
            // 
            // esiButtonLeft
            // 
            this.esiButtonLeft.AllowHotTrack = false;
            this.esiButtonLeft.Location = new System.Drawing.Point(0, 0);
            this.esiButtonLeft.Name = "esiButtonLeft";
            this.esiButtonLeft.Size = new System.Drawing.Size(99, 30);
            this.esiButtonLeft.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciBtnYesNo
            // 
            this.lciBtnYesNo.BestFitWeight = 75;
            this.lciBtnYesNo.CustomizationFormText = "lciBtnYesNo";
            this.lciBtnYesNo.GroupBordersVisible = false;
            this.lciBtnYesNo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.emptySpaceItem2});
            this.lciBtnYesNo.Location = new System.Drawing.Point(99, 0);
            this.lciBtnYesNo.Name = "lciBtnYesNo";
            this.lciBtnYesNo.Size = new System.Drawing.Size(210, 30);
            this.lciBtnYesNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.BestFitWeight = 50;
            this.layoutControlItem2.Control = this.sbYes;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(100, 30);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.BestFitWeight = 50;
            this.layoutControlItem1.Control = this.sbNo;
            this.layoutControlItem1.Location = new System.Drawing.Point(110, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(100, 30);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(100, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(10, 0);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 30);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // esiButtonRight
            // 
            this.esiButtonRight.AllowHotTrack = false;
            this.esiButtonRight.BestFitWeight = 75;
            this.esiButtonRight.Location = new System.Drawing.Point(409, 0);
            this.esiButtonRight.Name = "esiButtonRight";
            this.esiButtonRight.Size = new System.Drawing.Size(29, 30);
            this.esiButtonRight.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciBtnOk
            // 
            this.lciBtnOk.Control = this.sbOk;
            this.lciBtnOk.CustomizationFormText = "lciBtnOk";
            this.lciBtnOk.Location = new System.Drawing.Point(309, 0);
            this.lciBtnOk.Name = "lciBtnOk";
            this.lciBtnOk.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciBtnOk.Size = new System.Drawing.Size(100, 30);
            this.lciBtnOk.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnOk.TextVisible = false;
            this.lciBtnOk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.lblCaption);
            this.lcMain.Controls.Add(this.lcMessage);
            this.lcMain.Controls.Add(this.pictureEdit1);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 49);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup2;
            this.lcMain.Size = new System.Drawing.Size(448, 81);
            this.lcMain.TabIndex = 12;
            this.lcMain.Text = "layoutControl2";
            // 
            // lblCaption
            // 
            this.lblCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblCaption.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            this.lblCaption.Appearance.Options.UseFont = true;
            this.lblCaption.Appearance.Options.UseForeColor = true;
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblCaption.Location = new System.Drawing.Point(95, 30);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(328, 25);
            this.lblCaption.StyleController = this.lcMain;
            this.lblCaption.TabIndex = 7;
            this.lblCaption.Text = "CAPTION";
            // 
            // lcMessage
            // 
            this.lcMessage.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lcMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lcMessage.Appearance.Options.UseBackColor = true;
            this.lcMessage.Appearance.Options.UseFont = true;
            this.lcMessage.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.lcMessage.AppearanceDisabled.Options.UseBackColor = true;
            this.lcMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lcMessage.Location = new System.Drawing.Point(8, 121);
            this.lcMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lcMessage.Name = "lcMessage";
            this.lcMessage.Size = new System.Drawing.Size(415, 25);
            this.lcMessage.StyleController = this.lcMain;
            this.lcMessage.TabIndex = 6;
            this.lcMessage.Text = "MESSAGE";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::LifeLogApp.Properties.Resources.question_mark;
            this.pictureEdit1.Location = new System.Drawing.Point(8, 8);
            this.pictureEdit1.MaximumSize = new System.Drawing.Size(70, 70);
            this.pictureEdit1.MenuManager = this.ribbon;
            this.pictureEdit1.MinimumSize = new System.Drawing.Size(70, 70);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.NullText = " ";
            this.pictureEdit1.Properties.ReadOnly = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(70, 70);
            this.pictureEdit1.StyleController = this.lcMain;
            this.pictureEdit1.TabIndex = 5;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.lcgDetails,
            this.layoutControlItem5,
            this.simpleSeparator1});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(431, 154);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.pictureEdit1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(76, 76);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // lcgDetails
            // 
            this.lcgDetails.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.lcgDetails.AppearanceGroup.Options.UseBorderColor = true;
            buttonImageOptions1.SvgImage = global::LifeLogApp.Properties.Resources.copy;
            buttonImageOptions1.SvgImageSize = new System.Drawing.Size(20, 20);
            this.lcgDetails.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", false, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.lcgDetails.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.lcgDetails.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.lcgDetails.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.lcgDetails.Location = new System.Drawing.Point(0, 76);
            this.lcgDetails.Name = "lcgDetails";
            this.lcgDetails.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgDetails.Size = new System.Drawing.Size(421, 73);
            this.lcgDetails.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.lcgDetails.Text = "Details";
            this.lcgDetails.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.lcgDetails_CustomButtonClick);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lcMessage;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(421, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem5.Control = this.lblCaption;
            this.layoutControlItem5.Location = new System.Drawing.Point(87, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(334, 76);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(76, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(11, 76);
            this.simpleSeparator1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 0, 0);
            // 
            // MessageBoxDialogForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 170);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.lcButtons);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.SvgImage = global::LifeLogApp.Properties.Resources.icon_svg;
            this.MaximumSize = new System.Drawing.Size(450, 400);
            this.MinimumSize = new System.Drawing.Size(450, 171);
            this.Name = "MessageBoxDialogForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBoxDialogForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcButtons)).EndInit();
            this.lcButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiButtonLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esiButtonRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.SimpleButton sbNo;
        private DevExpress.XtraLayout.LayoutControl lcButtons;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem esiButtonRight;
        private DevExpress.XtraEditors.SimpleButton sbYes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup lciBtnYesNo;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraEditors.LabelControl lcMessage;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDetails;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem esiButtonLeft;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton sbOk;
        private DevExpress.XtraLayout.LayoutControlItem lciBtnOk;
    }
}