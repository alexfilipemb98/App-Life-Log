using DevExpress.XtraEditors;
using LifeLog.Base.Infrastructure.Flags;
using LifeLog.Base.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LifeLog.UI.FrontEnd.Views.Settings
{
	/// <summary>
	/// Modules setting view
	/// </summary>
	public partial class ModulesSettingView : XtraUserControl
	{
		#region MAIN 

		// PROPERTIES
		public Action<long> OnSavedModules { get; internal set; }

		//PRIVATE
		private Dictionary<ToggleSwitch, FrontModulesFlag> _map;

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
			_map = new Dictionary<ToggleSwitch, FrontModulesFlag>
			{
				{ tsNotes, FrontModulesFlag.Notes },
				{ tsCommandsRunner, FrontModulesFlag.CommandsRunner },
				{ tsPasswords, FrontModulesFlag.Passwords },
				{ tsWeather, FrontModulesFlag.Weather },
				{ tsRollDice, FrontModulesFlag.RollDice },
				{ tsCoinFlip, FrontModulesFlag.CoinFlip },
				{ tsTicTacToe, FrontModulesFlag.TicTacToe },
				{ tsPassowordsGenerator, FrontModulesFlag.PasswordsGenerator },
				{ tsPdfMerger, FrontModulesFlag.PdfMerger },
				{ tsGradeCalculator, FrontModulesFlag.GradesCalculator },
				{ tsConvertText, FrontModulesFlag.ConvertText },
				{ tsFormOut, FrontModulesFlag.FormOut },
				{ tsThreeSimpleRule, FrontModulesFlag.ThreeSimpleRule }
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
			foreach (KeyValuePair<ToggleSwitch, FrontModulesFlag> kvp in _map)
				kvp.Key.IsOn = kvp.Value.IsActive(valor);
		}

		#endregion

		#endregion
	}
}
