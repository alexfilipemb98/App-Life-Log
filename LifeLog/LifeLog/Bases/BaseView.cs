using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace LifeLog.Bases;

/// <summary>
/// Base view usercontrol to edit master data
/// </summary>
public partial class BaseView : XtraUserControl
{
	#region MAIN

	/// <summary>
	/// Constructor
	/// </summary>
	public BaseView() => InitializeComponent();

	#endregion

	#region EVENTS

	#region CLICK

	/// <summary>
	/// Back button click
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public virtual void bbiBack_ItemClick(object sender, ItemClickEventArgs e) => ShowListView();

	/// <summary>
	/// New button click
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public virtual void bbiNew_ItemClick(object sender, ItemClickEventArgs e) => ShowDetailView();

	/// <summary>
	/// Edit button click
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public virtual void bbiEdit_ItemClick(object sender, ItemClickEventArgs e) => ShowDetailView();

	/// <summary>
	/// Delete button click
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public virtual void bbiDelele_ItemClick(object sender, ItemClickEventArgs e) => throw new NotImplementedException();

	/// <summary>
	/// Save button click
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public virtual void bbiSave_ItemClick(object sender, ItemClickEventArgs e) => ShowListView();

	/// <summary>
	/// Reload button click
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public virtual void bbiReload_ItemClick(object sender, ItemClickEventArgs e) => throw new NotImplementedException();

	#endregion
	
	#endregion
	
	#region FUNCTIONS

	/// <summary>
	/// Show detail view 
	/// </summary>
	/// <param name="extProgram"></param>
	private void ShowDetailView()
	{
		bbiBaseNew.Visibility = BarItemVisibility.Never;
		bbiBaseSave.Visibility = BarItemVisibility.Always;
		bbiBaseBack.Visibility = BarItemVisibility.Always;
		bbiBaseEdit.Visibility = BarItemVisibility.Never;
		bbiBaseReload.Visibility = BarItemVisibility.Never;
		bbiBaseSearch.Visibility = BarItemVisibility.Never;

		navigationFrameBase.SelectedPage = npEditBase;
	}

	/// <summary>
	/// Show the list view
	/// </summary>
	private void ShowListView()
	{
		bbiBaseNew.Visibility = BarItemVisibility.Always;
		bbiBaseEdit.Visibility = BarItemVisibility.Always;
		bbiBaseBack.Visibility = BarItemVisibility.Never;
		bbiBaseSave.Visibility = BarItemVisibility.Never;
		bbiBaseReload.Visibility = BarItemVisibility.Always;
		bbiBaseSearch.Visibility = BarItemVisibility.Always;

		navigationFrameBase.SelectedPage = npListBase;
	}

	#endregion
}
