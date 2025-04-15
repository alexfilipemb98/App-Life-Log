using Data.ORM.DataModelCode;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraRichEdit;
using DevExpress.XtraTab;
using Components;
using LifeLogApp.Forms.Dialog;
using LifeLogApp.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLogApp.Views.Notes
{
    /// <summary>
    /// Notes view
    /// </summary>
    public partial class NotesView : XtraUserControl
    {
        #region MAIN

        //PRIVATE
        private List<ORM_Notes> _notesList;
        private RichEditControlEx _crtRichEdit;

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
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string nameNote = $"New Note ({_notesList.Count + 1})";
                DialogResult form = TextInputDialogForm.Dialog(ref nameNote, 3, 50);

                if (form != DialogResult.OK)
                    return;

                ORM_Notes note = new ORM_Notes();
                note.Id = Guid.NewGuid();
                note.Title = nameNote;
                note.User = AppContext.CurrentUser;


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
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// Notes tab close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                XtraTabPage page = (XtraTabPage)((DevExpress.XtraTab.ViewInfo.PageEventArgs)e).Page;

                ORM_Notes note = _notesList.FirstOrDefault(w => w.Id == Guid.Parse(page.Tag?.ToString()));

                DialogResult result = MessageBoxDialogForm.SD("Delete Note", $"Do you really want to delete {note.Title}?");

                if (page != null && result == DialogResult.Yes)
                {
                    bool deleted = AppContext.DataEngine.Notes.Delete(Guid.Parse(page.Tag.ToString()), out string message);
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
        private void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
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

                ORM_Notes note = _notesList.FirstOrDefault(w => w.Id == Guid.Parse(xtraTabPage.Tag?.ToString()));
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
        public void LoadData()
        {
            _notesList = AppContext.DataEngine.Notes.GetUserNotes(AppContext.CurrentUser.Id) ?? new List<ORM_Notes>();

            xtraTabControl.TabPages.Clear();

            foreach (ORM_Notes note in _notesList)
            {
                CreateTab(note);
            }
        }

        /// <summary>
        /// Saves the data for the view
        /// </summary>
        /// <returns></returns>
        public bool SaveData()
        {
            try
            {
                foreach (XtraTabPage tabPage in xtraTabControl.TabPages.ToList())
                {
                    ORM_Notes note = _notesList.FirstOrDefault(w => w.Id == Guid.Parse(tabPage.Tag?.ToString()));

                    foreach (object tabPageControl in tabPage.Controls)
                    {
                        if (tabPageControl is RichEditBarContol richEdit)
                        {
                            richEdit.Invoke((MethodInvoker)(() => note.Text = richEdit.HtmlText));
                            break;
                        }
                    }
                }

                bool saved = AppContext.DataEngine.Notes.Save(_notesList, out string message);

                AppHelper.StatusMessage(message, saved);

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
        private void CreateTab(ORM_Notes note)
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

            richEdit.RichEdit.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.Control && e.KeyCode == Keys.S)
                {
                    e.Handled = true;
                    SaveNoteByKey(xtraTabPage);
                }
            };

            xtraTabPage.Controls.Add(richEdit);

            xtraTabControl.TabPages.Add(xtraTabPage);
        }

        /// <summary>
        /// Save note by key
        /// </summary>
        /// <param name="xtraTabPage"></param>
        private void SaveNoteByKey(XtraTabPage xtraTabPage)
        {
            try
            {
                ORM_Notes note = _notesList.FirstOrDefault(w => w.Id == Guid.Parse(xtraTabPage.Tag?.ToString()));

                foreach (var tabPageControl in xtraTabPage.Controls)
                {
                    if (tabPageControl is RichEditControl richEdit)
                    {
                        richEdit.Invoke((MethodInvoker)(() => note.Text = richEdit.HtmlText));
                        break;
                    }
                }

                bool saved = AppContext.DataEngine.Notes.Save(note, out string message);
                AppHelper.StatusMessage(message, saved);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion
    }
}
