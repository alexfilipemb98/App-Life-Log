using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace LifeLog.Views.Tools
{
    public class FlipResult
    {
        public string Time { get; set; }
        public string Result { get; set; }
        public SolidColorBrush Color { get; set; }
    }

    public sealed partial class CoinFlipView : UserControl
    {
        public ObservableCollection<FlipResult> Flips { get; set; } = new ObservableCollection<FlipResult>();

        public CoinFlipView()
        {
            this.InitializeComponent();
            HistoryList.ItemsSource = Flips;
            UpdateCoinUI(true);
        }

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
            Flips.Insert(0, new FlipResult
            {
                Time = DateTime.Now.ToString("HH:mm:ss"),
                Result = finalResultHeads ? "HEADS" : "TAILS",
                Color = finalResultHeads ? new SolidColorBrush(Colors.Goldenrod) : new SolidColorBrush(Colors.SlateGray)
            });

            FlipBtn.IsEnabled = true;
        }

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

        private void ClearHistory_Click(object sender, RoutedEventArgs e)
        {
            Flips.Clear();
        }
    }
}