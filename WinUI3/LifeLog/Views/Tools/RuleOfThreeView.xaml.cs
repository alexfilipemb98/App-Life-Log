using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;

namespace LifeLog.Views.Tools;

public sealed partial class RuleOfThreeView : UserControl
{
    public RuleOfThreeView()
    {
        this.InitializeComponent();
    }

    // Método chamado sempre que o texto muda em qualquer uma das três TextBoxes
    private void Calculate_TextChanged(object sender, TextChangedEventArgs e)
    {
        // 1. Tentar converter o texto das 3 caixas para números decimais (double)
        // O TryParse devolve 'true' se for um número válido, e guarda o valor na variável (a, b ou c).
        bool isAValid = double.TryParse(ValueA.Text, out double a);
        bool isBValid = double.TryParse(ValueB.Text, out double b);
        bool isCValid = double.TryParse(ValueC.Text, out double c);

        // 2. Se os três campos tiverem números válidos, fazemos a conta
        if (isAValid && isBValid && isCValid)
        {
            // Proteção contra divisão por zero!
            if (a == 0)
            {
                ResultLabel.Text = "Erro"; // Não se pode dividir por zero
                return;
            }

            // Fórmula da Regra de 3 Simples: X = (B * C) / A
            double result = (b * c) / a;

            // Mostramos o resultado formatado. 
            // "0.####" significa que mostra até 4 casas decimais, mas ignora os zeros à direita.
            ResultLabel.Text = result.ToString("0.####");
        }
        else
        {
            // Se algum campo estiver vazio ou com letras, o resultado volta a ser "?"
            ResultLabel.Text = "?";
        }
    }

    // Método para copiar o resultado
    private async void CopyResultBtn_Click(object sender, RoutedEventArgs e)
    {
        // Só copia se houver um resultado válido (diferente de "?" e de "Erro")
        if (ResultLabel.Text != "?" && ResultLabel.Text != "Erro")
        {
            // 1. Prepara a "encomenda" com o texto
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(ResultLabel.Text);

            // 2. Envia para a área de transferência do Windows
            Clipboard.SetContent(dataPackage);

            // 3. Efeito visual: Muda o estilo do botão temporariamente para dar feedback ao utilizador
            var originalBrush = CopyResultBtn.Background;
            CopyResultBtn.Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.MediumSeaGreen);

            // Espera 1.5 segundos
            await Task.Delay(1500);

            // Volta à cor original (Accent Color)
            CopyResultBtn.Background = originalBrush;
        }
    }

    // Método para limpar todos os campos
    private void ClearBtn_Click(object sender, RoutedEventArgs e)
    {
        // Limpa o texto das caixas. 
        // O Calculate_TextChanged será disparado automaticamente e colocará o ResultLabel a "?".
        ValueA.Text = string.Empty;
        ValueB.Text = string.Empty;
        ValueC.Text = string.Empty;

        // Foca a primeira caixa para o utilizador poder recomeçar a digitar logo de imediato
        ValueA.Focus(FocusState.Programmatic);
    }
}
