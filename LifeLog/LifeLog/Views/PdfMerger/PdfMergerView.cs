using Core.Utils;
using DevExpress.XtraEditors;
using LifeLog.Helpers;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace LifeLog.Views.PdfMerger
{
	/// <summary>
	/// PDF Merger View
	/// </summary>
	public partial class PdfMergerView : XtraUserControl
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		public PdfMergerView() => InitializeComponent();

		#endregion

		#region CLICK

		/// <summary>
		/// Open the output folder
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiOpenOutput_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				if (Directory.Exists(Path.GetDirectoryName(beOutputFolder.Text)))
					Process.Start("explorer.exe", Path.GetDirectoryName(beOutputFolder.Text));
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Handles the click event of the merge button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void beOutputFolder_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog
				{
					Filter = "PDF files (*.pdf)|*.pdf",
					DefaultExt = "pdf",
					AddExtension = true,
					Title = "Save PDF"
				};

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
					beOutputFolder.Text = saveFileDialog.FileName;
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Handles the click event of the select folder button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bePdfsFolder_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			try
			{
				bePdfsFolder.Text = DialogHelper.OpenFolder(bePdfsFolder.Text);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Process and merge the PDFs
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				string input = bePdfsFolder.Text;
				string output = beOutputFolder.Text;

				dxErrorProvider.ClearErrors();

				if (string.IsNullOrWhiteSpace(input) || !Directory.Exists(input))
				{
					dxErrorProvider.SetError(bePdfsFolder, "Please select a valid folder.");
				}

				if (string.IsNullOrWhiteSpace(output) || !Directory.Exists(Path.GetDirectoryName(output)))
				{
					dxErrorProvider.SetError(beOutputFolder, "Please select a valid folder for the output.");
				}

				if (dxErrorProvider.HasErrors)
				{
					MessageBox.Show("Please correct the errors!");
					return;
				}

				SearchOption searchOption = tsSearchSubFolders.IsOn ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
				List<string> pdfFiles = Directory
				   .EnumerateFiles(input, "*.pdf", searchOption)
				   .OrderBy(f => f)
				   .ToList();

				richEditControl.Text += $"Merging {pdfFiles.Count} PDFs\r\n";

				PdfUtil.MergeAllPdfsInDirectory(input, output, tsSearchSubFolders.IsOn);
				MessageBox.Show("PDFs have been merged!");
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

	}
}
