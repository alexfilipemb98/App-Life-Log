using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Linq;
using DevExpress.XtraBars;
using System.Reflection;
using DevExpress.XtraBars.Ribbon;

namespace LifeLog.Helpers
{
	/// <summary>
	/// grid helper
	/// </summary>
	public static class ControlsHelper
	{
		/// <summary>
		/// Gets the object by row handle
		/// </summary>
		/// <param name="rowIndex"></param>
		/// <returns></returns>
		public static T? GetObjectByRowHandle<T>(this TileView tileView, int rowIndex) where T : class
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
		public static T? GetObjectByRowHandle<T>(this GridView gridView, int? rowIndex = null) where T : class
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
		public static void ButtonTogglePassword(this ButtonEdit button, ButtonPressedEventArgs e)
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
		public static void HideShowBarButton(this BarButtonItem barButtonItem, bool estado)
		{
			barButtonItem.Visibility = estado ? BarItemVisibility.Always : BarItemVisibility.Never;
		}
	}
}
