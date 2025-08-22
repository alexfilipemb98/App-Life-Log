using DevExpress.XtraEditors;
using LifeLog.Base.Models.Data;
using LifeLog.Data.Database.Entities;
using LifeLog.Data.Database.Queries;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Helpers;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLog.UI.BackEnd.Views.Images
{
	/// <summary>
	/// Images Detail View
	/// </summary>
	public partial class ImagesDetailView : XtraUserControl
	{
		#region MAIN

		//PRIVATE

		private ImagesModel _crtImage;

		/// <summary>
		/// Images Detail View
		/// </summary>
		public ImagesDetailView() => InitializeComponent();

		#endregion

		#region CLICK

		/// <summary>
		/// Context button click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void peImage_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
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

								_crtImage.Name = Path.GetFileNameWithoutExtension(filePath);
								_crtImage.Data = imageData;
								_crtImage.FileExtension = extension;

								teName.Text = _crtImage.Name;
								teExt.Text = _crtImage.FileExtension;
								tsIsSvg.IsOn = _crtImage.IsSvg;

								if (_crtImage.IsSvg)
									peImage.SvgImage = _crtImage.SvgImage;
								else
									peImage.Image = _crtImage.BitImage;

								peImage.Refresh();
							}
						}

						break;
					case "CLEAR":
						peImage.SvgImage = null;
						peImage.Image = null;

						//_crtImage.Data = null;

						break;
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Copy id to clipboard
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void beId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			Clipboard.SetText(beId.Text);
		}

		#endregion

		#region FUNCTIONS

		/// <summary>
		/// Load data
		/// </summary>
		/// <param name="model"></param>
		public void LoadData(ImagesModel model)
		{
			_crtImage = model;

			imagesEntityBindingSource.DataSource = _crtImage;

			if (_crtImage.IsSvg)
				peImage.SvgImage = _crtImage.SvgImage;
			else
				peImage.Image = _crtImage.BitImage;

			tsIsSvg.IsOn = _crtImage.IsSvg;
		}

		/// <summary>
		/// Reset form fields
		/// </summary>
		public void ResetForm()
		{
			imagesEntityBindingSource.DataSource = new { };
			peImage.SvgImage = null;
			peImage.Image = null;
			dataLayoutControl.ResetText();
		}

		/// <summary>
		/// Save data
		/// </summary>
		/// <returns></returns>
		public async Task<(bool, ImagesModel)> Save()
		{
			_crtImage.Name = teName.Text;

			if (!ValidationHelper.ValidateModelAndSetError(_crtImage, dxErrorProvider, dataLayoutControl))
				return (false, null);

			(bool saved, string message) = await AppSession.DataEngine.Images.Save(_crtImage);

			AppHelper.StatusMessage(message, saved);

			return (saved, _crtImage);
		}

		#endregion
	}
}
