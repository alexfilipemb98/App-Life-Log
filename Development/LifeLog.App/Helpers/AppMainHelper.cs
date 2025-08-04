using DevExpress.XtraSplashScreen;
using LifeLog.UI.Common.Forms.Dialog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LifeLog.App.Helpers
{
	public static class AppMainHelper
	{
		/// <summary>
		/// User32.dll to set the window to the front
		/// </summary>
		/// <param name="hWnd"></param>
		/// <returns></returns>
		[DllImport("User32.dll")]
		private static extern int SetForegroundWindow(IntPtr hWnd);

		/// <summary>
		/// Check if is already is running 
		/// </summary>
		public static void CheckForRunningInstance()
		{
#if !DEBUG
            Process currentProcess = Process.GetCurrentProcess();
            Process checkProcess = Process.GetProcessesByName(currentProcess.ProcessName).FirstOrDefault(p => p.Id != currentProcess.Id);

            if (checkProcess != null)
            {
                SplashScreenManager.CloseForm(false);
                MessageBoxDialogForm.SD("Application", "This app is already open!", yesno: false);

                IntPtr hWnd = IntPtr.Zero;
                hWnd = checkProcess.MainWindowHandle;
                SetForegroundWindow(hWnd);
                Environment.Exit(0);
            }
#endif
		}
	}
}
