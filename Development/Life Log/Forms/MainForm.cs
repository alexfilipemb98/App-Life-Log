using Core.Enums;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Life_Log.Forms.Dialogs;
using Life_Log.Helpers;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Log.Forms
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class MainForm : RibbonForm
    {
        #region MAIN

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm() => InitializeComponent();

        /// <summary>
        /// Main form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            navigationFrame.SelectedPage = npHomeDashboardView;
#if DEBUG
            bsiAppVersion.Caption = $"v{Application.ProductVersion} (DEBUG!)";
            bsiAppVersion.ItemAppearance.Normal.ForeColor = Color.Red;
            rpgTestButtons.Visible = true;
#else
            bsiAppVersion.Caption = $"v{Application.ProductVersion}";
            bsiAppVersion.ItemAppearance.Normal.ForeColor = Color.Green;
#endif
            bsiDatabase.Caption = AppHelper.DataEngine.DBName;
            bsiSizse.Caption = $"Size: {Size.Width}w X {Size.Height}h";

            switch (AppHelper.AppConfigs.Theme)
            {
                case Core.Enums.ThemeEnum.SYSTEM:
                    bciThemeSystem.Checked = true;
                    break;
                case Core.Enums.ThemeEnum.LIGHT:
                    bciThemeLight.Checked = true;
                    break;
                case Core.Enums.ThemeEnum.DARK:
                    bciThemeDark.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Resize event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Resize(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        bsiSizse.Caption = $"Size: {Size.Width} X {Size.Height}";
                    }));
                }
                else
                {
                    bsiSizse.Caption = $"Size: {Size.Width} X {Size.Height}";
                }
            });
        }

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult result = MessageBoxDialogForm.SD("Exit Confirmation", "Are you sure you want to close the program?\nAny unsaved changes will be lost.");
                if (result != DialogResult.Yes)
                    e.Cancel = true;
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Form closed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                AppHelper.SaveAppSetings();
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            bsiTime.Caption = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        #endregion

        #region CLICK

        /// <summary>
        /// Notes button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiHomeNotes_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "Notes";
            navigationFrame.SelectedPage = npHomeNotesView;
            notesView.LoadData();
        }

        /// <summary>
        /// Show tables external programs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiTablesExternalPrograms_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "Tables of External Programs";
            navigationFrame.SelectedPage = npTableExternalPrograms;
            externalProgramsListView.LoadData();
        }

        /// <summary>
        /// Show commands 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiHomeCommands_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "Commands Runner";
            navigationFrame.SelectedPage = npHomeCommadsView;
            commandsListView.LoadData();
        }

        /// <summary>
        /// Table images button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiTablesImages_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "Tables of Images";
            navigationFrame.SelectedPage = npTableImages;
            imagesListView.LoadData();
        }

        /// <summary>
        /// Show sql broser button click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiToolsSqlBrowser_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "Sql Browser";
            navigationFrame.SelectedPage = npSqlBrowserView;
        }

        /// <summary>
        /// Passwords button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiHomePasswords_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "Passwords";
            navigationFrame.SelectedPage = npHomePasswordsView;
            passwordsView.LoadData();
        }

        /// <summary>
        /// Generate password button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiToolsGenereatePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "Genereate Passwords";
            navigationFrame.SelectedPage = npToolsPasswordGeneratorView;
        }

        /// <summary>
        /// Settings app button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiSettingsApp_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "App Settings";
            navigationFrame.SelectedPage = npSettingsView; navigationFrame.SelectedPage = npSettingsView;
        }

        /// <summary>
        /// Show three simple rule form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiToolsThreeSimpleRule_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThreeSimpleRuleForm.Dialog();
        }

        /// <summary>
        /// Show hosts editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiToolsHostsEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "Hosts Editor";
            navigationFrame.SelectedPage = npToolsHotsEditorView;
            hostsEditorView.LoadData();
        }

        /// <summary>
        /// Show entertainment tic tac toe game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEntertainmentTicTacToe_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "Tic Tac Toe";
            navigationFrame.SelectedPage = npEntertainmentTicTacToeView;
        }

        /// <summary>
        /// Show entertainment coin flip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEntretainmentCoinFlip_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "Coin Flip";
            navigationFrame.SelectedPage = npEntertainmentCoinFlipView;
        }

        /// <summary>
        /// Show entertainment dice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEntretainmentDice_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ApplicationDocumentCaption = "Dice";
            navigationFrame.SelectedPage = npEntertainmentDiceView;
        }

        #endregion

        #region CHECKED CHANGED

        /// <summary>
        /// Set top most checked changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btsiSetTopMost_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            this.TopMost = btsiSetTopMost.Checked;
        }

        /// <summary>
        /// Theme light checked changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bciThemeLight_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (!bciThemeLight.Checked) return;

            bciThemeSystem.Checked = false;
            bciThemeDark.Checked = false;
            AppHelper.AppConfigs.Theme = ThemeEnum.LIGHT;
            UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinStyle.WXI, ThemeEnum.LIGHT.ToString());
        }

        /// <summary>
        /// Theme dark checked changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bciThemeDark_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (!bciThemeDark.Checked) return;

            bciThemeSystem.Checked = false;
            bciThemeLight.Checked = false;
            AppHelper.AppConfigs.Theme = ThemeEnum.DARK;
            UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinStyle.WXI, ThemeEnum.DARK.ToString());
        }

        /// <summary>
        /// Theme system checked changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bciThemeSystem_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (!bciThemeSystem.Checked) return;

            bciThemeDark.Checked = false;
            bciThemeLight.Checked = false;
            AppHelper.AppConfigs.Theme = ThemeEnum.SYSTEM;
            UserLookAndFeel.Default.ActiveLookAndFeel.SetSkinStyle(SkinStyle.WXI, AppHelper.GetTheme().ToString());
        }

        #endregion

        /// <summary>
        /// Show test buttons checked changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiTestCode_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}