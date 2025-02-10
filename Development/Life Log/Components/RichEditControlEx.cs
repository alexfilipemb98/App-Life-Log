using DevExpress.Portable.Input;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Internal;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.XtraRichEdit.Mouse;
using System.ComponentModel;
using System.Drawing;

namespace Life_Log.Components
{
    /// <summary>
    /// RichEditControlEx class
    /// </summary>
    [ToolboxItem(true)]
    public partial class RichEditControlEx : RichEditControl
    {
        //PROPERTIES
        [DefaultValue(false)]
        public bool FormatCalculatorEnabled { get; set; }

        //PRIVATE
        private DocumentRange sourceSelectedRange;

        /// <summary>
        /// Create Inner Control
        /// </summary>
        /// <returns></returns>
        protected override InnerRichEditControl CreateInnerControl() =>
            new InnerControlEx(this);

        /// <summary>
        /// Save Selected Range
        /// </summary>
        public void SaveSelectedRange()
        {
            DocumentRange selection = this.Document.Selection;
            SubDocument subDocument = selection.BeginUpdateDocument();
            sourceSelectedRange = subDocument.CreateRange(selection.Start, this.Document.Selection.Length);
            selection.EndUpdateDocument(subDocument);
        }

        /// <summary>
        /// Aplly Format to Selected Text
        /// </summary>
        public void ApplyFormatToSelectedText()
        {
            DocumentRange targetSelectedRange = this.Document.Selection;

            this.BeginUpdate();
            SubDocument targetSubDocument = targetSelectedRange.BeginUpdateDocument();
            SubDocument subDocument = sourceSelectedRange.BeginUpdateDocument();

            CharacterProperties targetCharactersProperties = targetSubDocument.BeginUpdateCharacters(targetSelectedRange);
            CharacterProperties sourceCharactersProperties = subDocument.BeginUpdateCharacters(sourceSelectedRange);
            targetCharactersProperties.Assign(sourceCharactersProperties);
            subDocument.EndUpdateCharacters(sourceCharactersProperties);
            targetSubDocument.EndUpdateCharacters(targetCharactersProperties);

            ParagraphProperties targetParagraphProperties = targetSubDocument.BeginUpdateParagraphs(targetSelectedRange);
            ParagraphProperties sourceParagraphProperties = subDocument.BeginUpdateParagraphs(sourceSelectedRange);
            targetParagraphProperties.Assign(sourceParagraphProperties);
            subDocument.EndUpdateParagraphs(sourceParagraphProperties);
            targetSubDocument.EndUpdateParagraphs(targetParagraphProperties);

            sourceSelectedRange.EndUpdateDocument(subDocument);
            targetSelectedRange.EndUpdateDocument(targetSubDocument);
            this.EndUpdate();
        }
    }

    /// <summary>
    /// Iner Control Ex
    /// </summary>
    public class InnerControlEx : InnerRichEditControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="owner"></param>
        public InnerControlEx(IInnerRichEditControlOwner owner) : base(owner)
        {
        }

        /// <summary>
        /// Mouse Cursor Calculator
        /// </summary>
        /// <returns></returns>
        protected override MouseCursorCalculator CreateMouseCursorCalculator() =>
            new MouseCursorCalculatorEx(ActiveView);
    }

    /// <summary>
    /// Mouse Cursor Calculator Ex
    /// </summary>
    public class MouseCursorCalculatorEx : MouseCursorCalculator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="view"></param>
        public MouseCursorCalculatorEx(RichEditView view) : base(view)
        {
        }

        /// <summary>
        /// Calculate Cursor for RichEdit
        /// </summary>
        /// <param name="hitTestResult"></param>
        /// <param name="physicalPoint"></param>
        /// <returns></returns>
        public override IPortableCursor Calculate(RichEditHitTestResultCore hitTestResult, Point physicalPoint)
        {
            if ((View.Control as RichEditControlEx).FormatCalculatorEnabled)
                return DevExpress.XtraRichEdit.Utils.RichEditCursors.Hand;

            return base.Calculate(hitTestResult, physicalPoint);
        }
    }
}
