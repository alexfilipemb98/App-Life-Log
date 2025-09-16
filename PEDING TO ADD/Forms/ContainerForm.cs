using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Life_Log.Forms.Loading;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Life_Log.Forms.Others
{
    public partial class ContainerForm : RibbonForm
    {
        public ContainerForm() => InitializeComponent();

        public static void ShowForm(string controllName, BarButtonItem button, Form parent)
        {
            SplashScreenManager.ShowForm(parent, typeof(LoadingForm), true, true, false);

            UserControl control = CreateInstanceFromName(controllName) as UserControl;
            control.Dock = DockStyle.Fill;

            ContainerForm form = new ContainerForm();
            form.Name = control.Name;
            form.Tag = control.Name;
            form.Size = new System.Drawing.Size((int)(parent.Bounds.Width * 0.8), (int)(parent.Bounds.Height * 0.8));
            form.panelControl.AddControl(control);
            form.StartPosition = FormStartPosition.CenterScreen;

            if (button.ImageOptions.SvgImage != null)
                form.IconOptions.SvgImage = button.ImageOptions.SvgImage;
            else
                form.IconOptions.Image = button.ImageOptions.Image;

            form.Text = button.Caption;

            form.Shown += (object sender, EventArgs e) =>
            {
                SplashScreenManager.CloseForm(false);
            };

            form.Show();
        }

        public static void ShowForm(string controllName, Form parent, DocumentManager documentManager, BarButtonItem button)
        {
            SplashScreenManager.ShowForm(parent, typeof(LoadingForm), true, true, false);

            UserControl control = CreateInstanceFromName(controllName) as UserControl;

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
                SplashScreenManager.CloseForm(false);
            };

            documentManager.View.AddDocument(form);

            form.Show();
        }

        private static object CreateInstanceFromName(string controlName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type controlType = assembly.GetTypes().FirstOrDefault(t => t.Name.Equals(controlName, StringComparison.OrdinalIgnoreCase));
            if (controlType != null)
                return Activator.CreateInstance(controlType);
            else
                return null;
        }
    }
}