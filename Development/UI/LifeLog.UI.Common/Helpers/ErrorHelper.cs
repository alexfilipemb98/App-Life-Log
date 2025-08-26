using System;
using System.Windows.Forms;
using LifeLog.Base.Utils;
using LifeLog.UI.Common.Forms.Dialog;

namespace LifeLog.UI.Common.Helpers
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
		 	MessageBoxDialogForm.SD(MessageBoxIcon.Error,ex.TargetSite.Name, ex.TargetSite.ToString(), ex.ToString(), false);
		}
	}
}