using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraRichEdit;

namespace LifeLog.Base.Components
{
    partial class RichEditBarContol
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.recMainBase = new LifeLog.Base.Components.RichEditControlEx();
			this.bmRichToolBar = new DevExpress.XtraBars.BarManager(this.components);
			this.clipboardBar1 = new DevExpress.XtraRichEdit.UI.ClipboardBar();
			this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
			this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
			this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
			this.pasteSpecialItem1 = new DevExpress.XtraRichEdit.UI.PasteSpecialItem();
			this.bciFormatPainter = new DevExpress.XtraBars.BarCheckItem();
			this.fontBar1 = new DevExpress.XtraRichEdit.UI.FontBar();
			this.changeFontNameItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontNameItem();
			this.repositoryItemFontEditRichEdit1 = new DevExpress.XtraRichEdit.UI.RepositoryItemFontEditRichEdit();
			this.changeFontSizeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontSizeItem();
			this.repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
			this.fontSizeIncreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem();
			this.fontSizeDecreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem();
			this.toggleFontBoldItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontBoldItem();
			this.toggleFontItalicItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontItalicItem();
			this.toggleFontUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem();
			this.toggleFontDoubleUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem();
			this.toggleFontStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem();
			this.changeFontColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontColorItem();
			this.changeFontHighlightColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem();
			this.changeTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ChangeTextCaseItem();
			this.makeTextUpperCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem();
			this.makeTextLowerCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem();
			this.capitalizeEachWordCaseItem1 = new DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem();
			this.toggleTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ToggleTextCaseItem();
			this.clearFormattingItem1 = new DevExpress.XtraRichEdit.UI.ClearFormattingItem();
			this.showFontFormItem1 = new DevExpress.XtraRichEdit.UI.ShowFontFormItem();
			this.paragraphBar1 = new DevExpress.XtraRichEdit.UI.ParagraphBar();
			this.toggleBulletedListItem1 = new DevExpress.XtraRichEdit.UI.ToggleBulletedListItem();
			this.toggleNumberingListItem1 = new DevExpress.XtraRichEdit.UI.ToggleNumberingListItem();
			this.toggleMultiLevelListItem1 = new DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem();
			this.decreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.DecreaseIndentItem();
			this.increaseIndentItem1 = new DevExpress.XtraRichEdit.UI.IncreaseIndentItem();
			this.toggleParagraphAlignmentLeftItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem();
			this.toggleParagraphAlignmentCenterItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem();
			this.toggleParagraphAlignmentRightItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem();
			this.toggleParagraphAlignmentJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem();
			this.toggleParagraphAlignmentArabicJustifyGroupItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyGroupItem();
			this.toggleParagraphAlignmentArabicJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyItem();
			this.toggleParagraphAlignmentJustifyLowItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyLowItem();
			this.toggleParagraphAlignmentJustifyMediumItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyMediumItem();
			this.toggleParagraphAlignmentJustifyHighItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyHighItem();
			this.toggleParagraphAlignmentDistributeItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentDistributeItem();
			this.toggleParagraphAlignmentThaiDistributeItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentThaiDistributeItem();
			this.changeParagraphLineSpacingItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem();
			this.setSingleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem();
			this.setSesquialteralParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem();
			this.setDoubleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem();
			this.showLineSpacingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem();
			this.addSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem();
			this.removeSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem();
			this.addSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem();
			this.removeSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem();
			this.changeParagraphBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem();
			this.editingBar1 = new DevExpress.XtraRichEdit.UI.EditingBar();
			this.findItem1 = new DevExpress.XtraRichEdit.UI.FindItem();
			this.replaceItem1 = new DevExpress.XtraRichEdit.UI.ReplaceItem();
			this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
			this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
			this.panelControl = new DevExpress.XtraEditors.PanelControl();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.richEditBarController = new DevExpress.XtraRichEdit.UI.RichEditBarController(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bmRichToolBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEditRichEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
			this.panelControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.richEditBarController)).BeginInit();
			this.SuspendLayout();
			// 
			// recMainBase
			// 
			this.recMainBase.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
			this.recMainBase.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.recMainBase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.recMainBase.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
			this.recMainBase.Location = new System.Drawing.Point(0, 103);
			this.recMainBase.Margin = new System.Windows.Forms.Padding(0);
			this.recMainBase.MenuManager = this.bmRichToolBar;
			this.recMainBase.Name = "recMainBase";
			this.recMainBase.Options.AutoCorrect.UseSpellCheckerSuggestions = true;
			this.recMainBase.Options.DocumentCapabilities.FootNotes = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
			this.recMainBase.Options.DocumentCapabilities.HeadersFooters = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
			this.recMainBase.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
			this.recMainBase.Options.DocumentSaveOptions.DefaultFormat = DevExpress.XtraRichEdit.DocumentFormat.Undefined;
			this.recMainBase.Options.HorizontalRuler.ShowLeftIndent = false;
			this.recMainBase.Options.HorizontalRuler.ShowRightIndent = false;
			this.recMainBase.Options.HorizontalRuler.ShowTabs = false;
			this.recMainBase.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
			this.recMainBase.Size = new System.Drawing.Size(760, 361);
			this.recMainBase.TabIndex = 4;
			this.recMainBase.Views.SimpleView.AdjustColorsToSkins = true;
			this.recMainBase.Views.SimpleView.AllowDisplayLineNumbers = true;
			// 
			// bmRichToolBar
			// 
			this.bmRichToolBar.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.clipboardBar1,
            this.fontBar1,
            this.paragraphBar1,
            this.editingBar1});
			this.bmRichToolBar.DockControls.Add(this.barDockControl1);
			this.bmRichToolBar.DockControls.Add(this.barDockControl2);
			this.bmRichToolBar.DockControls.Add(this.barDockControl3);
			this.bmRichToolBar.DockControls.Add(this.barDockControl4);
			this.bmRichToolBar.Form = this.panelControl;
			this.bmRichToolBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.pasteItem1,
            this.cutItem1,
            this.copyItem1,
            this.pasteSpecialItem1,
            this.changeFontNameItem1,
            this.changeFontSizeItem1,
            this.fontSizeIncreaseItem1,
            this.fontSizeDecreaseItem1,
            this.toggleFontBoldItem1,
            this.toggleFontItalicItem1,
            this.toggleFontUnderlineItem1,
            this.toggleFontDoubleUnderlineItem1,
            this.toggleFontStrikeoutItem1,
            this.changeFontColorItem1,
            this.changeFontHighlightColorItem1,
            this.changeTextCaseItem1,
            this.makeTextUpperCaseItem1,
            this.makeTextLowerCaseItem1,
            this.capitalizeEachWordCaseItem1,
            this.toggleTextCaseItem1,
            this.clearFormattingItem1,
            this.showFontFormItem1,
            this.toggleBulletedListItem1,
            this.toggleNumberingListItem1,
            this.toggleMultiLevelListItem1,
            this.decreaseIndentItem1,
            this.increaseIndentItem1,
            this.toggleParagraphAlignmentLeftItem1,
            this.toggleParagraphAlignmentCenterItem1,
            this.toggleParagraphAlignmentRightItem1,
            this.toggleParagraphAlignmentJustifyItem1,
            this.toggleParagraphAlignmentArabicJustifyGroupItem1,
            this.toggleParagraphAlignmentArabicJustifyItem1,
            this.toggleParagraphAlignmentJustifyLowItem1,
            this.toggleParagraphAlignmentJustifyMediumItem1,
            this.toggleParagraphAlignmentJustifyHighItem1,
            this.toggleParagraphAlignmentDistributeItem1,
            this.toggleParagraphAlignmentThaiDistributeItem1,
            this.changeParagraphLineSpacingItem1,
            this.setSingleParagraphSpacingItem1,
            this.setSesquialteralParagraphSpacingItem1,
            this.setDoubleParagraphSpacingItem1,
            this.showLineSpacingFormItem1,
            this.addSpacingBeforeParagraphItem1,
            this.removeSpacingBeforeParagraphItem1,
            this.addSpacingAfterParagraphItem1,
            this.removeSpacingAfterParagraphItem1,
            this.changeParagraphBackColorItem1,
            this.findItem1,
            this.replaceItem1,
            this.bciFormatPainter});
			this.bmRichToolBar.MaxItemId = 72;
			this.bmRichToolBar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEditRichEdit1,
            this.repositoryItemRichEditFontSizeEdit1});
			// 
			// clipboardBar1
			// 
			this.clipboardBar1.Control = this.recMainBase;
			this.clipboardBar1.DockCol = 0;
			this.clipboardBar1.DockRow = 0;
			this.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.clipboardBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.pasteItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "V", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.cutItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "X", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.copyItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "C", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.pasteSpecialItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bciFormatPainter, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.clipboardBar1.OptionsBar.AllowQuickCustomization = false;
			this.clipboardBar1.OptionsBar.DisableCustomization = true;
			this.clipboardBar1.OptionsBar.DrawDragBorder = false;
			// 
			// pasteItem1
			// 
			this.pasteItem1.Id = 0;
			this.pasteItem1.Name = "pasteItem1";
			// 
			// cutItem1
			// 
			this.cutItem1.Id = 1;
			this.cutItem1.Name = "cutItem1";
			// 
			// copyItem1
			// 
			this.copyItem1.Id = 2;
			this.copyItem1.Name = "copyItem1";
			// 
			// pasteSpecialItem1
			// 
			this.pasteSpecialItem1.Id = 3;
			this.pasteSpecialItem1.Name = "pasteSpecialItem1";
			// 
			// bciFormatPainter
			// 
			this.bciFormatPainter.Caption = "Format Painter";
			this.bciFormatPainter.Id = 69;
			this.bciFormatPainter.ImageOptions.SvgImage = global::LifeLog.Base.Components.Properties.Resources.extractstyle;
			this.bciFormatPainter.Name = "bciFormatPainter";
			// 
			// fontBar1
			// 
			this.fontBar1.Control = this.recMainBase;
			this.fontBar1.DockCol = 0;
			this.fontBar1.DockRow = 2;
			this.fontBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.fontBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.changeFontNameItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "FF", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeFontSizeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.fontSizeIncreaseItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "FG", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.fontSizeDecreaseItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "FK", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontBoldItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontItalicItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontUnderlineItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontDoubleUnderlineItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontStrikeoutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.changeFontColorItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "FC", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.changeFontHighlightColorItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "I", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeTextCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.clearFormattingItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "E", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.showFontFormItem1)});
			this.fontBar1.OptionsBar.AllowQuickCustomization = false;
			this.fontBar1.OptionsBar.DisableCustomization = true;
			this.fontBar1.OptionsBar.DrawDragBorder = false;
			this.fontBar1.OptionsBar.UseWholeRow = true;
			// 
			// changeFontNameItem1
			// 
			this.changeFontNameItem1.Edit = this.repositoryItemFontEditRichEdit1;
			this.changeFontNameItem1.Id = 4;
			this.changeFontNameItem1.Name = "changeFontNameItem1";
			// 
			// repositoryItemFontEditRichEdit1
			// 
			this.repositoryItemFontEditRichEdit1.AutoHeight = false;
			this.repositoryItemFontEditRichEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemFontEditRichEdit1.Name = "repositoryItemFontEditRichEdit1";
			// 
			// changeFontSizeItem1
			// 
			this.changeFontSizeItem1.Edit = this.repositoryItemRichEditFontSizeEdit1;
			this.changeFontSizeItem1.Id = 5;
			this.changeFontSizeItem1.Name = "changeFontSizeItem1";
			// 
			// repositoryItemRichEditFontSizeEdit1
			// 
			this.repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
			this.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemRichEditFontSizeEdit1.Control = this.recMainBase;
			this.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
			// 
			// fontSizeIncreaseItem1
			// 
			this.fontSizeIncreaseItem1.Id = 6;
			this.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1";
			// 
			// fontSizeDecreaseItem1
			// 
			this.fontSizeDecreaseItem1.Id = 7;
			this.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1";
			// 
			// toggleFontBoldItem1
			// 
			this.toggleFontBoldItem1.Id = 8;
			this.toggleFontBoldItem1.Name = "toggleFontBoldItem1";
			// 
			// toggleFontItalicItem1
			// 
			this.toggleFontItalicItem1.Id = 9;
			this.toggleFontItalicItem1.Name = "toggleFontItalicItem1";
			// 
			// toggleFontUnderlineItem1
			// 
			this.toggleFontUnderlineItem1.Id = 10;
			this.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1";
			// 
			// toggleFontDoubleUnderlineItem1
			// 
			this.toggleFontDoubleUnderlineItem1.Id = 11;
			this.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1";
			// 
			// toggleFontStrikeoutItem1
			// 
			this.toggleFontStrikeoutItem1.Id = 12;
			this.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1";
			// 
			// changeFontColorItem1
			// 
			this.changeFontColorItem1.Id = 16;
			this.changeFontColorItem1.Name = "changeFontColorItem1";
			// 
			// changeFontHighlightColorItem1
			// 
			this.changeFontHighlightColorItem1.Id = 17;
			this.changeFontHighlightColorItem1.Name = "changeFontHighlightColorItem1";
			// 
			// changeTextCaseItem1
			// 
			this.changeTextCaseItem1.Id = 18;
			this.changeTextCaseItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextUpperCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextLowerCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.capitalizeEachWordCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTextCaseItem1)});
			this.changeTextCaseItem1.Name = "changeTextCaseItem1";
			// 
			// makeTextUpperCaseItem1
			// 
			this.makeTextUpperCaseItem1.Id = 19;
			this.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1";
			// 
			// makeTextLowerCaseItem1
			// 
			this.makeTextLowerCaseItem1.Id = 20;
			this.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1";
			// 
			// capitalizeEachWordCaseItem1
			// 
			this.capitalizeEachWordCaseItem1.Id = 21;
			this.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1";
			// 
			// toggleTextCaseItem1
			// 
			this.toggleTextCaseItem1.Id = 22;
			this.toggleTextCaseItem1.Name = "toggleTextCaseItem1";
			// 
			// clearFormattingItem1
			// 
			this.clearFormattingItem1.Id = 23;
			this.clearFormattingItem1.Name = "clearFormattingItem1";
			// 
			// showFontFormItem1
			// 
			this.showFontFormItem1.Id = 24;
			this.showFontFormItem1.Name = "showFontFormItem1";
			// 
			// paragraphBar1
			// 
			this.paragraphBar1.Control = this.recMainBase;
			this.paragraphBar1.DockCol = 0;
			this.paragraphBar1.DockRow = 1;
			this.paragraphBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.paragraphBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleBulletedListItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "U", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleNumberingListItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "N", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleMultiLevelListItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "M", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.decreaseIndentItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AO", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.increaseIndentItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AI", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleParagraphAlignmentLeftItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AL", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleParagraphAlignmentCenterItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AC", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleParagraphAlignmentRightItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AR", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleParagraphAlignmentJustifyItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AJ", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentArabicJustifyGroupItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentDistributeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentThaiDistributeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.changeParagraphLineSpacingItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "K", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.changeParagraphBackColorItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "H", "")});
			this.paragraphBar1.OptionsBar.AllowQuickCustomization = false;
			this.paragraphBar1.OptionsBar.DisableCustomization = true;
			this.paragraphBar1.OptionsBar.DrawDragBorder = false;
			this.paragraphBar1.OptionsBar.UseWholeRow = true;
			// 
			// toggleBulletedListItem1
			// 
			this.toggleBulletedListItem1.Id = 25;
			this.toggleBulletedListItem1.Name = "toggleBulletedListItem1";
			// 
			// toggleNumberingListItem1
			// 
			this.toggleNumberingListItem1.Id = 26;
			this.toggleNumberingListItem1.Name = "toggleNumberingListItem1";
			// 
			// toggleMultiLevelListItem1
			// 
			this.toggleMultiLevelListItem1.Id = 27;
			this.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1";
			// 
			// decreaseIndentItem1
			// 
			this.decreaseIndentItem1.Id = 28;
			this.decreaseIndentItem1.Name = "decreaseIndentItem1";
			// 
			// increaseIndentItem1
			// 
			this.increaseIndentItem1.Id = 29;
			this.increaseIndentItem1.Name = "increaseIndentItem1";
			// 
			// toggleParagraphAlignmentLeftItem1
			// 
			this.toggleParagraphAlignmentLeftItem1.Id = 37;
			this.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1";
			// 
			// toggleParagraphAlignmentCenterItem1
			// 
			this.toggleParagraphAlignmentCenterItem1.Id = 38;
			this.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1";
			// 
			// toggleParagraphAlignmentRightItem1
			// 
			this.toggleParagraphAlignmentRightItem1.Id = 39;
			this.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1";
			// 
			// toggleParagraphAlignmentJustifyItem1
			// 
			this.toggleParagraphAlignmentJustifyItem1.Id = 40;
			this.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1";
			// 
			// toggleParagraphAlignmentArabicJustifyGroupItem1
			// 
			this.toggleParagraphAlignmentArabicJustifyGroupItem1.Id = 41;
			this.toggleParagraphAlignmentArabicJustifyGroupItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleParagraphAlignmentArabicJustifyItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AJ", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentJustifyLowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentJustifyMediumItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentJustifyHighItem1)});
			this.toggleParagraphAlignmentArabicJustifyGroupItem1.Name = "toggleParagraphAlignmentArabicJustifyGroupItem1";
			// 
			// toggleParagraphAlignmentArabicJustifyItem1
			// 
			this.toggleParagraphAlignmentArabicJustifyItem1.Id = 42;
			this.toggleParagraphAlignmentArabicJustifyItem1.Name = "toggleParagraphAlignmentArabicJustifyItem1";
			// 
			// toggleParagraphAlignmentJustifyLowItem1
			// 
			this.toggleParagraphAlignmentJustifyLowItem1.Id = 43;
			this.toggleParagraphAlignmentJustifyLowItem1.Name = "toggleParagraphAlignmentJustifyLowItem1";
			// 
			// toggleParagraphAlignmentJustifyMediumItem1
			// 
			this.toggleParagraphAlignmentJustifyMediumItem1.Id = 44;
			this.toggleParagraphAlignmentJustifyMediumItem1.Name = "toggleParagraphAlignmentJustifyMediumItem1";
			// 
			// toggleParagraphAlignmentJustifyHighItem1
			// 
			this.toggleParagraphAlignmentJustifyHighItem1.Id = 45;
			this.toggleParagraphAlignmentJustifyHighItem1.Name = "toggleParagraphAlignmentJustifyHighItem1";
			// 
			// toggleParagraphAlignmentDistributeItem1
			// 
			this.toggleParagraphAlignmentDistributeItem1.Id = 46;
			this.toggleParagraphAlignmentDistributeItem1.Name = "toggleParagraphAlignmentDistributeItem1";
			// 
			// toggleParagraphAlignmentThaiDistributeItem1
			// 
			this.toggleParagraphAlignmentThaiDistributeItem1.Id = 47;
			this.toggleParagraphAlignmentThaiDistributeItem1.Name = "toggleParagraphAlignmentThaiDistributeItem1";
			// 
			// changeParagraphLineSpacingItem1
			// 
			this.changeParagraphLineSpacingItem1.Id = 49;
			this.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSingleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSesquialteralParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setDoubleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showLineSpacingFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.addSpacingBeforeParagraphItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "B", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addSpacingAfterParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingAfterParagraphItem1)});
			this.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1";
			// 
			// setSingleParagraphSpacingItem1
			// 
			this.setSingleParagraphSpacingItem1.Id = 50;
			this.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1";
			// 
			// setSesquialteralParagraphSpacingItem1
			// 
			this.setSesquialteralParagraphSpacingItem1.Id = 51;
			this.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1";
			// 
			// setDoubleParagraphSpacingItem1
			// 
			this.setDoubleParagraphSpacingItem1.Id = 52;
			this.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1";
			// 
			// showLineSpacingFormItem1
			// 
			this.showLineSpacingFormItem1.Id = 53;
			this.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1";
			// 
			// addSpacingBeforeParagraphItem1
			// 
			this.addSpacingBeforeParagraphItem1.Id = 54;
			this.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1";
			// 
			// removeSpacingBeforeParagraphItem1
			// 
			this.removeSpacingBeforeParagraphItem1.Id = 55;
			this.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1";
			// 
			// addSpacingAfterParagraphItem1
			// 
			this.addSpacingAfterParagraphItem1.Id = 56;
			this.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1";
			// 
			// removeSpacingAfterParagraphItem1
			// 
			this.removeSpacingAfterParagraphItem1.Id = 57;
			this.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1";
			// 
			// changeParagraphBackColorItem1
			// 
			this.changeParagraphBackColorItem1.Id = 58;
			this.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1";
			// 
			// editingBar1
			// 
			this.editingBar1.Control = this.recMainBase;
			this.editingBar1.DockCol = 1;
			this.editingBar1.DockRow = 0;
			this.editingBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.editingBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.findItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.replaceItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "R", "")});
			this.editingBar1.Offset = 254;
			this.editingBar1.OptionsBar.AllowQuickCustomization = false;
			this.editingBar1.OptionsBar.DisableCustomization = true;
			this.editingBar1.OptionsBar.DrawDragBorder = false;
			// 
			// findItem1
			// 
			this.findItem1.Id = 62;
			this.findItem1.Name = "findItem1";
			// 
			// replaceItem1
			// 
			this.replaceItem1.Id = 63;
			this.replaceItem1.Name = "replaceItem1";
			// 
			// barDockControl1
			// 
			this.barDockControl1.CausesValidation = false;
			this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControl1.Location = new System.Drawing.Point(0, 0);
			this.barDockControl1.Manager = this.bmRichToolBar;
			this.barDockControl1.Size = new System.Drawing.Size(760, 103);
			// 
			// barDockControl2
			// 
			this.barDockControl2.CausesValidation = false;
			this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControl2.Location = new System.Drawing.Point(0, 464);
			this.barDockControl2.Manager = this.bmRichToolBar;
			this.barDockControl2.Size = new System.Drawing.Size(760, 0);
			// 
			// barDockControl3
			// 
			this.barDockControl3.CausesValidation = false;
			this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControl3.Location = new System.Drawing.Point(0, 103);
			this.barDockControl3.Manager = this.bmRichToolBar;
			this.barDockControl3.Size = new System.Drawing.Size(0, 361);
			// 
			// barDockControl4
			// 
			this.barDockControl4.CausesValidation = false;
			this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControl4.Location = new System.Drawing.Point(760, 103);
			this.barDockControl4.Manager = this.bmRichToolBar;
			this.barDockControl4.Size = new System.Drawing.Size(0, 361);
			// 
			// panelControl
			// 
			this.panelControl.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.panelControl.Appearance.Options.UseBackColor = true;
			this.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl.Controls.Add(this.recMainBase);
			this.panelControl.Controls.Add(this.barDockControl3);
			this.panelControl.Controls.Add(this.barDockControl4);
			this.panelControl.Controls.Add(this.barDockControl2);
			this.panelControl.Controls.Add(this.barDockControl1);
			this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl.Location = new System.Drawing.Point(0, 0);
			this.panelControl.Name = "panelControl";
			this.panelControl.Size = new System.Drawing.Size(760, 464);
			this.panelControl.TabIndex = 5;
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			// 
			// richEditBarController
			// 
			this.richEditBarController.BarItems.Add(this.pasteItem1);
			this.richEditBarController.BarItems.Add(this.cutItem1);
			this.richEditBarController.BarItems.Add(this.copyItem1);
			this.richEditBarController.BarItems.Add(this.pasteSpecialItem1);
			this.richEditBarController.BarItems.Add(this.changeFontNameItem1);
			this.richEditBarController.BarItems.Add(this.changeFontSizeItem1);
			this.richEditBarController.BarItems.Add(this.fontSizeIncreaseItem1);
			this.richEditBarController.BarItems.Add(this.fontSizeDecreaseItem1);
			this.richEditBarController.BarItems.Add(this.toggleFontBoldItem1);
			this.richEditBarController.BarItems.Add(this.toggleFontItalicItem1);
			this.richEditBarController.BarItems.Add(this.toggleFontUnderlineItem1);
			this.richEditBarController.BarItems.Add(this.toggleFontDoubleUnderlineItem1);
			this.richEditBarController.BarItems.Add(this.toggleFontStrikeoutItem1);
			this.richEditBarController.BarItems.Add(this.changeFontColorItem1);
			this.richEditBarController.BarItems.Add(this.changeFontHighlightColorItem1);
			this.richEditBarController.BarItems.Add(this.makeTextUpperCaseItem1);
			this.richEditBarController.BarItems.Add(this.makeTextLowerCaseItem1);
			this.richEditBarController.BarItems.Add(this.capitalizeEachWordCaseItem1);
			this.richEditBarController.BarItems.Add(this.toggleTextCaseItem1);
			this.richEditBarController.BarItems.Add(this.changeTextCaseItem1);
			this.richEditBarController.BarItems.Add(this.clearFormattingItem1);
			this.richEditBarController.BarItems.Add(this.showFontFormItem1);
			this.richEditBarController.BarItems.Add(this.toggleBulletedListItem1);
			this.richEditBarController.BarItems.Add(this.toggleNumberingListItem1);
			this.richEditBarController.BarItems.Add(this.toggleMultiLevelListItem1);
			this.richEditBarController.BarItems.Add(this.decreaseIndentItem1);
			this.richEditBarController.BarItems.Add(this.increaseIndentItem1);
			this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentLeftItem1);
			this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentCenterItem1);
			this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentRightItem1);
			this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentJustifyItem1);
			this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentArabicJustifyItem1);
			this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentJustifyLowItem1);
			this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentJustifyMediumItem1);
			this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentJustifyHighItem1);
			this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentArabicJustifyGroupItem1);
			this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentDistributeItem1);
			this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentThaiDistributeItem1);
			this.richEditBarController.BarItems.Add(this.setSingleParagraphSpacingItem1);
			this.richEditBarController.BarItems.Add(this.setSesquialteralParagraphSpacingItem1);
			this.richEditBarController.BarItems.Add(this.setDoubleParagraphSpacingItem1);
			this.richEditBarController.BarItems.Add(this.showLineSpacingFormItem1);
			this.richEditBarController.BarItems.Add(this.addSpacingBeforeParagraphItem1);
			this.richEditBarController.BarItems.Add(this.removeSpacingBeforeParagraphItem1);
			this.richEditBarController.BarItems.Add(this.addSpacingAfterParagraphItem1);
			this.richEditBarController.BarItems.Add(this.removeSpacingAfterParagraphItem1);
			this.richEditBarController.BarItems.Add(this.changeParagraphLineSpacingItem1);
			this.richEditBarController.BarItems.Add(this.changeParagraphBackColorItem1);
			this.richEditBarController.BarItems.Add(this.findItem1);
			this.richEditBarController.BarItems.Add(this.replaceItem1);
			this.richEditBarController.Control = this.recMainBase;
			// 
			// RichEditBarContol
			// 
			this.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelControl);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "RichEditBarContol";
			this.Size = new System.Drawing.Size(760, 464);
			((System.ComponentModel.ISupportInitialize)(this.bmRichToolBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEditRichEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
			this.panelControl.ResumeLayout(false);
			this.panelControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.richEditBarController)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl;
        private Components.RichEditControlEx recMainBase;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager bmRichToolBar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraRichEdit.UI.ClipboardBar clipboardBar1;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteSpecialItem pasteSpecialItem1;
        private DevExpress.XtraRichEdit.UI.FontBar fontBar1;
        private DevExpress.XtraRichEdit.UI.ChangeFontNameItem changeFontNameItem1;
        private DevExpress.XtraRichEdit.UI.RepositoryItemFontEditRichEdit repositoryItemFontEditRichEdit1;
        private DevExpress.XtraRichEdit.UI.ChangeFontSizeItem changeFontSizeItem1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;
        private DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem fontSizeIncreaseItem1;
        private DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem fontSizeDecreaseItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontBoldItem toggleFontBoldItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontItalicItem toggleFontItalicItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem toggleFontUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem toggleFontDoubleUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem toggleFontStrikeoutItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFontColorItem changeFontColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem changeFontHighlightColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTextCaseItem changeTextCaseItem1;
        private DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem makeTextUpperCaseItem1;
        private DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem makeTextLowerCaseItem1;
        private DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem capitalizeEachWordCaseItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTextCaseItem toggleTextCaseItem1;
        private DevExpress.XtraRichEdit.UI.ClearFormattingItem clearFormattingItem1;
        private DevExpress.XtraRichEdit.UI.ShowFontFormItem showFontFormItem1;
        private DevExpress.XtraRichEdit.UI.ParagraphBar paragraphBar1;
        private DevExpress.XtraRichEdit.UI.ToggleBulletedListItem toggleBulletedListItem1;
        private DevExpress.XtraRichEdit.UI.ToggleNumberingListItem toggleNumberingListItem1;
        private DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem toggleMultiLevelListItem1;
        private DevExpress.XtraRichEdit.UI.DecreaseIndentItem decreaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.IncreaseIndentItem increaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem toggleParagraphAlignmentLeftItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem toggleParagraphAlignmentCenterItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem toggleParagraphAlignmentRightItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem toggleParagraphAlignmentJustifyItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyGroupItem toggleParagraphAlignmentArabicJustifyGroupItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyItem toggleParagraphAlignmentArabicJustifyItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyLowItem toggleParagraphAlignmentJustifyLowItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyMediumItem toggleParagraphAlignmentJustifyMediumItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyHighItem toggleParagraphAlignmentJustifyHighItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentDistributeItem toggleParagraphAlignmentDistributeItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentThaiDistributeItem toggleParagraphAlignmentThaiDistributeItem1;
        private DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem changeParagraphLineSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem setSingleParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem setSesquialteralParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem setDoubleParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem showLineSpacingFormItem1;
        private DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem addSpacingBeforeParagraphItem1;
        private DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem removeSpacingBeforeParagraphItem1;
        private DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem addSpacingAfterParagraphItem1;
        private DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem removeSpacingAfterParagraphItem1;
        private DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem changeParagraphBackColorItem1;
        private DevExpress.XtraRichEdit.UI.EditingBar editingBar1;
        private DevExpress.XtraRichEdit.UI.FindItem findItem1;
        private DevExpress.XtraRichEdit.UI.ReplaceItem replaceItem1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController;
        private DevExpress.XtraBars.BarCheckItem bciFormatPainter;
    }
}
