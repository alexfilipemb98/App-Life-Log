using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Linq;

namespace Life_Log.Helpers
{
    /// <summary>
    /// grid helper
    /// </summary>
    public class GridHelper
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
    }
}
