using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Tile;
using LifeLog.Core.Utils;
using System.ComponentModel.DataAnnotations;

namespace LifeLog.Helpers;

/// <summary>
/// grid helper
/// </summary>
internal static class ControlsHelper
{
    /// <summary>
    /// Gets the object by row handle
    /// </summary>
    /// <param name="rowIndex"></param>
    /// <returns></returns>
    internal static T? GetObjectByRowHandle<T>(this TileView tileView, int rowIndex) where T : class
    {
        if (tileView == null)
            throw new ArgumentNullException(nameof(tileView));

        if (rowIndex >= 0)
        {
            object rowObject = tileView.GetRow(rowIndex);
            return rowObject as T;
        }

        return null;
    }

    /// <summary>
    /// Gets the object by row handle
    /// </summary>
    /// <param name="rowIndex"></param>
    /// <returns></returns>
    internal static T? GetObjectByRowHandle<T>(this GridView gridView, int? rowIndex = null) where T : class
    {
        if (gridView == null)
            throw new ArgumentNullException(nameof(gridView));

        int rowi = rowIndex ?? gridView.FocusedRowHandle;
        if (rowi >= 0)
        {
            object rowObject = gridView.GetRow(rowi);

            if (rowObject is DevExpress.Data.Async.Helpers.ReadonlyThreadSafeProxyForObjectFromAnotherThread data)
            {
                rowObject = data.OriginalRow;
            }

            return rowObject as T;
        }

        return null;
    }

    /// <summary>
    /// Toggle password visibility  
    /// </summary>
    /// <param name="button"></param>
    /// <param name="e"></param>
    internal static void ButtonTogglePassword(this ButtonEdit button, ButtonPressedEventArgs e)
    {
        if (e.Button.Tag?.ToString() != "SH_PASSWORD") return;
        button.Properties.UseSystemPasswordChar = !button.Properties.UseSystemPasswordChar;
        e.Button.ImageOptions.SvgImage = button.Properties.UseSystemPasswordChar ? Properties.Resources.security_visibilityoff : Properties.Resources.security_visibility;
    }

    /// <summary>
    /// Show or hide the bar button item
    /// </summary>
    /// <param name="barButtonItem"></param>
    /// <param name="estado"></param>
    internal static void HideShowBarButton(this BarButtonItem barButtonItem, bool estado)
    {
        barButtonItem.Visibility = estado ? BarItemVisibility.Always : BarItemVisibility.Never;
    }

    /// <summary>
    /// Validates a form
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    internal static bool ValidateForm<T>(T obj, DXErrorProvider dxErrorProvider, Dictionary<string, Control> map)
    {
        dxErrorProvider.ClearErrors();

        obj.ValidateModel(out List<ValidationResult> validations);

        foreach (ValidationResult result in validations)
        {
            string message = result.ErrorMessage ?? "Invalid value";

            if (result.MemberNames == null || !result.MemberNames.Any())
                continue;

            foreach (var member in result.MemberNames)
            {
                if (string.IsNullOrWhiteSpace(member))
                    continue;

                if (map.TryGetValue(member, out var ctrl))
                {
                    string existing = dxErrorProvider.GetError(ctrl);
                    string merged = string.IsNullOrWhiteSpace(existing) ? message : existing + Environment.NewLine + message;

                    dxErrorProvider.SetError(ctrl, merged);
                }
            }
        }

        return !dxErrorProvider.HasErrors;
    }
}
