using LifeLogApp.Pages.Tools;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
namespace LifeLogApp.Pages;

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

        switch (page)
        {
            case "TxtConvert":
                PlaceholderText.Visibility = Visibility.Collapsed;
                ContentFrame.Navigate(typeof(TextConvertPage));
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
