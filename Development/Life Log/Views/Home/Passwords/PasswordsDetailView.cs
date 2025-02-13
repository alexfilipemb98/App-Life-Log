using Data.Entities;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Model;
using Life_Log.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace Life_Log.Views.Home.Passwords
{
    /// <summary>
    /// Passwords Detail View
    /// </summary>
    public partial class PasswordsDetailView : XtraUserControl
    {
        #region MAIN

        //PUBLIC

        public PasswordsView _PasswordsView;
        public PasswordsListView _PasswordsListView;

        //PRIVATE

        private PasswordsEntity _crtPassword;
        private bool _isNew;

        /// <summary>
        /// Constructor to initialize the view
        /// </summary>
        public PasswordsDetailView() => InitializeComponent();

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load data to the view
        /// </summary>
        /// <param name="password"></param>
        public void LoadData(PasswordsEntity password = null)
        {
            try
            {
                if (password == null || password.Id == Guid.Empty)
                {
                    _isNew = true;
                    password = new PasswordsEntity();
                    password.Id = Guid.NewGuid();
                    password.CreatedAt = DateTime.Now;
                }

                if (password.Image == null)
                {
                    password.Image = new ImagesEntity();
                    password.Image.Id = Guid.NewGuid();
                    password.Image.CreatedAt = DateTime.Now;
                }

                _crtPassword = password;

                //Main Data
                teName.EditValue = _crtPassword.Name;
                teLoginUsername.EditValue = _crtPassword.LoginUsername;
                beLoginPassword.EditValue = _crtPassword.LoginPassword;
                beWebSite.EditValue = _crtPassword.WebSite;
                neNotes.EditValue = _crtPassword.Notes;

                //Geral Data
                beId.EditValue = _crtPassword.Id;
                teCreatedAt.EditValue = _crtPassword.CreatedAt;
                teUpdatedAt.EditValue = _crtPassword.UpdatedAt;
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Save data
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool SaveData()
        {
            try
            {
                //Main Data
                _crtPassword.Name = teName.EditValue.ToString();
                _crtPassword.LoginUsername = teLoginUsername.EditValue.ToString();
                _crtPassword.LoginPassword = beLoginPassword.EditValue.ToString();
                _crtPassword.WebSite = beWebSite.EditValue.ToString();
                _crtPassword.Notes = neNotes.EditValue.ToString();

                if (!ValidationHelper.ValidateModelAndSetError(_crtPassword, dxErrorProvider, layoutControl1))
                    return false;

                bool saved = false;
                if (!string.IsNullOrWhiteSpace(_crtPassword.Image.Name) && _crtPassword.Image.ImageData.Length > 0)
                {
                    saved = AppHelper.DataEngine.Images.Save(_crtPassword.Image);
                    _crtPassword.IdImage = _crtPassword.Image.Id;
                }
                else
                {
                    if (!AppHelper.DataEngine.Images.Exists(_crtPassword.Image.Id))
                        _crtPassword.Image = null;
                }

                saved = AppHelper.DataEngine.Passwords.Save(_crtPassword);

                if (saved)
                {
                    if (_isNew)
                        _PasswordsListView.passwordsEntityBindingSource.Add(_crtPassword);
                    else
                        _PasswordsListView.gridView.UpdateCurrentRow();

                    _PasswordsView.ShowView();
                    
                    ResetForm();
                }

                AppHelper.StatusMessage(saved ? "Password saved!" : "Unable to save password!", saved ? ForeColors.Information : ForeColors.Critical);

                return saved;
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
                return false;
            }
        }

        /// <summary>
        /// Reset form
        /// </summary>
        public void ResetForm()
        {
            teName.ResetText();
            teLoginUsername.ResetText();
            beLoginPassword.ResetText();
            beWebSite.ResetText();
            neNotes.ResetText();
            beId.ResetText();
            teCreatedAt.ResetText();
            teUpdatedAt.ResetText();
        }

        #endregion
    }
}
