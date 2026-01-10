using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using LifeLog.Bases;
using LifeLog.Data.DTOs;

namespace LifeLog.Views.ExternalPrograms;

/// <summary>
/// External Programs List View
/// </summary>
public partial class ExternalProgramsList : BaseView
{
    #region MAIN

    /// <summary>
    /// Constructor
    /// </summary>
    public ExternalProgramsList() => InitializeComponent();

    #endregion

    #region EVENTS

    #region CLICK

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

    /// <summary>
    /// Edit button click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public override void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
    {
        base.bbiEdit_ItemClick(sender, e);

        if (gridView.GetFocusedRow() is not ExternalProgramsDTO selected)
            return;

        externalProgramsEditor.LoadToForm(selected);
    }

    /// <summary>
    /// Reload button click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public override async void bbiReload_ItemClick(object sender, ItemClickEventArgs e) => await LoadData();

    #endregion

    #endregion

    #region FUNCTIONS

    #region PUBLIC

    /// <summary>
    /// Load Data
    /// </summary>
    /// <returns></returns>
    public async Task LoadData()
    {
        (List<ExternalProgramsDTO?>? lista, _) = await Program.DataEngine!.ExternalPrograms.GetAll();
        externalProgramsDTOBindingSource.DataSource = lista;
    }

    #endregion

    #endregion



    public override void bbiDelele_ItemClick(object sender, ItemClickEventArgs e)
    {
        if (gridView.GetFocusedRow() is not ExternalProgramsDTO selected)
            return;

        var result = XtraMessageBox.Show($"Are you sure you want to delete '{selected.Name}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (result != DialogResult.Yes)
            return;
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


}
