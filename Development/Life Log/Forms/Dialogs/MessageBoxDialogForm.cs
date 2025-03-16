using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.LookAndFeel;
using DevExpress.Skins;

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
        public static DialogResult SD(string caption, string message, string details = null, bool yesno = true)
        {
            using (MessageBoxDialogForm form = new MessageBoxDialogForm())
            {
                
                form.ribbon.ApplicationDocumentCaption = caption;
                form.lblCaption.Text = message;
                Skin skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
                form.BackColor = skin.Colors["Window"];
                form.lcButtons.BackColor = skin.Colors["Control"];

                Size ps1 = TextRenderer.MeasureText(form.lblCaption.Text, form.lblCaption.Font);
                form.Height = Math.Max(form.MinimumSize.Height, Math.Min((form.Size.Height + form.lblCaption.Size.Height), form.MaximumSize.Height));

                if (string.IsNullOrWhiteSpace(details))
                {
                    form.lcgDetails.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    form.Height = form.Height - form.lcgDetails.Height + 5;
                }
                else
                {
                    form.lcMessage.Text = details;
                    Size ps2 = TextRenderer.MeasureText(form.lcMessage.Text, form.lcMessage.Font);
                    form.Height = Math.Min(form.Size.Height + ps2.Height, form.MaximumSize.Height);
                }

                if (yesno)
                   form.lciBtnYesNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                else
                    form.lciBtnOk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                int w1 = (form.esiButtonLeft.Width + form.esiButtonRight.Width) / 2;
                form.esiButtonLeft.Width = w1;
                form.esiButtonRight.Width = w1;

                DialogResult reuslt = form.ShowDialog();

                return reuslt;
            }
        }



        #endregion

        #region CLICK

        /// <summary>
        /// Copy details to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lcgDetails_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            Clipboard.SetText(lcMessage.Text);
        }

        #endregion
    }
}