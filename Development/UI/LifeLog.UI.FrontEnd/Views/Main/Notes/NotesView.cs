using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using LifeLog.Base.Components;
using LifeLog.Base.Models.Data;
using LifeLog.UI.Common;
using LifeLog.UI.Common.Forms.Dialog;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.UI.FrontEnd.Views.Main.Notes
{
	/// <summary>
	/// Notes view
	/// </summary>
	public partial class NotesView : XtraUserControl
	{
		#region MAIN

		//PRIVATE
		private List<NotesModel> _notesList;

		/// <summary>
		/// Constructor for the notes view
		/// </summary>
		public NotesView() => InitializeComponent();

		#endregion

		#region ITEM CLICK

		/// <summary>
		/// Create new note
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				string nameNote = $"New Note ({_notesList.Count + 1})";
				DialogResult form = TextInputDialogForm.Dialog(ref nameNote, 3, 50);

				if (form != DialogResult.OK)
					return;

				NotesModel note = new NotesModel();
				note.Title = nameNote;
				note.User = AppSession.CurrentUser;

				(bool saved, string message) = await AppSession.DataEngine.Notes.Save(note);

				_notesList.Add(note);

				CreateTab(note);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Save notes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
		{
			await SaveData();
		}

		/// <summary>
		/// Notes tab close button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
		{
			try
			{
				XtraTabPage page = (XtraTabPage)((DevExpress.XtraTab.ViewInfo.PageEventArgs)e).Page;

				NotesModel note = _notesList.FirstOrDefault(w => w.Id == Guid.Parse(page.Tag?.ToString()));

				DialogResult result = MessageBoxDialogForm.SD("Delete Note", $"Do you really want to delete {note.Title}?");

				if (page != null && result == DialogResult.Yes)
				{
					(bool deleted, string message) = await AppSession.DataEngine.Notes.Delete(Guid.Parse(page.Tag.ToString()));
					if (deleted)
					{
						xtraTabControl.TabPages.Remove(page);
						AppHelper.StatusMessage(message, ForeColors.Critical);
					}
				}

				return;
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		/// <summary>
		/// Reload the data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
		{
			await LoadData();
		}

		/// <summary>
		/// Edit name of the note
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				XtraTabPage xtraTabPage = xtraTabControl.SelectedTabPage;

				if (xtraTabPage == null)
					return;

				NotesModel note = _notesList.FirstOrDefault(w => w.Id == Guid.Parse(xtraTabPage.Tag?.ToString()));
				string nameNote = note.Title;
				DialogResult form = TextInputDialogForm.Dialog(ref nameNote, 3, 50);

				if (form != DialogResult.OK)
					return;

				note.Title = nameNote;
				xtraTabPage.Text = nameNote;
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region FUNCTIONS

		//PUBLIC 

		/// <summary>
		/// Load the data for the view
		/// </summary>
		public async Task LoadData()
		{
			_notesList = await AppSession.DataEngine.Notes.GetUserNotes(AppSession.CurrentUser.Id) ?? new List<NotesModel>();

			xtraTabControl.TabPages.Clear();

			foreach (NotesModel note in _notesList)
			{
				CreateTab(note);
			}
		}

		/// <summary>
		/// Saves the data for the view
		/// </summary>
		/// <returns></returns>
		public async Task<bool> SaveData()
		{
			try
			{
				foreach (XtraTabPage tabPage in xtraTabControl.TabPages.ToList())
				{
					NotesModel note = _notesList.FirstOrDefault(w => w.Id == Guid.Parse(tabPage.Tag?.ToString()));

					foreach (object tabPageControl in tabPage.Controls)
					{
						if (tabPageControl is RichEditBarContol richEdit)
						{
							richEdit.Invoke((MethodInvoker)(() => note.Text = richEdit.HtmlText));
							break;
						}
					}
				}

				bool saved = await AppSession.DataEngine.Notes.SaveList(_notesList);

				AppHelper.StatusMessage(saved ? "Saved" : "Not Saved", saved);
				return saved;
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
				return false;
			}
		}

		//PRIVATE

		/// <summary>
		/// Creates a new tab
		/// </summary>
		/// <param name="note"></param>
		private void CreateTab(NotesModel note)
		{
			int count = _notesList.Count + 1;

			// Create a new tab page
			XtraTabPage xtraTabPage = new XtraTabPage();
			xtraTabPage.Name = $"xtraTabPage{count}";
			xtraTabPage.Text = note.Title;
			xtraTabPage.Tag = note.Id;
			xtraTabPage.PageVisible = true;

			RichEditBarContol richEdit = new RichEditBarContol();
			richEdit.HtmlText = note.Text;
			richEdit.Dock = DockStyle.Fill;
			richEdit.BorderStyle = BorderStyle.None;

			richEdit.RichEdit.KeyDown += async (object sender, KeyEventArgs e) =>
			{
				if (e.Control && e.KeyCode == Keys.S)
				{
					e.Handled = true;
					await SaveNoteByKey(xtraTabPage);
				}
			};

			xtraTabPage.Controls.Add(richEdit);

			xtraTabControl.TabPages.Add(xtraTabPage);
		}

		/// <summary>
		/// Save note by key
		/// </summary>
		/// <param name="xtraTabPage"></param>
		private async Task SaveNoteByKey(XtraTabPage xtraTabPage)
		{
			try
			{
				NotesModel note = _notesList.FirstOrDefault(w => w.Id == Guid.Parse(xtraTabPage.Tag?.ToString()));

				foreach (var tabPageControl in xtraTabPage.Controls)
				{
					if (tabPageControl is RichEditBarContol richEdit)
					{
						richEdit.Invoke((MethodInvoker)(() => note.Text = richEdit.HtmlText));
						break;
					}
				}

				bool saved = await AppSession.DataEngine.Notes.Save(note);
				AppHelper.StatusMessage(saved ? "Saved" : "Not Saved", saved);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion
	}
}
