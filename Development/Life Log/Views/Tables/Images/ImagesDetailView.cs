using DevExpress.XtraEditors;
using Life_Log.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace Life_Log.Views.Tables.Images
{
    /// <summary>
    /// Images Detail View
    /// </summary>
    public partial class ImagesDetailView : XtraUserControl
    {
        #region MAIN

        //PRIVATE

        private Data.Entities.ImagesEntity _crtImage;

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
                                _crtImage.ImageData = imageData;
                                _crtImage.IsSvg = extension == ".svg";
                                _crtImage.FileExtension = extension;

                                teName.Text = _crtImage.Name;
                                teExt.Text = _crtImage.FileExtension;

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

                        _crtImage.ImageData = null;

                        break;
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load data
        /// </summary>
        /// <param name="model"></param>
        public void LoadData(Data.Entities.ImagesEntity model)
        {
            _crtImage = model;

            teName.Text = _crtImage.Name;
            teCreatedAt.Text = _crtImage.CreatedAt.ToString();
            teUpdatedAt.Text = _crtImage.UpdatedAt.ToString();
            beId.Text = _crtImage.Id.ToString();
            teExt.Text = _crtImage.FileExtension;

            if (_crtImage.IsSvg)
                peImage.SvgImage = _crtImage.SvgImage;
            else
                peImage.Image = _crtImage.BitImage;
        }

        /// <summary>
        /// Reset form fields
        /// </summary>
        public void ResetForm()
        {
            teName.ResetText();
            teCreatedAt.ResetText();
            teUpdatedAt.ResetText();
            beId.ResetText();
            peImage.Reset();
            peImage.SvgImage = null;
            peImage.Image = null;
        }

        /// <summary>
        /// Save data
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            _crtImage.Name = teName.Text;

            if (!ValidationHelper.ValidateModelAndSetError(_crtImage, dxErrorProvider, layoutControl))
                return false;

            bool saved = AppHelper.DataEngine.Images.Save(_crtImage);

            if (saved)
                ResetForm();

            AppHelper.StatusMessage(saved ? "Image saved!" : "Unable to save the image!", saved ? ForeColors.Information : ForeColors.Critical);

            return saved;
        }

        #endregion
    }
}
