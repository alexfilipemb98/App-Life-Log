using DevExpress.XtraEditors;
using System;

namespace Life_Log_App.Views.Main.Commands
{
    /// <summary>
    /// Commands Detail View
    /// </summary>
    public partial class CommandsDetailView : XtraUserControl
    {
        #region MAIN

        //PRIVATE

        private Data.ORM.DataModelCode.ORM_Commands _crtCommand;

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
        public void LoadData(Data.ORM.DataModelCode.ORM_Commands command)
        {
            _crtCommand = command;

            //teType.Text = _crtCommand.Type;
            //teName.Text = _crtCommand.Name;
            //teDescription.Text = _crtCommand.Description;
            //recMain.Text = _crtCommand.Command;
            //tsEnabled.IsOn = _crtCommand.Enabled;
            //teCreatedAt.Text = _crtCommand.CreatedAt.ToString();
            //teUpdatedAt.Text = _crtCommand.UpdatedAt.ToString();
            //beId.Text = _crtCommand.Id.ToString();

            //externalProgramsBindingSource.DataSource = AppHelper.DataEngine.ExternalPrograms.GetAll();
            //cbeProgram.Properties.DropDownRows = Math.Min(7, externalProgramsBindingSource.Count);

            //cbeProgram.EditValue = _crtCommand.ExternalProgram.Id;
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

            //_crtCommand.Name = teName.Text;
            //_crtCommand.Description = teDescription.Text;
            //_crtCommand.Command = recMain.Text;
            //_crtCommand.Type = teType.Text;
            //_crtCommand.IsEnabled = tsEnabled.IsOn;
            //_crtCommand.ExternalProgram = (ExternalProgramsEntity)cbeProgram.GetSelectedDataRow();

            //if (!Helpers.ValidationHelper.ValidateModelAndSetError(_crtCommand, dxErrorProvider, layoutControl))
            //    return false;

            //bool saved = AppHelper.DataEngine.Commands.Save(_crtCommand, out _);

            //return saved;

            return false;
        }

        #endregion
    }
}
