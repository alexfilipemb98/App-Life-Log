using DevExpress.XtraSplashScreen;
using LifeLog.UI.Common.Forms.Loading;
using System.IO;
using System.Windows.Forms;

namespace LifeLog.UI.Common.Helpers
{
    /// <summary>
    /// Dialog Helper class
    /// </summary>
    public static class DialogHelper
    {
        /// <summary>
        /// Open the folder dialog
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string OpenFolder(string path)
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
        public static void ShowWait(Form form = null)
        {
            SplashScreenManager.ShowForm(form ?? AppSession.Container.EngineForm.MainForm, typeof(LoadingForm), true, true, false);
        }

        /// <summary>
        /// Close the wait form
        /// </summary>
        public static void CloseWait()
        {
            SplashScreenManager.CloseForm(false);
        }

    }
}
