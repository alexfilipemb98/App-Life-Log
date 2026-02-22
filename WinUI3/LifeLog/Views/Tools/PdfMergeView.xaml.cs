using LifeLog.Helpers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Windows.Storage.Pickers;

namespace LifeLog.Views.Tools
{
    public sealed partial class PdfMergeView : UserControl
    {
        public PdfMergeView()
        {
            InitializeComponent();
        }

        private async void BrowseSourceBtn_Click(object sender, RoutedEventArgs e)
        {
            SourceFolderBox.Text = await DialogHelper.SelectFolderAsync(SourceFolderBox.Text);
        }

        private async void BrowseOutputBtn_Click(object sender, RoutedEventArgs e)
        {
            string path = await DialogHelper.SaveFileAsync("Documento Unificado", "PDF files", ".pdf");
            if (!string.IsNullOrEmpty(path))
            {
                OutputFileBox.Text = path;
            }
        }

        private void OpenOutputBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OutputFileBox.Text))
                return;

            if (Directory.Exists(Path.GetDirectoryName(OutputFileBox.Text)))
                Process.Start("explorer.exe", Path.GetDirectoryName(OutputFileBox.Text));
        }

        private void MergeBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = SourceFolderBox.Text;
            string output = OutputFileBox.Text;
        }
    }
}
