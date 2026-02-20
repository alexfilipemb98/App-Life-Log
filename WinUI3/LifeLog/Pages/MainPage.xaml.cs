using LifeLog.Views.Tools;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;

namespace LifeLog.Pages;

/// <summary>
/// Main page
/// </summary>
public sealed partial class MainPage : Page
{
    // Cache de UserControls para evitar recriar instâncias
    private readonly Dictionary<string, UserControl> _controlCache = new();

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
            ContentFrame.Content = null;
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
                ContentFrame.Content = GetOrCreateControl("TxtConvert", () => new TextConvertView());
                break;
            case "Grades":
                ContentFrame.Content = GetOrCreateControl("Grades", () => new GradesView());
                break;

            default:
                PlaceholderText.Visibility = Visibility.Visible;
                PlaceholderText.Text = $"'{selectedItem.Content}' does not exist.";
                ContentFrame.Content = null;
                break;
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
