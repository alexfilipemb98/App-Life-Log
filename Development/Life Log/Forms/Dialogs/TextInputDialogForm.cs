using DevExpress.XtraBars.Ribbon;
using System;
using System.Windows.Forms;

namespace Life_Log.Forms.Dialogs
{
    /// <summary>
    /// Text input form
    /// </summary>
    public partial class TextInputDialogForm : RibbonForm
    {
        #region MAIN

        //PRIVATE
        private int _minLength = 0;
        private int _maxLength = int.MaxValue;

        /// <summary>
        /// Contructor for the text input form
        /// </summary>
        public TextInputDialogForm() => InitializeComponent();

        /// <summary>
        /// Show the text input form
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DialogResult SD(ref string text, int minLength = 0, int maxLength = int.MaxValue)
        {
            using (TextInputDialogForm form = new TextInputDialogForm())
            {
                form.teText.Text = text;
                form.teText.Properties.MaxLength = Math.Min(maxLength, int.MaxValue);

                form._minLength = minLength;
                form._maxLength = maxLength;

                DialogResult result = form.ShowDialog();
                text = form.teText.Text;
                return result;
            }
        }

        #endregion

        #region KEY DOWN

        /// <summary>
        /// Text key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendData();
        }

        #endregion

        #region CLICK

        /// <summary>
        /// Ok button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbOk_Click(object sender, EventArgs e) => SendData();

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Send the text back
        /// </summary>
        private void SendData()
        {
            dxErrorProvider.ClearErrors();

            if (string.IsNullOrWhiteSpace(teText.Text))
            {
                dxErrorProvider.SetError(teText, "Text is required!");
                return;
            }

            if (teText.Text.Length < _minLength)
            {
                dxErrorProvider.SetError(teText, $"Text must be at least {_minLength} characters long!");
                return;
            }

            if (teText.Text.Length > _maxLength)
            {
                dxErrorProvider.SetError(teText, $"Text must be at most {_maxLength} characters long!");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        #endregion

    }
}