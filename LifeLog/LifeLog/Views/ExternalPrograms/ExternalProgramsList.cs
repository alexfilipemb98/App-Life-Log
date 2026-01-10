using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using LifeLog.Bases;
using LifeLog.Data.DTOs;
using System.Threading.Tasks;

namespace LifeLog.Views.ExternalPrograms;

public partial class ExternalProgramsList : BaseView
{
	public ExternalProgramsList() => InitializeComponent();


	/// <summary>
	/// New button click
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public override void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
	{
		base.bbiNew_ItemClick(sender, e);

		externalProgramsEditor.LoadToForm();
	}


	public override void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
	{
		base.bbiEdit_ItemClick(sender, e);

		if (gridView.GetFocusedRow() is not ExternalProgramsDTO selected)
			return;

		externalProgramsEditor.LoadToForm(selected);
	}


	public override void bbiDelele_ItemClick(object sender, ItemClickEventArgs e)
	{
		if (gridView.GetFocusedRow() is not ExternalProgramsDTO selected)
			return;

		var result = XtraMessageBox.Show($"Are you sure you want to delete '{selected.Name}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

		if (result != DialogResult.Yes)
			return;
	}

	public override async void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
	{
		await LoadData();
	}

	public override async void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
	{
		(ExternalProgramsDTO? model, bool saved) = await externalProgramsEditor.SaveObject();

		if (!saved)
			return;

		ExternalProgramsDTO? existing = externalProgramsDTOBindingSource.List.OfType<ExternalProgramsDTO>().FirstOrDefault(x => x.Id == model!.Id);

		if (existing is not null)
			gridView.UpdateCurrentRow();
		else
			externalProgramsDTOBindingSource.Add(model!);

		base.bbiSave_ItemClick(sender, e);
	}

	public async Task LoadData()
	{
		(List<ExternalProgramsDTO?>? lista, _) = await Program.DataEngine!.ExternalPrograms.GetAll();
		externalProgramsDTOBindingSource.DataSource = lista;
	}
}
