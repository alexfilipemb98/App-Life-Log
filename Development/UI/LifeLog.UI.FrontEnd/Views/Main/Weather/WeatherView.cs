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
				{
					string url = $"https://api.openweathermap.org/data/2.5/weather?q={city.name},{state.state_code},{country.iso2}&appid=f56b2228d2888531cedd5596dd2be12c";
					//string url = $"https://api.openweathermap.org/data/2.5/weather?q=Leiria,10,PT&appid=f56b2228d2888531cedd5596dd2be12c";

					using (HttpClient client = new HttpClient())
					{
						HttpResponseMessage response = await client.GetAsync(url);

						if (response.IsSuccessStatusCode)
						{
							string responseBody = await response.Content.ReadAsStringAsync();

							JObject weatherData = JsonConvert.DeserializeObject<JObject>(responseBody);

							lcgWeatherInformationGroup.Text = $"Weather Information for - {weatherData["name"]},{weatherData["sys"]?["country"]} {ConversionUtil.KelvinToCelsius(weatherData["main"]?["temp"]?.ToObject<double>() ?? 0.0)} ºC";

							//			WeatherDataListObject weatherState = weatherData.Weather.FirstOrDefault();
							//			teWeatherState.Text = $"{weatherState.Main} - {weatherState.Description}";
										peWheatherState.Image = ImagesUtil.ImageUrlToBitmap($"http://openweathermap.org/img/wn/{((JContainer)weatherData["weather"])[0]["icon"]}@2x.png");
							//			beMiminumTemperature.Text = $"{ConversionUtil.KelvinToCelsius(weatherData.Main.Temp_min)} ºC";
							//			beMaximumTemperature.Text = $"{ConversionUtil.KelvinToCelsius(weatherData.Main.Temp_max)} ºC";
							//			beWindData.Text = $"{ConversionUtil.MetersPerSecondToKilometersPerHour(weatherData.Wind.Speed)} km\\h - {ConversionUtil.DegreesToCompassDirection(weatherData.Wind.Deg)}";
							//			beCloudsData.Text = $"{weatherData.Clouds.All} %";
							//			bePressure.Text = $"{weatherData.Main.Pressure} hPa";
							//			beHumidity.Text = $"{weatherData.Main.Humidity} %";
							//			beTime.Text = $"{ConversionUtil.UnixToDateTime(weatherData.Dt)}";
							//			(string name, string utcOffset) = ConversionUtil.GetTimeZoneInfo(weatherData.Timezone);
							//			beTimezone.Text = $"{name} ({utcOffset})";
							//			beSunrise.Text = $"{ConversionUtil.UnixToDateTime(weatherData.Sys.Sunrise)}";
							//			beSunset.Text = $"{ConversionUtil.UnixToDateTime(weatherData.Sys.Sunset)}";
							//			beCoordinates.Text = $"LAT: {weatherData.Coord.Lat}, LON: {weatherData.Coord.Lon}";
						}
					}
				}
			}
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region EDIT VALUE CHANGED



		#endregion

		#region FUCNTIONS

		#region PUBLIC

		public async Task LoadData()
		{
			using (IOverlaySplashScreenHandle loder = SplashScreenManager.ShowOverlayForm(this))
			{
				countriesModelBindingSource.DataSource = await Countries.Data.Countries();
			}
		}

		#endregion

		#endregion

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
	}
}
