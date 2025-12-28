using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace LifeLog.Forms;
public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
{
	public MainForm()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Main form load
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void MainForm_Load(object sender, EventArgs e)
	{
		Version version = Assembly.GetExecutingAssembly().GetName()!.Version!;
#if DEBUG
		bsiAppVersion.Caption = $"v{version} (DEBUG!)";
		bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Critical;
#else
		bsiAppVersion.Caption = $"v{version}";
		bsiAppVersion.ItemAppearance.Normal.ForeColor = ForeColors.Information;
#endif
		bsiUserMenu.Caption = Program.LoggedUser!.Username;
		bsiDatabase.Caption = Program.DataEngine!.DBName;


		InitAccentColors();
	}

	private void mainTimer_Tick(object sender, EventArgs e)
	{
		bsiTime.Caption = $"{DateTime.Now:HH:mm:ss}";
	}


	private void bbiShowSettings_ItemClick(object sender, ItemClickEventArgs e)
	{
		ribbon.ShowApplicationButtonContentControl();
	}

	private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
	{

	}

	#region FUNCTIONS

	#region PRIVATES

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
}