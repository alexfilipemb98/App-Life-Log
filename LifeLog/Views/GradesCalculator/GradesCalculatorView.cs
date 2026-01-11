using DevExpress.XtraLayout;

namespace LifeLog.Views.GradesCalculator
{
	public partial class GradesCalculatorView : DevExpress.XtraEditors.XtraUserControl
	{
		#region MAIN

		//PRIVATES

		private int linhaIndex = 1;

		/// <summary>
		/// Constructor
		/// </summary>
		public GradesCalculatorView() => InitializeComponent();

		#endregion

		#region CLICK

		/// <summary>
		/// Adicionar nova linha
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiAddRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			AddNewLine();
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Add new line 
		/// </summary>
		private void AddNewLine()
		{
			BaseLineView baseLineView = new BaseLineView();
			baseLineView.Name = $"baseLineView_{linhaIndex}";

			// Evento de remoção
			baseLineView.btnRemoveBase.Click += (s, e) =>
			{
				LayoutControlItem layoutItem = lcBaseGradesView.Root.Items
					.OfType<LayoutControlItem>()
					.FirstOrDefault(w => w.Control == baseLineView);

				if (layoutItem != null)
				{
					lcBaseGradesView.Root.Remove(layoutItem);
				}

				lcBaseGradesView.Controls.Remove(baseLineView);
				baseLineView.Dispose();
			};

			//When value is changed
			baseLineView.seGradeBase.EditValueChanged += (s, e) =>
			{
				CalculateGrades();
			};
			baseLineView.seWeigthBase.EditValueChanged += (s, e) =>
			{
				CalculateGrades();
			};

			lcBaseGradesView.Controls.Add(baseLineView);
			baseLineView.layoutControl.BestFit();

			LayoutControlItem item = new LayoutControlItem
			{
				Control = baseLineView,
				TextVisible = false
			};

			if (linhaIndex > 0)
				item.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);

			lcBaseGradesView.Root.Add(item);
			linhaIndex++;
		}

		/// <summary>
		/// Reload the data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void LoadData()
		{
			AddNewLine();
			ResizeCalc();
		}

		/// <summary>
		/// Calculate results alginments
		/// </summary>
		public void ResizeCalc()
		{
			int w = (esiLeft.Width + esiRight.Width) / 2;
			esiLeft.Width = w;
			esiRight.Width = w;
		}

		private void CalculateGrades()
		{
			decimal somaNotasPonderadas = 0;
			decimal somaPesos = 0;

			foreach (Control ctrl in lcBaseGradesView.Controls)
			{
				if (ctrl is BaseLineView baseLine)
				{
					decimal nota = baseLine.seGradeBase.Value;
					decimal peso = baseLine.seWeigthBase.Value;

					somaNotasPonderadas += nota * peso;
					somaPesos += peso;
				}
			}

			if (somaPesos == 0)
			{
				MessageBox.Show("A soma dos pesos é zero. Verifica os dados.");
				return;
			}

			if (somaPesos > 100)
			{
				MessageBox.Show($"A soma dos pesos ultrapassa 100% ({somaPesos}%). Corrige os valores.");
				return;
			}

			decimal notaFinal = somaNotasPonderadas / somaPesos;

			if (notaFinal >= 9.50m)
			{
				lcGrade.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
				lcFinalGrade.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
			}
			else if (notaFinal == 0)
			{
				lcGrade.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
				lcFinalGrade.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
			}
			else if (notaFinal < 9.50m)
			{
				lcGrade.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
				lcFinalGrade.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
			}

			lcGrade.Text = $"{notaFinal:F2}";
			lcFinalGrade.Text = $"{Math.Round(notaFinal)}";
		}

		#endregion

	}
}
