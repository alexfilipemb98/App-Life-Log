using DevExpress.Utils.Controls;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraRichEdit;
using DevExpress.XtraSplashScreen;
using Life_Log_App.Forms.Loading;
using Life_Log_App.Helpers;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Log_App.Forms
{
    /// <summary>
    /// Container form for displaying user controls
    /// </summary>
    public partial class ContainerForm : RibbonForm
    {
        #region MAIN

        /// <summary>
        /// Constructor
        /// </summary>
        public ContainerForm() => InitializeComponent();

        #endregion

        /// <summary>
        /// Show form with the specified control name  
        /// </summary>
        /// <param name="controllName"></param>
        /// <param name="parent"></param>
        /// <param name="documentManager"></param>
        /// <param name="button"></param>
        public static void ShowForm(string controllName, Form parent, DocumentManager documentManager, BarButtonItem button)
        {
            SplashScreenManager.ShowForm(AppContext.MainForm, typeof(LoadingForm), true, true, false);

            UserControl control = ControlsHelper.CreateInstanceFromName(controllName) as UserControl;

            if (control == null) return;

            BaseDocument doc = documentManager.View.Documents.FirstOrDefault(w => w.Control.FindForm().Name == control.Name);

            if (doc != null)
            {
                doc.Form.BringToFront();
                doc.Form.Focus();

                if (doc.Form.WindowState == FormWindowState.Minimized)
                    doc.Form.WindowState = FormWindowState.Normal;

                control.Dispose();

                SplashScreenManager.CloseForm();

                return;
            }

            ContainerForm form = new ContainerForm();

            control.Dock = DockStyle.Fill;

            form.Name = control.Name;
            form.Tag = control.Name;
            form.Size = new System.Drawing.Size((int)(documentManager.Bounds.Width * 0.8), (int)(documentManager.Bounds.Height * 0.8));
            form.panelControl.AddControl(control);
            form.MdiParent = parent;
            form.StartPosition = FormStartPosition.CenterScreen;

            if (button.ImageOptions.SvgImage != null)
                form.IconOptions.SvgImage = button.ImageOptions.SvgImage;

            form.Text = button.Caption;

            form.Shown += (object sender, EventArgs e) =>
            {
                SplashScreenManager.CloseForm();
            };

            documentManager.View.AddDocument(form);

            form.Show();
        }


        public static void ShowForm(string controllName)
        {
            SplashScreenManager.ShowForm(AppContext.MainForm, typeof(LoadingForm), true, true, false);

            UserControl control = ControlsHelper.CreateInstanceFromName(controllName) as UserControl;

            control.Dock = DockStyle.Fill;

            if (control == null) return;

            ContainerForm form = new ContainerForm();

            form.Name = control.Name;
            form.Tag = control.Name;
            form.Size = new System.Drawing.Size((int)(AppContext.MainForm.Width * 0.8), (int)(AppContext.MainForm.Height * 0.8));
            form.panelControl.AddControl(control);
            form.StartPosition = FormStartPosition.CenterScreen;

            form.Shown += (object sender, EventArgs e) =>
            {
                SplashScreenManager.CloseForm();
            };

            form.Show();
        }
    }
}