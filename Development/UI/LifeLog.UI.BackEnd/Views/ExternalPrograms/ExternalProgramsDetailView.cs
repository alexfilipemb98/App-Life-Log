using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using LifeLog.Base.Models.Data;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLog.UI.BackEnd.Views.ExternalPrograms
{
	/// <summary>
	/// External programs detail view
	/// </summary>
	public partial class ExternalProgramsDetailView : XtraUserControl
	{
		#region MAIN

		//PRIVATE
		private ExternalProgramsModel _crtExtProgram;

		/// <summary>
		/// Constructor to initialize the view
		/// </summary>
		public ExternalProgramsDetailView() => InitializeComponent();

		#endregion

		#region CLICK

		/// <summary>
		/// Context button click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void peImage_ContextButtonClick(object sender, ContextItemClickEventArgs e)
		{
			try
			{
				string item = e.Item.Tag.ToString();

				switch (item)
				{
					case "OPEN":
						using (OpenFileDialog openFileDialog = new OpenFileDialog())
						{
							openFileDialog.Title = "Open Image File";
							openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.svg";

							if (openFileDialog.ShowDialog() == DialogResult.OK)
							{
								string filePath = openFileDialog.FileName;
								string extension = Path.GetExtension(filePath).ToLower();
								byte[] imageData = File.ReadAllBytes(filePath);

								if (_crtExtProgram.Image == null)
									_crtExtProgram.Image = new ImagesModel();

								_crtExtProgram.Image.Name = Path.GetFileNameWithoutExtension(filePath);
								_crtExtProgram.Image.Data = imageData;
								_crtExtProgram.Image.FileExtension = extension;

								if (_crtExtProgram.Image.IsSvg)
									peImage.SvgImage = _crtExtProgram.Image.SvgImage;
								else
									peImage.Image = _crtExtProgram.Image.BitImage;

								peImage.Refresh();
							}
						}

						break;

					case "CLEAR":
						peImage.SvgImage = null;
						peImage.Image = null;

						_crtExtProgram.Image.Data = null;

						break;
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Choose file button click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bePath_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "Open File";
				openFileDialog.Filter = "All files (*.*)|*.*";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					bePath.Text = openFileDialog.FileName;
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Copies the id
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void beId_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			Clipboard.SetText(beId.Text);
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Load data from the database
		/// </summary>
		/// <param name="extProgram"></param>
		public void LoadData(ExternalProgramsModel extProgram)
		{
			_crtExtProgram = extProgram;

			externalProgramsModelBindingSource.DataSource = _crtExtProgram;

			if (_crtExtProgram.Image != null)
			{
				if (_crtExtProgram.Image.IsSvg)
					peImage.SvgImage = _crtExtProgram.Image.SvgImage;
				else
					peImage.Image = _crtExtProgram.Image.BitImage;
			}
		}

		/// <summary>
		/// Save data to the database
		/// </summary>
		/// <returns></returns>
		public async Task<(bool, ExternalProgramsModel)> SaveData()
		{
			dataLayoutControl.Focus();
			externalProgramsModelBindingSource.EndEdit();

			if (!ValidationHelper.ValidateModelAndSetError(_crtExtProgram, dxErrorProvider, dataLayoutControl))
				return (false, null);

			if (_crtExtProgram.Image != null)
			{
				if (_crtExtProgram.Image.Data == null || _crtExtProgram.Image.Data.Length <= 0)
					_crtExtProgram.Image = null;
			}

			(bool saved, string message) = await AppSession.DataEngine.ExternalPrograms.Save(_crtExtProgram);

			AppHelper.StatusMessage(message, saved);

			return (saved, _crtExtProgram);
		}

		/// <summary>
		/// Restores the form to its original state
		/// </summary>
		public void ResetForm()
		{
			dataLayoutControl.ResetText();
			peImage.Reset();
			peImage.SvgImage = null;
			peImage.Image = null;
			externalProgramsModelBindingSource.Clear();	
		}

		#endregion
	}
}
