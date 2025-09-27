using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using LifeLog.UI.Common.Helpers;

namespace LifeLog.UI.FrontEnd.Views.Main.Passwords
{
	/// <summary>
	/// Passwords View 
	/// </summary>
	public partial class PasswordsView : XtraUserControl
	{
		#region MAIN

		/// <summary>
		/// Constructor to initialize the view
		/// </summary>
		public PasswordsView() => InitializeComponent();

		#endregion
		
		#region EVENTS

		#region CLICK

		/// <summary>
		/// New item click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
		}

		/// <summary>
		/// Save 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
		{
		}

		/// <summary>
		/// Edit data click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
		}

		/// <summary>
		/// Password button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void beLoginPassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			ControlsHelper.ButtonTogglePassword(sender as ButtonEdit, e);

			if (e.Button.Tag?.ToString() == "GENPASS")
			{
				
			}

		}

		#endregion

		#endregion

		#region FUNCTIONS

		#region PUBLIC

		/// <summary>
		/// LoadData to views
		/// </summary>
		public void LoadData()
		{

		}

		#endregion

		#endregion

	}
}
