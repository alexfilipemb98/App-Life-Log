using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraRichEdit;

namespace Components
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
            components = new System.ComponentModel.Container();
            recMainBase = new RichEditControlEx();
            bmRichToolBar = new BarManager(components);
            clipboardBar1 = new DevExpress.XtraRichEdit.UI.ClipboardBar();
            pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            pasteSpecialItem1 = new DevExpress.XtraRichEdit.UI.PasteSpecialItem();
            bciFormatPainter = new BarCheckItem();
            fontBar1 = new DevExpress.XtraRichEdit.UI.FontBar();
            changeFontNameItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontNameItem();
            repositoryItemFontEditRichEdit1 = new DevExpress.XtraRichEdit.UI.RepositoryItemFontEditRichEdit();
            changeFontSizeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontSizeItem();
            repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            fontSizeIncreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem();
            fontSizeDecreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem();
            toggleFontBoldItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontBoldItem();
            toggleFontItalicItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontItalicItem();
            toggleFontUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem();
            toggleFontDoubleUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem();
            toggleFontStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem();
            changeFontColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontColorItem();
            changeFontHighlightColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem();
            changeTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ChangeTextCaseItem();
            makeTextUpperCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem();
            makeTextLowerCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem();
            capitalizeEachWordCaseItem1 = new DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem();
            toggleTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ToggleTextCaseItem();
            clearFormattingItem1 = new DevExpress.XtraRichEdit.UI.ClearFormattingItem();
            showFontFormItem1 = new DevExpress.XtraRichEdit.UI.ShowFontFormItem();
            paragraphBar1 = new DevExpress.XtraRichEdit.UI.ParagraphBar();
            toggleBulletedListItem1 = new DevExpress.XtraRichEdit.UI.ToggleBulletedListItem();
            toggleNumberingListItem1 = new DevExpress.XtraRichEdit.UI.ToggleNumberingListItem();
            toggleMultiLevelListItem1 = new DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem();
            decreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.DecreaseIndentItem();
            increaseIndentItem1 = new DevExpress.XtraRichEdit.UI.IncreaseIndentItem();
            toggleParagraphAlignmentLeftItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem();
            toggleParagraphAlignmentCenterItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem();
            toggleParagraphAlignmentRightItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem();
            toggleParagraphAlignmentJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem();
            toggleParagraphAlignmentArabicJustifyGroupItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyGroupItem();
            toggleParagraphAlignmentArabicJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyItem();
            toggleParagraphAlignmentJustifyLowItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyLowItem();
            toggleParagraphAlignmentJustifyMediumItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyMediumItem();
            toggleParagraphAlignmentJustifyHighItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyHighItem();
            toggleParagraphAlignmentDistributeItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentDistributeItem();
            toggleParagraphAlignmentThaiDistributeItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentThaiDistributeItem();
            changeParagraphLineSpacingItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem();
            setSingleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem();
            setSesquialteralParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem();
            setDoubleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem();
            showLineSpacingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem();
            addSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem();
            removeSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem();
            addSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem();
            removeSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem();
            changeParagraphBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem();
            editingBar1 = new DevExpress.XtraRichEdit.UI.EditingBar();
            findItem1 = new DevExpress.XtraRichEdit.UI.FindItem();
            replaceItem1 = new DevExpress.XtraRichEdit.UI.ReplaceItem();
            barDockControl1 = new BarDockControl();
            barDockControl2 = new BarDockControl();
            barDockControl3 = new BarDockControl();
            barDockControl4 = new BarDockControl();
            panelControl = new DevExpress.XtraEditors.PanelControl();
            bar3 = new Bar();
            richEditBarController = new DevExpress.XtraRichEdit.UI.RichEditBarController(components);
            ((System.ComponentModel.ISupportInitialize)bmRichToolBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemFontEditRichEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemRichEditFontSizeEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl).BeginInit();
            panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)richEditBarController).BeginInit();
            SuspendLayout();
            // 
            // recMainBase
            // 
            recMainBase.ActiveViewType = RichEditViewType.Simple;
            recMainBase.BorderStyle = BorderStyles.NoBorder;
            recMainBase.Dock = System.Windows.Forms.DockStyle.Fill;
            recMainBase.LayoutUnit = DocumentLayoutUnit.Pixel;
            recMainBase.Location = new System.Drawing.Point(2, 113);
            recMainBase.Margin = new System.Windows.Forms.Padding(0);
            recMainBase.MenuManager = bmRichToolBar;
            recMainBase.Name = "recMainBase";
            recMainBase.Options.AutoCorrect.UseSpellCheckerSuggestions = true;
            recMainBase.Options.DocumentCapabilities.FootNotes = DocumentCapability.Disabled;
            recMainBase.Options.DocumentCapabilities.HeadersFooters = DocumentCapability.Disabled;
            recMainBase.Options.DocumentSaveOptions.CurrentFormat = DocumentFormat.PlainText;
            recMainBase.Options.DocumentSaveOptions.DefaultFormat = DocumentFormat.Undefined;
            recMainBase.Options.HorizontalRuler.ShowLeftIndent = false;
            recMainBase.Options.HorizontalRuler.ShowRightIndent = false;
            recMainBase.Options.HorizontalRuler.ShowTabs = false;
            recMainBase.Options.Printing.PrintPreviewFormKind = PrintPreviewFormKind.Bars;
            recMainBase.Size = new System.Drawing.Size(864, 436);
            recMainBase.TabIndex = 4;
            recMainBase.Views.SimpleView.AdjustColorsToSkins = true;
            recMainBase.Views.SimpleView.AllowDisplayLineNumbers = true;
            recMainBase.MouseUp += recMainBase_MouseUp;
            // 
            // bmRichToolBar
            // 
            bmRichToolBar.Bars.AddRange(new Bar[] { clipboardBar1, fontBar1, paragraphBar1, editingBar1 });
            bmRichToolBar.DockControls.Add(barDockControl1);
            bmRichToolBar.DockControls.Add(barDockControl2);
            bmRichToolBar.DockControls.Add(barDockControl3);
            bmRichToolBar.DockControls.Add(barDockControl4);
            bmRichToolBar.Form = panelControl;
            bmRichToolBar.Items.AddRange(new BarItem[] { pasteItem1, cutItem1, copyItem1, pasteSpecialItem1, changeFontNameItem1, changeFontSizeItem1, fontSizeIncreaseItem1, fontSizeDecreaseItem1, toggleFontBoldItem1, toggleFontItalicItem1, toggleFontUnderlineItem1, toggleFontDoubleUnderlineItem1, toggleFontStrikeoutItem1, changeFontColorItem1, changeFontHighlightColorItem1, changeTextCaseItem1, makeTextUpperCaseItem1, makeTextLowerCaseItem1, capitalizeEachWordCaseItem1, toggleTextCaseItem1, clearFormattingItem1, showFontFormItem1, toggleBulletedListItem1, toggleNumberingListItem1, toggleMultiLevelListItem1, decreaseIndentItem1, increaseIndentItem1, toggleParagraphAlignmentLeftItem1, toggleParagraphAlignmentCenterItem1, toggleParagraphAlignmentRightItem1, toggleParagraphAlignmentJustifyItem1, toggleParagraphAlignmentArabicJustifyGroupItem1, toggleParagraphAlignmentArabicJustifyItem1, toggleParagraphAlignmentJustifyLowItem1, toggleParagraphAlignmentJustifyMediumItem1, toggleParagraphAlignmentJustifyHighItem1, toggleParagraphAlignmentDistributeItem1, toggleParagraphAlignmentThaiDistributeItem1, changeParagraphLineSpacingItem1, setSingleParagraphSpacingItem1, setSesquialteralParagraphSpacingItem1, setDoubleParagraphSpacingItem1, showLineSpacingFormItem1, addSpacingBeforeParagraphItem1, removeSpacingBeforeParagraphItem1, addSpacingAfterParagraphItem1, removeSpacingAfterParagraphItem1, changeParagraphBackColorItem1, findItem1, replaceItem1, bciFormatPainter });
            bmRichToolBar.MaxItemId = 72;
            bmRichToolBar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemFontEditRichEdit1, repositoryItemRichEditFontSizeEdit1 });
            // 
            // clipboardBar1
            // 
            clipboardBar1.Control = recMainBase;
            clipboardBar1.DockCol = 0;
            clipboardBar1.DockRow = 0;
            clipboardBar1.DockStyle = BarDockStyle.Top;
            clipboardBar1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(BarLinkUserDefines.KeyTip, pasteItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "V", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, cutItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "X", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, copyItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "C", ""), new LinkPersistInfo(pasteSpecialItem1), new LinkPersistInfo(BarLinkUserDefines.PaintStyle, bciFormatPainter, "", true, true, true, 0, null, BarItemPaintStyle.CaptionGlyph) });
            clipboardBar1.OptionsBar.AllowQuickCustomization = false;
            clipboardBar1.OptionsBar.DisableCustomization = true;
            clipboardBar1.OptionsBar.DrawDragBorder = false;
            // 
            // pasteItem1
            // 
            pasteItem1.Id = 0;
            pasteItem1.Name = "pasteItem1";
            // 
            // cutItem1
            // 
            cutItem1.Id = 1;
            cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            copyItem1.Id = 2;
            copyItem1.Name = "copyItem1";
            // 
            // pasteSpecialItem1
            // 
            pasteSpecialItem1.Id = 3;
            pasteSpecialItem1.Name = "pasteSpecialItem1";
            // 
            // bciFormatPainter
            // 
            bciFormatPainter.Caption = "Format Painter";
            bciFormatPainter.Id = 69;
            bciFormatPainter.ImageOptions.SvgImage = Properties.Resources.extractstyle;
            bciFormatPainter.Name = "bciFormatPainter";
            bciFormatPainter.ItemClick += bciFormatPainter_ItemClick;
            // 
            // fontBar1
            // 
            fontBar1.Control = recMainBase;
            fontBar1.DockCol = 0;
            fontBar1.DockRow = 2;
            fontBar1.DockStyle = BarDockStyle.Top;
            fontBar1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(BarLinkUserDefines.KeyTip, changeFontNameItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "FF", ""), new LinkPersistInfo(changeFontSizeItem1), new LinkPersistInfo(BarLinkUserDefines.KeyTip, fontSizeIncreaseItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "FG", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, fontSizeDecreaseItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "FK", ""), new LinkPersistInfo(toggleFontBoldItem1), new LinkPersistInfo(toggleFontItalicItem1), new LinkPersistInfo(toggleFontUnderlineItem1), new LinkPersistInfo(toggleFontDoubleUnderlineItem1), new LinkPersistInfo(toggleFontStrikeoutItem1), new LinkPersistInfo(BarLinkUserDefines.KeyTip, changeFontColorItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "FC", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, changeFontHighlightColorItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "I", ""), new LinkPersistInfo(changeTextCaseItem1), new LinkPersistInfo(BarLinkUserDefines.KeyTip, clearFormattingItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "E", ""), new LinkPersistInfo(showFontFormItem1) });
            fontBar1.OptionsBar.AllowQuickCustomization = false;
            fontBar1.OptionsBar.DisableCustomization = true;
            fontBar1.OptionsBar.DrawDragBorder = false;
            fontBar1.OptionsBar.UseWholeRow = true;
            // 
            // changeFontNameItem1
            // 
            changeFontNameItem1.Edit = repositoryItemFontEditRichEdit1;
            changeFontNameItem1.Id = 4;
            changeFontNameItem1.Name = "changeFontNameItem1";
            // 
            // repositoryItemFontEditRichEdit1
            // 
            repositoryItemFontEditRichEdit1.AutoHeight = false;
            repositoryItemFontEditRichEdit1.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            repositoryItemFontEditRichEdit1.Name = "repositoryItemFontEditRichEdit1";
            // 
            // changeFontSizeItem1
            // 
            changeFontSizeItem1.Edit = repositoryItemRichEditFontSizeEdit1;
            changeFontSizeItem1.Id = 5;
            changeFontSizeItem1.Name = "changeFontSizeItem1";
            // 
            // repositoryItemRichEditFontSizeEdit1
            // 
            repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
            repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            repositoryItemRichEditFontSizeEdit1.Control = recMainBase;
            repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
            // 
            // fontSizeIncreaseItem1
            // 
            fontSizeIncreaseItem1.Id = 6;
            fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1";
            // 
            // fontSizeDecreaseItem1
            // 
            fontSizeDecreaseItem1.Id = 7;
            fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1";
            // 
            // toggleFontBoldItem1
            // 
            toggleFontBoldItem1.Id = 8;
            toggleFontBoldItem1.Name = "toggleFontBoldItem1";
            // 
            // toggleFontItalicItem1
            // 
            toggleFontItalicItem1.Id = 9;
            toggleFontItalicItem1.Name = "toggleFontItalicItem1";
            // 
            // toggleFontUnderlineItem1
            // 
            toggleFontUnderlineItem1.Id = 10;
            toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1";
            // 
            // toggleFontDoubleUnderlineItem1
            // 
            toggleFontDoubleUnderlineItem1.Id = 11;
            toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1";
            // 
            // toggleFontStrikeoutItem1
            // 
            toggleFontStrikeoutItem1.Id = 12;
            toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1";
            // 
            // changeFontColorItem1
            // 
            changeFontColorItem1.Id = 16;
            changeFontColorItem1.Name = "changeFontColorItem1";
            // 
            // changeFontHighlightColorItem1
            // 
            changeFontHighlightColorItem1.Id = 17;
            changeFontHighlightColorItem1.Name = "changeFontHighlightColorItem1";
            // 
            // changeTextCaseItem1
            // 
            changeTextCaseItem1.Id = 18;
            changeTextCaseItem1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(makeTextUpperCaseItem1), new LinkPersistInfo(makeTextLowerCaseItem1), new LinkPersistInfo(capitalizeEachWordCaseItem1), new LinkPersistInfo(toggleTextCaseItem1) });
            changeTextCaseItem1.Name = "changeTextCaseItem1";
            // 
            // makeTextUpperCaseItem1
            // 
            makeTextUpperCaseItem1.Id = 19;
            makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1";
            // 
            // makeTextLowerCaseItem1
            // 
            makeTextLowerCaseItem1.Id = 20;
            makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1";
            // 
            // capitalizeEachWordCaseItem1
            // 
            capitalizeEachWordCaseItem1.Id = 21;
            capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1";
            // 
            // toggleTextCaseItem1
            // 
            toggleTextCaseItem1.Id = 22;
            toggleTextCaseItem1.Name = "toggleTextCaseItem1";
            // 
            // clearFormattingItem1
            // 
            clearFormattingItem1.Id = 23;
            clearFormattingItem1.Name = "clearFormattingItem1";
            // 
            // showFontFormItem1
            // 
            showFontFormItem1.Id = 24;
            showFontFormItem1.Name = "showFontFormItem1";
            // 
            // paragraphBar1
            // 
            paragraphBar1.Control = recMainBase;
            paragraphBar1.DockCol = 0;
            paragraphBar1.DockRow = 1;
            paragraphBar1.DockStyle = BarDockStyle.Top;
            paragraphBar1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(BarLinkUserDefines.KeyTip, toggleBulletedListItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "U", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, toggleNumberingListItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "N", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, toggleMultiLevelListItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "M", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, decreaseIndentItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "AO", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, increaseIndentItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "AI", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, toggleParagraphAlignmentLeftItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "AL", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, toggleParagraphAlignmentCenterItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "AC", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, toggleParagraphAlignmentRightItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "AR", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, toggleParagraphAlignmentJustifyItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "AJ", ""), new LinkPersistInfo(toggleParagraphAlignmentArabicJustifyGroupItem1), new LinkPersistInfo(toggleParagraphAlignmentDistributeItem1), new LinkPersistInfo(toggleParagraphAlignmentThaiDistributeItem1), new LinkPersistInfo(BarLinkUserDefines.KeyTip, changeParagraphLineSpacingItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "K", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, changeParagraphBackColorItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "H", "") });
            paragraphBar1.OptionsBar.AllowQuickCustomization = false;
            paragraphBar1.OptionsBar.DisableCustomization = true;
            paragraphBar1.OptionsBar.DrawDragBorder = false;
            paragraphBar1.OptionsBar.UseWholeRow = true;
            // 
            // toggleBulletedListItem1
            // 
            toggleBulletedListItem1.Id = 25;
            toggleBulletedListItem1.Name = "toggleBulletedListItem1";
            // 
            // toggleNumberingListItem1
            // 
            toggleNumberingListItem1.Id = 26;
            toggleNumberingListItem1.Name = "toggleNumberingListItem1";
            // 
            // toggleMultiLevelListItem1
            // 
            toggleMultiLevelListItem1.Id = 27;
            toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1";
            // 
            // decreaseIndentItem1
            // 
            decreaseIndentItem1.Id = 28;
            decreaseIndentItem1.Name = "decreaseIndentItem1";
            // 
            // increaseIndentItem1
            // 
            increaseIndentItem1.Id = 29;
            increaseIndentItem1.Name = "increaseIndentItem1";
            // 
            // toggleParagraphAlignmentLeftItem1
            // 
            toggleParagraphAlignmentLeftItem1.Id = 37;
            toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1";
            // 
            // toggleParagraphAlignmentCenterItem1
            // 
            toggleParagraphAlignmentCenterItem1.Id = 38;
            toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1";
            // 
            // toggleParagraphAlignmentRightItem1
            // 
            toggleParagraphAlignmentRightItem1.Id = 39;
            toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1";
            // 
            // toggleParagraphAlignmentJustifyItem1
            // 
            toggleParagraphAlignmentJustifyItem1.Id = 40;
            toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1";
            // 
            // toggleParagraphAlignmentArabicJustifyGroupItem1
            // 
            toggleParagraphAlignmentArabicJustifyGroupItem1.Id = 41;
            toggleParagraphAlignmentArabicJustifyGroupItem1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(BarLinkUserDefines.KeyTip, toggleParagraphAlignmentArabicJustifyItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "AJ", ""), new LinkPersistInfo(toggleParagraphAlignmentJustifyLowItem1), new LinkPersistInfo(toggleParagraphAlignmentJustifyMediumItem1), new LinkPersistInfo(toggleParagraphAlignmentJustifyHighItem1) });
            toggleParagraphAlignmentArabicJustifyGroupItem1.Name = "toggleParagraphAlignmentArabicJustifyGroupItem1";
            // 
            // toggleParagraphAlignmentArabicJustifyItem1
            // 
            toggleParagraphAlignmentArabicJustifyItem1.Id = 42;
            toggleParagraphAlignmentArabicJustifyItem1.Name = "toggleParagraphAlignmentArabicJustifyItem1";
            // 
            // toggleParagraphAlignmentJustifyLowItem1
            // 
            toggleParagraphAlignmentJustifyLowItem1.Id = 43;
            toggleParagraphAlignmentJustifyLowItem1.Name = "toggleParagraphAlignmentJustifyLowItem1";
            // 
            // toggleParagraphAlignmentJustifyMediumItem1
            // 
            toggleParagraphAlignmentJustifyMediumItem1.Id = 44;
            toggleParagraphAlignmentJustifyMediumItem1.Name = "toggleParagraphAlignmentJustifyMediumItem1";
            // 
            // toggleParagraphAlignmentJustifyHighItem1
            // 
            toggleParagraphAlignmentJustifyHighItem1.Id = 45;
            toggleParagraphAlignmentJustifyHighItem1.Name = "toggleParagraphAlignmentJustifyHighItem1";
            // 
            // toggleParagraphAlignmentDistributeItem1
            // 
            toggleParagraphAlignmentDistributeItem1.Id = 46;
            toggleParagraphAlignmentDistributeItem1.Name = "toggleParagraphAlignmentDistributeItem1";
            // 
            // toggleParagraphAlignmentThaiDistributeItem1
            // 
            toggleParagraphAlignmentThaiDistributeItem1.Id = 47;
            toggleParagraphAlignmentThaiDistributeItem1.Name = "toggleParagraphAlignmentThaiDistributeItem1";
            // 
            // changeParagraphLineSpacingItem1
            // 
            changeParagraphLineSpacingItem1.Id = 49;
            changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(setSingleParagraphSpacingItem1), new LinkPersistInfo(setSesquialteralParagraphSpacingItem1), new LinkPersistInfo(setDoubleParagraphSpacingItem1), new LinkPersistInfo(showLineSpacingFormItem1), new LinkPersistInfo(BarLinkUserDefines.KeyTip, addSpacingBeforeParagraphItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "B", ""), new LinkPersistInfo(removeSpacingBeforeParagraphItem1), new LinkPersistInfo(addSpacingAfterParagraphItem1), new LinkPersistInfo(removeSpacingAfterParagraphItem1) });
            changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1";
            // 
            // setSingleParagraphSpacingItem1
            // 
            setSingleParagraphSpacingItem1.Id = 50;
            setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1";
            // 
            // setSesquialteralParagraphSpacingItem1
            // 
            setSesquialteralParagraphSpacingItem1.Id = 51;
            setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1";
            // 
            // setDoubleParagraphSpacingItem1
            // 
            setDoubleParagraphSpacingItem1.Id = 52;
            setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1";
            // 
            // showLineSpacingFormItem1
            // 
            showLineSpacingFormItem1.Id = 53;
            showLineSpacingFormItem1.Name = "showLineSpacingFormItem1";
            // 
            // addSpacingBeforeParagraphItem1
            // 
            addSpacingBeforeParagraphItem1.Id = 54;
            addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1";
            // 
            // removeSpacingBeforeParagraphItem1
            // 
            removeSpacingBeforeParagraphItem1.Id = 55;
            removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1";
            // 
            // addSpacingAfterParagraphItem1
            // 
            addSpacingAfterParagraphItem1.Id = 56;
            addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1";
            // 
            // removeSpacingAfterParagraphItem1
            // 
            removeSpacingAfterParagraphItem1.Id = 57;
            removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1";
            // 
            // changeParagraphBackColorItem1
            // 
            changeParagraphBackColorItem1.Id = 58;
            changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1";
            // 
            // editingBar1
            // 
            editingBar1.Control = recMainBase;
            editingBar1.DockCol = 1;
            editingBar1.DockRow = 0;
            editingBar1.DockStyle = BarDockStyle.Top;
            editingBar1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(BarLinkUserDefines.KeyTip, findItem1, "", true, true, true, 0, null, BarItemPaintStyle.Standard, "", ""), new LinkPersistInfo(BarLinkUserDefines.KeyTip, replaceItem1, "", false, true, true, 0, null, BarItemPaintStyle.Standard, "R", "") });
            editingBar1.Offset = 254;
            editingBar1.OptionsBar.AllowQuickCustomization = false;
            editingBar1.OptionsBar.DisableCustomization = true;
            editingBar1.OptionsBar.DrawDragBorder = false;
            // 
            // findItem1
            // 
            findItem1.Id = 62;
            findItem1.Name = "findItem1";
            // 
            // replaceItem1
            // 
            replaceItem1.Id = 63;
            replaceItem1.Name = "replaceItem1";
            // 
            // barDockControl1
            // 
            barDockControl1.CausesValidation = false;
            barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControl1.Location = new System.Drawing.Point(2, 2);
            barDockControl1.Manager = bmRichToolBar;
            barDockControl1.Size = new System.Drawing.Size(864, 111);
            // 
            // barDockControl2
            // 
            barDockControl2.CausesValidation = false;
            barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControl2.Location = new System.Drawing.Point(2, 549);
            barDockControl2.Manager = bmRichToolBar;
            barDockControl2.Size = new System.Drawing.Size(864, 0);
            // 
            // barDockControl3
            // 
            barDockControl3.CausesValidation = false;
            barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControl3.Location = new System.Drawing.Point(2, 113);
            barDockControl3.Manager = bmRichToolBar;
            barDockControl3.Size = new System.Drawing.Size(0, 436);
            // 
            // barDockControl4
            // 
            barDockControl4.CausesValidation = false;
            barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControl4.Location = new System.Drawing.Point(866, 113);
            barDockControl4.Manager = bmRichToolBar;
            barDockControl4.Size = new System.Drawing.Size(0, 436);
            // 
            // panelControl
            // 
            panelControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            panelControl.Appearance.Options.UseBackColor = true;
            panelControl.BorderStyle = BorderStyles.NoBorder;
            panelControl.Controls.Add(recMainBase);
            panelControl.Controls.Add(barDockControl3);
            panelControl.Controls.Add(barDockControl4);
            panelControl.Controls.Add(barDockControl2);
            panelControl.Controls.Add(barDockControl1);
            panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl.Location = new System.Drawing.Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new System.Drawing.Size(868, 551);
            panelControl.TabIndex = 5;
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // richEditBarController
            // 
            richEditBarController.BarItems.Add(pasteItem1);
            richEditBarController.BarItems.Add(cutItem1);
            richEditBarController.BarItems.Add(copyItem1);
            richEditBarController.BarItems.Add(pasteSpecialItem1);
            richEditBarController.BarItems.Add(changeFontNameItem1);
            richEditBarController.BarItems.Add(changeFontSizeItem1);
            richEditBarController.BarItems.Add(fontSizeIncreaseItem1);
            richEditBarController.BarItems.Add(fontSizeDecreaseItem1);
            richEditBarController.BarItems.Add(toggleFontBoldItem1);
            richEditBarController.BarItems.Add(toggleFontItalicItem1);
            richEditBarController.BarItems.Add(toggleFontUnderlineItem1);
            richEditBarController.BarItems.Add(toggleFontDoubleUnderlineItem1);
            richEditBarController.BarItems.Add(toggleFontStrikeoutItem1);
            richEditBarController.BarItems.Add(changeFontColorItem1);
            richEditBarController.BarItems.Add(changeFontHighlightColorItem1);
            richEditBarController.BarItems.Add(makeTextUpperCaseItem1);
            richEditBarController.BarItems.Add(makeTextLowerCaseItem1);
            richEditBarController.BarItems.Add(capitalizeEachWordCaseItem1);
            richEditBarController.BarItems.Add(toggleTextCaseItem1);
            richEditBarController.BarItems.Add(changeTextCaseItem1);
            richEditBarController.BarItems.Add(clearFormattingItem1);
            richEditBarController.BarItems.Add(showFontFormItem1);
            richEditBarController.BarItems.Add(toggleBulletedListItem1);
            richEditBarController.BarItems.Add(toggleNumberingListItem1);
            richEditBarController.BarItems.Add(toggleMultiLevelListItem1);
            richEditBarController.BarItems.Add(decreaseIndentItem1);
            richEditBarController.BarItems.Add(increaseIndentItem1);
            richEditBarController.BarItems.Add(toggleParagraphAlignmentLeftItem1);
            richEditBarController.BarItems.Add(toggleParagraphAlignmentCenterItem1);
            richEditBarController.BarItems.Add(toggleParagraphAlignmentRightItem1);
            richEditBarController.BarItems.Add(toggleParagraphAlignmentJustifyItem1);
            richEditBarController.BarItems.Add(toggleParagraphAlignmentArabicJustifyItem1);
            richEditBarController.BarItems.Add(toggleParagraphAlignmentJustifyLowItem1);
            richEditBarController.BarItems.Add(toggleParagraphAlignmentJustifyMediumItem1);
            richEditBarController.BarItems.Add(toggleParagraphAlignmentJustifyHighItem1);
            richEditBarController.BarItems.Add(toggleParagraphAlignmentArabicJustifyGroupItem1);
            richEditBarController.BarItems.Add(toggleParagraphAlignmentDistributeItem1);
            richEditBarController.BarItems.Add(toggleParagraphAlignmentThaiDistributeItem1);
            richEditBarController.BarItems.Add(setSingleParagraphSpacingItem1);
            richEditBarController.BarItems.Add(setSesquialteralParagraphSpacingItem1);
            richEditBarController.BarItems.Add(setDoubleParagraphSpacingItem1);
            richEditBarController.BarItems.Add(showLineSpacingFormItem1);
            richEditBarController.BarItems.Add(addSpacingBeforeParagraphItem1);
            richEditBarController.BarItems.Add(removeSpacingBeforeParagraphItem1);
            richEditBarController.BarItems.Add(addSpacingAfterParagraphItem1);
            richEditBarController.BarItems.Add(removeSpacingAfterParagraphItem1);
            richEditBarController.BarItems.Add(changeParagraphLineSpacingItem1);
            richEditBarController.BarItems.Add(changeParagraphBackColorItem1);
            richEditBarController.BarItems.Add(findItem1);
            richEditBarController.BarItems.Add(replaceItem1);
            richEditBarController.Control = recMainBase;
            // 
            // RichEditBarContol
            // 
            Appearance.BackColor = System.Drawing.Color.Transparent;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelControl);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "RichEditBarContol";
            Size = new System.Drawing.Size(868, 551);
            ((System.ComponentModel.ISupportInitialize)bmRichToolBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemFontEditRichEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemRichEditFontSizeEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl).EndInit();
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)richEditBarController).EndInit();
            ResumeLayout(false);
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
