using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using LifeLog.Components;
using LifeLog.Core.Utils;
using LifeLog.Data.Entities;
using LifeLog.Helpers;

namespace LifeLog.Views.Notes;

/// <summary>
/// Notes view
/// </summary>
public partial class NotesView : XtraUserControl
{
	#region MAIN

	//PRIVATE
	private List<Note> _notesList;
	private XtraTabPage dragTab = null;

	/// <summary>
	/// Constructor for the notesJson view
	/// </summary>
	public NotesView() => InitializeComponent();

	#endregion

	#region EVENTS

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

			Note note = new Note();
			note.Title = nameNote;
			note.IdUser = Program.LoggedUser!.Id;

			(bool saved, string message) = await Program.DataEngine!.Notes.Save(note);

			AppHelper.StatusMessage(message, saved);

			if (saved)
			{
				_notesList.Add(note);
				CreateTab(note);
			}
		}
		catch (Exception ex)
		{
			ErrorHelper.Handler(ex);
		}
	}

	/// <summary>
	/// Save notesJson
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void bbiSave_ItemClick(object sender, ItemClickEventArgs e) => await SaveData();

	/// <summary>
	/// Reload the data
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void bbiReload_ItemClick(object sender, ItemClickEventArgs e) => await LoadData();

	/// <summary>
	/// Export notesJson to JSON
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
	{
		string? fileName = DialogHelper.SaveJsonFile("notes");
		if (string.IsNullOrWhiteSpace(fileName))
			return;

		JsonUtil.ExportToFile(_notesList, fileName, indented: true);
		MessageBox.Show($"({_notesList.Count}) Notes exported successfuly!");
	}

	/// <summary>
	/// Import notesJson from JSON
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void bbiImport_ItemClick(object sender, ItemClickEventArgs e)
	{
		try
		{
			using OpenFileDialog openFileDialog = new();
			openFileDialog.Title = "Open notes JSON";
			openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
			openFileDialog.DefaultExt = "json";

			if (openFileDialog.ShowDialog() != DialogResult.OK)
				return;

			List<Note>? notesJson = JsonUtil.ImportFromFile<List<Note>>(openFileDialog.FileName);

			if (notesJson is null)
				return;

			notesJson.ForEach(w => w.IdUser = Program.LoggedUser!.Id);

			_notesList.AddRange(notesJson);

			(bool saved, string message) = await Program.DataEngine!.Notes.SaveList(notesJson);

			AppHelper.StatusMessage(message, saved);

			if (saved)
			{
				foreach (Note note in notesJson)
					CreateTab(note);
			}
		}
		catch (Exception ex)
		{
			ErrorHelper.Handler(ex);
		}
	}

	#endregion

	#region TAB CONTROLL

	/// <summary>
	/// Notes tab close button
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
	{
		XtraTabPage page = (XtraTabPage)((PageEventArgs)e).Page;

		string? tag = page.Tag?.ToString();

		if (string.IsNullOrWhiteSpace(tag) || !Guid.TryParse(tag, out Guid noteId) || noteId == Guid.Empty)
			return;

		Note? note = _notesList.FirstOrDefault(w => w.Id == noteId);

		if (note is null)
			return;

		DialogResult result = MessageBox.Show($"Do you really want to delete {note.Title}?", "Delete Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (page == null || result != DialogResult.Yes)
			return;

		(bool deleted, string message) = await Program.DataEngine!.Notes.Delete(noteId);

		AppHelper.StatusMessage(message, !deleted);

		if (deleted)
		{
			_notesList.Remove(note);
			xtraTabControl.TabPages.Remove(page);
		}
	}

	/// <summary>
	/// Notes tab controll mouse down
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void xtraTabControl_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			XtraTabHitInfo hitInfo = xtraTabControl.CalcHitInfo(e.Location);
			if (hitInfo.HitTest == XtraTabHitTest.PageHeader)
				dragTab = hitInfo.Page;
			else
				dragTab = null;
		}
		catch (Exception ex)
		{
			ErrorHelper.Handler(ex);
		}
	}

	/// <summary>
	/// Tab controll mouse move
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void xtraTabControl_MouseMove(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left && dragTab != null)
			{
				xtraTabControl.DoDragDrop(dragTab, DragDropEffects.Move);
			}
		}
		catch (Exception ex)
		{
			ErrorHelper.Handler(ex);
		}
	}

	/// <summary>
	/// Tab controll drag over 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void xtraTabControl_DragOver(object sender, DragEventArgs e)
	{
		e.Effect = DragDropEffects.Move;
	}

	/// <summary>
	/// Tab controll drag and drop
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void xtraTabControl_DragDrop(object sender, DragEventArgs e)
	{
		try
		{
			if (e.Data is null) return;

			Point pt = xtraTabControl.PointToClient(new Point(e.X, e.Y));
			XtraTabHitInfo hitInfo = xtraTabControl.CalcHitInfo(pt);
			XtraTabPage targetTab = hitInfo.Page;
			XtraTabPage? draggedTab = (XtraTabPage?)e.Data.GetData(typeof(XtraTabPage));

			if (draggedTab == null || targetTab == null || draggedTab == targetTab)
				return;

			int targetIndex = xtraTabControl.TabPages.IndexOf(targetTab);
			xtraTabControl.TabPages.Remove(draggedTab);
			xtraTabControl.TabPages.Insert(targetIndex, draggedTab);
			xtraTabControl.SelectedTabPage = draggedTab;
		}
		catch (Exception ex)
		{
			ErrorHelper.Handler(ex);
		}
	}

	/// <summary>
	/// Tab controll selected page changed
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void xtraTabControl_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
	{
		XtraTabPage xtraTabPage = xtraTabControl.SelectedTabPage;

		if (xtraTabPage == null
			|| string.IsNullOrWhiteSpace(xtraTabPage.Tag?.ToString())
			|| !Guid.TryParse(xtraTabPage.Tag.ToString(), out Guid id)
			|| id == Guid.Empty)
			return;

		Note? note = _notesList.FirstOrDefault(w => w.Id == id);

		if (note is null) return;

		bbiTitle.EditValue = note.Title!;

		if (xtraTabPage.Appearance.Header.BackColor.Name != "0")
			bbiNotesColor.EditValue = xtraTabPage.Appearance.Header.BackColor.ToArgb();
		else
			bbiNotesColor.EditValue = null;
	}

	#endregion

	#region EDIT VALUE CHANGED

	/// <summary>
	/// Notes color edit value
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void bbiNotesColor_EditValueChanged(object sender, EventArgs e)
	{
		XtraTabPage xtraTabPage = xtraTabControl.SelectedTabPage;
		if (xtraTabPage == null)
			return;

		BarEditItem? edit = sender as BarEditItem;
		if (edit?.EditValue is Color selectedColor)
		{
			xtraTabPage.BackColor = selectedColor;
			xtraTabPage.Appearance.Header.BackColor = selectedColor;
		}
	}

	/// <summary>
	/// notesJson title changed
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void bbiTitle_EditValueChanged(object sender, EventArgs e)
	{
		XtraTabPage xtraTabPage = xtraTabControl.SelectedTabPage;
		if (xtraTabPage == null
			|| string.IsNullOrWhiteSpace(xtraTabPage.Tag?.ToString())
			|| !Guid.TryParse(xtraTabPage.Tag.ToString(), out Guid id)
			|| id == Guid.Empty)
			return;

		Note? note = _notesList.FirstOrDefault(w => w.Id == id);

		if (note is null) return;

		note.Title = bbiTitle.EditValue?.ToString();
		xtraTabPage.Text = bbiTitle.EditValue?.ToString();
	}

	#endregion

	#endregion

	#region FUNCTIONS

	#region PUBLIC

	/// <summary>
	/// Load the data for the view
	/// </summary>
	public async Task LoadData()
	{
		(List<Note?>? notesList, _) = await Program.DataEngine!.Notes.GetUserNotes(Program.LoggedUser!.Id);

		_notesList = notesList ?? new List<Note>();

		xtraTabControl.TabPages.Clear();

		foreach (Note note in _notesList)
		{
			CreateTab(note);
		}

		xtraTabControl.AllowDrop = true;
		xtraTabControl.MouseDown += xtraTabControl_MouseDown;
		xtraTabControl.MouseMove += xtraTabControl_MouseMove;
		xtraTabControl.DragOver += xtraTabControl_DragOver;
		xtraTabControl.DragDrop += xtraTabControl_DragDrop;
	}

	/// <summary>
	/// Saves the data for the view
	/// </summary>
	/// <returns></returns>
	public async Task<bool> SaveData()
	{
		short index = 0;
		foreach (XtraTabPage tabPage in xtraTabControl.TabPages.ToList())
		{
			if (tabPage.Tag is not Guid id || id == Guid.Empty)
				continue;

			Note? note = _notesList.FirstOrDefault(w => w.Id == id);

			if (note is null)
				continue;

			if (tabPage.Appearance.Header.BackColor.Name != "0")
				note.Color = tabPage.Appearance.Header.BackColor.ToArgb();

			note.Position = index;

			foreach (object tabPageControl in tabPage.Controls)
			{
				if (tabPageControl is RichEditBarContol richEdit)
				{
					richEdit.Invoke((MethodInvoker)(() => note.Text = richEdit.HtmlText));
					break;
				}
			}

			index++;
		}

		(bool saved, string message) = await Program.DataEngine!.Notes.SaveList(_notesList);

		AppHelper.StatusMessage(message, saved);

		return saved;
	}

	#endregion

	#region PRIVATE

	/// <summary>
	/// Creates a new tab
	/// </summary>
	/// <param name="note"></param>
	private void CreateTab(Note note)
	{
		int count = _notesList.Count + 1;

		XtraTabPage xtraTabPage = new XtraTabPage();
		xtraTabPage.Name = $"xtraTabPage{count}";
		xtraTabPage.Text = note.Title;
		xtraTabPage.Tag = note.Id;
		xtraTabPage.PageVisible = true;

		if (note.Color != 0)
		{
			xtraTabPage.Appearance.Header.BackColor = Color.FromArgb(note.Color);
			xtraTabPage.Appearance.Header.BackColor2 = Color.FromArgb(note.Color); // gradiente igual
			xtraTabPage.Appearance.Header.Options.UseBackColor = true;
		}

		RichEditBarContol richEdit = new RichEditBarContol();
		richEdit.HtmlText = note.Text!;
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
		if (!(xtraTabPage.Tag is Guid id && id != Guid.Empty))
			return;

		Note? note = _notesList.FirstOrDefault(w => w.Id == id);

		if (note is null)
			return;

		int index = xtraTabControl.TabPages.IndexOf(xtraTabPage);

		note.Position = (short)index;

		if (xtraTabPage.Appearance.Header.BackColor.Name != "0")
			note.Color = xtraTabPage.Appearance.Header.BackColor.ToArgb();

		foreach (var tabPageControl in xtraTabPage.Controls)
		{
			if (tabPageControl is RichEditBarContol richEdit)
			{
				richEdit.Invoke((MethodInvoker)(() => note.Text = richEdit.HtmlText));
				break;
			}
		}

		(bool saved, string message) = await Program.DataEngine!.Notes.Save(note);

		AppHelper.StatusMessage(message, saved);
	}

	#endregion

	#endregion
}
