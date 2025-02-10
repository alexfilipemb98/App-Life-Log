using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Life_Log.Forms.Loading
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