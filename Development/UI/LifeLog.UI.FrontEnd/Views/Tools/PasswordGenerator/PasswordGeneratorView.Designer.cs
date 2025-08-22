using DevExpress.XtraLayout;

namespace LifeLog.UI.FrontEnd.Views.Tools.PasswordGenerator
{
	partial class PasswordGeneratorView
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.passwordsCount = new DevExpress.XtraEditors.TrackBarControl();
            this.passwordsList = new DevExpress.XtraEditors.MemoEdit();
            this.tsUseLCLetters = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsUseUCLetters = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsUseNumbers = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsUseSpecialChars = new DevExpress.XtraEditors.ToggleSwitch();
            this.passwordLegth = new DevExpress.XtraEditors.TrackBarControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.bbiGenPass = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsUseLCLetters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsUseUCLetters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsUseNumbers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsUseSpecialChars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLegth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLegth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.passwordsCount);
            this.layoutControl1.Controls.Add(this.passwordsList);
            this.layoutControl1.Controls.Add(this.tsUseLCLetters);
            this.layoutControl1.Controls.Add(this.tsUseUCLetters);
            this.layoutControl1.Controls.Add(this.tsUseNumbers);
            this.layoutControl1.Controls.Add(this.tsUseSpecialChars);
            this.layoutControl1.Controls.Add(this.passwordLegth);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 39);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(719, 398);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // passwordsCount
            // 
            this.passwordsCount.EditValue = 1;
            this.passwordsCount.Location = new System.Drawing.Point(119, 198);
            this.passwordsCount.Margin = new System.Windows.Forms.Padding(2);
            this.passwordsCount.Name = "passwordsCount";
            this.passwordsCount.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.passwordsCount.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.passwordsCount.Properties.Maximum = 50;
            this.passwordsCount.Properties.Minimum = 1;
            this.passwordsCount.Size = new System.Drawing.Size(592, 45);
            this.passwordsCount.StyleController = this.layoutControl1;
            this.passwordsCount.TabIndex = 9;
            this.passwordsCount.Value = 1;
            this.passwordsCount.EditValueChanged += new System.EventHandler(this.event_Toggled);
            // 
            // passwordsList
            // 
            this.passwordsList.Location = new System.Drawing.Point(85, 291);
            this.passwordsList.Margin = new System.Windows.Forms.Padding(2);
            this.passwordsList.Name = "passwordsList";
            this.passwordsList.Size = new System.Drawing.Size(626, 99);
            this.passwordsList.StyleController = this.layoutControl1;
            this.passwordsList.TabIndex = 8;
            // 
            // tsUseLCLetters
            // 
            this.tsUseLCLetters.EditValue = true;
            this.tsUseLCLetters.Location = new System.Drawing.Point(490, 45);
            this.tsUseLCLetters.Margin = new System.Windows.Forms.Padding(2);
            this.tsUseLCLetters.Name = "tsUseLCLetters";
            this.tsUseLCLetters.Properties.OffText = "No";
            this.tsUseLCLetters.Properties.OnText = "Yes";
            this.tsUseLCLetters.Size = new System.Drawing.Size(221, 24);
            this.tsUseLCLetters.StyleController = this.layoutControl1;
            this.tsUseLCLetters.TabIndex = 6;
            this.tsUseLCLetters.Toggled += new System.EventHandler(this.event_Toggled);
            // 
            // tsUseUCLetters
            // 
            this.tsUseUCLetters.EditValue = true;
            this.tsUseUCLetters.Location = new System.Drawing.Point(134, 45);
            this.tsUseUCLetters.Margin = new System.Windows.Forms.Padding(2);
            this.tsUseUCLetters.Name = "tsUseUCLetters";
            this.tsUseUCLetters.Properties.OffText = "No";
            this.tsUseUCLetters.Properties.OnText = "Yes";
            this.tsUseUCLetters.Size = new System.Drawing.Size(224, 24);
            this.tsUseUCLetters.StyleController = this.layoutControl1;
            this.tsUseUCLetters.TabIndex = 6;
            this.tsUseUCLetters.Toggled += new System.EventHandler(this.event_Toggled);
            // 
            // tsUseNumbers
            // 
            this.tsUseNumbers.EditValue = true;
            this.tsUseNumbers.Location = new System.Drawing.Point(490, 75);
            this.tsUseNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.tsUseNumbers.Name = "tsUseNumbers";
            this.tsUseNumbers.Properties.OffText = "No";
            this.tsUseNumbers.Properties.OnText = "Yes";
            this.tsUseNumbers.Size = new System.Drawing.Size(221, 24);
            this.tsUseNumbers.StyleController = this.layoutControl1;
            this.tsUseNumbers.TabIndex = 6;
            this.tsUseNumbers.Toggled += new System.EventHandler(this.event_Toggled);
            // 
            // tsUseSpecialChars
            // 
            this.tsUseSpecialChars.EditValue = true;
            this.tsUseSpecialChars.Location = new System.Drawing.Point(134, 75);
            this.tsUseSpecialChars.Margin = new System.Windows.Forms.Padding(2);
            this.tsUseSpecialChars.Name = "tsUseSpecialChars";
            this.tsUseSpecialChars.Properties.OffText = "No";
            this.tsUseSpecialChars.Properties.OnText = "Yes";
            this.tsUseSpecialChars.Size = new System.Drawing.Size(224, 24);
            this.tsUseSpecialChars.StyleController = this.layoutControl1;
            this.tsUseSpecialChars.TabIndex = 6;
            this.tsUseSpecialChars.Toggled += new System.EventHandler(this.event_Toggled);
            // 
            // passwordLegth
            // 
            this.passwordLegth.EditValue = 20;
            this.passwordLegth.Location = new System.Drawing.Point(119, 147);
            this.passwordLegth.Margin = new System.Windows.Forms.Padding(2);
            this.passwordLegth.Name = "passwordLegth";
            this.passwordLegth.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.passwordLegth.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.passwordLegth.Properties.Maximum = 100;
            this.passwordLegth.Properties.Minimum = 1;
            this.passwordLegth.Size = new System.Drawing.Size(592, 45);
            this.passwordLegth.StyleController = this.layoutControl1;
            this.passwordLegth.TabIndex = 9;
            this.passwordLegth.Value = 20;
            this.passwordLegth.EditValueChanged += new System.EventHandler(this.event_Toggled);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 5);
            this.Root.Size = new System.Drawing.Size(719, 398);
            this.Root.TextVisible = false;
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
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(709, 92);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Settings";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tsUseUCLetters;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(356, 30);
            this.layoutControlItem1.Text = "Uper Case Letters";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(110, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tsUseSpecialChars;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(356, 30);
            this.layoutControlItem5.Text = "Special Characters";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(110, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tsUseLCLetters;
            this.layoutControlItem3.Location = new System.Drawing.Point(356, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(353, 30);
            this.layoutControlItem3.Text = "Lower Case Letters";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(110, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tsUseNumbers;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem2.Location = new System.Drawing.Point(356, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(353, 30);
            this.layoutControlItem2.Text = "Numbers";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(110, 16);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
            this.layoutControlGroup2.ExpandButtonVisible = true;
            this.layoutControlGroup2.ExpandOnDoubleClick = true;
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 92);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(709, 144);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.layoutControlGroup2.Text = "Lengh";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.passwordLegth;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem4.CustomizationFormText = "Num. Passwords";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(709, 51);
            this.layoutControlItem4.Text = "Length";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.passwordsCount;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 51);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(709, 51);
            this.layoutControlItem7.Text = "Num. Passwords";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 236);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.Size = new System.Drawing.Size(709, 147);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.layoutControlGroup3.Text = "List Passowords";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem6.Control = this.passwordsList;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(709, 105);
            this.layoutControlItem6.Text = "Passwords";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(61, 16);
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
            this.bbiGenPass});
            this.barManager.MainMenu = this.bar;
            this.barManager.MaxItemId = 3;
            // 
            // bar
            // 
            this.bar.BarName = "Main menu";
            this.bar.DockCol = 0;
            this.bar.DockRow = 0;
            this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiGenPass)});
            this.bar.OptionsBar.AllowQuickCustomization = false;
            this.bar.OptionsBar.DisableCustomization = true;
            this.bar.OptionsBar.DrawBorder = false;
            this.bar.OptionsBar.DrawDragBorder = false;
            this.bar.OptionsBar.MultiLine = true;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.Text = "Main menu";
            // 
            // bbiGenPass
            // 
            this.bbiGenPass.Caption = "Gen. Passwords";
            this.bbiGenPass.Id = 0;
            this.bbiGenPass.ImageOptions.SvgImage = Properties.Resources.bo_resume;
            this.bbiGenPass.Name = "bbiGenPass";
            this.bbiGenPass.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiGenPass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGenPass_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(719, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 437);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(719, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(719, 39);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 398);
            // 
            // PasswordGeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PasswordGeneratorView";
            this.Size = new System.Drawing.Size(719, 437);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordsCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsUseLCLetters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsUseUCLetters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsUseNumbers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsUseSpecialChars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLegth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLegth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LayoutControl layoutControl1;
		private LayoutControlGroup Root;
		private DevExpress.XtraEditors.ToggleSwitch tsUseLCLetters;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraEditors.ToggleSwitch tsUseUCLetters;
		private DevExpress.XtraEditors.ToggleSwitch tsUseNumbers;
		private DevExpress.XtraEditors.ToggleSwitch tsUseSpecialChars;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraEditors.MemoEdit passwordsList;
		private LayoutControlItem layoutControlItem6;
		private DevExpress.XtraEditors.TrackBarControl passwordsCount;
		private LayoutControlItem layoutControlItem7;
		private DevExpress.XtraEditors.TrackBarControl passwordLegth;
		private LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiGenPass;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlGroup layoutControlGroup3;
    }
}
