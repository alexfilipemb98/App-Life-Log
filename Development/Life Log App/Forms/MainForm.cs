using Components;
using Data.ORM.DataModelCode;
using DevExpress.Data.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Life_Log_App.Forms.Dialog;
using Life_Log_App.Helpers;
using Life_Log_App.Views.Tables.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Life_Log_App.Forms
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class MainForm : RibbonForm
    {
        #region MAIN

        //PRIVATE FIELDS

        private string _previousCaption = string.Empty;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm() => InitializeComponent();

        /// <summary>
        /// Load the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadModuleSettings();

                bsiMenuUser.Caption = AppContext.CurrentUser.Username;
                bsiDatabase.Caption = AppContext.DataEngine.DBName;
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
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
        /// Timer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            bsiTime.Caption = $"TIME: {DateTime.Now:HH:mm:ss}";
        }

        #endregion

        #region BACK STAGE VIEW CONTROL

        /// <summary>
        /// Handles the selected tab changed event of the backstage view control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backstageViewControl_SelectedTabChanged(object sender, BackstageViewItemEventArgs e)
        {
            if (AppContext.MainForm == null) return;

            if (e.Item == btviAppSettings)
            {
                ribbon.ApplicationDocumentCaption = "Geral Settings";
            }
            else if (e.Item == bvtiDatabaseSettings)
            {
                ribbon.ApplicationDocumentCaption = "Database settings";
            }
        }

        /// <summary>
        /// Handles the showing event of the backstage view control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backstageViewControl_Showing(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ribbon.ApplicationDocumentCaption))
                {
                    _previousCaption = ribbon.ApplicationDocumentCaption;
                }

                backstageViewControl.SelectedTab = btviAppSettings;
                geralSettingsView.LoadData();
                databaseSettingsView.LoadData();
                modulleSettingsView.LoadData();
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Handles the hiding event of the backstage view control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backstageViewControl_Hiding(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                ribbon.ApplicationDocumentCaption = _previousCaption;

                LoadModuleSettings();
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region CHECKED CHANGED

        /// <summary>
        /// Set form to top most
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btsTopMost_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (sender is BarToggleSwitchItem toggleSwitchItem)
            {
                this.TopMost = toggleSwitchItem.Checked;
            }
        }

        #endregion

        #region CLICK

        /// <summary>
        /// Handles the item click event of the ribbon control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ribbon_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string tag = e.Item.Tag?.ToString();
                if (string.IsNullOrWhiteSpace(tag)) return;

                OpenPages(e, tag);
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        //Main

        /// <summary>
        /// Show the settings view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiAppSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.ShowApplicationButtonContentControl();
        }

        //Tools

        /// <summary>
        /// Make the form out 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiMakeFormOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                NavigationPage selectedPage = navigationFrame.SelectedPage;
                XtraUserControl control = selectedPage.Controls.OfType<XtraUserControl>().FirstOrDefault();

                if (control != null)
                {
                    string typeName = control.GetType().FullName;
                    ContainerForm.ShowForm(typeName);
                }
            }
            catch (Exception ex)
            {
                Helpers.ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Load the module settings
        /// </summary>
        private void LoadModuleSettings()
        {
            //Main
            bbiCommandsView.HideShowBarButton(AppContext.ModuleSettings.EnableCommands);
            bbiNotesView.HideShowBarButton(AppContext.ModuleSettings.EnableNotes);
            bbiPasswordsView.HideShowBarButton(AppContext.ModuleSettings.EnablePasswords);

            bool rpHomeAny = rpHome.Groups
                   .SelectMany(group => group.ItemLinks)
                   .Any(link => link.Item.Visibility == BarItemVisibility.Always);

            rpHome.Visible = rpHomeAny;

            //Entertainment
            bbiDiceRollView.HideShowBarButton(AppContext.ModuleSettings.EnableDiceRoll);
            bbiTicTacToeView.HideShowBarButton(AppContext.ModuleSettings.EnableTicTacToe);
            bbiCoinFlipView.HideShowBarButton(AppContext.ModuleSettings.EnableCoinFilp);

            bool rpEntertainmentAny = rpEntertainment.Groups
                    .SelectMany(group => group.ItemLinks)
                    .Any(link => link.Item.Visibility == BarItemVisibility.Always);

            rpEntertainment.Visible = rpEntertainmentAny;

            //Tools
            bbiPasswordGeneratorView.HideShowBarButton(AppContext.ModuleSettings.EnablePasswordGenerator);
            bbiMergePdfs.HideShowBarButton(AppContext.ModuleSettings.EnableMergePdfs);

            bool rpToolsAny = rpTools.Groups
                   .SelectMany(group => group.ItemLinks)
                   .Any(link => link.Item.Visibility == BarItemVisibility.Always);

            rpTools.Visible = rpToolsAny;
        }

        /// <summary>
        /// Open the pages
        /// </summary>
        /// <param name="e"></param>
        /// <param name="userControl"></param>
        private void OpenPages(ItemClickEventArgs e, string userControl)
        {
            try
            {
                string caption = e.Item.Caption.Replace("\r\n", " ");
                ribbon.ApplicationDocumentCaption = caption;

                DialogHelper.ShowWait();

                NavigationPage pageExists = navigationFrame.Pages
                     .OfType<NavigationPage>()
                     .FirstOrDefault(p => p.Tag?.ToString() == userControl);

                if (pageExists != null)
                {
                    navigationFrame.SelectedPage = pageExists;
                    return;
                }

                object obj = ControlsHelper.CreateInstanceFromName(userControl);

                if (!(obj is XtraUserControl control)) return;

                control.Dock = DockStyle.Fill;

                NavigationPage page = new NavigationPage();
                page.Controls.Add(control);
                page.Name = control.Name;
                page.Tag = userControl;
                page.Text = caption;

                if (e.Item is BarButtonItem btn)
                {
                    if (btn.ImageOptions.SvgImage != null)
                        page.ImageOptions.SvgImage = btn.ImageOptions.SvgImage;
                    else
                        page.ImageOptions.Image = btn.ImageOptions.Image;
                }

                navigationFrame.Pages.Add(page);

                navigationFrame.SelectedPage = page;

                if (obj is UserControlBase ucb)
                {
                    ucb.LoadData();
                }
            }
            catch (Exception ex)
            {
                DialogHelper.CloseWait();
                ErrorHelper.Handler(ex);
            }
            finally
            {
                DialogHelper.CloseWait();
            }
        }

        #endregion
    }
}