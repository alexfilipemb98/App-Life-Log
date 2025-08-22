using DevExpress.XtraEditors.Controls;
using LifeLog.Base.Utils;
using LifeLog.UI.Common.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
			//	CountriesObject country = ((CountriesObject)slupCountries.EditValue);
			//	StatesObject state = ((StatesObject)slueState.EditValue);
			//	CitiesObject city = ((CitiesObject)slueCity.EditValue);

				//string url = $"https://api.openweathermap.org/data/2.5/weather?q={city.name},{state.state_code},{country.iso2}&appid=f56b2228d2888531cedd5596dd2be12c";
				string url = $"https://api.openweathermap.org/data/2.5/weather?q=Leiria,10,PT&appid=f56b2228d2888531cedd5596dd2be12c";

				using (HttpClient client = new HttpClient())
				{
					HttpResponseMessage response = await client.GetAsync(url);

					if (response.IsSuccessStatusCode)
					{
						string responseBody = await response.Content.ReadAsStringAsync();

						JObject weatherData = JsonConvert.DeserializeObject<JObject>(responseBody);

						lcgWeatherInformationGroup.Text = $"Weather Information for - {weatherData["Name"]},{weatherData["sys"]?["country"]} {ConversionUtil.KelvinToCelsius(weatherData["main"]?["temp"]?.ToObject<double>() ?? 0.0)} ºC";

			//			WeatherDataListObject weatherState = weatherData.Weather.FirstOrDefault();
			//			teWeatherState.Text = $"{weatherState.Main} - {weatherState.Description}";
			//			peWheatherState.Image = ImageUtil.ImageUrlToBitmap($"http://openweathermap.org/img/wn/{weatherState.Icon}@2x.png");
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
			catch (Exception ex)
			{
				ErrorHelper.Handler(ex);
			}
		}

		#endregion

		#region BUTTON CLICK

		/// <summary>
		/// Buttons click event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void slupCountries_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			try
			{
				switch (e.Button.Kind)
				{
					case ButtonPredefines.DropDown:
						slupCountries.ShowPopup();
						break;
					case ButtonPredefines.Clear:
						slupCountries.Clear();
						break;
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
		/// When selected country is changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void slupCountries_EditValueChanged(object sender, EventArgs e)
		{
			//try
			//{
			//	CountriesObject country = ((CountriesObject)slupCountries.EditValue);
			//	EditorButton btnFlag = slupCountries.Properties.Buttons.FirstOrDefault(w => w.Tag.ToString() == "CountryFlag");
			//	EditorButton btnClear = slupCountries.Properties.Buttons.FirstOrDefault(w => w.Kind == ButtonPredefines.Clear);

			//	slueState.EditValue = null;

			//	if (country != null)
			//	{
			//		bsStates.DataSource = Program.CORE.JsonData.GetListStates(out _).Where(w => w.country_id == country.id);
			//		btnFlag.ImageOptions.Image = ImageUtil.DownloadImage($"https://flagsapi.com/{country.iso2}/flat/24.png");
			//		btnClear.Visible = true;
			//		btnFlag.Visible = true;
			//		slueState.Enabled = true;
			//		sbSearch.Enabled = true;
			//	}
			//	else
			//	{
			//		bsStates.DataSource = new List<StatesObject>();
			//		btnFlag.ImageOptions.Image = null;
			//		btnClear.Visible = false;
			//		btnFlag.Visible = false;
			//		slueState.Enabled = false;
			//		slueState.EditValue = null;
			//		sbSearch.Enabled = false;
			//	}
			//}
			//catch (Exception ex)
			//{
			//	//AppHelper.ErrorHandler(ex);
			//}
		}

		/// <summary>
		/// States edit value 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void slueState_EditValueChanged(object sender, EventArgs e)
		{
			//try
			//{
			//	StatesObject state = ((StatesObject)slueState.EditValue);

			//	slueCity.EditValue = null;

			//	if (state != null)
			//	{
			//		bsCities.DataSource = Program.CORE.JsonData.GetListCities(out _).Where(w => w.state_id == state.id);
			//	}
			//	else
			//	{
			//		bsCities.DataSource = new List<CitiesObject>();
			//	}
			//}
			//catch (Exception ex)
			//{
			//	//AppHelper.ErrorHandler(ex);
			//}
		}

		#endregion

	}
}
