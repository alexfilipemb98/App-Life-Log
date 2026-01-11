using DevExpress.XtraEditors;
using LifeLog.Core.Flags;
using LifeLog.Core.Utils;
using System.Data;
using System.ComponentModel;

namespace LifeLog.Views.Settings;

/// <summary>
/// Modules setting view
/// </summary>
public partial class ModulesSettingView : XtraUserControl
{
    #region MAIN 

    // PROPERTIES
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Action<long> OnSavedModules { get; internal set; }

    //PRIVATE
    private Dictionary<ToggleSwitch, ModulesFlag> _map;

    /// <summary>
    /// Constructor
    /// </summary>
    public ModulesSettingView() => InitializeComponent();

    /// <summary>
    /// Load  of the view
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ModulesSettingView_Load(object sender, EventArgs e)
    {
        _map = new Dictionary<ToggleSwitch, ModulesFlag>
        {
            { tsNotes, ModulesFlag.Notes },
            { tsCommandsRunner, ModulesFlag.CommandsRunner },
            { tsPasswords, ModulesFlag.Passwords },
            { tsWeather, ModulesFlag.Weather },
            { tsRollDice, ModulesFlag.RollDice },
            { tsCoinFlip, ModulesFlag.CoinFlip },
            { tsTicTacToe, ModulesFlag.TicTacToe },
            { tsPassowordsGenerator, ModulesFlag.PasswordsGenerator },
            { tsPdfMerger, ModulesFlag.PdfMerger },
            { tsGradeCalculator, ModulesFlag.GradesCalculator },
            { tsConvertText, ModulesFlag.ConvertText },
            { tsFormOut, ModulesFlag.FormOut },
            { tsThreeSimpleRule, ModulesFlag.ThreeSimpleRule }
        };
    }

    #endregion

    #region EVENTS

    #region CLICK

    /// <summary>
    /// Guardar os modulos selecionados
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bbiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        long valor = _map
              .Where(x => x.Key.IsOn)
              .Aggregate(0L, (acc, x) => acc | (long)x.Value);

        OnSavedModules?.Invoke(valor);
    }

    #endregion

    #endregion

    #region FUNCTIONS

    #region PUBLIC

    /// <summary>
    /// Load data into the toggles
    /// </summary>
    /// <param name="valor"></param>
    public void LoadData(long valor)
    {
        if (_map is null) return;
        foreach (KeyValuePair<ToggleSwitch, ModulesFlag> kvp in _map)
            kvp.Key.IsOn = kvp.Value.IsActive(valor);
    }

    #endregion

    #endregion
}
