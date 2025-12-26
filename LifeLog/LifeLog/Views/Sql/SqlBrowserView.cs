using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using LifeLog.Helpers;
using System.Dynamic;
using System.Threading.Tasks;

namespace LifeLog.UI.Common.Views
{
	/// <summary>
	/// SQL Browser view
	/// </summary>
	public partial class SqlBrowserView : XtraUserControl
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		public SqlBrowserView() => InitializeComponent();

		#endregion

		#region CLICK

		/// <summary>
		/// Execute button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiExecute_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			gridControl.BeginUpdate();
			gridView.BeginDataUpdate();
			try
			{
				dxErrorProvider.ClearErrors();

				if (string.IsNullOrWhiteSpace(recSqlPromt.Text))
					dxErrorProvider.SetError(recSqlPromt, "SQL is required");

				if (dxErrorProvider.HasErrors)
					return;

				string sqlText = recSqlPromt.Text;

				gridView.Columns.Clear();
				gridControl.DataSource = null;

				string selectedText = recSqlPromt.Document.GetText(recSqlPromt.Document.Selection);
				if (!string.IsNullOrEmpty(selectedText))
					sqlText = selectedText;

				string[] queries = sqlText.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
				List<ExpandoObject> processedResults = new List<ExpandoObject>();

				foreach (string query in queries)
				{
					bool isSelectQuery = query.TrimStart().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase);

					if (isSelectQuery)
					{
						IEnumerable<dynamic> results = await Program.DataEngine!.Geral.LoadSql<dynamic>(query.Trim());

						foreach (var result in results)
						{
							IDictionary<string, object> resultDict = result;
							dynamic expandoObj = new ExpandoObject();
							IDictionary<string, object> expandoDict = expandoObj;

							int unnamedCount = 0; // Counter for unnamed columns

							foreach (var kvp in resultDict)
							{
								string key = string.IsNullOrEmpty(kvp.Key) ? $"Column_{++unnamedCount}" : kvp.Key;

								if (expandoDict.ContainsKey(key))
									expandoDict[$"{key}_1"] = kvp.Value;
								else
									expandoDict[key] = kvp.Value;
							}

							processedResults.Add(expandoObj);
						}
					}
					else		   
					{
						int affectedRows = await Program.DataEngine!.Geral.ExecuteSql<int>(query.Trim());
						dynamic expandoObj = new ExpandoObject();
						IDictionary<string, object> expandoDict = expandoObj;

						expandoDict["Query"] = query.Trim();
						expandoDict["AffectedRows"] = affectedRows;

						processedResults.Add(expandoObj);
					}
				}

				gridControl.DataSource = processedResults;
				gridControl.RefreshDataSource();
				gridView.PopulateColumns();
				gridView.OptionsView.ColumnAutoWidth = true;

				foreach (GridColumn column in gridView.Columns)
				{
					column.OptionsColumn.AllowSize = true;
					column.BestFit();
					column.Width = Math.Min(column.Width, 550);
				}

				gridView.OptionsView.ColumnAutoWidth = false;
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
			finally
			{
				gridView.EndDataUpdate();
				gridControl.EndUpdate();
			}
		}

		/// <summary>
		/// Clear button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Right)
					popupMenuGridResults.ShowPopup(Control.MousePosition);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Copy cell value to clipboard
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiCopyCellValue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			try
			{
				object cellValue = gridView.GetFocusedValue();
				if (cellValue != null)
					Clipboard.SetText(cellValue!.ToString()!);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion
	}
}
