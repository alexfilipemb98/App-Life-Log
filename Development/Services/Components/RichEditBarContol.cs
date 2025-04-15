using DevExpress.XtraBars;
using System;
using System.ComponentModel;
using System.Linq;

namespace Components
{
    [ToolboxItem(true)]
    public partial class RichEditBarContol : DevExpress.XtraEditors.XtraUserControl
    {
        [Category("Data")]
        [Description("RichEdit controll")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public RichEditControlEx RichEdit { get => recMainBase; }

        [Category("Data")]
        [Description("Gets or sets the html text associated with the control.")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string HtmlText { get => recMainBase.HtmlText; set => recMainBase.HtmlText = value; }


        [Category("Data")]
        [Description("Gets or sets the text associated with the control.")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Text { get => recMainBase.Text; set => recMainBase.Text = value; }

        /// <summary>
        /// Constructor for RichEditBarContol
        /// </summary>
        public RichEditBarContol() => InitializeComponent();

        /// <summary>
        /// Copy text format to another text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bciFormatPainter_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bciFormatPainter.Checked)
            {
                recMainBase.SaveSelectedFormat();
                recMainBase.FormatCalculatorEnabled = true;
            }
            else
                recMainBase.FormatCalculatorEnabled = false;
        }

        /// <summary>
        /// Apply the format to the selected text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recMainBase_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (bciFormatPainter.Checked)
            {
                recMainBase.ApplySavedFormat();
                bciFormatPainter.Checked = false;
            }
        }
    }
}
