using LifeLog.Items;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;

namespace LifeLog.Views.Tools;

/// <summary>
/// Password generation 
/// </summary>
public sealed partial class PassGeneratorView : UserControl
{
    private List<PasswordItem> _generatedPasswords = new();

    public PassGeneratorView() => InitializeComponent();

    private void LengthSlider_ValueChanged(object sender, Microsoft.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
    {
        if (LengthLabel != null)
        {
            LengthLabel.Text = e.NewValue.ToString("0");
        }
    }

    private void CountSlider_ValueChanged(object sender, Microsoft.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
    {
        if (CountLabel != null)
        {
            CountLabel.Text = e.NewValue.ToString("0");
        }
    }

    private async void CopyBtn_Click(object sender, RoutedEventArgs e)
    {
        if (_generatedPasswords.Count <= 0)
            return;
        
        string allPasswords = string.Join(Environment.NewLine, _generatedPasswords.Select(p => p.Password));

        DataPackage? dataPackage = new DataPackage();
        dataPackage.SetText(allPasswords);
        Clipboard.SetContent(dataPackage);

        CopyBtn.Content = new StackPanel
        {
            Orientation = Orientation.Horizontal,
            Spacing = 6,
            Children =
            {
                new FontIcon { Glyph = "\uE8FB", FontSize = 14, Foreground = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.LightGreen) },
                new TextBlock { Text = "Copied!", FontSize = 12 }
            }
        };

        await Task.Delay(1500);
        ResetCopyButton();
    }

    private async void CopySingleBtn_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button btn && btn.Tag is string pwd)
        {
            DataPackage? dataPackage = new DataPackage();
            dataPackage.SetText(pwd);
            Clipboard.SetContent(dataPackage);

            // Animação de sucesso no pequeno botão
            if (btn.Content is FontIcon icon)
            {
                string originalGlyph = icon.Glyph;
                icon.Glyph = "\uE8FB"; // Ícone de visto (checkmark)
                icon.Foreground = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.LightGreen);

                await Task.Delay(1500);

                icon.Glyph = originalGlyph; // Volta ao ícone de copiar
                icon.Foreground = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.White); // Ajusta se o teu tema usar outra cor base
            }
        }
    }
    
    private void ClearBtn_Click(object sender, RoutedEventArgs e)
    {
        _generatedPasswords.Clear();
        if (PasswordsListView != null)
        {
            PasswordsListView.ItemsSource = null;
        }
        ResetCopyButton();
    }
    
    private void GenerateBtn_Click(object sender, RoutedEventArgs e)
    {
        bool useUpper = ToggleUpperCase.IsOn;
        bool useLower = ToggleLowerCase.IsOn;
        bool useNumbers = ToggleNumbers.IsOn;
        bool useSymbols = ToggleSpecialChars.IsOn;
        bool excludeAmbiguous = ToggleExcludeAmbiguous.IsOn;

        if (!useUpper && !useLower && !useNumbers && !useSymbols)
        {
            useLower = true;
            ToggleLowerCase.IsOn = true;
        }

        int length = (int)LengthSlider.Value;
        int count = (int)CountSlider.Value;

        _generatedPasswords.Clear();

        for (int i = 0; i < count; i++)
        {
            string pwd = GenerateSinglePassword(length, useUpper, useLower, useNumbers, useSymbols, excludeAmbiguous);

            _generatedPasswords.Add(new PasswordItem
            {
                IndexStr = $"{i + 1}.",
                Password = pwd
            });
        }

        PasswordsListView.ItemsSource = null;
        PasswordsListView.ItemsSource = _generatedPasswords;

        ResetCopyButton();
    }

    private string GenerateSinglePassword(int length, bool useUpper, bool useLower, bool useNumbers, bool useSymbols, bool excludeAmbiguous)
    {
        string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowerChars = "abcdefghijklmnopqrstuvwxyz";
        string numberChars = "0123456789";
        string symbolChars = "!@#$%^&*()_-+=[{]};:>|./?";
        string ambiguousChars = "il1Lo0O";

        if (excludeAmbiguous)
        {
            upperChars = new string(upperChars.Where(c => !ambiguousChars.Contains(c)).ToArray());
            lowerChars = new string(lowerChars.Where(c => !ambiguousChars.Contains(c)).ToArray());
            numberChars = new string(numberChars.Where(c => !ambiguousChars.Contains(c)).ToArray());
            symbolChars = new string(symbolChars.Where(c => !ambiguousChars.Contains(c)).ToArray());
        }









        List<char> password = new List<char>();
        string fullPool = "";

        if (useUpper && upperChars.Length > 0)
        {
            password.Add(upperChars[Random.Shared.Next(upperChars.Length)]);
            fullPool += upperChars;
        }
        if (useLower && lowerChars.Length > 0)
        {
            password.Add(lowerChars[Random.Shared.Next(lowerChars.Length)]);
            fullPool += lowerChars;
        }
        if (useNumbers && numberChars.Length > 0)
        {
            password.Add(numberChars[Random.Shared.Next(numberChars.Length)]);
            fullPool += numberChars;
        }
        if (useSymbols && symbolChars.Length > 0)
        {
            password.Add(symbolChars[Random.Shared.Next(symbolChars.Length)]);
            fullPool += symbolChars;
        }

        // Preenche o resto do tamanho da password com caracteres aleatórios da pool global
        while (password.Count < length)
        {
            password.Add(fullPool[Random.Shared.Next(fullPool.Length)]);
        }

        // Baralha os caracteres para que os "obrigatórios" não fiquem sempre no início
        return new string(password.OrderBy(x => Random.Shared.Next()).ToArray());
    }

    private void ResetCopyButton()
    {
        if (CopyBtn != null)
        {
            CopyBtn.Content = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                Spacing = 6,
                Children =
                {
                    new FontIcon { Glyph = "\uE8C8", FontSize = 14 },
                    new TextBlock { Text = "Copy all", FontSize = 12 }
                }
            };
        }
    }
}