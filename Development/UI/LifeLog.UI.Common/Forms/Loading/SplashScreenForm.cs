using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;
using System.Reflection;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.UI.Common.Forms.Loading
{
	public partial class SplashScreenForm : SplashScreen
	{
		#region MAIN

		/// <summary>
		/// Constructor
		/// </summary>
		public SplashScreenForm() => InitializeComponent();

		/// <summary>
		/// Form Load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmSplashScreen_Load(object sender, EventArgs e)
		{
			labelCopyright.Parent = progressPanel;
			labelVersion.Parent = progressPanel;

			labelCopyright.BackColor = Color.Transparent;
			labelVersion.BackColor = Color.Transparent;

			labelCopyright.Text = "© 2018 - " + DateTime.Now.Year.ToString();

			Version verssion = Assembly.GetExecutingAssembly().GetName().Version;
#if DEBUG
			labelVersion.Text = $"v{verssion} (DEBUG!)";
			labelVersion.Appearance.ForeColor = ForeColors.Critical;
#else
			labelVersion.Text = $"v{verssion}";
			labelVersion.Appearance.ForeColor = ForeColors.Information;
#endif
		}

		#endregion
	}
}