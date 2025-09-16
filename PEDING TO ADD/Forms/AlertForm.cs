using DevExpress.XtraEditors;
using Life_Log.Helpers;
using Life_Log.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Life_Log.Forms.Others
{
    /// <summary>
    /// Alert form
    /// </summary>
    public partial class AlertForm : XtraForm
    {
        #region MAIN

        //*// Variables /*/

        private int x, y;

        //*//   EMUMS   /*/

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private enmAction action;

        /// <summary>
        /// Contructor
        /// </summary>
        public AlertForm() => InitializeComponent();

        #endregion

        #region CLICK

        /// <summary>
        /// Closes the alert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PeClose_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            action = enmAction.close;
        }

        #endregion

        #region OTHERS

        /// <summary>
        /// Timer of the alert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (this.action)
                {
                    case enmAction.wait:
                        timer.Interval = 5000;
                        action = enmAction.close;
                        break;
                    case AlertForm.enmAction.start:
                        this.timer.Interval = 1;
                        this.Opacity += 0.1;
                        if (this.x < this.Location.X)
                        {
                            this.Left--;
                        }
                        else
                        {
                            if (this.Opacity == 1.0)
                            {
                                action = AlertForm.enmAction.wait;
                            }
                        }
                        break;
                    case enmAction.close:
                        timer.Interval = 1;
                        this.Opacity -= 0.1;

                        this.Left -= 3;
                        if (base.Opacity == 0.0)
                        {
                            base.Close();
                            base.Dispose();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                AppHelper.ErrorHandler(ex);
            }
        }

        /// <summary>
        /// Shows the alert
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="type"></param>
        private void CreateAlert(string msg, enmType type, bool playSound = true)
        {
            try
            {
                this.Opacity = 0.0;
                this.StartPosition = FormStartPosition.Manual;
                string fname;

                for (int i = 1; i < 10; i++)
                {
                    fname = $"alert{i}";
                    AlertForm frm = (AlertForm)Application.OpenForms[fname];

                    if (frm == null)
                    {
                        this.Name = fname;
                        this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                        this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                        this.Location = new Point(this.x, this.y);
                        break;

                    }

                }
                this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

                switch (type)
                {
                    case enmType.Success:
                        this.pbIcon.Image = Resources.success;
                        this.BackColor = Color.SeaGreen;
                        if (playSound) SystemSounds.Asterisk.Play();
                        break;
                    case enmType.Error:
                        this.pbIcon.Image = Resources.error;
                        this.BackColor = Color.DarkRed;
                        if (playSound) SystemSounds.Hand.Play();
                        break;
                    case enmType.Info:
                        this.pbIcon.Image = Resources.info;
                        this.BackColor = Color.RoyalBlue;
                        if (playSound) SystemSounds.Asterisk.Play();
                        break;
                    case enmType.Warning:
                        this.pbIcon.Image = Resources.warning;
                        this.BackColor = Color.DarkOrange;
                        if (playSound) SystemSounds.Exclamation.Play();
                        break;
                }


                this.lblMsg.Text = msg;

                this.Show();
                this.action = enmAction.start;
                this.timer.Interval = 1;
                this.timer.Start();
            }
            catch (Exception ex)
            {
                AppHelper.ErrorHandler(ex);
            }
        }

        /// <summary>
        /// Custom show form
        /// </summary>
        public static void Alert(string msg, enmType type, bool playSound = true)
        {
            try
            {
                AlertForm frm = new AlertForm();
                frm.CreateAlert(msg, type, playSound);
            }
            catch (Exception ex)
            {
                AppHelper.ErrorHandler(ex);
            }
        }

        #endregion
    }
}