using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using LifeLog.Helpers;
using System.Reflection;

namespace LifeLog.Forms.Others
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

		#region EVENTS

		#region CHECKED CHANGED

		/// <summary>
		/// Set top most
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bbiTopMost_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			this.TopMost = bbiTopMost.Checked;
		}

		#endregion

		#endregion

		#region FUNCTIONS

		/// <summary>
		///  Show form with the specified control name  
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="controllName"></param>
		/// <param name="documentManager"></param>
		/// <param name="button"></param>
		public static void ShowForm(Form parent, string controllName, DocumentManager documentManager, BarButtonItem button)
		{
			try
			{
				DialogHelper.ShowWait(parent);

				Type? t = Type.GetType(controllName);
				if (t is null)
					return;

				XtraUserControl control = (XtraUserControl)Activator.CreateInstance(t)!;

				if (control == null) return;

				BaseDocument? doc = documentManager.View.Documents.FirstOrDefault(w => w.Control.FindForm()?.Name == control.Name);

				if (doc != null)
				{
					doc.Form.BringToFront();
					doc.Form.Focus();

					if (doc.Form.WindowState == FormWindowState.Minimized)
						doc.Form.WindowState = FormWindowState.Normal;

					control.Dispose();

					DialogHelper.CloseWait();

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

				form.Shown += (_, _) => SplashScreenManager.CloseForm();

				documentManager.View.AddDocument(form);

				form.Show();
			}
			catch (Exception)
			{
				DialogHelper.CloseWait();
				throw;
			}
		}

		/// <summary>
		/// Show form with out side the main one
		/// </summary>
		/// <param name="controllName"></param>
		public static async Task ShowFormAsync(Form parent, string controllName)
		{
			try
			{
				DialogHelper.ShowWait(parent);

				Type? t = Type.GetType(controllName);
				if (t is null)
					return;

				XtraUserControl control = (XtraUserControl)Activator.CreateInstance(t)!;

				control.Dock = DockStyle.Fill;

				if (control == null)
					return;

				ContainerForm form = new ContainerForm();

				form.Text = control.Name;
				form.Name = control.Name;
				form.Tag = control.Name;
				form.Size = new System.Drawing.Size((int)(parent.Width * 0.8), (int)(parent.Height * 0.8));
				form.panelControl.AddControl(control);
				form.StartPosition = FormStartPosition.CenterScreen;

				form.Shown += (_, _) => DialogHelper.CloseWait();

				MethodInfo? method = control.GetType().GetMethod("LoadData");

				if (method != null)
				{
					object? result = method.Invoke(control, null);
					if (result is Task taskResult)
						await taskResult;
				}

				form.Show();
			}
			catch (Exception)
			{
				DialogHelper.CloseWait();
				throw;
			}
		}

		#endregion


	}
}