using LifeLog.Pages.Tools;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace LifeLog.Pages;

/// <summary>
/// Main page
/// </summary>
public sealed partial class MainPage : Page
{
    /// <summary>
    /// Constructor
    /// </summary>
    public MainPage()
    {
        InitializeComponent();

        MainWindow.Instance.SetTitleBar(AppTitleBar);
    }

    private void ThemeToggleButton_Click(object sender, RoutedEventArgs e)
    {
        if (this.ActualTheme == ElementTheme.Dark)
        {
            this.RequestedTheme = ElementTheme.Light;
            ThemeIcon.Glyph = "\xE706";
        }
        else
        {
            this.RequestedTheme = ElementTheme.Dark;
            ThemeIcon.Glyph = "\xE708";
        }
    }

    private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        if (args.IsSettingsSelected)
        {
            PlaceholderText.Visibility = Visibility.Visible;
            return;
        }

        NavigationViewItem? selectedItem = (NavigationViewItem)args.SelectedItem;
        if (selectedItem is null)
            return;

        string? page = selectedItem.Tag?.ToString();

        if (string.IsNullOrWhiteSpace(page))
            return;

        PlaceholderText.Visibility = Visibility.Collapsed;

        switch (page)
        {
            // Tools

            case "TxtConvert":
                ContentFrame.Navigate(typeof(TextConvertPage));
                break;
            case "Grades":
                ContentFrame.Content = new GradesControll();
                break;

            default:
                PlaceholderText.Visibility = Visibility.Visible;
                PlaceholderText.Text = $"'{selectedItem.Content}' does not exist.";
                ContentFrame.Content = null;
                break;
        }
    }

    private void TopMostToggle_Toggled(object sender, RoutedEventArgs e)
    {

    }
}
