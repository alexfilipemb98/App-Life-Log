using Microsoft.AspNetCore.Components.Forms;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Media;

namespace LifeLog.Views.Main
{
    public sealed partial class NotesView : UserControl
    {
        public NotesView()
        {
            this.InitializeComponent();

            // Monitorizar alterações para atualizar o estado dos botões (Bold, Italic, etc)
            Editor.SelectionChanged += Editor_SelectionChanged;
        }

        // --- Formatação Básica ---
        private void Bold_Click(object sender, RoutedEventArgs e)
        {
            Editor.Document.Selection.CharacterFormat.Bold = FormatEffect.Toggle;
        }

        private void Italic_Click(object sender, RoutedEventArgs e)
        {
            Editor.Document.Selection.CharacterFormat.Italic = FormatEffect.Toggle;
        }

        private void Strikethrough_Click(object sender, RoutedEventArgs e)
        {
            Editor.Document.Selection.CharacterFormat.Strikethrough = FormatEffect.Toggle;
        }

        // --- Listas ---
        private void FormatList_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuFlyoutItem item && item.Tag is string listType)
            {
                var paragraph = Editor.Document.Selection.ParagraphFormat;
                if (listType == "Bullet")
                {
                    paragraph.ListType = paragraph.ListType == MarkerType.Bullet ? MarkerType.None : MarkerType.Bullet;
                }
                else if (listType == "Number")
                {
                    paragraph.ListType = paragraph.ListType == MarkerType.Arabic ? MarkerType.None : MarkerType.Arabic;
                }
            }
        }

        // --- Estilos de Texto (Headings) ---
        private void FormatHeading_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuFlyoutItem item && int.TryParse(item.Tag.ToString(), out int level))
            {
                var format = Editor.Document.Selection.CharacterFormat;
                switch (level)
                {
                    case 1: format.Size = 24; format.Bold = FormatEffect.On; break; // Título
                    case 2: format.Size = 20; format.Bold = FormatEffect.On; break; // Subtítulo
                    case 3: format.Size = 16; format.Bold = FormatEffect.On; break; // Cabeçalho
                    case 0: format.Size = 14; format.Bold = FormatEffect.Off; break; // Corpo
                }
            }
        }

        // --- Limpar Formatação ---
        private void ClearFormatting_Click(object sender, RoutedEventArgs e)
        {
            var selection = Editor.Document.Selection;
            selection.CharacterFormat.Bold = FormatEffect.Off;
            selection.CharacterFormat.Italic = FormatEffect.Off;
            selection.CharacterFormat.Strikethrough = FormatEffect.Off;
            selection.CharacterFormat.Underline = UnderlineType.None;
            selection.CharacterFormat.Size = 14; // Tamanho padrão
            selection.ParagraphFormat.ListType = MarkerType.None;
        }

        // --- Gestão da Barra de Pesquisa ---
        private void ToggleSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchBar.Visibility = SearchBar.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            if (SearchBar.Visibility == Visibility.Visible)
            {
                SearchBox.Focus(FocusState.Programmatic);
            }
        }

        private void CloseSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchBar.Visibility = Visibility.Collapsed;
            Editor.Focus(FocusState.Programmatic);
        }

        // --- Atualizar UI consoante o cursor ---
        private void Editor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var format = Editor.Document.Selection.CharacterFormat;
            BtnBold.IsChecked = format.Bold == FormatEffect.On;
            BtnItalic.IsChecked = format.Italic == FormatEffect.On;
            BtnStrikethrough.IsChecked = format.Strikethrough == FormatEffect.On;
        }

private void AutoTextColor_Click(object sender, RoutedEventArgs e)
    {
        // Restaura para a cor padrão do tema atual
        Editor.Document.Selection.CharacterFormat.ForegroundColor = Microsoft.UI.Colors.Black; // Ou White dependendo do tema base
    }

    private void TextColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is GridView gridView && gridView.SelectedItem is GridViewItem item)
        {
            if (item.Background is SolidColorBrush brush)
            {
                Editor.Document.Selection.CharacterFormat.ForegroundColor = brush.Color;
            }
            gridView.SelectedItem = null; // Reseta a seleção para poder clicar na mesma cor depois
        }
    }

    // --- Cores de Realce (Highlight) ---
    private void NoHighlightColor_Click(object sender, RoutedEventArgs e)
    {
        // O valor transparente/padrão remove o realce no RTF
        Editor.Document.Selection.CharacterFormat.BackgroundColor = Microsoft.UI.Colors.Transparent;
    }

    private void HighlightColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is GridView gridView && gridView.SelectedItem is GridViewItem item)
        {
            if (item.Background is SolidColorBrush brush)
            {
                Editor.Document.Selection.CharacterFormat.BackgroundColor = brush.Color;
            }
            gridView.SelectedItem = null;
        }
    }

    // --- Citação (Blockquote) ---
    private void Quote_Click(object sender, RoutedEventArgs e)
    {
        // A RichEditBox nativa não tem um "Blockquote" HTML-like perfeito, 
        // mas simula-se aumentando o avanço (indentation) e metendo um estilo.
        var paragraph = Editor.Document.Selection.ParagraphFormat;

        // Se já estiver avançado, retira (toggle), se não, aplica o avanço de citação
        if (paragraph.FirstLineIndent > 0 || paragraph.LeftIndent > 0)
        {
            paragraph.SetIndents(0, 0, 0);
            Editor.Document.Selection.CharacterFormat.Italic = FormatEffect.Off;
        }
        else
        {
            paragraph.SetIndents(36, 0, 0); // Avança o texto
            Editor.Document.Selection.CharacterFormat.Italic = FormatEffect.On; // Costuma ficar bem em itálico
        }
    }
}
}