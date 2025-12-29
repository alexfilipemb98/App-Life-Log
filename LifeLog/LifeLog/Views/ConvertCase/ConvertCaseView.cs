using LifeLog.Core.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using LifeLog.Helpers;

namespace LifeLog.Views.ConvertCase
{
	/// <summary>
	/// Convert case view 
	/// </summary>
	public partial class ConvertCaseView : XtraUserControl
	{
		#region MAIN

		/// <summary>
		/// Construtor
		/// </summary>
		public ConvertCaseView() => InitializeComponent();

		#endregion

		#region ITEM CLICK

		/// <summary>
		/// Copy text result to the clipboard
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiCopyText_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (string.IsNullOrEmpty(meTextResult.Text))
				return;

			Clipboard.SetText(meTextResult.Text);
		}

		#endregion

		private void cbText_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				CheckButton clickedButton = ((CheckButton)sender);

				if (clickedButton == null || !clickedButton.Checked)
					return;

				foreach (Control control in clickedButton.Parent.Controls)
				{
					if (control is CheckButton button && button != clickedButton)
					{
						button.Checked = false;
					}
				}

				ConvertCase();
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		private void ConvertCase()
		{
			Task.Run(() =>
			{
				string textOriginal = meTextSource.Text;
				string textModified = textOriginal;

				if (cbSentenceCase.Checked)
					textModified = textOriginal.ToSentenceCase();

				if (cbTitleCase.Checked)
					textModified = textOriginal.ToTitleCase();

				if (cbUpperCase.Checked)
					textModified = textOriginal.ToUpper();

				if (cbLowerCase.Checked)
					textModified = textOriginal.ToLower();

				if (cbAlternativeCase.Checked)
					textModified = textOriginal.ToAlternativeCase();

				if (cbInvertCase.Checked)
					textModified = textOriginal.InvertCase();

				meTextResult.BeginInvoke((MethodInvoker)(() => meTextResult.Text = textModified));
			});
		}

		private void meTextSource_EditValueChanged(object sender, EventArgs e)
		{
			ConvertCase();
		}
	}
}
