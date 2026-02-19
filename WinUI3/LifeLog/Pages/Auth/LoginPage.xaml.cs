using LifeLog.Core.Utils;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using System;
using System.Threading.Tasks;

namespace LifeLogApp.Pages.Auth;

public sealed partial class LoginPage : Page
{
    public LoginPage()
    {
        this.InitializeComponent();
#if DEBUG

        EmailBox.Text = "admin@lifelog.com";
        PassBox.Password = "123456";
#endif
    }

    // ---- Caps Lock Detection ----
    private void CheckCapsLock()
    {
        // Verifica o estado do teclado na thread atual
        var state = Microsoft.UI.Input.InputKeyboardSource.GetKeyStateForCurrentThread(Windows.System.VirtualKey.CapitalLock);
        bool isCapsLockOn = state.HasFlag(Windows.UI.Core.CoreVirtualKeyStates.Locked);

        // Mostra ou esconde o aviso
        CapsLockWarning.Visibility = isCapsLockOn ? Visibility.Visible : Visibility.Collapsed;
    }

    private void PassBox_GotFocus(object sender, RoutedEventArgs e)
    {
        CheckCapsLock(); // Checa quando clica na caixa de senha
    }

    private void PassBox_KeyDown(object sender, Microsoft.UI.Xaml.Input.KeyRoutedEventArgs e)
    {
        CheckCapsLock(); // Checa enquanto digita (caso ele ative/desative no meio)

        // Verifica se a tecla pressionada foi o Enter
        if (e.Key == Windows.System.VirtualKey.Enter)
        {
            // Se sim, chama o método do botão de Sign In diretamente
            SignIn_Click(this, new RoutedEventArgs());
        }
    }

    // ---- Validation Logic ----
    private void ValidateInputs(object sender, object e)
    {
        if (ErrorMessage.Visibility == Visibility.Visible)
        {
            ErrorMessage.Visibility = Visibility.Collapsed;
        }
    }

    private void TriggerErrorShake(string message)
    {
        ErrorMessage.Text = message;
        ErrorMessage.Visibility = Visibility.Visible;

        DoubleAnimation shakeAnimation = new DoubleAnimation
        {
            From = 0,
            To = 5,
            Duration = TimeSpan.FromMilliseconds(50),
            AutoReverse = true,
            RepeatBehavior = new RepeatBehavior(3)
        };
        Storyboard storyboard = new Storyboard();
        storyboard.Children.Add(shakeAnimation);
        Storyboard.SetTarget(shakeAnimation, CardShakeTransform);
        Storyboard.SetTargetProperty(shakeAnimation, "X");
        storyboard.Begin();
    }

    private async void SignIn_Click(object sender, RoutedEventArgs e)
    {
        if (!EmailBox.Text.IsValidEmail())
        {
            TriggerErrorShake("Please enter a valid email address.");
            return;
        }

        if (PassBox.Password.Length < 6)
        {
            TriggerErrorShake("Password must be at least 6 characters.");
            return;
        }

        SetLoadingState(true);

        await Task.Delay(2000);

        this.Frame.Navigate(typeof(MainPage));
    }

    private void SetLoadingState(bool isLoading)
    {
        SignInButton.IsEnabled = !isLoading;
        SignInText.Visibility = isLoading ? Visibility.Collapsed : Visibility.Visible;
        SignInSpinner.Visibility = isLoading ? Visibility.Visible : Visibility.Collapsed;
        SignInSpinner.IsActive = isLoading;
    }

    // ---- Mouse Hover Animations ----
    private void LoginCard_PointerEntered(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
    {
        CardHoverEnterAnim.Begin();
    }

    private void LoginCard_PointerExited(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
    {
        CardHoverExitAnim.Begin();
    }

    private void GoToRegister_Click(object sender, RoutedEventArgs e)
    {
        // Navegação para a página de registro
        this.Frame.Navigate(typeof(RegisterPage));
    }

    // Adiciona este método junto dos outros do PassBox
    private void PassBox_LostFocus(object sender, RoutedEventArgs e)
    {
        // Quando sai da caixa de password, esconde o aviso do Caps Lock
        CapsLockWarning.Visibility = Visibility.Collapsed;
    }

    private void Input_KeyDown(object sender, Microsoft.UI.Xaml.Input.KeyRoutedEventArgs e)
    {
        // Verifica se a tecla pressionada foi o Enter
        if (e.Key == Windows.System.VirtualKey.Enter)
        {
            // Se sim, chama o método do botão de Sign In diretamente
            SignIn_Click(this, new RoutedEventArgs());
        }
    }
}