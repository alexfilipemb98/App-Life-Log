using System.Diagnostics;
using LifeLog.Helpers;
using LifeLog.Services.JsonApi;

namespace LifeLog.Views.JsonApi;

/// <summary>
/// Json api
/// </summary>
public partial class JsonApiView : DevExpress.XtraEditors.XtraUserControl
{
	private string? _file;
	private Engine _api;
	private Stopwatch _sw;

	/// <summary>
	/// Construtor
	/// </summary>
	public JsonApiView() => InitializeComponent();


	private void bbiOpenFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
	{
		_file = DialogHelper.OpenJsonFile();

		bbiStart.Enabled = _file is not null;
	}

	private void bbiStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
	{
		_api = new Services.JsonApi.Engine();
		string apiUrl = $"http://localhost:{seApiPort.Value}";
		Task.Run(() => _api.StartAsync(apiUrl, _file!));

		bbiOpenFile.Enabled = false;
		bbiStart.Enabled = false;
		bbiStop.Enabled = true;
		timer.Start();
		_sw = Stopwatch.StartNew();
	}

	private async void bbiStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
	{
		await _api.DisposeAsync();

		bbiOpenFile.Enabled = true;
		bbiStart.Enabled = true;
		bbiStop.Enabled = false;

		timer.Stop();
		_sw.Stop();
	}

	private void btnBrowserApi_Click(object sender, EventArgs e)
	{
		string apiUrl = $"http://localhost:{seApiPort.Value}";

		if (!Uri.TryCreate(apiUrl, UriKind.Absolute, out Uri? uri))
			return;

		Process.Start(new ProcessStartInfo
		{
			FileName = uri.ToString(),
			UseShellExecute = true
		});
	}

	private void timer_Tick(object sender, EventArgs e)
	{
		bsiTime.Caption = _sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
	}
}