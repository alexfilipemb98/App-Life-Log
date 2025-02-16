using Data.Entities;
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

        private ImagesEntity _crtImage;

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

                        _crtImage.ImageData = null;

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
        public void LoadData(ImagesEntity model)
        {
            _crtImage = model;

            imagesEntityBindingSource.DataSource = _crtImage;

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
            imagesEntityBindingSource.DataSource = new ImagesEntity();
            peImage.SvgImage = null;
            peImage.Image = null;
            dataLayoutControl.ResetText();
        }

        /// <summary>
        /// Save data
        /// </summary>
        /// <returns></returns>
        public bool Save(out ImagesEntity image)
        {
            _crtImage.Name = teName.Text;
            image = _crtImage;  

            if (!ValidationHelper.ValidateModelAndSetError(_crtImage, dxErrorProvider, dataLayoutControl))
                return false;

            bool saved = AppHelper.DataEngine.Images.Save(_crtImage, out string message);
            
            AppHelper.StatusMessage(message, saved ? ForeColors.Information : ForeColors.Critical);

            return saved;
        }

        #endregion
    }
}
