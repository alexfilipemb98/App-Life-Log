using DevExpress.Portable.Input;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Internal;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.XtraRichEdit.Mouse;
using System.ComponentModel;
using System.Drawing;

namespace LifeLog.Components
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
			if (Document == null) return;

			DocumentRange selection = Document.Selection;
			if (selection.Length == 0) return;

			SubDocument doc = selection.BeginUpdateDocument();
			try
			{
				CharacterProperties charProps = doc.BeginUpdateCharacters(selection);
				ParagraphProperties paraProps = doc.BeginUpdateParagraphs(selection);

				try
				{
					savedFormatting = new TextFormattingSnapshot
					{
						FontName = charProps.FontName,
						FontSize = charProps.FontSize,
						Bold = charProps.Bold,
						Italic = charProps.Italic,
						Underline = charProps.Underline,
						Strikeout = charProps.Strikeout,
						ForeColor = charProps.ForeColor,
						BackColor = charProps.BackColor,
						Alignment = paraProps.Alignment,
						LineSpacing = paraProps.LineSpacing
					};
				}
				finally
				{
					doc.EndUpdateCharacters(charProps);
					doc.EndUpdateParagraphs(paraProps);
				}
			}
			finally
			{
				selection.EndUpdateDocument(doc);
			}
		}

		/// <summary>
		/// Apply saved formatting to current selection
		/// </summary>
		public void ApplySavedFormat()
		{
			if (savedFormatting == null || Document == null) return;

			DocumentRange selection = Document.Selection;
			if (selection.Length == 0) return;

			SubDocument doc = selection.BeginUpdateDocument();
			try
			{
				CharacterProperties charProps = doc.BeginUpdateCharacters(selection);
				try
				{
					if (!string.IsNullOrEmpty(savedFormatting.FontName))
						charProps.FontName = savedFormatting.FontName;

					if (savedFormatting.FontSize.HasValue)
						charProps.FontSize = savedFormatting.FontSize.Value;

					if (savedFormatting.Bold.HasValue)
						charProps.Bold = savedFormatting.Bold.Value;

					if (savedFormatting.Italic.HasValue)
						charProps.Italic = savedFormatting.Italic.Value;

					if (savedFormatting.Underline.HasValue)
						charProps.Underline = savedFormatting.Underline.Value;

					if (savedFormatting.Strikeout.HasValue)
						charProps.Strikeout = savedFormatting.Strikeout.Value;

					if (savedFormatting.ForeColor.HasValue)
						charProps.ForeColor = savedFormatting.ForeColor.Value;

					if (savedFormatting.BackColor.HasValue)
						charProps.BackColor = savedFormatting.BackColor.Value;
				}
				finally
				{
					doc.EndUpdateCharacters(charProps);
				}

				ParagraphProperties paraProps = doc.BeginUpdateParagraphs(selection);
				try
				{
					if (savedFormatting.Alignment.HasValue)
						paraProps.Alignment = savedFormatting.Alignment.Value;

					if (savedFormatting.LineSpacing.HasValue)
						paraProps.LineSpacing = savedFormatting.LineSpacing.Value;
				}
				finally
				{
					doc.EndUpdateParagraphs(paraProps);
				}
			}
			finally
			{
				selection.EndUpdateDocument(doc);
			}
		}
	}

	/// <summary>
	/// Class to store formatting settings (nullable for flexibility)
	/// </summary>
	public class TextFormattingSnapshot
	{
		public string FontName { get; set; } 
		public float? FontSize { get; set; }
		public bool? Bold { get; set; }
		public bool? Italic { get; set; }
		public UnderlineType? Underline { get; set; }
		public StrikeoutType? Strikeout { get; set; }
		public Color? ForeColor { get; set; }
		public Color? BackColor { get; set; }
		public ParagraphAlignment? Alignment { get; set; }
		public float? LineSpacing { get; set; }
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
