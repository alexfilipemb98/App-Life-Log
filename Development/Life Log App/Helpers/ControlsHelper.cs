using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Linq;
using DevExpress.XtraBars;
using System.Reflection;
using DevExpress.XtraBars.Ribbon;

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
		/// Show or hide the bar button item
		/// </summary>
		/// <param name="Rib"></param>
		internal static void RibbonPageVisibly(this RibbonPage Rib)
		{
			bool rpTableAny = Rib.Groups
				.SelectMany(group => group.ItemLinks)
				.Any(link => link.Item.Visibility == BarItemVisibility.Always);

			Rib.Visible = rpTableAny;
		}

		/// <summary>
		/// Create instance from name
		/// </summary>
		/// <param name="controlName"></param>
		/// <returns></returns>
		internal static object CreateInstanceFromName(string controlName, string nameSpacePrefix = "Life_Log_App")
		{
			Assembly assembly = Assembly.GetExecutingAssembly();

			// Procura por tipos cujo FullName começa com o namespace base e termina com o nome passado
			Type controlType = assembly.GetTypes()
				.FirstOrDefault(t =>
					t.IsClass &&
					t.FullName.StartsWith(nameSpacePrefix) &&
					t.FullName.EndsWith(controlName, StringComparison.Ordinal));

			return controlType != null ? Activator.CreateInstance(controlType) : null;
		}
	}
}
