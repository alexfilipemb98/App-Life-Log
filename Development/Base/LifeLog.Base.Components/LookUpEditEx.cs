using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;

namespace LifeLog.Base.Components
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
		}

		/// <summary>
		/// Datasource changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LookupEditorEx_DataSourceChanged(object sender, EventArgs e)
		{
			if (sender is LookUpEdit lp)
			{
				var ds = lp.Properties.DataSource;
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
}
