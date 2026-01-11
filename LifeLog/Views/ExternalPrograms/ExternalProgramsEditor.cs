using LifeLog.Core.Utils;
using LifeLog.Data.DTOs;
using LifeLog.Helpers;
using System.IO;

namespace LifeLog.Views.ExternalPrograms;

/// <summary>
/// External Programs Editor User Control
/// </summary>
public partial class ExternalProgramsEditor : DevExpress.XtraEditors.XtraUserControl
{
    #region MAIN

    //PRIVATE
    private ExternalProgramsDTO _current;

    /// <summary>
    /// Constructor
    /// </summary>
    public ExternalProgramsEditor() => InitializeComponent();

    /// <summary>
    /// External Programs Editor Resize Event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ExternalProgramsEditor_Resize(object sender, EventArgs e) => EditorResize();

    #endregion

    #region EVENTS

    #region CLICK

    /// <summary>
    /// Icon Context Button Click Event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void peIcon_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
    {
        string item = e.Item.Name.ToString();

        switch (item)
        {
            case "btnOpenFolder":
                using (OpenFileDialog openFileDialog = new())
                {
                    openFileDialog.Title = "Open Image File";
                    openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.svg";

                    if (openFileDialog.ShowDialog() != DialogResult.OK)
                        break;

                    string filePath = openFileDialog.FileName;
                    string extension = Path.GetExtension(filePath).ToLower();
                    byte[] imageData = File.ReadAllBytes(filePath);

                    _current.ImageExtension = Path.GetExtension(filePath);
                    _current.ImageData = imageData;

                    if (_current.IsImageSvg)
                        peIcon.SvgImage = _current.SvgImage;
                    else
                        peIcon.Image = _current.BitImage;

                    peIcon.Refresh();
                }

                break;

            case "btnClear":
                peIcon.SvgImage = null;
                peIcon.Image = null;

                _current.ImageData = null;
                break;
        }
    }

    #endregion

    #endregion

    #region FUNCTIONS

    #region PRIVATE

    /// <summary>
    /// Load Data From Form
    /// </summary>
    /// <returns></returns>
    private void LoadFillObj(ref ExternalProgramsDTO obj)
    {
        obj.Name = txtName.Text.Trim();
        obj.PathToProgram = txtPath.Text.Trim();
        obj.FileExtension = txtFileExt.Text.Trim();
        obj.Arguments = txtArgs.Text.Trim();
    }

    /// <summary>
    /// Validate Form
    /// </summary>
    /// <returns></returns>
    private bool ValidateForm()
    {
		this.ValidateChildren();

		ExternalProgramsDTO validateObject = _current.DeepCloneJson();

        LoadFillObj(ref validateObject);

        return ControlsHelper.ValidateForm(
            validateObject,
            dxErrorProvider,
            new Dictionary<string, Control>(StringComparer.Ordinal)
            {
                [nameof(ExternalProgramsDTO.Name)] = txtName,
                [nameof(ExternalProgramsDTO.PathToProgram)] = txtPath,
                [nameof(ExternalProgramsDTO.FileExtension)] = txtFileExt,
            });
    }

    /// <summary>
    /// Resize Editor
    /// </summary>
    private void EditorResize()
    {
        int h1 = (esiLeft.Height + esiRight.Height) / 2;
        esiLeft.Height = h1;
        esiRight.Height = h1;
    }

    #endregion

    #region PUBLIC

    /// <summary>
    /// Load Data To Form
    /// </summary>
    /// <param name="externalProgram"></param>
    public void LoadToForm(ExternalProgramsDTO? externalProgram = null)
    {
        EditorResize();

        if (externalProgram is null)
        {
            externalProgram = new ExternalProgramsDTO();
        }

        _current = externalProgram;

        txtName.Text = _current.Name;
        txtPath.Text = _current.PathToProgram;
        txtFileExt.Text = _current.FileExtension;
        txtArgs.Text = _current.Arguments;

        if (_current.IsImageSvg)
            peIcon.SvgImage = _current.SvgImage;
        else
            peIcon.Image = _current.BitImage;

        peIcon.Refresh();
    }

    /// <summary>
    /// Save Object
    /// </summary>
    /// <returns></returns>
    public async Task<(ExternalProgramsDTO?, bool)> SaveObject()
    {
        if (!ValidateForm())
            return (null, false);

        LoadFillObj(ref _current);

        (bool saved, string message) = await Program.DataEngine!.ExternalPrograms.Save(_current);

        if (!saved)
        {
            MessageBox.Show(message);
            return (null, false);
        }

        return (_current, saved);
    }

    #endregion

    #endregion
}
