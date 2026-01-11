using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using LifeLog.Core.Utils;
using LifeLog.Data.DTOs;
using System.ComponentModel.DataAnnotations;

namespace LifeLog.Helpers
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
			Program.Logger!.LogError(ex);
			DialogHelper.CloseWait();
			XtraMessageBox.Show(ex?.Message, ex?.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}