using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace Life_Log.Forms.Dialogs
{
    /// <summary>
    /// MessageBoxDialogForm class
    /// </summary>
	public partial class MessageBoxDialogForm : RibbonForm
    {
        #region MAIN

        /// <summary>
        /// Constructor
        /// </summary>
        public MessageBoxDialogForm() => InitializeComponent();

        /// <summary>
        /// Show dialog form 
        /// </summary>
        /// <returns></returns>
        public static DialogResult SD(string caption, string message, string details = null)
        {
            using (MessageBoxDialogForm form = new MessageBoxDialogForm())
            {
                int w1 = (form.esibuttonLeft.Width + form.esiButtonRight.Width) / 2;
                form.esibuttonLeft.Width = w1;
                form.esiButtonRight.Width = w1;

                form.lblCaption.Text = caption;

                if (string.IsNullOrWhiteSpace(details))
                {

                }

                DialogResult reuslt = form.ShowDialog();


                return reuslt;
            }
        }

        #endregion



    }
}