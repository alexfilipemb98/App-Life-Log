using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LifeLogApp.Forms.Loading
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
            labelVersion.Text = $"v{Application.ProductVersion}";

        }

        #endregion
    }
}