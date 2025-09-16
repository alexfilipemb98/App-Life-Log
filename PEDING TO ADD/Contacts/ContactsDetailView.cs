using Core.Models.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraLayout;
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

namespace Life_Log.Views.Home.Main.Contacts
{
    public partial class ContactsDetailView : DevExpress.XtraEditors.XtraUserControl
    {
        private ContactsDataModel _model;
        private ImageDataModel _icon;

        public ContactsDetailView()
        {
            InitializeComponent();
        }

        public void LoadData(ContactsDataModel model)
        {
            Task.Run(() =>
            {
                Invoke(new Action(() =>
                {
                    _model = model;
                    _model.IdUser = AppHelper.CurrentUser.Id;

                    teName.Text = model.Name;
                    teAddress.Text = model.Address;
                    teEmail.Text = model.Email;
                    teNickname.Text = model.Nickname;
                    deBirthday.EditValue = model.Birthday;
                    tePhone.Text = model.Phone;

                    //deCreatedAt.EditValue = model.CreatedAt;
                    //deUpdatedAt.EditValue = model.UpdatedAt;

                    if (_model.IdImage > 0)
                    {
                        _icon = AppHelper.Engine.Images.Get(_model.IdImage, out _);
                        if (_icon.IsSvg)
                            peImage.SvgImage = _icon.SvgImage;
                        else
                            peImage.Image = _icon.BitImage;
                    }
                    else
                    {
                        _icon = new ImageDataModel();
                        _icon.IdUser = AppHelper.CurrentUser.Id;
                    }

                }));
            });
        }

        public void ResetForm()
        {
            peImage.Reset();
            peImage.Image = null;
            peImage.SvgImage = null;

            teName.ResetText();
            teAddress.ResetText();
            teEmail.ResetText();
            teNickname.ResetText();
            deBirthday.ResetText();
            tePhone.ResetText();
        }

        public bool SaveData()
        {
            try
            {
                if (!Helpers.ValidationHelper.ValidateModelAndSetError(_model, dxErrorProvider, layoutControl))
                    return false;

                string message = null;

                if (_icon.ImageData != null && _icon.ImageData.Length > 0)
                {
                    bool savedIcon = AppHelper.Engine.Images.Save(_icon, out message);
                    AppHelper.SetStatusLabel(message, savedIcon ? ForeColors.Information : ForeColors.Critical);

                    if (savedIcon)
                        _model.IdImage = _icon.Id;
                }

                bool savedProgram = AppHelper.Engine.Contacts.Save(_model, out message);
                AppHelper.SetStatusLabel(message, savedProgram ? ForeColors.Information : ForeColors.Critical);
                return savedProgram;
            }
            catch (Exception ex)
            {
                AppHelper.SetStatusLabel(ex.Message, ForeColors.Critical);
                return false;
            }
        }

        private void deBirthday_EditValueChanged(object sender, EventArgs e)
        {
            if (deBirthday.EditValue is DateTime dt)
            {
                _model.Birthday = dt;
                teAge.Text = _model.Age.ToString();
            }
        }

        private void teName_EditValueChanged(object sender, EventArgs e) =>
            _model.Name = teName.Text;

        private void teNickname_EditValueChanged(object sender, EventArgs e) =>
            _model.Nickname = teNickname.Text;

        private void teEmail_EditValueChanged(object sender, EventArgs e) =>
            _model.Email = teEmail.Text;

        private void tePhone_EditValueChanged(object sender, EventArgs e) =>
            _model.Phone = tePhone.Text;

        private void teAddress_EditValueChanged(object sender, EventArgs e) =>
            _model.Address = teAddress.Text;

        private void peImage_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "cbClear":
                    peImage.SvgImage = null;
                    peImage.Image = null;

                    _icon.ImageData = null;
                    break;

                case "cbLoad":
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Title = "Open Image File";
                    openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.svg";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        string extension = Path.GetExtension(filePath).ToLower();
                        byte[] imageData = File.ReadAllBytes(filePath);

                        _icon.Name = Path.GetFileNameWithoutExtension(filePath);
                        _icon.IsSvg = extension == ".svg";
                        _icon.ImageData = imageData;

                        if (_icon.IsSvg)
                            peImage.SvgImage = _icon.SvgImage;
                        else
                            peImage.Image = _icon.BitImage;

                        peImage.Refresh();
                    }

                    break;
            }
        }
    }
}
