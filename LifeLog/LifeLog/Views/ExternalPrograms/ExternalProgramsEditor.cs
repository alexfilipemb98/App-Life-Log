using LifeLog.Core.Utils;
using LifeLog.Data.DTOs;
using System.IO;
using System.Threading.Tasks;

namespace LifeLog.Views.ExternalPrograms;

/// <summary>
/// External Programs Editor User Control
/// </summary>
public partial class ExternalProgramsEditor : DevExpress.XtraEditors.XtraUserControl
{

	//PRIVATE
	ExternalProgramsDTO _current;

	/// <summary>
	/// Constructor
	/// </summary>
	public ExternalProgramsEditor() => InitializeComponent();

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

	public async Task<(ExternalProgramsDTO?, bool)> SaveObject()
	{
		if (!ValidateForm())
			return (null, false);

		var result = LoadFromForm();

		(bool saved , string message) = await Program.DataEngine!.ExternalPrograms.Save(result);

		if (!saved)
		{
			MessageBox.Show(message);
			return (null, false);
		}

		return (result, saved);
	}

	private ExternalProgramsDTO LoadFromForm()
	{
		_current.Name = txtName.Text.Trim();
		_current.PathToProgram = txtPath.Text.Trim();
		_current.FileExtension = txtFileExt.Text.Trim();
		_current.Arguments = txtArgs.Text.Trim();

		return _current;
	}

	private bool ValidateForm()
	{
		dxErrorProvider.ClearErrors();

		if (string.IsNullOrWhiteSpace(txtName.Text))
			dxErrorProvider.SetError(txtName, "Name is required.");

		if (string.IsNullOrWhiteSpace(txtPath.Text))
			dxErrorProvider.SetError(txtPath, "Path is required.");

		if (string.IsNullOrWhiteSpace(txtFileExt.Text))
			dxErrorProvider.SetError(txtFileExt, "File extension is required.");

		return !dxErrorProvider.HasErrors;
	}

	private void EditorResize()
	{
		int h1 = (esiLeft.Height + esiRight.Height) / 2;
		esiLeft.Height = h1;
		esiRight.Height = h1;
	}


}
