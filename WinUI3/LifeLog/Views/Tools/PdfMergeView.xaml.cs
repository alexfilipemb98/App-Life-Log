using LifeLog.Core.Utils;
using LifeLog.Helpers;
using LifeLog.Pages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
            string path = await DialogHelper.SaveFileAsync("MergedPdf", "PDF files", ".pdf");
            if (!string.IsNullOrEmpty(path))
            {
                OutputFileBox.Text = path;
            }
        }

        private void OpenOutputBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OutputFileBox.Text))
                return;

            string? fileName = OutputFileBox.Text;

            if (string.IsNullOrWhiteSpace(fileName) || !File.Exists(fileName))
                return;

            Process.Start("explorer.exe", fileName);
        }

        private async void MergeBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = SourceFolderBox.Text;
            string output = OutputFileBox.Text;

            if (!ValidateForm(input, output))
                return;

            ShowErrorMessage();

            SetLoadingState(true);

            await Task.Delay(500);

            SearchOption searchOption = ToggleSubfolders.IsOn ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            List<string> pdfFiles = Directory
               .EnumerateFiles(input, "*.pdf", searchOption)
               .OrderBy(f => f)
               .ToList();

            PdfUtil.MergePdfs(pdfFiles, output);


            bool fileCreated = File.Exists(output);

            OpenOutputBtn.IsEnabled = fileCreated;

            var count = pdfFiles.Count;
            MainPage.SetStatusMsg($"Merged {count} PDF file{(count > 1 ? "s" : "")} successfully.");

            SetLoadingState(false);
        }


        #region FUNCTIONS

        /// <summary>
        /// Shows an error message in the InfoBar
        /// </summary>
        /// <param name="message">The error message to display</param>
        private void ShowErrorMessage(string message = null)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                AlertBar.Severity = InfoBarSeverity.Error;
                AlertBar.Title = null;
                AlertBar.Message = null;
                AlertBar.IsOpen = false;

            }
            else
            {
                AlertBar.Severity = InfoBarSeverity.Error;
                AlertBar.Title = "Validation Error";
                AlertBar.Message = message;
                AlertBar.IsOpen = true;
            }
        }

        /// <summary>
        /// Sets the loading state
        /// </summary>
        /// <param name="isLoading"></param>
        private void SetLoadingState(bool isLoading)
        {
            MergeBtn.IsEnabled = !isLoading;
            MergePDfText.Visibility = isLoading ? Visibility.Collapsed : Visibility.Visible;
            MergePDfSpinner.Visibility = isLoading ? Visibility.Visible : Visibility.Collapsed;
            MergePDfSpinner.IsActive = isLoading;
        }

        /// <summary>
        /// Validate form
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        private bool ValidateForm(string input, string output)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                ShowErrorMessage("Please select or enter a source folder containing PDF files.");
                return false;
            }

            if (!Directory.Exists(input))
            {
                ShowErrorMessage("The source folder does not exist. Please check the path and try again.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(output))
            {
                ShowErrorMessage("Please select or enter an output file path for the merged PDF.");
                return false;
            }

            if (!output.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                ShowErrorMessage("The output file must have a .pdf extension.");
                return false;
            }

            string outputDir = Path.GetDirectoryName(output);
            if (!string.IsNullOrEmpty(outputDir) && !Directory.Exists(outputDir))
            {
                ShowErrorMessage("The output folder does not exist. Please check the path and try again.");
                return false;
            }

            return true;
        }

        #endregion
    }
}
