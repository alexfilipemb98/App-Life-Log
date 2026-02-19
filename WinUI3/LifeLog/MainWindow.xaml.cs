using LifeLogApp.Pages.Auth;
using Microsoft.UI.Composition.SystemBackdrops;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;


namespace LifeLogApp;

/// <summary>
/// Main window
/// </summary>
public sealed partial class MainWindow : Window
{
    public static MainWindow Instance { get; internal set; }

    /// <summary>
    /// Constructor
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
