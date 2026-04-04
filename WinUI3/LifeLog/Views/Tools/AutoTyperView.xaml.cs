using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput.Events;

namespace LifeLog.Views.Tools;

/// <summary>
/// Represents a user interface control that simulates typing input with configurable delay and speed settings.
/// </summary>
/// <remarks>AutoTyperView enables users to enter text that will be automatically typed out, simulating human
/// typing behavior. The control provides options to adjust the typing speed and delay before typing begins, and offers
/// visual feedback on the current status of the typing process. Users can start or cancel the typing operation, and the
/// control updates its UI to reflect the current state. This control is intended for scenarios where automated,
/// human-like text entry is required, such as demonstrations or testing environments.</remarks>
public sealed partial class AutoTyperView : UserControl
{
    #region MAIN

    //Variables
    private CancellationTokenSource? _cancellationTokenSource;

    /// <summary>
    /// Constructor
    /// </summary>
    public AutoTyperView() => InitializeComponent();

    #endregion

    #region EVENTS

    #region VALUE CHANGED

    /// <summary>
    /// Delay slider value changed - Updates the label with the current delay in seconds
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DelaySlider_ValueChanged(object sender, Microsoft.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
    {
        if (DelayLabel != null)
            DelayLabel.Text = $"{e.NewValue:0}s";
    }

    /// <summary>
    /// Speed slider value changed event handler. 
    /// Updates the label to show the current speed setting in ms and a descriptive label (Fast, Normal, Slow).
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SpeedSlider_ValueChanged(object sender, Microsoft.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
    {
        if (SpeedLabel != null)
        {
            double speed = e.NewValue;
            string label = speed < 30 ? "Fast" : (speed > 100 ? "Slow" : "Normal");
            SpeedLabel.Text = $"{label} ({speed:0}ms)";
        }
    }

    #endregion

    #region CLICK

    /// <summary>
    /// Start button click event handler.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void StartBtn_Click(object sender, RoutedEventArgs e)
    {
        string textToType = InputBox.Text;
        if (string.IsNullOrEmpty(textToType)) return;

        StartBtn.IsEnabled = false;
        StopBtn.IsEnabled = true;

        StatusBadge.Visibility = Visibility.Visible;
        StatusBadge.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Orange);
        StatusIcon.Glyph = "\uE916"; // Ícone de relógio

        int delaySeconds = (int)DelaySlider.Value;
        int speedMs = (int)SpeedSlider.Value;

        _cancellationTokenSource = new CancellationTokenSource();
        var token = _cancellationTokenSource.Token;

        try
        {
            // 1. CONTAGEM DECRESCENTE (Dá tempo para clicares na janela de destino!)
            for (int i = delaySeconds; i > 0; i--)
            {
                StatusText.Text = $"Click target window! ({i}s left)";
                await Task.Delay(1000, token);
            }

            StatusBadge.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.DodgerBlue);
            StatusIcon.Glyph = "\uE765"; // Ícone de teclado
            StatusText.Text = "Typing...";

            // 2. FASE DE ESCRITA SIMULADA (Nova Sintaxe)
            foreach (char c in textToType)
            {
                token.ThrowIfCancellationRequested();

                // Ignorar o Carriage Return do Windows para não dar duplos ENTERS acidentais
                if (c == '\r') continue;

                if (c == '\n')
                {
                    // Se for uma mudança de linha, carrega na tecla "ENTER" fisicamente
                    await WindowsInput.Simulate.Events().Click(KeyCode.Return).Invoke();
                }
                else
                {
                    // Se for uma letra normal, escreve o caracter onde o rato estiver
                    await WindowsInput.Simulate.Events().Click(c.ToString()).Invoke();
                }

                int currentDelay = speedMs;

                // Pausas "humanas"
                if (c == '.' || c == '?' || c == '!') currentDelay += 200;
                if (c == ',') currentDelay += 100;

                currentDelay += Random.Shared.Next(-10, 11); // Imperfeição humana (± 10ms)
                if (currentDelay < 1) currentDelay = 1;

                await Task.Delay(currentDelay, token);
            }

            StatusBadge.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.MediumSeaGreen);
            StatusIcon.Glyph = "\uE73E";
            StatusText.Text = "Finished!";
        }
        catch (TaskCanceledException)
        {
            StatusBadge.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Crimson);
            StatusIcon.Glyph = "\uE71A";
            StatusText.Text = "ABORTED";
        }
        finally
        {
            StartBtn.IsEnabled = true;
            StopBtn.IsEnabled = false;

            await Task.Delay(2000);
            if (StartBtn.IsEnabled)
                StatusBadge.Visibility = Visibility.Collapsed;
        }
    }

    /// <summary>
    /// Stops the auto-typing process by cancelling the ongoing task. Updates the UI to reflect the aborted state.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void StopBtn_Click(object sender, RoutedEventArgs e)
    {
        if (_cancellationTokenSource != null)
        {
            _cancellationTokenSource.Cancel();
        }
    }


    #endregion

    #endregion

}