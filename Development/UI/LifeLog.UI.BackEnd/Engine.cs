using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSplashScreen;
using LifeLog.Base.Infrastructure.Interfaces;
using LifeLog.UI.BackEnd.Forms;
using System;
using System.Drawing;

namespace LifeLog.UI.BackEnd
{
	/// <summary>
	/// Form engine class
	/// </summary>
	public class Engine : IEngineForm
	{
		private MainForm mainForm;

		/// <summary>
		/// Constructor
		/// </summary>
		public Engine()
		{
			mainForm = new MainForm();

			mainForm.Shown += (s, e) =>
				SplashScreenManager.CloseForm(false);

			mainForm.FormClosed += (s, e) =>
				this.IsUserLogingout = mainForm.Logout;
		}

		/// <summary>
		/// Main form
		/// </summary>
		public RibbonForm MainForm => mainForm;

		/// <summary>
		/// If user is loging out
		/// </summary>
		public bool IsUserLogingout { get; set; }

		/// <summary>
		/// Set label form status
		/// </summary>
		/// <param name="status"></param>
		/// <param name="color"></param>
		public void SetLabelStatus(string status, Color color)
		{
			mainForm.Invoke(new Action(() =>
			{
				mainForm.bsiStatusLabel.Caption = status;
				mainForm.bsiStatusLabel.ItemAppearance.Normal.ForeColor = color;
				mainForm.bsiStatusLabel.Refresh();
				mainForm.ribbonStatusBar.Refresh();
			}));
		}
	}
}
