using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSplashScreen;
using LifeLog.Components;

namespace LifeLog.Forms;

/// <summary>
/// Settings View
/// </summary>
public partial class SettingsView : DevExpress.XtraEditors.XtraUserControl
{
	/// <summary>
	/// Constructor
	/// </summary>
	public SettingsView() => InitializeComponent();

	private async void backstageViewControl_SelectedTabChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
	{
		string? name = e.Item?.Name;

		if (name is null)
			return;

		switch (name)
		{
			case nameof(bvtiDatabase):
				databaseSettingsView.LoadData();
				break;
		}
	}

	private async void navigationPaneEx_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
	{
		string name = ((NavigationPageEx)e.Page).Name;

		if (name is null)
			return;

		switch (name)
		{
			case nameof(npExternalPrograms):
				await externalProgramsList.LoadData();
				break;

		}
	}
}
