using DevExpress.XtraEditors;
using LifeLog.Data.Models;
using LifeLog.Helpers;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace LifeLog.Views.Sql;

/// <summary>
/// SQL Browser view
/// </summary>
public partial class SqlBrowserView : XtraUserControl
{
    #region MAIN

    //PRIVATE
    private CancellationTokenSource? _sqlCts;
    private enum BatchKind { QueryReturnsRows, NonQuery }

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

        _sqlCts?.Dispose();
        _sqlCts = new CancellationTokenSource();

        try
        {
            dxErrorProvider.ClearErrors();

            if (string.IsNullOrWhiteSpace(recSqlPromt.Text))
            {
                dxErrorProvider.SetError(recSqlPromt, "SQL is required");
                return;
            }

            bbiStop.Enabled = true;

            string sqlText = GetSelectedOrAllSql();

            gridView.Columns.Clear();
            gridControl.DataSource = null;
            lblSqlInfo.Text = ""; // <-- troca para o teu LabelControl/MemoEdit

            var batches = SplitSqlBatches(sqlText).ToList();
            if (batches.Count == 0)
                return;

            var summary = new System.Text.StringBuilder();
            var totalSw = Stopwatch.StartNew();

            DataTable? lastSelectTable = null;
            int selectCount = 0;

            for (int i = 0; i < batches.Count; i++)
            {
                string batch = (batches[i] ?? "").Trim();
                if (batch.Length == 0) continue;

                var sw = Stopwatch.StartNew();

                try
                {
                    bool returnsRows = ClassifyBatch(batch) == BatchKind.QueryReturnsRows;

                    var r = await Program.DataEngine!.Geral.RunBatchAsync(
                        sql: batch,
                        returnsRows: returnsRows,
                        ct: _sqlCts.Token,
                        timeout: null
                    );

                    if (r.ReturnsRows)
                    {
                        selectCount++;
                        lastSelectTable = BuildDataTable(r);
                        summary.AppendLine($"SELECT #{selectCount}: {r.Rows.Count} row(s) | {sw.ElapsedMilliseconds} ms");
                    }
                    else
                    {
                        summary.AppendLine($"NON-SELECT: {r.AffectedRows ?? 0} row(s) affected | {sw.ElapsedMilliseconds} ms");
                    }
                }
                catch (OperationCanceledException)
                {
                    summary.AppendLine($"CANCELED | {sw.ElapsedMilliseconds} ms");
                    break;
                }
                catch (Exception ex)
                {
                    summary.AppendLine($"ERROR: {ex.Message} | {sw.ElapsedMilliseconds} ms");
                }
                finally
                {
                    sw.Stop();
                }
            }

            totalSw.Stop();

            if (lastSelectTable != null)
            {
                gridControl.DataSource = lastSelectTable;
                gridControl.RefreshDataSource();
                gridView.PopulateColumns();

                // Ajuste visual
                gridView.OptionsView.ColumnAutoWidth = true;
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView.Columns)
                {
                    col.OptionsColumn.AllowSize = true;
                    col.BestFit();
                    col.Width = Math.Min(col.Width, 550);
                }
                gridView.OptionsView.ColumnAutoWidth = false;
            }
            else
            {
                gridControl.DataSource = null;
                gridControl.RefreshDataSource();
            }

