using LifeLog.Pages.Auth;
using Microsoft.UI.Composition.SystemBackdrops;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
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


}
