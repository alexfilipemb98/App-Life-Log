using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using LifeLog.Data.Models;
using LifeLog.UI.BackEnd.Views.ExternalPrograms;
using LifeLog.UI.Common.Helpers;
using System;

namespace LifeLog.UI.BackEnd.Bases
{
	/// <summary>
	/// Base view usercontrol to edit master data
	/// </summary>
	public partial class BaseView : XtraUserControl
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public BaseView() => InitializeComponent();

		public virtual void bbiBack_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowListView();
		}

		public virtual void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowDetailView();
		}

		public virtual void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowDetailView();
		}

		public virtual void bbiDelele_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		public virtual void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowListView();
		}

		public virtual void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		#region FUNCTIONS

		/// <summary>
		/// Show detail view 
		/// </summary>
		/// <param name="extProgram"></param>
		private void ShowDetailView()
		{
			bbiNew.Visibility = BarItemVisibility.Never;
			bbiSave.Visibility = BarItemVisibility.Always;
			bbiBack.Visibility = BarItemVisibility.Always;
			bbiEdit.Visibility = BarItemVisibility.Never;
			bbiReload.Visibility = BarItemVisibility.Never;
			bbiSearch.Visibility = BarItemVisibility.Never;

			navigationFrame.SelectedPage = npEdit;
		}

		/// <summary>
		/// Show the list view
		/// </summary>
		private void ShowListView()
		{
			try
			{
				bbiNew.Visibility = BarItemVisibility.Always;
				bbiEdit.Visibility = BarItemVisibility.Always;
				bbiBack.Visibility = BarItemVisibility.Never;
				bbiSave.Visibility = BarItemVisibility.Never;
				bbiReload.Visibility = BarItemVisibility.Always;
				bbiSearch.Visibility = BarItemVisibility.Always;

				navigationFrame.SelectedPage = npList;
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion
	}
}
