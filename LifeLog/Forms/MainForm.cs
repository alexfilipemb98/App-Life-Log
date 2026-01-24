using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using LifeLog.Components;
using LifeLog.Forms.Others;
using LifeLog.Helpers;
using System.Reflection;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.Forms;

/// <summary>
/// Main form
/// </summary>
public partial class MainForm : RibbonForm
{
    private SettingsView _settingsView;

    #region MAIN 

    /// <summary>
    /// Construtor
    /// </summary>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Main form load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_Load(object sender, EventArgs e)
    {
        string? fileVersion = Assembly.GetExecutingAssembly()
           .GetCustomAttribute<AssemblyFileVersionAttribute>()?
           .Version;

#if DEBUG
		bsiAppVersion.Caption = $"v{fileVersion} (DEBUG!)";
        bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Critical;
#else
        bsiAppVersion.Caption = $"v{fileVersion}";
        bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Information;
#endif
        bsiUserMenu.Caption = Program.LoggedUser!.Username;
        bsiDatabase.Caption = Program.DataEngine!.DBName;

        navigationFrame.TransitionManager.AfterTransitionEnds += (ts, te) => DialogHelper.CloseWait();

        _settingsView = new SettingsView();

        ribbon.ApplicationButtonDropDownControl = _settingsView.backstageViewControl;

        InitAccentColors();

        bsiStatusLabel.Caption = "Welcome back!";
    }

    /// <summary>
    /// Main timer tick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void mainTimer_Tick(object sender, EventArgs e)
    {
        bsiTime.Caption = $"{DateTime.Now:HH:mm:ss}";
    }

    #endregion

    #region EVENTS

    #region CLICK

    /// <summary>
    /// Show settings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bbiShowSettings_ItemClick(object sender, ItemClickEventArgs e)
    {
        ribbon.ShowApplicationButtonContentControl();
    }

    /// <summary>
    /// Ribbon open page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void ribbon_ItemClick(object sender, ItemClickEventArgs e)
    {
        if (e.Item is not BarButtonItemEx btn || btn == null || string.IsNullOrWhiteSpace(btn.TargetViewTypeName))
            return;

        await OpenPages(e, btn.TargetViewTypeName);
    }

    /// <summary>
    /// Make a form with current user controll
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void bbiFormOut_ItemClick(object sender, ItemClickEventArgs e)
    {
        NavigationPage selectedPage = navigationFrame.SelectedPage;

        if (selectedPage is null || selectedPage.Controls is null)
            return;

        XtraUserControl? control = selectedPage.Controls.OfType<XtraUserControl>().FirstOrDefault();

        if (control != null)
            await ContainerForm.ShowFormAsync(this, control.Tag?.ToString()!);
    }

    /// <summary>
    /// Three simple rule click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void bbiThreeSimpleRule_ItemClick(object sender, ItemClickEventArgs e)
    {
        using (ThreeSimpleRuleForm form = new())
        {
            form.ShowDialog();
        }
    }

    #endregion

    #region CHECK CHANGED

    /// <summary>
    /// Set top most
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btsiTopMost_CheckedChanged(object sender, ItemClickEventArgs e)
    {
        this.TopMost = btsiTopMost.Checked;
    }

    #endregion

    #endregion

    #region FUNCTIONS

    #region PRIVATES


    /// <summary>
    /// Open the pages
    /// </summary>
    /// <param name="e"></param>
    /// <param name="userControl"></param>
    private async Task OpenPages(ItemClickEventArgs e, string userControl)
    {
        DialogHelper.ShowWait(this);
        Application.DoEvents();
        await Task.Delay(250);

        try
        {
            string caption = e.Item.Caption.Replace("\r\n", " ");
            ribbon.ApplicationDocumentCaption = caption;

            NavigationPage? pageExists = navigationFrame.Pages
                 .OfType<NavigationPage>()
                 .FirstOrDefault(p => p.Tag?.ToString() == userControl);

            if (pageExists != null)
            {
                if (navigationFrame.SelectedPage != pageExists)
                    navigationFrame.SelectedPage = pageExists;
                else
                    DialogHelper.CloseWait();

                return;
            }

            Type? t = Type.GetType(userControl);
            if (t is null)
                return;

            XtraUserControl view = (XtraUserControl)Activator.CreateInstance(t)!;

            if (!(view is XtraUserControl control))
            {
                MessageBox.Show("Page not found!");
                return;
            }

            control.Tag = userControl;
            control.Dock = DockStyle.Fill;
            control.Parent = this;

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

            MethodInfo? method = view.GetType().GetMethod("LoadData");

            if (method != null)
            {
                object result = method.Invoke(view, null)!;
                if (result is Task taskResult)
                    await taskResult;
            }
        }
        catch (Exception ex)
        {
            DialogHelper.CloseWait();
            ErrorHelper.Handler(ex);
        }
    }

    /// <summary>
    /// Initialize accent colors
    /// </summary>
    private void InitAccentColors()
    {
        SkinHelper.InitTrackWindowsAppMode(bciTrackWindowsAppMode);
        bciTrackWindowsAppMode.SuperTip = new SuperToolTip();
        bciTrackWindowsAppMode.SuperTip.Items.Add("This setting is available for WXI, Basic, and Bezier skins.");
        bciTrackWindowsAppMode.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
        SkinHelper.InitResetToOriginalPalette(bciOriginalPalette);
        SkinHelper.InitTrackWindowsAccentColor(bciTrackWindowsAccentColor);
        SkinHelper.InitCustomAccentColor(Ribbon.Manager, bbiCustomColors);
        bbiCustomColors.SuperTip = new SuperToolTip();
        bbiCustomColors.SuperTip.Items.Add("Custom Accent Color.");
        bbiCustomColors.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
        SkinHelper.InitCustomAccentColor2(Ribbon.Manager, bbiCustomColors2);
        bbiCustomColors2.SuperTip = new SuperToolTip();
        bbiCustomColors2.SuperTip.Items.Add("Custom Accent Color 2.");
        bbiCustomColors2.SuperTip.Items[0].Appearance.FontStyleDelta = FontStyle.Bold;
    }

    #endregion

    #endregion

    private void bbiTestCode_ItemClick(object sender, ItemClickEventArgs e)
    {
        QrCodeForm.ShowCode("WIFI:T:WPA;S:Vodafone-7D9753;P:Es7wFuGxeG;H:false;;", this);
    }
}