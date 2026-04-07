using LifeLog.Core.Items;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace LifeLog.Views.Games;

public sealed partial class CoinFlipView : UserControl
{
    #region MAIN

    //Private fields
    private ObservableCollection<FlipResultItem> _flips = [];

    /// <summary>
    /// Constructor
    /// </summary>
    public CoinFlipView()
    {
        this.InitializeComponent();
        HistoryList.ItemsSource = _flips;
        UpdateCoinUI(true);
    }

    #endregion

    #region EVENTS

    /// <summary>
    /// Make flip animation super smooth with "Squash & Stretch" effect to simulate 3D rotation, and decide the final result at the beginning of the animation for a more natural feel. 
    /// The coin will flip a random number of times (between 5 and 7) before settling on the final result. 
    /// The speed of the flips will start fast and slow down towards the end for added realism.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void FlipBtn_Click(object sender, RoutedEventArgs e)
    {
        FlipBtn.IsEnabled = false;

        // Decide o resultado final logo no início
        bool finalResultHeads = Random.Shared.Next(0, 2) == 0;

        // Um número aleatório de "flips" completos
        int totalFlips = Random.Shared.Next(5, 8);

        // Animação super suave de "Squash & Stretch" para simular o 3D
        for (int i = 0; i < totalFlips; i++)
        {
            // Descobrir que face mostrar a meio deste flip em particular
            bool showHeads = (i == totalFlips - 1) ? finalResultHeads : (i % 2 == 0);

            // Easing: A moeda roda rápido no início, e vai abrandando no fim!
            int stepDelay = 8 + (i * 3);
            double stepSize = 0.15; // Velocidade da distorção

            // 1. Encolher a moeda (Parece que está de lado/quina)
            for (double s = 1.0; s >= 0; s -= stepSize)
            {
                CoinScale.ScaleY = Math.Max(0, s); // Proteção para não passar de 0
                await Task.Delay(stepDelay);
            }

            // 2. Com a moeda invisível (Scale = 0), trocamos o ícone e a cor!
            CoinScale.ScaleY = 0;
            UpdateCoinUI(showHeads);

            // 3. Voltar a esticar a moeda (Parece que bateu de chapa)
            for (double s = 0.0; s <= 1.0; s += stepSize)
            {
                CoinScale.ScaleY = Math.Min(1, s); // Proteção para não passar de 1
                await Task.Delay(stepDelay);
            }

            CoinScale.ScaleY = 1.0; // Garante que fica perfeita no final do loop
        }

        // Adiciona ao histórico animado
        _flips.Insert(0, new FlipResultItem
        {
            Time = DateTime.Now.ToString("HH:mm:ss"),
            Result = finalResultHeads ? "HEADS" : "TAILS",
            Color = finalResultHeads ? new SolidColorBrush(Colors.Goldenrod) : new SolidColorBrush(Colors.SlateGray)
        });

        FlipBtn.IsEnabled = true;
    }

    /// <summary>
    /// Clear the flip history, removing all previous results from the list. 
    /// This will reset the history display to an empty state, allowing users to start fresh with new flips. 
    /// The method simply clears the ObservableCollection that is bound to the UI, which will automatically update the display to reflect the cleared history.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ClearHistory_Click(object sender, RoutedEventArgs e)
    {
        _flips.Clear();
    }

    #endregion

    #region FUNCTIONS

    /// <summary>
    /// Updates the visual elements of the coin to display either heads or tails based on the specified state.
    /// </summary>
    /// <remarks>This method updates the coin's icon, label, and background color to reflect the current
    /// state. It should be called whenever the coin's state changes to ensure the UI remains consistent.</remarks>
    /// <param name="isHeads">A value indicating whether the coin should display heads. If <see langword="true"/>, the UI displays heads;
    /// otherwise, it displays tails.</param>
    private void UpdateCoinUI(bool isHeads)
    {
        if (isHeads)
        {
            CoinIcon.Glyph = "\uE77B";
            CoinText.Text = "HEADS";
            CoinBg.Fill = new SolidColorBrush(Colors.Goldenrod);
        }
        else
        {
            CoinIcon.Glyph = "\uE83D";
            CoinText.Text = "TAILS";
            CoinBg.Fill = new SolidColorBrush(Colors.SlateGray);
        }
    }

    #endregion
}