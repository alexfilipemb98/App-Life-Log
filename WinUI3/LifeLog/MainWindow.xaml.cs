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
    private static MainWindow Instance = null;

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
    
    #region FUNCTIONS

    /// <summary>
    /// Sets the title bar for the specified UI element, enabling customization of the window's title bar appearance.
    /// </summary>
    /// <remarks>This method delegates to the application's instance to apply the title bar settings. Ensure
    /// that the element is properly initialized before calling this method.</remarks>
    /// <param name="element">The UIElement to use as the custom title bar. Must be a valid, initialized UI component that supports title bar
    /// customization.</param>
    public static void SetTitleBarEx(UIElement element)
    {
        Instance.SetTitleBar(element);
    }

    /// <summary>
    /// Sets the main window's title bar to a custom UI element, allowing for a more integrated and customized appearance.
    /// </summary>
    /// <param name="topMost"></param>
    public static void SetTopMost(bool topMost)
    {
        IntPtr hWnd = WindowNative.GetWindowHandle(Instance);
        WindowId windowId = Win32Interop.GetWindowIdFromWindow(hWnd);
        AppWindow appWindow = AppWindow.GetFromWindowId(windowId);

        if (appWindow.Presenter is OverlappedPresenter presenter)
            presenter.IsAlwaysOnTop = topMost;
    }

    #endregion

}
