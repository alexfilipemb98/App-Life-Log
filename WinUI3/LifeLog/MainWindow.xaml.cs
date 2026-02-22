using LifeLog.Pages.Auth;
using Microsoft.UI;
using Microsoft.UI.Composition.SystemBackdrops;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using System;
using WinRT.Interop;

namespace LifeLog;

/// <summary>
/// Main window of the application
/// </summary>
public sealed partial class MainWindow : Window
{
    public static MainWindow? Instance { get; internal set; }

    /// <summary>
    /// Constructor for the main window, initializes the UI and sets up the Mica backdrop
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();

        Instance = this;

        SystemBackdrop = new MicaBackdrop
        {
            Kind = MicaKind.BaseAlt
        };

        ExtendsContentIntoTitleBar = true;

        this.AppWindow.TitleBar.PreferredHeightOption = TitleBarHeightOption.Tall;

        RootFrame.Navigate(typeof(LoginPage));
    }

    /// <summary>
    /// Sets the main window's title bar to a custom UI element, allowing for a more integrated and customized appearance.
    /// </summary>
    /// <param name="topMost"></param>
    public void SetTopMost(bool topMost)
    {
        IntPtr hWnd = WindowNative.GetWindowHandle(this);
        WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
        AppWindow appWindow = AppWindow.GetFromWindowId(windowId);

        if (appWindow.Presenter is OverlappedPresenter presenter)
            presenter.IsAlwaysOnTop = topMost;
    }


}
