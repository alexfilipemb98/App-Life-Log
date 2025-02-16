using Core.Interfaces;
using Data.Entities;
using DevExpress.Utils.Html;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraRichEdit;
using DevExpress.XtraTab;
using Life_Log.Components;
using Life_Log.Forms.Dialogs;
using Life_Log.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace Life_Log.Views.Home.Notes
{
    /// <summary>
    /// Notes view
    /// </summary>
    public partial class NotesView : XtraUserControl
    {
        #region MAIN

        //PRIVATE
        private List<Data.Entities.NotesEntity> _notesList;
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
                DialogResult form = TextInputDialogForm.SD(ref nameNote, 3, 50);

                if (form != DialogResult.OK)
                    return;

                Data.Entities.NotesEntity note = new Data.Entities.NotesEntity();
                note.Id = Guid.NewGuid();
                note.EditingMode = false;
                note.Name = nameNote;

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
        /// Copy text format to another text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bciFormatPainter_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bciFormatPainter.Checked)
            {
                _crtRichEdit.SaveSelectedRange();
                _crtRichEdit.FormatCalculatorEnabled = true;
            }
            else
                _crtRichEdit.FormatCalculatorEnabled = false;
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

                DialogResult result = DialogHelper.ShowDeleteDialog("Delete Note", $"Do you really want to delete {page.Text}?");

                if (page != null && result == DialogResult.Yes)
                {
                    bool deleted = AppHelper.DataEngine.Notes.Delete(Guid.Parse(page.Tag.ToString()), out string message);
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
                Data.Entities.NotesEntity note = _notesList.FirstOrDefault(w => w.Id == Guid.Parse(xtraTabPage.Tag?.ToString()));
                string nameNote = note.Name;
                DialogResult form = TextInputDialogForm.SD(ref nameNote, 3, 50);

                if (form != DialogResult.OK)
                    return;

                note.Name = nameNote;
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
            _notesList = AppHelper.DataEngine.Notes.GetAll() ?? new List<Data.Entities.NotesEntity>();

            xtraTabControl.TabPages.Clear();

            foreach (Data.Entities.NotesEntity note in _notesList)
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
                foreach (XtraTabPage tabPage in xtraTabControl.TabPages.ToList<XtraTabPage>())
                {
                    Data.Entities.NotesEntity note = _notesList.FirstOrDefault(w => w.Id == Guid.Parse(tabPage.Tag?.ToString()));

                    foreach (object tabPageControl in tabPage.Controls)
                    {
                        if (tabPageControl is RichEditControl richEdit)
                        {
                            richEdit.Invoke((MethodInvoker)(() => note.Text = richEdit.HtmlText));
                            break;
                        }
                    }

                    bool saved = AppHelper.DataEngine.Notes.Save(note, out _);
                }

                AppHelper.StatusMessage("Notes saved!", Color.Green);

                return true;
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
        private void CreateTab(Data.Entities.NotesEntity note)
        {
            int count = _notesList.Count + 1;

            // Create a new tab page
            XtraTabPage xtraTabPage = new XtraTabPage();
            xtraTabPage.Name = $"xtraTabPage{count}";
            xtraTabPage.Text = note.Name;
            xtraTabPage.Tag = note.Id;
            xtraTabPage.PageVisible = true;

            RichEditControlEx richEdit = new RichEditControlEx();
            richEdit.Dock = DockStyle.Fill;
            richEdit.Name = $"richEdit{count}";
            richEdit.BorderStyle = BorderStyles.NoBorder;
            richEdit.Margin = new Padding(0);
            richEdit.HtmlText = note.Text;
            richEdit.Options.DocumentSaveOptions.CurrentFormat = DocumentFormat.PlainText;
            richEdit.Options.DocumentSaveOptions.DefaultFormat = DocumentFormat.Undefined;
            richEdit.Options.HorizontalScrollbar.Visibility = RichEditScrollbarVisibility.Hidden;
            richEdit.Options.Printing.PrintPreviewFormKind = PrintPreviewFormKind.Bars;
            richEdit.Options.DocumentCapabilities.FootNotes = DocumentCapability.Disabled;
            richEdit.Options.DocumentCapabilities.HeadersFooters = DocumentCapability.Disabled;
            richEdit.LayoutUnit = DocumentLayoutUnit.Pixel;
            richEdit.MenuManager = barManager;
            richEdit.ActiveViewType = RichEditViewType.Simple;
            richEdit.SpellChecker = spellChecker;
            richEdit.Options.HorizontalRuler.ShowLeftIndent = false;
            richEdit.Options.HorizontalRuler.ShowRightIndent = false;
            richEdit.Options.HorizontalRuler.ShowTabs = false;
            richEdit.Views.SimpleView.AdjustColorsToSkins = true;
            richEdit.Views.SimpleView.AllowDisplayLineNumbers = true;

            richEdit.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.Control && e.KeyCode == Keys.S)
                {
                    e.Handled = true;
                    SaveNoteByKey(xtraTabPage);
                }
            };

            richEdit.MouseUp += (object sender, MouseEventArgs e) =>
            {
                if (bciFormatPainter.Checked)
                {
                    richEdit.ApplyFormatToSelectedText();
                    bciFormatPainter.Checked = false;
                }
            };

            richEdit.GotFocus += (object sender, EventArgs e) =>
            {
                richEditBarController.Control = richEdit;
                _crtRichEdit = richEdit;
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
                Data.Entities.NotesEntity note = _notesList.FirstOrDefault(w => w.Id == Guid.Parse(xtraTabPage.Tag?.ToString()));

                foreach (var tabPageControl in xtraTabPage.Controls)
                {
                    if (tabPageControl is RichEditControl richEdit)
                    {
                        richEdit.Invoke((MethodInvoker)(() => note.Text = richEdit.HtmlText));
                        break;
                    }
                }

                bool saved = AppHelper.DataEngine.Notes.Save(note, out string message);
                AppHelper.StatusMessage(message, saved ? ForeColors.Information : ForeColors.Critical);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion
    }
}
