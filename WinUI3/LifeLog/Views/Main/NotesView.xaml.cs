using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LifeLog.Views.Main
{
    public class NoteItem : INotifyPropertyChanged
    {
        private string _title;
        private string _plainContent; // Usado para o resumo na lista da esquerda
        private DateTime _lastModified;

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string RtfContent { get; set; } = string.Empty; // Onde guardamos as formatações reais!

        public string Title
        {
            get => _title;
            set { if (_title != value) { _title = value; OnPropertyChanged(); } }
        }

        public string PlainContent
        {
            get => _plainContent;
            set { if (_plainContent != value) { _plainContent = value; OnPropertyChanged(); } }
        }

        public DateTime LastModified
        {
            get => _lastModified;
            set { if (_lastModified != value) { _lastModified = value; OnPropertyChanged(); OnPropertyChanged(nameof(DateStr)); } }
        }

        public string DateStr => LastModified.ToString("MMM dd, yyyy - HH:mm");

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public sealed partial class NotesView : UserControl
    {
        private ObservableCollection<NoteItem> _allNotes = new ObservableCollection<NoteItem>();
        public ObservableCollection<NoteItem> DisplayNotes { get; set; } = new ObservableCollection<NoteItem>();

        private NoteItem _currentNote;
        private bool _isUpdatingUI = false;

        public NotesView()
        {
            this.InitializeComponent();
            NotesList.ItemsSource = DisplayNotes;
            AddNote("Welcome to LifeLog", "Start writing your secure, rich-text notes here!");
        }

        private void NewNoteBtn_Click(object sender, RoutedEventArgs e)
        {
            AddNote("Untitled Note", "");
        }

        private void AddNote(string title, string content)
        {
            var newNote = new NoteItem
            {
                Title = title,
                PlainContent = content,
                LastModified = DateTime.Now
            };

            _allNotes.Insert(0, newNote);
            FilterNotes(SearchBox.Text);

            NotesList.SelectedItem = newNote;
            TitleBox.Focus(FocusState.Programmatic);
        }

        private void NotesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _currentNote = NotesList.SelectedItem as NoteItem;

            if (_currentNote != null)
            {
                _isUpdatingUI = true;

                TitleBox.Text = _currentNote.Title;

                // Carrega o texto com a formatação guardada (RTF)
                if (!string.IsNullOrEmpty(_currentNote.RtfContent))
                {
                    ContentBox.Document.SetText(TextSetOptions.FormatRtf, _currentNote.RtfContent);
                }
                else
                {
                    ContentBox.Document.SetText(TextSetOptions.None, _currentNote.PlainContent);
                }

                SaveStatusText.Text = "Saved";
                EditorPanel.Visibility = Visibility.Visible;
                EmptyStatePanel.Visibility = Visibility.Collapsed;

                _isUpdatingUI = false;
            }
            else
            {
                EditorPanel.Visibility = Visibility.Collapsed;
                EmptyStatePanel.Visibility = Visibility.Visible;
                TitleBox.Text = string.Empty;
                ContentBox.Document.SetText(TextSetOptions.None, string.Empty);
            }
        }

        // Título alterado
        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_isUpdatingUI || _currentNote == null) return;
            SaveNoteData();
        }

        // Conteúdo Rico alterado
        private void RichEditor_TextChanged(object sender, RoutedEventArgs e)
        {
            if (_isUpdatingUI || _currentNote == null) return;
            SaveNoteData();
        }

        private void SaveNoteData()
        {
            SaveStatusText.Text = "Saving...";

            _currentNote.Title = string.IsNullOrWhiteSpace(TitleBox.Text) ? "Untitled" : TitleBox.Text;

            // Extrai o texto rico (com negritos e cores)
            ContentBox.Document.GetText(TextGetOptions.FormatRtf, out string rtfContent);
            _currentNote.RtfContent = rtfContent;

            // Extrai o texto limpo só para a lista da esquerda
            ContentBox.Document.GetText(TextGetOptions.NoHidden, out string plainContent);
            _currentNote.PlainContent = plainContent.TrimEnd('\r', '\n');

            _currentNote.LastModified = DateTime.Now;

            SaveStatusText.Text = $"Saved at {DateTime.Now.ToString("HH:mm")}";
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_currentNote != null)
            {
                _allNotes.Remove(_currentNote);
                DisplayNotes.Remove(_currentNote);
            }
        }

        private void SearchBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
                FilterNotes(sender.Text);
        }

        private void FilterNotes(string query)
        {
            var previouslySelected = _currentNote;
            DisplayNotes.Clear();

            if (string.IsNullOrWhiteSpace(query))
            {
                foreach (var note in _allNotes) DisplayNotes.Add(note);
            }
            else
            {
                var lowerQuery = query.ToLower();
                var filtered = _allNotes.Where(n =>
                    (n.Title != null && n.Title.ToLower().Contains(lowerQuery)) ||
                    (n.PlainContent != null && n.PlainContent.ToLower().Contains(lowerQuery)));

                foreach (var note in filtered) DisplayNotes.Add(note);
            }

            if (previouslySelected != null && DisplayNotes.Contains(previouslySelected))
                NotesList.SelectedItem = previouslySelected;
        }

        // --- MÉTODOS DE FORMATAÇÃO (TOOLBAR) ---
        // 1. Histórico
        private void UndoBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentBox.Document.Undo();
        }

        private void RedoBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentBox.Document.Redo();
        }

        // 2. Tamanho do Texto
        private void FontSizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontSizeBox.SelectedItem is string sizeStr && float.TryParse(sizeStr, out float size))
            {
                ContentBox.Document.Selection.CharacterFormat.Size = size;
                // Volta a focar o editor para poderes continuar a escrever logo a seguir a mudar o tamanho
                ContentBox.Focus(FocusState.Programmatic);
            }
        }

        // 3. Formatação Base
        private void BoldBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentBox.Document.Selection.CharacterFormat.Bold = FormatEffect.Toggle;
        }

        private void ItalicBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentBox.Document.Selection.CharacterFormat.Italic = FormatEffect.Toggle;
        }

        private void UnderlineBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentUnderline = ContentBox.Document.Selection.CharacterFormat.Underline;
            ContentBox.Document.Selection.CharacterFormat.Underline =
                currentUnderline == UnderlineType.Single ? UnderlineType.None : UnderlineType.Single;
        }

        private void StrikeBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentBox.Document.Selection.CharacterFormat.Strikethrough = FormatEffect.Toggle;
        }

        // 4. Alinhamentos
        private void AlignLeftBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentBox.Document.Selection.ParagraphFormat.Alignment = ParagraphAlignment.Left;
        }

        private void AlignCenterBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentBox.Document.Selection.ParagraphFormat.Alignment = ParagraphAlignment.Center;
        }

        private void AlignRightBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentBox.Document.Selection.ParagraphFormat.Alignment = ParagraphAlignment.Right;
        }

        // 5. Listas
        private void ListBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentList = ContentBox.Document.Selection.ParagraphFormat.ListType;
            ContentBox.Document.Selection.ParagraphFormat.ListType =
                currentList == MarkerType.Bullet ? MarkerType.None : MarkerType.Bullet;
        }

        // 6. Cores
        private void TextColorPicker_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {
            ContentBox.Document.Selection.CharacterFormat.ForegroundColor = args.NewColor;
        }

        private void HighlightColorPicker_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
        {
            ContentBox.Document.Selection.CharacterFormat.BackgroundColor = args.NewColor;
        }

        // 7. Limpar Tudo (Voltar ao normal)
        private void ClearFormatBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentBox.Document.Selection.CharacterFormat.Bold = FormatEffect.Off;
            ContentBox.Document.Selection.CharacterFormat.Italic = FormatEffect.Off;
            ContentBox.Document.Selection.CharacterFormat.Underline = UnderlineType.None;
            ContentBox.Document.Selection.CharacterFormat.Strikethrough = FormatEffect.Off;
            ContentBox.Document.Selection.CharacterFormat.Size = 16; // O teu tamanho default

            // Repor cores para as cores automáticas do sistema
            ContentBox.Document.Selection.CharacterFormat.ForegroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            ContentBox.Document.Selection.CharacterFormat.BackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
        }
    }
}