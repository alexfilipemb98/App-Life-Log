using DevExpress.XtraSplashScreen;
using Life_Log_App.Forms.Loading;
using System.IO;
using System.Windows.Forms;

namespace Life_Log_App.Helpers
{
    /// <summary>
    /// Dialog Helper class
    /// </summary>
    internal static class DialogHelper
    {
        /// <summary>
        /// Open the folder dialog
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        internal static string OpenFolder(string path)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select the folder to save the merged pdf.";

                if (!string.IsNullOrWhiteSpace(path) && Directory.Exists(path))
                    dialog.SelectedPath = path;

                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.SelectedPath;
            }

            return path;
        }

        /// <summary>
        /// Show the wait form
        /// </summary>
        /// <param name="form"></param>
        internal static void ShowWait(Form form = null)
        {
            SplashScreenManager.ShowForm(form ?? AppContext.MainForm, typeof(LoadingForm), true, true, false);
        }

        /// <summary>
        /// Close the wait form
        /// </summary>
        internal static void CloseWait()
        {
            SplashScreenManager.CloseForm(false);
        }

    }
}
