using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using LifeLog.Components;

namespace LifeLog.Forms;

/// <summary>
/// Settings View
/// </summary>
public partial class SettingsView : XtraUserControl
{
	/// <summary>
	/// Constructor
	/// </summary>
	public SettingsView() => InitializeComponent();

	private async void backstageViewControl_SelectedTabChanged(object sender, BackstageViewItemEventArgs e)
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

	private async void navigationPaneEx_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
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
