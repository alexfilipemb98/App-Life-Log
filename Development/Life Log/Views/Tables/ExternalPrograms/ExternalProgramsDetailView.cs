using DevExpress.XtraEditors;
using Life_Log.Helpers;
using System;
using System.IO;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace Life_Log.Views.Tables.ExternalPrograms
{
    /// <summary>
    /// External programs detail view
    /// </summary>
    public partial class ExternalProgramsDetailView : XtraUserControl
    {
        #region MAIN

        //PRIVATE
        private Data.Entities.ExternalProgramsEntity _crtExtProgram;

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

                                _crtExtProgram.Image.Name = Path.GetFileNameWithoutExtension(filePath);
                                _crtExtProgram.Image.ImageData = imageData;
                                _crtExtProgram.Image.IsSvg = extension == ".svg";
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

                        _crtExtProgram.Image.ImageData = null;

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
        private void bePath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load data from the database
        /// </summary>
        /// <param name="extProgram"></param>
        public void LoadData(Data.Entities.ExternalProgramsEntity extProgram)
        {
            _crtExtProgram = extProgram;

            teName.Text = _crtExtProgram.Name;
            bePath.Text = _crtExtProgram.PathToProgram;
            teArguments.Text = _crtExtProgram.Arguments;
            teFileExt.Text = _crtExtProgram.FileExtension;
            teCreatedAt.Text = _crtExtProgram.CreatedAt.ToString();
            teUpdatedAt.Text = _crtExtProgram.UpdatedAt.ToString();
            beId.Text = _crtExtProgram.Id.ToString();

            if (_crtExtProgram.Image == null)
            {
                _crtExtProgram.Image = new Data.Entities.ImagesEntity();
                _crtExtProgram.Image.Id = Guid.NewGuid();
            }
            else
            {
                _crtExtProgram.Image = AppHelper.DataEngine.Images.GetByKey(_crtExtProgram.Image.Id);
                _crtExtProgram.Image.EditingMode = true;
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
        public bool Save()
        {
            _crtExtProgram.Name = teName.Text;
            _crtExtProgram.PathToProgram = bePath.Text;
            _crtExtProgram.Arguments = teArguments.Text;
            _crtExtProgram.FileExtension = teFileExt.Text;

            if (!ValidationHelper.ValidateModelAndSetError(_crtExtProgram, dxErrorProvider, layoutControl1))
                return false;

            bool saved = false;
            if (!string.IsNullOrWhiteSpace(_crtExtProgram.Image.Name) && _crtExtProgram.Image.ImageData.Length > 0)
            {
                saved = AppHelper.DataEngine.Images.Save(_crtExtProgram.Image);
                _crtExtProgram.IdImage = _crtExtProgram.Image.Id;
            }
            else
            {
                if (!AppHelper.DataEngine.Images.Exists(_crtExtProgram.Image.Id))
                    _crtExtProgram.Image = null;
            }

            saved = AppHelper.DataEngine.ExternalPrograms.Save(_crtExtProgram);

            if (saved)
                ResetForm();

            AppHelper.StatusMessage(saved ? "External program saved!" : "Unable to save the external program!", saved ? ForeColors.Information : ForeColors.Critical);

            return saved;
        }

        /// <summary>
        /// Restores the form to its original state
        /// </summary>
        public void ResetForm()
        {
            teFileExt.ResetText();
            teName.ResetText();
            teArguments.ResetText();
            bePath.ResetText();
            teCreatedAt.ResetText();
            teUpdatedAt.ResetText();
            beId.ResetText();
            peImage.Reset();
            peImage.SvgImage = null;
            peImage.Image = null;
        }

        #endregion
    }
}
