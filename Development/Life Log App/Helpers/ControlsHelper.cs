using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Linq;
using DevExpress.XtraBars;
using System.Reflection;

namespace Life_Log_App.Helpers
{
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
        internal static T GetObjectByRowHandle<T>(this TileView tileView, int rowIndex) where T : class
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
        internal static T GetObjectByRowHandle<T>(this GridView gridView, int rowIndex) where T : class
        {
            if (gridView == null)
                throw new ArgumentNullException(nameof(gridView));

            if (rowIndex >= 0)
            {
                object rowObject = gridView.GetRow(rowIndex);
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
        /// Create instance from name
        /// </summary>
        /// <param name="controlName"></param>
        /// <returns></returns>
        internal static object CreateInstanceFromName(string controlName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type controlType = assembly.GetType(controlName);

            if (controlType != null)
                return Activator.CreateInstance(controlType);
            else
                return null;
        }
    }
}
