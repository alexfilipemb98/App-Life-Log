using Countries.Models;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using LifeLog.Base.Utils;
using LifeLog.UI.Common.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LifeLog.UI.FrontEnd.Views.Main.Weather
{
	/// <summary>
	/// View weather information
	/// </summary>
	public partial class WeatherView : DevExpress.XtraEditors.XtraUserControl
	{
		#region MAIN

		/// <summary>
		/// Contructor
		/// </summary>
		public WeatherView() => InitializeComponent();

		#endregion

		#region CLICK

		/// <summary>
		/// Search the data for the weather
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void sbSearch_Click(object sender, EventArgs e)
		{
			try
			{
				dxErrorProvider.ClearErrors();

				CountriesModel country = (CountriesModel)lueCountry.GetSelectedDataRow();
				StatesModel state = (StatesModel)lueState.GetSelectedDataRow();
				CitiesModel city = (CitiesModel)lueCity.GetSelectedDataRow();

				if (country == null)
					dxErrorProvider.SetError(lueCountry, "Select a country");

				if (state == null)
					dxErrorProvider.SetError(lueState, "Select a state");

				if (city == null)
					dxErrorProvider.SetError(lueCity, "Select a city");

				if (dxErrorProvider.HasErrors)
					return;

				using (IOverlaySplashScreenHandle loder = SplashScreenManager.ShowOverlayForm(this))
				using (Services.WeatherApi.Engine api = new Services.WeatherApi.Engine("f56b2228d2888531cedd5596dd2be12c"))
				{
					Services.WeatherApi.Models.RootModel data = await api.GetWeather(country.iso2, state.state_code, city.name);

					if (data != null)
					{
						peWheatherState.Image = data.weather.First().image;
						lcgWeatherInformationGroup.Text = $"Weather Information for - ({data.sys.country}) {data.name} is {ConversionUtil.KelvinToCelsius(data.main.temp)} ºC";
						lblWeatherState.Text = $"{data.weather.First().main} - {data.weather.First().description}";
						lblTime.Text = $"{ConversionUtil.UnixToDateTime(data.dt)}";
						lblMinTemp.Text = $"{ConversionUtil.KelvinToCelsius(data.main.temp_min)} ºC";
						lblMaxTemp.Text = $"{ConversionUtil.KelvinToCelsius(data.main.temp_max)} ºC";
						lblHumidity.Text = $"{data.main.humidity} %";
						lblWindData.Text = $"{ConversionUtil.MetersPerSecondToKilometersPerHour(data.wind.speed)} km\\h - {ConversionUtil.DegreesToCompassDirection(data.wind.deg)}";
						lblCloudsData.Text = $"{data.clouds.all} %";
						lblPressure.Text = $"{data.main.pressure} hPa";
						lblSunrise.Text = $"{ConversionUtil.UnixToDateTime(data.sys.sunrise)}";
						lblSunset.Text = $"{ConversionUtil.UnixToDateTime(data.sys.sunset)}";
						
						(string name, string utcOffset) = ConversionUtil.GetTimeZoneInfo(data.timezone);
						lblTimezone.Text = $"{name} ({utcOffset})";

						lblCoordinates.Text = $"LAT: {data.coord.lat}, LON: {data.coord.lon}";
					}
					else
						ResetTexts();
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}



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
		/// State edit value changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void lueState_EditValueChanged(object sender, EventArgs e)
		{
			using (IOverlaySplashScreenHandle loder = SplashScreenManager.ShowOverlayForm(this))
			{
				if (lueState.EditValue is int id && id > 0)
					citiesModelBindingSource.DataSource = await Countries.Data.Cities(id.ToString());
				else
					citiesModelBindingSource.DataSource = await Countries.Data.Cities();
			}
		}

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
		}

		#endregion

		#endregion

	}
}
