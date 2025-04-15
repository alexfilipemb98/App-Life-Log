using Core.Utils;
using DevExpress.XtraEditors;
using LifeLogApp.Forms.Dialog;
using System;
using System.Windows.Forms;

namespace LifeLogApp.Helpers
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
            LoggerUtil.LogError(ex);
            MessageBoxDialogForm.SD(ex.TargetSite.Name, ex.TargetSite.ToString(), ex.ToString(), false);
        }
    }
}