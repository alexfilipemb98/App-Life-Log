namespace LifeLog.Views.GradesCalculator
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
            pcBase = new DevExpress.XtraEditors.PanelControl();
            layoutControl = new DevExpress.XtraLayout.LayoutControl();
            txtNameBase = new DevExpress.XtraEditors.TextEdit();
            seGradeBase = new DevExpress.XtraEditors.SpinEdit();
            seWeigthBase = new DevExpress.XtraEditors.SpinEdit();
            btnRemoveBase = new DevExpress.XtraEditors.SimpleButton();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)pcBase).BeginInit();
            pcBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNameBase.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seGradeBase.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seWeigthBase.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            SuspendLayout();
            // 
            // pcBase
            // 
            pcBase.Controls.Add(layoutControl);
            pcBase.Dock = DockStyle.Fill;
            pcBase.Location = new Point(0, 0);
            pcBase.Margin = new Padding(0);
            pcBase.MaximumSize = new Size(0, 46);
            pcBase.MinimumSize = new Size(0, 46);
            pcBase.Name = "pcBase";
            pcBase.Size = new Size(724, 46);
            pcBase.TabIndex = 7;
            // 
            // layoutControl
            // 
            layoutControl.Controls.Add(txtNameBase);
            layoutControl.Controls.Add(seGradeBase);
            layoutControl.Controls.Add(seWeigthBase);
            layoutControl.Controls.Add(btnRemoveBase);
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Location = new Point(2, 2);
            layoutControl.Margin = new Padding(0);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = layoutControlGroup1;
            layoutControl.Size = new Size(720, 42);
            layoutControl.TabIndex = 0;
            layoutControl.Text = "layoutControl2";
            // 
            // txtNameBase
            // 
            txtNameBase.Location = new Point(33, 7);
            txtNameBase.Margin = new Padding(3, 2, 3, 2);
            txtNameBase.Name = "txtNameBase";
            txtNameBase.Size = new Size(275, 28);
            txtNameBase.StyleController = layoutControl;
            txtNameBase.TabIndex = 9;
            // 
            // seGradeBase
            // 
            seGradeBase.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seGradeBase.Location = new Point(345, 7);
            seGradeBase.Margin = new Padding(3, 2, 3, 2);
            seGradeBase.MaximumSize = new Size(146, 0);
            seGradeBase.MinimumSize = new Size(146, 0);
            seGradeBase.Name = "seGradeBase";
            seGradeBase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seGradeBase.Properties.EditValueChangedDelay = 1000;
            seGradeBase.Size = new Size(146, 28);
            seGradeBase.StyleController = layoutControl;
            seGradeBase.TabIndex = 8;
            // 
            // seWeigthBase
            // 
            seWeigthBase.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            seWeigthBase.Location = new Point(533, 7);
            seWeigthBase.Margin = new Padding(3, 2, 3, 2);
            seWeigthBase.MaximumSize = new Size(146, 0);
            seWeigthBase.MinimumSize = new Size(146, 0);
            seWeigthBase.Name = "seWeigthBase";
            seWeigthBase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            seWeigthBase.Properties.EditValueChangedDelay = 1000;
            seWeigthBase.Size = new Size(146, 28);
            seWeigthBase.StyleController = layoutControl;
            seWeigthBase.TabIndex = 7;
            // 
            // btnRemoveBase
            // 
            btnRemoveBase.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnRemoveBase.ImageOptions.SvgImage");
            btnRemoveBase.ImageOptions.SvgImageSize = new Size(24, 24);
            btnRemoveBase.Location = new Point(685, 6);
            btnRemoveBase.Margin = new Padding(3, 2, 3, 2);
            btnRemoveBase.Name = "btnRemoveBase";
            btnRemoveBase.Size = new Size(32, 30);
            btnRemoveBase.StyleController = layoutControl;
            btnRemoveBase.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem4, layoutControlItem2, layoutControlItem1, layoutControlItem3 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
            layoutControlGroup1.OptionsItemText.TextToControlDistance = 2;
            layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            layoutControlGroup1.Size = new Size(720, 42);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.BestFitWeight = 50;
            layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControlItem4.Control = btnRemoveBase;
            layoutControlItem4.Location = new Point(682, 0);
            layoutControlItem4.MaxSize = new Size(38, 36);
            layoutControlItem4.MinSize = new Size(38, 36);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(38, 42);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.BestFitWeight = 75;
            layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControlItem2.Control = seGradeBase;
            layoutControlItem2.Location = new Point(311, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(183, 42);
            layoutControlItem2.Text = "Grade";
            layoutControlItem2.TextSize = new Size(29, 13);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.BestFitWeight = 75;
            layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControlItem1.Control = seWeigthBase;
            layoutControlItem1.Location = new Point(494, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(188, 42);
            layoutControlItem1.Text = "Weight";
            layoutControlItem1.TextSize = new Size(34, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.BestFitWeight = 150;
            layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControlItem3.Control = txtNameBase;
            layoutControlItem3.Location = new Point(0, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(311, 42);
            layoutControlItem3.Text = "Name";
            layoutControlItem3.TextSize = new Size(28, 13);
            // 
            // BaseLineView
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pcBase);
            MaximumSize = new Size(0, 46);
            MinimumSize = new Size(0, 46);
            Name = "BaseLineView";
            Size = new Size(724, 46);
            ((System.ComponentModel.ISupportInitialize)pcBase).EndInit();
            pcBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtNameBase.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seGradeBase.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)seWeigthBase.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ResumeLayout(false);

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
