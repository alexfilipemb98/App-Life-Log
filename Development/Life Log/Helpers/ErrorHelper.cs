using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Life_Log.Helpers
{
    /// <summary>
    /// Error Helper class
    /// </summary>
    public class ErrorHelper
    {
        /// <summary>
        /// Handles an exception
        /// </summary>
        /// <param name="ex"></param>
        public static void Handler(Exception ex)
        {
            XtraMessageBox.Show(ex.ToString(), ex.TargetSite.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
