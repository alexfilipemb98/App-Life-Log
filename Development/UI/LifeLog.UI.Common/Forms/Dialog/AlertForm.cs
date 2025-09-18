using DevExpress.XtraEditors;
using LifeLog.UI.Common.Helpers;
using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LifeLog.UI.Common.Forms.Dialog
{
	public partial class AlertForm : XtraForm
	{
		// ----- nativo para mostrar sem ativar / mover sem ativar -----
		private const int SW_SHOWNOACTIVATE = 4;
		private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
		private const uint SWP_NOSIZE = 0x0001;
		private const uint SWP_NOMOVE = 0x0002;
		private const uint SWP_NOACTIVATE = 0x0010;
		private const uint SWP_SHOWWINDOW = 0x0040;

		[DllImport("user32.dll")] private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
		[DllImport("user32.dll")]
		private static extern bool SetWindowPos(
			IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		// ----- o resto é o teu código -----
		private int x, y;
		public enum enmAction { wait, start, close }
		public enum enmType { Success, Warning, Error, Info }
		private enmAction action;

		public AlertForm()
		{
			InitializeComponent();

			// mantém o teu estilo, mas:
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.DoubleBuffered = true;
			this.StartPosition = FormStartPosition.Manual;

			// garante que o Timer usa o nosso handler
			this.timer.Tick -= Timer_Tick;
			this.timer.Tick += Timer_Tick;
		}

		// NUNCA ativar quando aparece / recebe clique
		protected override bool ShowWithoutActivation => true;

		// ToolWindow + NoActivate (não entra em Alt-Tab nem rouba foco)
		protected override CreateParams CreateParams
		{
			get
			{
				const int WS_EX_TOOLWINDOW = 0x00000080;
				const int WS_EX_APPWINDOW = 0x00040000;
				const int WS_EX_NOACTIVATE = 0x08000000;

				var cp = base.CreateParams;
				cp.ExStyle |= WS_EX_TOOLWINDOW | WS_EX_NOACTIVATE;
				cp.ExStyle &= ~WS_EX_APPWINDOW;
				return cp;
			}
		}

		private void PeClose_Click(object sender, EventArgs e)
		{
			timer.Interval = 15;
			action = enmAction.close;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			try
			{
				switch (this.action)
				{
					case enmAction.wait:
						timer.Interval = 5000;    // tempo visível
						action = enmAction.close;
						break;

					case enmAction.start:
						timer.Interval = 15;      // animação suave

						// fade-in
						if (this.Opacity < 1.0)
							this.Opacity = Math.Min(1.0, this.Opacity + 0.10);

						// slide-in sem ativar (use SetWindowPos + SWP_NOACTIVATE)
						if (this.Left > this.x)
						{
							int newLeft = Math.Max(this.x, this.Left - 3);
							SetWindowPos(this.Handle, HWND_TOPMOST, newLeft, this.Top, 0, 0,
										 SWP_NOSIZE | SWP_NOACTIVATE | SWP_SHOWWINDOW);
						}

						if (this.Opacity >= 1.0 && this.Left <= this.x)
							action = enmAction.wait;

						break;

					case enmAction.close:
						timer.Interval = 15;

						if (this.Opacity > 0.0)
						{
							this.Opacity = Math.Max(0.0, this.Opacity - 0.10);
							// slide-out sem ativar
							SetWindowPos(this.Handle, HWND_TOPMOST, this.Left - 3, this.Top, 0, 0,
										 SWP_NOSIZE | SWP_NOACTIVATE | SWP_SHOWWINDOW);
						}
						else
						{
							timer.Stop();
							Close();
						}
						break;
				}
			}
			catch (Exception ex)
			{
				timer.Stop();
				ErrorHelper.Handler(ex);
			}
		}

		private void CreateAlert(string msg, enmType type, bool playSound = true)
		{
			try
			{
				this.Opacity = 0.0;

				// ecrã do cursor (stack multi-monitor)
				var screen = Screen.FromPoint(Cursor.Position);
				var wa = screen.WorkingArea;

				for (int i = 1; i < 10; i++)
				{
					string fname = $"alert{i}";
					AlertForm frm = (AlertForm)Application.OpenForms[fname];
					if (frm == null)
					{
						this.Name = fname;

						int startX = wa.Right - this.Width + 15;
						int startY = wa.Bottom - this.Height * i - 5 * i;

						this.x = wa.Right - this.Width - 5; // alvo final
						this.y = startY;

						// posiciona SEM ativar
						SetWindowPos(this.Handle, HWND_TOPMOST, startX, startY, 0, 0,
									 SWP_NOSIZE | SWP_NOACTIVATE | SWP_SHOWWINDOW);
						break;
					}
				}

				this.x = wa.Right - base.Width - 5;

				switch (type)
				{
					case enmType.Success:
						this.pbIcon.Image = Base.Assets.Resources.success;
						this.BackColor = Color.SeaGreen;
						if (playSound) SystemSounds.Asterisk.Play();
						break;
					case enmType.Error:
						this.pbIcon.Image = Base.Assets.Resources.error;
						this.BackColor = Color.DarkRed;
						if (playSound) SystemSounds.Hand.Play();
						break;
					case enmType.Info:
						this.pbIcon.Image = Base.Assets.Resources.info;
						this.BackColor = Color.RoyalBlue;
						if (playSound) SystemSounds.Asterisk.Play();
						break;
					case enmType.Warning:
						this.pbIcon.Image = Base.Assets.Resources.warning;
						this.BackColor = Color.DarkOrange;
						if (playSound) SystemSounds.Exclamation.Play();
						break;
				}

				this.lblMsg.Text = msg;

				// mostra SEM ativar (em vez de Show())
				if (!this.IsHandleCreated) this.CreateControl();
				ShowWindow(this.Handle, SW_SHOWNOACTIVATE);

				this.action = enmAction.start;
				this.timer.Interval = 15;
				this.timer.Start();
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		public static void Alert(string msg, enmType type, bool playSound = true)
		{
			try
			{
				void show()
				{
					var frm = new AlertForm();
					frm.CreateAlert(msg, type, playSound);
				}

				if (Application.OpenForms.Count > 0)
				{
					var any = Application.OpenForms[0];
					if (any.InvokeRequired) any.BeginInvoke((Action)show);
					else show();
				}
				else
				{
					show(); // já com message loop
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}
	}
}
