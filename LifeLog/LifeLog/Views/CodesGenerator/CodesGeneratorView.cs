using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraEditors;

namespace LifeLog.Views.CodesGenerator
{
	/// <summary>
	/// View to generate codes
	/// </summary>
	public partial class CodesGeneratorView : XtraUserControl
	{
		#region MAIN
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CodesGeneratorView() => InitializeComponent();

		/// <summary>
		/// On Load event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CodesGeneratorView_Load(object sender, EventArgs e)
		{
			cbeSymbology.Properties.DropDownRows = Math.Min(cbeSymbology.Properties.Items.Count, 7);
			cbeCodeType.Properties.DropDownRows = Math.Min(cbeCodeType.Properties.Items.Count, 7);
			pcCode.MinimumSize = new System.Drawing.Size(lciCode.Size.Width, lciCode.Size.Height - 10 );
			pcCode.MaximumSize = new System.Drawing.Size(lciCode.Size.Width, lciCode.Size.Height - 10 );
			pcCode.Size = new System.Drawing.Size(lciCode.Size.Width, lciCode.Size.Height - 10 );
		}

		#endregion
		
		#region EVENTS

		#region ITEM CLICK

		/// <summary>
		/// Generate code button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiGenCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		#endregion

		#region SELECT INDEX CHANGED

		/// <summary>
		/// Symbology changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbeSymbology_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = cbeSymbology.SelectedIndex;
			switch (index)
			{
				case 0: // Code 128
					barCodeControl.Symbology = new EAN13Generator();
					break;

				case 2: // Qr Code
					barCodeControl.Symbology = new QRCodeGenerator();
					break;

				default:
					barCodeControl.Symbology = new QRCodeGenerator();
					break;
			}
		}

		/// <summary>
		/// Code type changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbeCodeType_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		#endregion

		#region EDIT VALUE CHANGED

		/// <summary>
		/// Edit text changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void teTypeText_EditValueChanged(object sender, EventArgs e)
		{
			barCodeControl.Text = teTypeText.Text;
			barCodeControl.Height = lciCode.Height - 10;
		}

		#endregion 

		#endregion
	}
}
