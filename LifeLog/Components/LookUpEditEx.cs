using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;

namespace LifeLog.Components
{
	[ToolboxItem(true)]
	public class LookUpEditEx : LookUpEdit
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public LookUpEditEx()
		{
			this.DataSourceChanged += LookupEditorEx_DataSourceChanged;
			this.BeforePopup += LookUpEditEx_BeforePopup;
		}

		/// <summary>
		/// Lookup edit before popup
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LookUpEditEx_BeforePopup(object sender, EventArgs e) => CheckDataSouce(sender);

		/// <summary>
		/// Datasource changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LookupEditorEx_DataSourceChanged(object sender, EventArgs e) => CheckDataSouce(sender);

		/// <summary>
		/// Check datasource and ajust DropDownRows
		/// </summary>
		/// <param name="sender"></param>
		private static void CheckDataSouce(object sender)
		{
			if (sender is not LookUpEdit lp)
				return;
			
			object ds = lp.Properties.DataSource;
			int cnt = 0;

			if (ds is IListSource ls)             // DataTable, BindingSource, etc.
				ds = ls.GetList();

			if (ds is ICollection col)            // IList, List<T>, BindingList<T>, DataView, etc.
				cnt = col.Count;
			else if (ds is IEnumerable en)        // Qualquer outra sequência enumerável
				cnt = en.Cast<object>().Count();

			lp.Properties.DropDownRows = Math.Min(7, Math.Max(0, cnt));
		}
	}
}
