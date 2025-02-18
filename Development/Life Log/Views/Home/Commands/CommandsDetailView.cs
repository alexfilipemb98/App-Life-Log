using Data.Entities;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Life_Log.Components;
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

namespace Life_Log.Views.Home.Commands
{
    /// <summary>
    /// Commands Detail View
    /// </summary>
    public partial class CommandsDetailView : XtraUserControl
    {
        #region MAIN

        //PRIVATE

        private Data.Entities.CommandsEntity _crtCommand;

        /// <summary>
        /// Constructor to initialize the view
        /// </summary>
        public CommandsDetailView() => InitializeComponent();

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load data from the database
        /// </summary>
        /// <param name="extProgram"></param>
        public void LoadData(Data.Entities.CommandsEntity command)
        {
            _crtCommand = command;

            teType.Text = _crtCommand.Type;
            teName.Text = _crtCommand.Name;
            teDescription.Text = _crtCommand.Description;
            recMain.Text = _crtCommand.Command;
            tsEnabled.IsOn = _crtCommand.IsEnabled;
            teCreatedAt.Text = _crtCommand.CreatedAt.ToString();
            teUpdatedAt.Text = _crtCommand.UpdatedAt.ToString();
            beId.Text = _crtCommand.Id.ToString();

            externalProgramsBindingSource.DataSource = AppHelper.DataEngine.ExternalPrograms.GetAll();
            cbeProgram.Properties.DropDownRows = Math.Min(7, externalProgramsBindingSource.Count);

            cbeProgram.EditValue = _crtCommand.IdExternalProgram;
        }

        /// <summary>
        /// Reset the form
        /// </summary>
        public void ResetForm()
        {
            _crtCommand = null;

            teType.ResetText();
            teName.ResetText();
            teDescription.ResetText();
            recMain.ResetText();
            tsEnabled.IsOn = false;
            cbeProgram.ResetText();
            teCreatedAt.ResetText();
            teUpdatedAt.ResetText();
            beId.ResetText();

            recMain.ResetText();
        }

        /// <summary>
        /// Save the data
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            if (_crtCommand == null)
                return false;

            _crtCommand.Name = teName.Text;
            _crtCommand.Description = teDescription.Text;
            _crtCommand.Command = recMain.Text;
            _crtCommand.Type = teType.Text;
            _crtCommand.IsEnabled = tsEnabled.IsOn;
            _crtCommand.ExternalProgram = (ExternalProgramsEntity)cbeProgram.GetSelectedDataRow();

            if (!Helpers.ValidationHelper.ValidateModelAndSetError(_crtCommand, dxErrorProvider, layoutControl))
                return false;

            bool saved = AppHelper.DataEngine.Commands.Save(_crtCommand, out _);

            return saved;
        }

        #endregion
    }
}
