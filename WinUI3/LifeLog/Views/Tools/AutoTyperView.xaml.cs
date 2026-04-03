using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;

namespace LifeLog.Views.Tools
{
    public sealed partial class AutoTyperView : UserControl
    {
        private CancellationTokenSource _cancellationTokenSource;
        private InputSimulator _simulator;

        public AutoTyperView()
        {
            this.InitializeComponent();
            _simulator = new InputSimulator();
        }

        private void DelaySlider_ValueChanged(object sender, Microsoft.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            if (DelayLabel != null)
                DelayLabel.Text = $"{e.NewValue:0}s";
        }

        private void SpeedSlider_ValueChanged(object sender, Microsoft.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            if (SpeedLabel != null)
            {
                double speed = e.NewValue;
                string label = speed < 30 ? "Fast" : (speed > 100 ? "Slow" : "Normal");
                SpeedLabel.Text = $"{label} ({speed:0}ms)";
            }
        }

        private async void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            string textToType = InputBox.Text;
            if (string.IsNullOrEmpty(textToType)) return;

            // Bloqueia a UI para impedir cliques duplos
            StartBtn.IsEnabled = false;
            StopBtn.IsEnabled = true;

            // UI Feedback
            StatusBadge.Visibility = Visibility.Visible;
            StatusBadge.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Orange);
            StatusIcon.Glyph = "\uE916"; // Timer icon

            int delaySeconds = (int)DelaySlider.Value;
            int speedMs = (int)SpeedSlider.Value;

            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            try
            {
                // 1. CONTAGEM DECRESCENTE (Dá tempo para mudar de janela)
                for (int i = delaySeconds; i > 0; i--)
                {
                    StatusText.Text = $"Click target window! ({i}s left)";
                    await Task.Delay(1000, token);
                }

                // Muda o visual para "A Escrever"
                StatusBadge.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.DodgerBlue);
                StatusIcon.Glyph = "\uE765"; // Keyboard icon
                StatusText.Text = "Typing...";

                // 2. FASE DE ESCRITA SIMULADA
                foreach (char c in textToType)
                {
                    token.ThrowIfCancellationRequested();

                    // Simula o teclado físico no Windows
                    _simulator.Keyboard.TextEntry(c.ToString());

                    // Pausas para parecer um humano a escrever
                    int currentDelay = speedMs;
                    if (c == '.' || c == '?' || c == '!') currentDelay += 200;
                    if (c == ',') currentDelay += 100;

                    // Variação aleatória (± 10ms)
                    currentDelay += Random.Shared.Next(-10, 11);
                    if (currentDelay < 1) currentDelay = 1;

                    await Task.Delay(currentDelay, token);
                }

                // Finalizou com sucesso
                StatusBadge.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.MediumSeaGreen);
                StatusIcon.Glyph = "\uE73E"; // Checkmark icon
                StatusText.Text = "Finished!";
            }
            catch (TaskCanceledException)
            {
                // Abortado
                StatusBadge.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Crimson);
                StatusIcon.Glyph = "\uE71A"; // Stop icon
                StatusText.Text = "ABORTED";
            }
            finally
            {
                StartBtn.IsEnabled = true;
                StopBtn.IsEnabled = false;

                // Oculta a badge após 2 segundos
                await Task.Delay(2000);
                if (StartBtn.IsEnabled)
                    StatusBadge.Visibility = Visibility.Collapsed;
            }
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_cancellationTokenSource != null)
            {
                // Cancela a tarefa
                _cancellationTokenSource.Cancel();
            }
        }
    }
}