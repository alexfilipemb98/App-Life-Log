namespace LifeLog.UI.FrontEnd.Views.Tools.GradesCalculator
{
	partial class BaseLineView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseLineView));
			this.pcBase = new DevExpress.XtraEditors.PanelControl();
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.txtNameBase = new DevExpress.XtraEditors.TextEdit();
			this.seGradeBase = new DevExpress.XtraEditors.SpinEdit();
			this.seWeigthBase = new DevExpress.XtraEditors.SpinEdit();
			this.btnRemoveBase = new DevExpress.XtraEditors.SimpleButton();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.pcBase)).BeginInit();
			this.pcBase.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtNameBase.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.seGradeBase.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.seWeigthBase.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// pcBase
			// 
			this.pcBase.Controls.Add(this.layoutControl);
			this.pcBase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pcBase.Location = new System.Drawing.Point(0, 0);
			this.pcBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pcBase.MaximumSize = new System.Drawing.Size(0, 46);
			this.pcBase.MinimumSize = new System.Drawing.Size(0, 46);
			this.pcBase.Name = "pcBase";
			this.pcBase.Size = new System.Drawing.Size(0, 46);
			this.pcBase.TabIndex = 7;
			// 
			// layoutControl
			// 
			this.layoutControl.Controls.Add(this.txtNameBase);
			this.layoutControl.Controls.Add(this.seGradeBase);
			this.layoutControl.Controls.Add(this.seWeigthBase);
			this.layoutControl.Controls.Add(this.btnRemoveBase);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(1, 2);
			this.layoutControl.Margin = new System.Windows.Forms.Padding(0);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.Root = this.layoutControlGroup1;
			this.layoutControl.Size = new System.Drawing.Size(0, 42);
			this.layoutControl.TabIndex = 0;
			this.layoutControl.Text = "layoutControl2";
			// 
			// txtNameBase
			// 
			this.txtNameBase.Location = new System.Drawing.Point(35, 10);
			this.txtNameBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNameBase.Name = "txtNameBase";
			this.txtNameBase.Size = new System.Drawing.Size(50, 20);
			this.txtNameBase.StyleController = this.layoutControl;
			this.txtNameBase.TabIndex = 9;
			// 
			// seGradeBase
			// 
			this.seGradeBase.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.seGradeBase.Location = new System.Drawing.Point(120, 10);
			this.seGradeBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.seGradeBase.MaximumSize = new System.Drawing.Size(146, 0);
			this.seGradeBase.MinimumSize = new System.Drawing.Size(146, 0);
			this.seGradeBase.Name = "seGradeBase";
			this.seGradeBase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.seGradeBase.Properties.EditValueChangedDelay = 1000;
			this.seGradeBase.Size = new System.Drawing.Size(146, 20);
			this.seGradeBase.StyleController = this.layoutControl;
			this.seGradeBase.TabIndex = 8;
			// 
			// seWeigthBase
			// 
			this.seWeigthBase.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.seWeigthBase.Location = new System.Drawing.Point(306, 10);
			this.seWeigthBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.seWeigthBase.MaximumSize = new System.Drawing.Size(146, 0);
			this.seWeigthBase.MinimumSize = new System.Drawing.Size(146, 0);
			this.seWeigthBase.Name = "seWeigthBase";
			this.seWeigthBase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.seWeigthBase.Properties.EditValueChangedDelay = 1000;
			this.seWeigthBase.Size = new System.Drawing.Size(146, 20);
			this.seWeigthBase.StyleController = this.layoutControl;
			this.seWeigthBase.TabIndex = 7;
			// 
			// btnRemoveBase
			// 
			this.btnRemoveBase.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemoveBase.ImageOptions.SvgImage")));
			this.btnRemoveBase.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
			this.btnRemoveBase.Location = new System.Drawing.Point(456, 6);
			this.btnRemoveBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRemoveBase.MaximumSize = new System.Drawing.Size(27, 24);
			this.btnRemoveBase.MinimumSize = new System.Drawing.Size(27, 24);
			this.btnRemoveBase.Name = "btnRemoveBase";
			this.btnRemoveBase.Size = new System.Drawing.Size(27, 24);
			this.btnRemoveBase.StyleController = this.layoutControl;
			this.btnRemoveBase.TabIndex = 6;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3});
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
			this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 2;
			this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
			this.layoutControlGroup1.Size = new System.Drawing.Size(492, 40);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.BestFitWeight = 50;
			this.layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
			this.layoutControlItem4.Control = this.btnRemoveBase;
			this.layoutControlItem4.Location = new System.Drawing.Point(450, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(34, 32);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.BestFitWeight = 75;
			this.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
			this.layoutControlItem2.Control = this.seGradeBase;
			this.layoutControlItem2.Location = new System.Drawing.Point(83, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(181, 32);
			this.layoutControlItem2.Text = "Grade";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(29, 13);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.BestFitWeight = 75;
			this.layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
			this.layoutControlItem1.Control = this.seWeigthBase;
			this.layoutControlItem1.Location = new System.Drawing.Point(264, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(186, 32);
			this.layoutControlItem1.Text = "Weight";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(34, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.BestFitWeight = 150;
			this.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
			this.layoutControlItem3.Control = this.txtNameBase;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(83, 32);
			this.layoutControlItem3.Text = "Name";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(27, 13);
			// 
			// BaseLineView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pcBase);
			this.MaximumSize = new System.Drawing.Size(0, 46);
			this.MinimumSize = new System.Drawing.Size(0, 46);
			this.Name = "BaseLineView";
			this.Size = new System.Drawing.Size(0, 46);
			((System.ComponentModel.ISupportInitialize)(this.pcBase)).EndInit();
			this.pcBase.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtNameBase.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.seGradeBase.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.seWeigthBase.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl pcBase;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		internal DevExpress.XtraLayout.LayoutControl layoutControl;
		internal DevExpress.XtraEditors.TextEdit txtNameBase;
		internal DevExpress.XtraEditors.SpinEdit seGradeBase;
		internal DevExpress.XtraEditors.SpinEdit seWeigthBase;
		internal DevExpress.XtraEditors.SimpleButton btnRemoveBase;
	}
}
