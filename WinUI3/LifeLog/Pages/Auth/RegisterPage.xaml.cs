using LifeLog.Helpers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using System;
using System.Threading.Tasks;

namespace LifeLog.Pages.Auth
{
    public sealed partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            this.InitializeComponent();
        }

        // ---- Email Validation ----
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // ---- Caps Lock Detection ----
        private void CheckCapsLock()
        {
            var state = Microsoft.UI.Input.InputKeyboardSource.GetKeyStateForCurrentThread(Windows.System.VirtualKey.CapitalLock);
            bool isCapsLockOn = state.HasFlag(Windows.UI.Core.CoreVirtualKeyStates.Locked);
            CapsLockWarning.Visibility = isCapsLockOn ? Visibility.Visible : Visibility.Collapsed;
        }

        private void PassBox_GotFocus(object sender, RoutedEventArgs e) => CheckCapsLock();
        private void PassBox_LostFocus(object sender, RoutedEventArgs e) => CapsLockWarning.Visibility = Visibility.Collapsed;

        // ---- Keyboard Events (Enter Key) ----
        private void Input_KeyDown(object sender, Microsoft.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                SignUp_Click(this, new RoutedEventArgs());
            }
        }

        private void PassBox_KeyDown(object sender, Microsoft.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            CheckCapsLock();
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                SignUp_Click(this, new RoutedEventArgs());
            }
        }

    private void PassRevealToggle_Checked(object sender, RoutedEventArgs e)
    {
        PassBox.PasswordRevealMode = PasswordRevealMode.Visible;
    }

    private void PassRevealToggle_Unchecked(object sender, RoutedEventArgs e)
    {
        PassBox.PasswordRevealMode = PasswordRevealMode.Hidden;
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
                To = 10,
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

        // ---- Registration Action ----
        private async void SignUp_Click(object sender, RoutedEventArgs e)
        {
            // 1. Validar Username
            if (string.IsNullOrWhiteSpace(UsernameBox.Text) || UsernameBox.Text.Length < 3)
            {
                TriggerErrorShake("Username must be at least 3 characters.");
                return;
            }

            // 2. Validar Email
            if (!IsValidEmail(EmailBox.Text))
            {
                TriggerErrorShake("Please enter a valid email address.");
                return;
            }

            // 3. Validar Password
            if (PassBox.Password.Length < 6)
            {
                TriggerErrorShake("Password must be at least 6 characters.");
                return;
            }

            // Entra em estado de carregamento
            SetLoadingState(true);

            Core.Models.RegisterModel? register = new LifeLog.Core.Models.RegisterModel
            {
                Username = UsernameBox.Text,
                Email = EmailBox.Text,
                Password = PassBox.Password
            };

            (bool registered, string message) result = await AppHelper.DataEngine!.Users.Register(register);


            // SIMULAÇÃO de requisição à API para registar o utilizador
            await Task.Delay(2000);


            if (!result.registered)
            {
                TriggerErrorShake(result.message);
                SetLoadingState(false);
                return;
            }

            SetLoadingState(false);

            // Se o registo for bem sucedido, normalmente navegas para a página principal ou de login
            Frame.Navigate(typeof(LoginPage));
        }

        private void SetLoadingState(bool isLoading)
        {
            SignUpButton.IsEnabled = !isLoading;
            SignUpText.Visibility = isLoading ? Visibility.Collapsed : Visibility.Visible;
            SignUpSpinner.Visibility = isLoading ? Visibility.Visible : Visibility.Collapsed;
            SignUpSpinner.IsActive = isLoading;
        }

        // ---- Mouse Hover Animations ----
        private void RegisterCard_PointerEntered(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            CardHoverEnterAnim.Begin();
        }

        private void RegisterCard_PointerExited(object sender, Microsoft.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            CardHoverExitAnim.Begin();
        }

        // ---- Navigation ----
        private void GoToLogin_Click(object sender, RoutedEventArgs e)
        {
            // Navega de volta para a página de Login
            // Exemplo: Frame.Navigate(typeof(LoginPage));
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }
    }
}