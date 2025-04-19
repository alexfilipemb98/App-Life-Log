using Data.ORM.DataModelCode;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using LifeLogApp.Forms.Dialog;
using LifeLogApp.Helpers;
using System;
using System.Windows.Forms;

namespace LifeLogApp.Forms;

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
        lblTime.Caption = $"{DateTime.Now:yyyy/MM/dd HH:mm:ss}";
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
    /// Show the notes view
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bbiNotesView_ItemClick(object sender, ItemClickEventArgs e)
    {
        ribbon.ApplicationDocumentCaption = "Notes";
        navigationFrame.SelectedPage = npNotesView;
        notesView.LoadData();
    }

    /// <summary>
    /// Show the settings view
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bbiAppSettings_ItemClick(object sender, ItemClickEventArgs e)
    {
        ribbon.ShowApplicationButtonContentControl();
    }

    /// <summary>
    /// Show passwords view
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bbiPasswordsView_ItemClick(object sender, ItemClickEventArgs e)
    {
        ribbon.ApplicationDocumentCaption = "Passwords";
        navigationFrame.SelectedPage = npPasswordView;
        passwordView.LoadData();
    }


    private void bbiCoinFlipView_ItemClick(object sender, ItemClickEventArgs e)
    {
        ribbon.ApplicationDocumentCaption = "Coin Flip";
        navigationFrame.SelectedPage = npCoinFilpView;
    }

    private void bbiTicTacToeView_ItemClick(object sender, ItemClickEventArgs e)
    {
        ribbon.ApplicationDocumentCaption = "Tic Tac Toe";
        navigationFrame.SelectedPage = npTicTacToeView;
    }

    private void bbiDiceRollView_ItemClick(object sender, ItemClickEventArgs e)
    {
        ribbon.ApplicationDocumentCaption = "Dice Roll";
        navigationFrame.SelectedPage = npDiceRollView;
    }

    #endregion

    #region FUNCTIONS

    /// <summary>
    /// Load the module settings
    /// </summary>
    private void LoadModuleSettings()
    {
        bbiNotesView.Visibility = AppContext.ModuleSettings.EnableNotes ? BarItemVisibility.Always : BarItemVisibility.Never;
        bbiPasswordsView.Visibility = AppContext.ModuleSettings.EnablePasswords ? BarItemVisibility.Always : BarItemVisibility.Never;

        rpHome.Visible = 
            AppContext.ModuleSettings.EnableNotes 
            || AppContext.ModuleSettings.EnableNotes;

        bbiDiceRollView.Visibility = AppContext.ModuleSettings.EnableDiceRoll ? BarItemVisibility.Always : BarItemVisibility.Never;
        bbiTicTacToeView.Visibility = AppContext.ModuleSettings.EnableTicTacToe ? BarItemVisibility.Always : BarItemVisibility.Never;
        bbiCoinFlipView.Visibility = AppContext.ModuleSettings.EnableCoinFilp ? BarItemVisibility.Always : BarItemVisibility.Never;

        rpEntertainment.Visible = 
            AppContext.ModuleSettings.EnableDiceRoll 
            || AppContext.ModuleSettings.EnableTicTacToe 
            || AppContext.ModuleSettings.EnableCoinFilp;
    }

    #endregion

    #region backstageViewControl
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

    private void backstageViewControl_Showing(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(ribbon.ApplicationDocumentCaption))
        {
            _previousCaption = ribbon.ApplicationDocumentCaption;
        }

        backstageViewControl.SelectedTab = btviAppSettings;
        geralSettingsView.LoadData();
        databaseSettingsView.LoadData();
        modulleSettings1.LoadData();
    }

    private void backstageViewControl_Hiding(object sender, System.ComponentModel.CancelEventArgs e)
    {
        ribbon.ApplicationDocumentCaption = _previousCaption;

        LoadModuleSettings();
    }

    #endregion


}