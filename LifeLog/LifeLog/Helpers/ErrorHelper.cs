using DevExpress.XtraEditors;

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
			//LoggerUtil.LogError(ex);
			//DialogHelper.CloseWait();

			XtraMessageBox.Show(ex?.TargetSite?.ToString(), ex?.TargetSite?.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}