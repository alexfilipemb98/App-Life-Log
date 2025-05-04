using DevExpress.Portable.Input;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Internal;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.XtraRichEdit.Mouse;
using System.ComponentModel;
using System.Drawing;

namespace Components
{
    /// <summary>
    /// Extended RichEditControl with format copy/paste support.
    /// </summary>
    [ToolboxItem(true)]
    public partial class RichEditControlEx : RichEditControl
    {
        [DefaultValue(false)]
        public bool FormatCalculatorEnabled { get; set; }

        private TextFormattingSnapshot savedFormatting;

        protected override InnerRichEditControl CreateInnerControl() =>
            new InnerControlEx(this);

        /// <summary>
        /// Save font and paragraph formatting from current selection
        /// </summary>
        public void SaveSelectedFormat()
        {
            DocumentRange selection = Document.Selection;
            if (selection.Length == 0) return;

            SubDocument doc = selection.BeginUpdateDocument();
            CharacterProperties charProps = doc.BeginUpdateCharacters(selection);
            ParagraphProperties paraProps = doc.BeginUpdateParagraphs(selection);

            savedFormatting = new TextFormattingSnapshot
            {
                FontName = charProps.FontName,
                FontSize = charProps.FontSize.Value,
                Bold = charProps.Bold.Value,
                Italic = charProps.Italic.Value,
                Underline = charProps.Underline.Value,
                Strikeout = charProps.Strikeout.Value,
                ForeColor = charProps.ForeColor,
                BackColor = charProps.BackColor,
                Alignment = paraProps.Alignment.Value,
                LineSpacing = paraProps.LineSpacing.Value
            };

            doc.EndUpdateCharacters(charProps);
            doc.EndUpdateParagraphs(paraProps);
            selection.EndUpdateDocument(doc);
        }

        /// <summary>
        /// Apply saved formatting to current selection
        /// </summary>
        public void ApplySavedFormat()
        {
            if (savedFormatting == null) return;

            var selection = Document.Selection;
            if (selection.Length == 0) return;

            var doc = selection.BeginUpdateDocument();
            var charProps = doc.BeginUpdateCharacters(selection);

            charProps.FontName = savedFormatting.FontName;
            charProps.FontSize = savedFormatting.FontSize;
            charProps.Bold = savedFormatting.Bold;
            charProps.Italic = savedFormatting.Italic;
            charProps.Underline = savedFormatting.Underline;
            charProps.Strikeout = savedFormatting.Strikeout;
            charProps.ForeColor = savedFormatting.ForeColor;
            charProps.BackColor = savedFormatting.BackColor;

            doc.EndUpdateCharacters(charProps);

            var paraProps = doc.BeginUpdateParagraphs(selection);
            paraProps.Alignment = savedFormatting.Alignment;
            paraProps.LineSpacing = savedFormatting.LineSpacing;
            doc.EndUpdateParagraphs(paraProps);

            selection.EndUpdateDocument(doc);
        }
    }

    /// <summary>
    /// Class to store formatting settings
    /// </summary>
    public class TextFormattingSnapshot
    {
        public string FontName { get; set; }
        public float FontSize { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public UnderlineType Underline { get; set; }
        public StrikeoutType Strikeout { get; set; }
        public Color? ForeColor { get; set; }
        public Color? BackColor { get; set; }
        public ParagraphAlignment Alignment { get; set; }
        public float LineSpacing { get; set; }
    }

    /// <summary>
    /// Inner control override
    /// </summary>
    public class InnerControlEx : InnerRichEditControl
    {
        public InnerControlEx(IInnerRichEditControlOwner owner) : base(owner) { }

        protected override MouseCursorCalculator CreateMouseCursorCalculator() =>
            new MouseCursorCalculatorEx(ActiveView);
    }

    /// <summary>
    /// Custom cursor behaviour
    /// </summary>
    public class MouseCursorCalculatorEx : MouseCursorCalculator
    {
        public MouseCursorCalculatorEx(RichEditView view) : base(view) { }

        public override IPortableCursor Calculate(RichEditHitTestResultCore hitTestResult, Point physicalPoint)
        {
            if (View.Control is RichEditControlEx richEdit && richEdit.FormatCalculatorEnabled)
                return DevExpress.XtraRichEdit.Utils.RichEditCursors.Hand;

            return base.Calculate(hitTestResult, physicalPoint);
        }
    }
}
