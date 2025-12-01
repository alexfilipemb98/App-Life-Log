using Countries.Models;
using DevExpress.XtraSplashScreen;
using LifeLog.Base.Utils;
using LifeLog.Services.WeatherApi.Models;
using LifeLog.UI.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LifeLog.UI.FrontEnd.Views.Main.Weather
{
	/// <summary>
	/// View weather information
	/// </summary>
	public partial class WeatherView : DevExpress.XtraEditors.XtraUserControl
	{
		//PRIVATE
		private CancellationTokenSource _cts;
		private Services.WeatherApi.Engine _WeatherApi;

		#region MAIN

		/// <summary>
		/// Contructor
		/// </summary>
		public WeatherView() => InitializeComponent();

		/// <summary>
		/// Load event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WeatherView_Load(object sender, EventArgs e)
		{
			_WeatherApi = new Services.WeatherApi.Engine("f56b2228d2888531cedd5596dd2be12c");
		}

		#endregion

		#region EVENTS

		#region CLICK

		/// <summary>
		/// Search the data for the weather
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void sbSearch_Click(object sender, EventArgs e) => await LoadWeatherToForm();

		#endregion

		#region EDIT VALUE CHANGED

		/// <summary>
		/// Country edit value changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void lueCountry_EditValueChanged(object sender, EventArgs e)
		{
			using (IOverlaySplashScreenHandle loder = SplashScreenManager.ShowOverlayForm(this))
			{
				if (lueCountry.GetSelectedDataRow() is CountriesModel country && country != null)
				{
					statesModelBindingSource.DataSource = await Countries.Data.States(country.id.ToString());

					Bitmap image = ImagesUtil.ImageUrlToBitmap($"https://flagsapi.com/{country.iso2}/flat/24.png");
					peIconCountry.Image = image;
				}
				else
				{
					statesModelBindingSource.DataSource = await Countries.Data.States();
					peIconCountry.Image = null;
				}
			}
		}

		/// <summary>
		/// Popup container edit edit value changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void pceSearch_EditValueChanged(object sender, EventArgs e)
		{
			try
			{
				string txt = popupContainerEdit1.Text.Trim();
				if (txt.Length < 3)
					return;

				await LoadSugestions(txt);
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region SELECTED INDEX CHANGED

		/// <summary>
		/// lcbSearch selected index changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void lcbSearch_SelectedIndexChanged(object sender, EventArgs e) => await LoadWeatherToForm();

		#endregion

		#endregion

		#region FUCNTIONS

		#region PUBLIC

		/// <summary>
		/// Load data
		/// </summary>
		/// <returns></returns>
		public async Task LoadData()
		{
			using (IOverlaySplashScreenHandle loder = SplashScreenManager.ShowOverlayForm(this))
			{
				ResetTexts();
				countriesModelBindingSource.DataSource = await Countries.Data.Countries();
			}
		}

		#endregion

		#region PRIVATE

		/// <summary>
		/// Reset texts
		/// </summary>
		private void ResetTexts()
		{
			peWheatherState.Image = null;
			lcgWeatherInformationGroup.Text = $"Weather Information for -";
			lblWeatherState.ResetText();
			lblTime.ResetText();
			lblMinTemp.ResetText();
			lblMaxTemp.ResetText();
			lblHumidity.ResetText();
			lblWindData.ResetText();
			lblCloudsData.ResetText();
			lblPressure.ResetText();
			lblSunrise.ResetText();
			lblSunset.ResetText();
			lblTimezone.ResetText();
			lblCoordinates.ResetText();
		}

		/// <summary>
		/// Update search list
		/// </summary>
		/// <param name="locais"></param>
		private void UpdateSearchList(List<SmallMainModel> locais)
		{
			lcbSearch.BeginUpdate();
			try
			{
				lcbSearch.DataSource = null;

				// HTML ON
				lcbSearch.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
				lcbSearch.ItemHeight = 36; // um pouco mais alto para 2 linhas

				// Usa o texto com HTML
				lcbSearch.DisplayMember = "HtmlSearchName";
				lcbSearch.DataSource = locais;
				lcbSearch.UnSelectAll();
			}
			finally
			{
				lcbSearch.EndUpdate();
			}

			if (locais.Count > 0 && !popupContainerEdit1.IsPopupOpen)
				popupContainerEdit1.ShowPopup();
		}

		/// <summary>
		/// Load suggestions async
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		private async Task LoadSugestions(string text)
		{
			using (IOverlaySplashScreenHandle loder = SplashScreenManager.ShowOverlayForm(this))
			{
				_cts?.Cancel();
				_cts = new CancellationTokenSource();
				CancellationToken token = _cts.Token;

				try
				{
					CountriesModel country = (CountriesModel)lueCountry.GetSelectedDataRow();
					if (country != null)
						text += $", {country.iso2}";

					await Task.Delay(500, token);

					if (token.IsCancellationRequested) return;

					List<Services.WeatherApi.Models.SmallMainModel> locations = await _WeatherApi.SearchCitiesAsync(text, token);
					if (token.IsCancellationRequested) return;

					if (!IsHandleCreated || IsDisposed)
						return;

					if (InvokeRequired)
						Invoke(new Action(() => UpdateSearchList(locations)));
					else
						UpdateSearchList(locations);
				}
				catch (TaskCanceledException) when (token.IsCancellationRequested)
				{
				}
			}
		}

		/// <summary>
		/// Load weather to form
		/// </summary>
		/// <returns></returns>
		private async Task LoadWeatherToForm()
		{
			try
			{
				if (!(lcbSearch.SelectedItem is Services.WeatherApi.Models.SmallMainModel sel))
					return;

				using (IOverlaySplashScreenHandle loder = SplashScreenManager.ShowOverlayForm(this))
				{
					Services.WeatherApi.Models.Root.WeatherRootObjectModel data = await _WeatherApi.GetWeatherByCoordinates(sel.Lat, sel.Lon);
					(List<DailySummaryModel> dailySummaries, List<Next24HoursModel> next12Hours) forecast = await _WeatherApi.GetForecast(sel.Lat, sel.Lon);

					if (data == null)
						ResetTexts();
					else
					{
						peWheatherState.Image = data.Weather.First().Image;
						lcgWeatherInformationGroup.Text = $"Weather Information for - ({data.Sys.Country}) {data.Name} is {data.Main.Temp} ºC";
						lblWeatherState.Text = $"{data.Weather.First().Main} - {data.Weather.First().Description}";
						lblTime.Text = $"{ConversionUtil.UnixToDateTime(data.Dt)}";
						lblMinTemp.Text = $"{data.Main.TempMin} ºC";
						lblMaxTemp.Text = $"{data.Main.TempMax} ºC";
						lblHumidity.Text = $"{data.Main.Humidity} %";
						lblWindData.Text = $"{ConversionUtil.MetersPerSecondToKilometersPerHour(data.Wind.Speed)} km\\h - {ConversionUtil.DegreesToCompassDirection(data.Wind.Deg)}";
						lblCloudsData.Text = $"{data.Clouds.All} %";
						lblPressure.Text = $"{data.Main.Pressure} hPa";
						lblSunrise.Text = $"{ConversionUtil.UnixToDateTime(data.Sys.Sunrise)}";
						lblSunset.Text = $"{ConversionUtil.UnixToDateTime(data.Sys.Sunset)}";
						lblTimezone.Text = TimezoneUtil.GetTimeZoneInfo(data.Coord.Lat, data.Coord.Lon, data.Timezone);
						lblCoordinates.Text = $"LAT: {data.Coord.Lat}, LON: {data.Coord.Lon}";
					}

					chartControl1.DataSource = forecast.next12Hours;

					//DevExpress.XtraCharts.Series series = chartControl1.Series[0];

					//series.ArgumentDataMember = "Time";
					//series.ValueDataMembers.Clear();
					//series.ValueDataMembers.AddRange("Temp");
					//series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;

					//// Mostra horas
					//series.Label.TextPattern = "{A:HH:mm} - {V}°C";

					//var diagram = chartControl1.Diagram as DevExpress.XtraCharts.XYDiagram;
					//if (diagram != null)
					//{
					//	diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
					//	diagram.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour;
					//	diagram.AxisX.Label.TextPattern = "{A:HH:mm}";
					//}

					popupContainerEdit1.ClosePopup();
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#endregion
	}
}
