using LifeLog.Views.Tools;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace LifeLog.Pages;

/// <summary>
/// Main page 
/// </summary>
public sealed partial class MainPage : Page
{
    #region MAIN

    //PRIVATE FIELDS
    private static MainPage? Instance = null;
    private Dictionary<string, UserControl> _controlCache = new();
    private bool _isNavigating = false;
    private DispatcherTimer mainTimer;

    /// <summary>
    /// Constructor
    /// </summary>
    public MainPage()
    {
        InitializeComponent();

        Instance = this;
        MainWindow.SetTitleBarEx(AppTitleBar);

        mainTimer = new DispatcherTimer();
        mainTimer.Interval = TimeSpan.FromSeconds(1);
        mainTimer.Tick += MainTimer_Tick;
        mainTimer.Start();

        string? fileVersion = Assembly.GetExecutingAssembly()
           .GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;

#if DEBUG
        VersionAppLabel.Text = $"v{fileVersion} (DEBUG!)";
        VersionAppLabel.Foreground = new SolidColorBrush(Colors.Red);
#else
        VersionAppLabel.Text = $"v{fileVersion}";
        VersionAppLabel.Foreground = (Brush)Application.Current.Resources["TextFillColorSecondaryBrush"];
#endif

    }

    /// <summary>
    /// Main timer tick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainTimer_Tick(object? sender, object e)
    {
        DateTimeLabel.Text = $"{DateTime.Now:dd/MM/yyyy HH:mm:ss}";
    }

    #endregion




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
                #region TOOLS

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

                case "PdfMerge":
                    ContentFrame.Content = GetOrCreateControl("PdfMerge", () => new PdfMergeView());
                    break;

                case "QrCodeGen":
                    ContentFrame.Content = GetOrCreateControl("QrCodeGen", () => new QrCodeGenView());
                    break;

                #endregion

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

    private void TopMostToggle_Toggled(object sender, RoutedEventArgs e)
    {
        MainWindow.SetTopMost(TopMostToggle.IsOn);
    }

    #region FUNCTIONS

    #region PRIVATE

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

    #endregion

    #region PUBLIC

    /// <summary>
    /// Sets the status message
    /// </summary>
    /// <param name="message"></param>
    public static void SetStatusMsg(string message)
    {
        Instance!.TextStatus.Text = message;
    }

    #endregion

    #endregion
}
