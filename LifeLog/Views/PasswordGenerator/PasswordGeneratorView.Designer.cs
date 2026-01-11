using DevExpress.XtraLayout;

namespace LifeLog.Views.PasswordGenerator
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
			this.lciPasswordLength = new DevExpress.XtraLayout.LayoutControlItem();
			this.lciNumPasswords = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.bar = new DevExpress.XtraBars.Bar();
			this.bbiGenPass = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
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
			((System.ComponentModel.ISupportInitialize)(this.lciPasswordLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciNumPasswords)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
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
			this.layoutControl1.Location = new System.Drawing.Point(0, 24);
			this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(616, 331);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// passwordsCount
			// 
			this.passwordsCount.EditValue = 1;
			this.passwordsCount.Location = new System.Drawing.Point(112, 155);
			this.passwordsCount.Margin = new System.Windows.Forms.Padding(2);
			this.passwordsCount.Name = "passwordsCount";
			this.passwordsCount.Properties.LabelAppearance.Options.UseTextOptions = true;
			this.passwordsCount.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.passwordsCount.Properties.Maximum = 50;
			this.passwordsCount.Properties.Minimum = 1;
			this.passwordsCount.Size = new System.Drawing.Size(498, 45);
			this.passwordsCount.StyleController = this.layoutControl1;
			this.passwordsCount.TabIndex = 9;
			this.passwordsCount.Value = 1;
			this.passwordsCount.EditValueChanged += new System.EventHandler(this.event_Toggled);
			// 
			// passwordsList
			// 
			this.passwordsList.Location = new System.Drawing.Point(67, 234);
			this.passwordsList.Margin = new System.Windows.Forms.Padding(2);
			this.passwordsList.Name = "passwordsList";
			this.passwordsList.Size = new System.Drawing.Size(543, 91);
			this.passwordsList.StyleController = this.layoutControl1;
			this.passwordsList.TabIndex = 8;
			// 
			// tsUseLCLetters
			// 
			this.tsUseLCLetters.AutoSizeInLayoutControl = true;
			this.tsUseLCLetters.EditValue = true;
			this.tsUseLCLetters.Location = new System.Drawing.Point(286, 32);
			this.tsUseLCLetters.Margin = new System.Windows.Forms.Padding(2);
			this.tsUseLCLetters.Name = "tsUseLCLetters";
			this.tsUseLCLetters.Properties.AutoWidth = true;
			this.tsUseLCLetters.Properties.OffText = "No";
			this.tsUseLCLetters.Properties.OnText = "Yes";
			this.tsUseLCLetters.Size = new System.Drawing.Size(70, 18);
			this.tsUseLCLetters.StyleController = this.layoutControl1;
			this.tsUseLCLetters.TabIndex = 6;
			this.tsUseLCLetters.Toggled += new System.EventHandler(this.event_Toggled);
			// 
			// tsUseUCLetters
			// 
			this.tsUseUCLetters.AutoSizeInLayoutControl = true;
			this.tsUseUCLetters.EditValue = true;
			this.tsUseUCLetters.Location = new System.Drawing.Point(109, 32);
			this.tsUseUCLetters.Margin = new System.Windows.Forms.Padding(2);
			this.tsUseUCLetters.Name = "tsUseUCLetters";
			this.tsUseUCLetters.Properties.AutoWidth = true;
			this.tsUseUCLetters.Properties.OffText = "No";
			this.tsUseUCLetters.Properties.OnText = "Yes";
			this.tsUseUCLetters.Size = new System.Drawing.Size(70, 18);
			this.tsUseUCLetters.StyleController = this.layoutControl1;
			this.tsUseUCLetters.TabIndex = 6;
			this.tsUseUCLetters.Toggled += new System.EventHandler(this.event_Toggled);
			// 
			// tsUseNumbers
			// 
			this.tsUseNumbers.AutoSizeInLayoutControl = true;
			this.tsUseNumbers.EditValue = true;
			this.tsUseNumbers.Location = new System.Drawing.Point(286, 54);
			this.tsUseNumbers.Margin = new System.Windows.Forms.Padding(2);
			this.tsUseNumbers.Name = "tsUseNumbers";
			this.tsUseNumbers.Properties.AutoWidth = true;
			this.tsUseNumbers.Properties.OffText = "No";
			this.tsUseNumbers.Properties.OnText = "Yes";
			this.tsUseNumbers.Size = new System.Drawing.Size(70, 18);
			this.tsUseNumbers.StyleController = this.layoutControl1;
			this.tsUseNumbers.TabIndex = 6;
			this.tsUseNumbers.Toggled += new System.EventHandler(this.event_Toggled);
			// 
			// tsUseSpecialChars
			// 
			this.tsUseSpecialChars.AutoSizeInLayoutControl = true;
			this.tsUseSpecialChars.EditValue = true;
			this.tsUseSpecialChars.Location = new System.Drawing.Point(109, 54);
			this.tsUseSpecialChars.Margin = new System.Windows.Forms.Padding(2);
			this.tsUseSpecialChars.Name = "tsUseSpecialChars";
			this.tsUseSpecialChars.Properties.AutoWidth = true;
			this.tsUseSpecialChars.Properties.OffText = "No";
			this.tsUseSpecialChars.Properties.OnText = "Yes";
			this.tsUseSpecialChars.Size = new System.Drawing.Size(70, 18);
			this.tsUseSpecialChars.StyleController = this.layoutControl1;
			this.tsUseSpecialChars.TabIndex = 6;
			this.tsUseSpecialChars.Toggled += new System.EventHandler(this.event_Toggled);
			// 
			// passwordLegth
			// 
			this.passwordLegth.EditValue = 20;
			this.passwordLegth.Location = new System.Drawing.Point(112, 106);
			this.passwordLegth.Margin = new System.Windows.Forms.Padding(2);
			this.passwordLegth.Name = "passwordLegth";
			this.passwordLegth.Properties.LabelAppearance.Options.UseTextOptions = true;
			this.passwordLegth.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.passwordLegth.Properties.Maximum = 100;
			this.passwordLegth.Properties.Minimum = 1;
			this.passwordLegth.Size = new System.Drawing.Size(498, 45);
			this.passwordLegth.StyleController = this.layoutControl1;
			this.passwordLegth.TabIndex = 9;
			this.passwordLegth.Value = 20;
			this.passwordLegth.EditValueChanged += new System.EventHandler(this.event_Toggled);
			// 
			// BaseRoot
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.layoutControlGroup3});
			this.Root.Name = "Root";
			this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 8, 4);
			this.Root.Size = new System.Drawing.Size(616, 331);
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
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Size = new System.Drawing.Size(608, 66);
			this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup1.Text = "Settings";
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.tsUseUCLetters;
			this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(177, 22);
			this.layoutControlItem1.Text = "Uper Case Letters";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.tsUseSpecialChars;
			this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 22);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(177, 22);
			this.layoutControlItem5.Text = "Special Characters";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(93, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.tsUseLCLetters;
			this.layoutControlItem3.Location = new System.Drawing.Point(177, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(177, 22);
			this.layoutControlItem3.Text = "Lower Case Letters";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.tsUseNumbers;
			this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
			this.layoutControlItem2.Location = new System.Drawing.Point(177, 22);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(177, 22);
			this.layoutControlItem2.Text = "Numbers";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
			this.layoutControlGroup2.ExpandButtonVisible = true;
			this.layoutControlGroup2.ExpandOnDoubleClick = true;
			this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.layoutControlGroup2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPasswordLength,
            this.lciNumPasswords});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 66);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
			this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup2.Size = new System.Drawing.Size(608, 128);
			this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 8, 0);
			this.layoutControlGroup2.Text = "Lengh";
			// 
			// lciPasswordLength
			// 
			this.lciPasswordLength.Control = this.passwordLegth;
			this.lciPasswordLength.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
			this.lciPasswordLength.CustomizationFormText = "Num. Passwords";
			this.lciPasswordLength.Location = new System.Drawing.Point(0, 0);
			this.lciPasswordLength.Name = "lciPasswordLength";
			this.lciPasswordLength.Size = new System.Drawing.Size(608, 49);
			this.lciPasswordLength.Text = "Length (20)";
			this.lciPasswordLength.TextSize = new System.Drawing.Size(96, 13);
			// 
			// lciNumPasswords
			// 
			this.lciNumPasswords.Control = this.passwordsCount;
			this.lciNumPasswords.Location = new System.Drawing.Point(0, 49);
			this.lciNumPasswords.Name = "lciNumPasswords";
			this.lciNumPasswords.Size = new System.Drawing.Size(608, 49);
			this.lciNumPasswords.Text = "Num. Passwords (1)";
			this.lciNumPasswords.TextSize = new System.Drawing.Size(96, 13);
			// 
			// layoutControlGroup3
			// 
			this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
			this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
			this.layoutControlGroup3.Location = new System.Drawing.Point(0, 194);
			this.layoutControlGroup3.Name = "layoutControlGroup3";
			this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
			this.layoutControlGroup3.Size = new System.Drawing.Size(608, 125);
			this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 8, 0);
			this.layoutControlGroup3.Text = "List Passowords";
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
			this.layoutControlItem6.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.layoutControlItem6.Control = this.passwordsList;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(608, 95);
			this.layoutControlItem6.Text = "Passwords";
			this.layoutControlItem6.TextSize = new System.Drawing.Size(51, 13);
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
			this.bbiGenPass.ImageOptions.SvgImage = global::LifeLog.Properties.Resources.bo_resume;
			this.bbiGenPass.Name = "bbiGenPass";
			this.bbiGenPass.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.bbiGenPass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGenPass_ItemClick);
			// 
			// barBaseDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager;
			this.barDockControlTop.Size = new System.Drawing.Size(616, 24);
			// 
			// barBaseDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 355);
			this.barDockControlBottom.Manager = this.barManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(616, 0);
			// 
			// barBaseDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
			this.barDockControlLeft.Manager = this.barManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 331);
			// 
			// barBaseDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(616, 24);
			this.barDockControlRight.Manager = this.barManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 331);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.Location = new System.Drawing.Point(354, 22);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(254, 22);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.Location = new System.Drawing.Point(354, 0);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(254, 22);
			// 
			// PasswordGeneratorView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "PasswordGeneratorView";
			this.Size = new System.Drawing.Size(616, 355);
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
			((System.ComponentModel.ISupportInitialize)(this.lciPasswordLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciNumPasswords)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
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
		private LayoutControlItem lciNumPasswords;
		private DevExpress.XtraEditors.TrackBarControl passwordLegth;
		private LayoutControlItem lciPasswordLength;
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
		private EmptySpaceItem emptySpaceItem1;
		private EmptySpaceItem emptySpaceItem2;
	}
}
