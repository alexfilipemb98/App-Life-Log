using LifeLog.Core.Items;
using LifeLog.Core.Utils;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;

namespace LifeLog.Views.Tools;

/// <summary>
/// Password generator view that allows users to create random passwords based on selected criteria such as length, character types, and exclusion of ambiguous characters. 
/// The view provides options to copy generated passwords to the clipboard and clear the list of generated passwords. 
/// It utilizes the SecurityUtil class for password generation logic and the PasswordItem class to represent individual password entries in the UI.
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
            string pwd = SecurityUtil.GeneratePassword(length, useUpper, useLower, useNumbers, useSymbols, excludeAmbiguous);

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


    #region FUNCTIONS

    /// <summary>
    /// Resets the copy button to its default state with the "Copy all" text and the copy icon.
    /// </summary>
    private void ResetCopyButton()
    {
        CopyBtn?.Content = new StackPanel
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

    #endregion
}