            lblSqlInfo.Text =
                summary.ToString().TrimEnd() +
                $"{Environment.NewLine}Total: {totalSw.ElapsedMilliseconds} ms";
        }
        catch (Exception ex)
        {
            ErrorHelper.Handler(ex);
        }
        finally
        {
            _sqlCts?.Dispose();
            _sqlCts = null;

            gridView.EndDataUpdate();
            gridControl.EndUpdate();

            bbiStop.Enabled = false;
        }

        // ===== helpers locais =====

        string GetSelectedOrAllSql()
        {
            string selectedText = recSqlPromt.Document.GetText(recSqlPromt.Document.Selection);
            return !string.IsNullOrWhiteSpace(selectedText) ? selectedText : recSqlPromt.Text;
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

    /// <summary>
    /// Stop button click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bbiStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        _sqlCts?.Cancel();
    }

    #endregion

    #region FUNCTIONS

    #region PRIVATE

    /// <summary>
    /// Build DataTable from SqlBatchResult
    /// </summary>
    /// <param name="r"></param>
    /// <returns></returns>
    private static DataTable BuildDataTable(SqlBatchResult r)
    {
        DataTable dt = new DataTable("Result");

        foreach (var c in r.Columns)
            dt.Columns.Add(c, typeof(object));

        foreach (var row in r.Rows)
        {
            DataRow dr = dt.NewRow();
            foreach (string c in r.Columns)
                dr[c] = row.TryGetValue(c, out var v) && v != null ? v : DBNull.Value;

            dt.Rows.Add(dr);
        }

        return dt;
    }

    /// <summary>
    /// Classify batch type
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    private BatchKind ClassifyBatch(string sql)
    {
        string cleaned = StripComments(sql).TrimStart();
        if (cleaned.Length == 0) return BatchKind.NonQuery;

        string firstToken = ReadFirstToken(cleaned);

        // Para MSSQL/SQLite, isto cobre a esmagadora maioria
        if (firstToken.Equals("SELECT", StringComparison.OrdinalIgnoreCase) ||
            firstToken.Equals("WITH", StringComparison.OrdinalIgnoreCase) ||
            firstToken.Equals("PRAGMA", StringComparison.OrdinalIgnoreCase) ||  // SQLite
            firstToken.Equals("SHOW", StringComparison.OrdinalIgnoreCase) ||
            firstToken.Equals("DESCRIBE", StringComparison.OrdinalIgnoreCase) ||
            firstToken.Equals("DESC", StringComparison.OrdinalIgnoreCase))
        {
            return BatchKind.QueryReturnsRows;
        }

        return BatchKind.NonQuery;
    }

    /// <summary>
    /// Read first token
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    private string ReadFirstToken(string text)
    {
        int i = 0;
        while (i < text.Length && char.IsWhiteSpace(text[i])) i++;

        int start = i;
        while (i < text.Length && (char.IsLetter(text[i]) || text[i] == '_')) i++;

        return start < i ? text.Substring(start, i - start) : "";
    }

    /// <summary>
    /// Splip sql batches
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    private static IEnumerable<string> SplitSqlBatches(string sql)
    {
        if (string.IsNullOrWhiteSpace(sql))
            yield break;

        var sb = new StringBuilder();
        bool inString = false;
        bool inLineComment = false;
        bool inBlockComment = false;

        for (int i = 0; i < sql.Length; i++)
        {
            char c = sql[i];
            char next = (i + 1 < sql.Length) ? sql[i + 1] : '\0';

            if (inLineComment)
            {
                sb.Append(c);
                if (c == '\n') inLineComment = false;
                continue;
            }

            if (inBlockComment)
            {
                sb.Append(c);
                if (c == '*' && next == '/')
                {
                    sb.Append(next);
                    i++;
                    inBlockComment = false;
                }
                continue;
            }

            if (!inString)
            {
                if (c == '-' && next == '-')
                {
                    sb.Append(c).Append(next);
                    i++;
                    inLineComment = true;
                    continue;
                }

                if (c == '/' && next == '*')
                {
                    sb.Append(c).Append(next);
                    i++;
                    inBlockComment = true;
                    continue;
                }
            }

            // strings: '...' com escape '' (duas aspas simples)
            if (c == '\'')
            {
                sb.Append(c);

                if (inString && next == '\'')
                {
                    sb.Append(next);
                    i++;
                }
                else
                {
                    inString = !inString;
                }
                continue;
            }

            // separador de batch
            if (!inString && c == ';')
            {
                var batch = sb.ToString().Trim();
                if (batch.Length > 0) yield return batch;
                sb.Clear();
                continue;
            }

            sb.Append(c);
        }

        var last = sb.ToString().Trim();
        if (last.Length > 0)
            yield return last;
    }

    /// <summary>
    /// Strip comments from SQL
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    private static string StripComments(string sql)
    {
        if (string.IsNullOrEmpty(sql)) return sql;

        var sb = new StringBuilder(sql.Length);
        bool inString = false;
        bool inLineComment = false;
        bool inBlockComment = false;

        for (int i = 0; i < sql.Length; i++)
        {
            char c = sql[i];
            char next = (i + 1 < sql.Length) ? sql[i + 1] : '\0';

            if (inLineComment)
            {
                if (c == '\n')
                {
                    inLineComment = false;
                    sb.Append(c);
                }
                continue;
            }

            if (inBlockComment)
            {
                if (c == '*' && next == '/')
                {
                    i++;
                    inBlockComment = false;
                }
                continue;
            }

            if (!inString)
            {
                if (c == '-' && next == '-')
                {
                    i++;
                    inLineComment = true;
                    continue;
                }

                if (c == '/' && next == '*')
                {
                    i++;
                    inBlockComment = true;
                    continue;
                }
            }

            if (c == '\'')
            {
                sb.Append(c);

                if (inString && next == '\'')
                {
                    sb.Append(next);
                    i++;
                }
                else
                {
                    inString = !inString;
                }
                continue;
            }

            sb.Append(c);
        }

        return sb.ToString();
    }

    #endregion

    #endregion
}
