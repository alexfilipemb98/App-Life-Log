using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Linq;

namespace LifeLogApp.Helpers
{
    /// <summary>
    /// grid helper
    /// </summary>
    public class ControlsHelper
    {
        /// <summary>
        /// Gets the object by row handle
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public static T GetObjectByRowHandle<T>(TileView tileView, int rowIndex) where T : class
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
        public static T GetObjectByRowHandle<T>(GridView gridView, int rowIndex) where T : class
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
        public static void ButtonTogglePassword(ButtonEdit button, ButtonPressedEventArgs e)
        {
            button.Properties.UseSystemPasswordChar = !button.Properties.UseSystemPasswordChar;
            e.Button.ImageOptions.SvgImage = button.Properties.UseSystemPasswordChar ? Properties.Resources.security_visibilityoff : Properties.Resources.security_visibility;
        }
    }
}
