using DevExpress.XtraBars.Ribbon;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LifeLog.Base.Forms
{
	public partial class QrCodeForm : RibbonForm
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="main"></param>
		/// <param name="v"></param>
		public QrCodeForm() => InitializeComponent();

		/// <summary>
		/// Display a QR code dialog
		/// </summary>
		/// <param name="text"></param>
		/// <param name="owner"></param>
		public static void ShowCode(string text, IWin32Window owner = null)
		{
			using (QrCodeForm f = new QrCodeForm())
			{
				f.barCodeControl.Text = text;
				f.ShowDialog(owner);
			}
		}

		#endregion

		#region EVENT'S

		/// <summary>
		/// when the qr code is loaded
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ShowQrCode_Load(object sender, EventArgs e)
		{
			if (Owner != null)
				Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
					Owner.Location.Y + Owner.Height / 2 - Height / 2);
		}

		#endregion
	}
}