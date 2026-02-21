using LifeLog.Views.Tools;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LifeLog.Pages;

/// <summary>
/// Main page
/// </summary>
public sealed partial class MainPage : Page
{
    // Cache de UserControls para evitar recriar instâncias
    private readonly Dictionary<string, UserControl> _controlCache = new();
    private bool _isNavigating = false;

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

    private async void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        NavigationViewItem? selectedItem = (NavigationViewItem)args.SelectedItem;
        if (selectedItem is null)
            return;

        string? page = selectedItem.Tag?.ToString();
        if (string.IsNullOrWhiteSpace(page))
            return;

        if (_isNavigating) return;
        _isNavigating = true;

        LoadingOverlay.Visibility = Visibility.Visible;
        HomePanel.Visibility = Visibility.Collapsed;
        ContentFrame.Visibility = Visibility.Collapsed;

        await Task.Delay(250);

        try
        {
            if (args.IsSettingsSelected)
            {
                HomePanel.Visibility = Visibility.Visible;
                ContentFrame.Content = null;
                return;
            }

            switch (page)
            {
                case "TxtConvert":
                    ContentFrame.Content = GetOrCreateControl("TxtConvert", () => new TextConvertView());
                    break;

                case "Grades":
                    ContentFrame.Content = GetOrCreateControl("Grades", () => new GradesView());
                    break;

                case "RuleOf3":
                    ContentFrame.Content = GetOrCreateControl("RuleOf3", () => new RuleOfThreeView());
                    break;

                case "PasswordGen":
                    ContentFrame.Content = GetOrCreateControl("PasswordGen", () => new PassGeneratorView());
                    break;

                default:
                    HomePanel.Visibility = Visibility.Visible;
                    ContentFrame.Content = null;
                    break;
            }

            if (ContentFrame.Content != null)
                ContentFrame.Visibility = Visibility.Visible;
        }
        finally
        {
            LoadingOverlay.Visibility = Visibility.Collapsed;
            _isNavigating = false;
        }
    }

    /// <summary>
    /// Gets a cached control or creates a new one if it doesn't exist
    /// </summary>
    private UserControl GetOrCreateControl(string key, Func<UserControl> factory)
    {
        if (!_controlCache.TryGetValue(key, out UserControl? control))
        {
            control = factory();
            _controlCache[key] = control;
        }

        return control;
    }

    private void TopMostToggle_Toggled(object sender, RoutedEventArgs e)
    {

    }
}
