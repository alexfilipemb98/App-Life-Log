using LifeLog.Core.Items;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace LifeLog.Views.Games;

public sealed partial class RollDiceView : UserControl
{
    public ObservableCollection<DiceResultItem> Rolls { get; set; } = [];

    /// <summary>
    /// Constructor
    /// </summary>
    public RollDiceView()
    {
        this.InitializeComponent();
        HistoryList.ItemsSource = Rolls;
    }

    private async void RollBtn_Click(object sender, RoutedEventArgs e)
    {
        RollBtn.IsEnabled = false;

        // Dispara a animação fluida da placa gráfica a 60/120fps (XAML Storyboard)
        RollDiceAnim.Begin();

        // Loop ultra-rápido para baralhar o número do texto enquanto a animação ocorre
        for (int i = 0; i < 12; i++)
        {
            DiceValueText.Text = Random.Shared.Next(1, 7).ToString();
            await Task.Delay(40 + (i * 2));
        }

        // Resultado Final
        int finalValue = Random.Shared.Next(1, 7);
        DiceValueText.Text = finalValue.ToString();

        // Adiciona ao Histórico
        Rolls.Insert(0, new DiceResultItem
        {
            Time = DateTime.Now.ToString("HH:mm:ss"),
            Value = finalValue.ToString()
        });

        RollBtn.IsEnabled = true;
    }

    private void ClearHistoryBtn_Click(object sender, RoutedEventArgs e)
    {
        Rolls.Clear();
    }
}