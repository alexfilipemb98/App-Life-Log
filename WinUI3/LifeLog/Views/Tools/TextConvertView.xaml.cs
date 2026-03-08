using LifeLog.Core.Utils.Utils;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.ApplicationModel.DataTransfer;


namespace LifeLog.Views.Tools;

public sealed partial class TextConvertView : UserControl
{
    public TextConvertView()
    {
        InitializeComponent();
    }

    private void ClearBtn_Click(object sender, RoutedEventArgs e)
    {
        InputTextBox.Text = string.Empty;
    }

    private void UpperBtn_Click(object sender, RoutedEventArgs e)
    {
        OutputTextBox.Text = InputTextBox.Text.ToUpper();
    }

    private void LowerBtn_Click(object sender, RoutedEventArgs e)
    {
        OutputTextBox.Text = InputTextBox.Text.ToLower();
    }

    private void TitleBtn_Click(object sender, RoutedEventArgs e)
    {
        OutputTextBox.Text = InputTextBox.Text.ToTitleCase();
    }

    private void SentenceBtn_Click(object sender, RoutedEventArgs e)
    {
        OutputTextBox.Text = InputTextBox.Text.ToSentenceCase();
    }

    private void AlternatingBtn_Click(object sender, RoutedEventArgs e)
    {
        OutputTextBox.Text = InputTextBox.Text.ToAlternativeCase();
    }

    private void InverseBtn_Click(object sender, RoutedEventArgs e)
    {
        OutputTextBox.Text = InputTextBox.Text.InvertCase();
    }

    private void CopyBtn_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(OutputTextBox.Text))
            return;

        var dataPackage = new DataPackage();
        dataPackage.SetText(OutputTextBox.Text);
        Clipboard.SetContent(dataPackage);
    }
}
