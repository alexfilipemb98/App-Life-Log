using LifeLog.Base.Utils;
using LifeLog.Services.WeatherApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace LifeLog.Services.WeatherApi
{
	/// <summary>
	/// https://api.openweathermap.org/data/2.5/weather?q=Leiria,10,PT&appid=f56b2228d2888531cedd5596dd2be12c
	/// </summary>
	public class Engine
	{
		//PRIVATE
		private readonly string _urlWeather = "https://api.openweathermap.org/data/2.5/weather?";
		private readonly string _key;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="key"></param>
		public Engine(string key)
		{
			_key = key;
		}

		/// <summary>
		/// Gets the weather by country state and city
		/// </summary>
		/// <param name="country"></param>
		/// <param name="state"></param>
		/// <param name="city"></param>
		/// <returns></returns>
		public async Task<RootModel> GetWeather(string country, string state, string city)
		{
			RootModel weatherData = null;
			string url = $"{_urlWeather}q={city},{state},{country}&appid={_key}";

			using (HttpClient client = new HttpClient())
			using (HttpResponseMessage response = await client.GetAsync(url))
			{
				response.EnsureSuccessStatusCode();

				string responseBody = await response.Content.ReadAsStringAsync();

				weatherData = JsonConvert.DeserializeObject<RootModel>(responseBody);

				weatherData.Weather.First().Image = ImagesUtil.ImageUrlToBitmap($"http://openweathermap.org/img/wn/{weatherData.Weather.First().Icon}@2x.png");
			}

			return weatherData;
		}

		/// <summary>
		/// Searches for cities matching the query
		/// </summary>
		/// <param name="query"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		public async Task<List<GeoResultModel>> SearchCitiesAsync(string query, CancellationToken ct)
		{
			string normalized = StringsUtil.RemoveAccents(query);
			string url = $"https://api.openweathermap.org/geo/1.0/direct?q={Uri.EscapeDataString(normalized)}&limit=5&appid={_key}";

			try
			{
				using (HttpClient client = new HttpClient())
				using (HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url))
				{
					HttpResponseMessage resp = await client.SendAsync(req, HttpCompletionOption.ResponseHeadersRead, ct);

					resp.EnsureSuccessStatusCode();

					string json = await resp.Content.ReadAsStringAsync();

					List<GeoResultModel> raw = JsonConvert.DeserializeObject<List<GeoResultModel>>(json) ?? new List<GeoResultModel>();

					return raw;
				}
			}
			catch (TaskCanceledException) when (ct.IsCancellationRequested)
			{
				return new List<GeoResultModel>();
			}
		}


		// Example API call for reverse geocoding:
		//https://api.openweathermap.org/geo/1.0/reverse?lat=40.3043902&lon=-7.8740397&limit=5&appid=f56b2228d2888531cedd5596dd2be12c

		/// <summary>
		/// Gets the weather by coordinates
		/// </summary>
		/// <param name="lat"></param>
		/// <param name="lon"></param>
		/// <returns></returns>
		public async Task<RootModel> GetWeatherByCoordinates(double lat, double lon)
		{
			RootModel weatherData = null;
			string url = $"{_urlWeather}lat={lat}&lon={lon}&appid={_key}&units=metric";

			using (HttpClient client = new HttpClient())
			using (HttpResponseMessage response = await client.GetAsync(url))
			{
				response.EnsureSuccessStatusCode();
				string responseBody = await response.Content.ReadAsStringAsync();

				weatherData = JsonConvert.DeserializeObject<RootModel>(responseBody);

				weatherData.Weather.First().Image = ImagesUtil.ImageUrlToBitmap($"http://openweathermap.org/img/wn/{weatherData.Weather.First().Icon}@2x.png");

				return weatherData;
			}
		}

		// Example API call for next 5 days
		//https://api.openweathermap.org/data/2.5/forecast?q=Leiria,PT&units=metric&appid=f56b2228d2888531cedd5596dd2be12c

	}
}
