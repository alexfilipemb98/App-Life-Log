using LifeLog.Base.Utils;
using LifeLog.Services.WeatherApi.Models;
using LifeLog.Services.WeatherApi.Models.Root;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LifeLog.Services.WeatherApi
{
	/// <summary>
	/// https://api.openweathermap.org/data/2.5/weather?q=Leiria,10,PT&appid=f56b2228d2888531cedd5596dd2be12c
	/// https://api.openweathermap.org/data/2.5/forecast?q=Leiria,PT&units=metric&appid=f56b2228d2888531cedd5596dd2be12c
	/// https://api.openweathermap.org/geo/1.0/reverse?lat=39.6023941&lon=-8.8185271&limit=5&appid=f56b2228d2888531cedd5596dd2be12c
	/// https://api.openweathermap.org/geo/1.0/direct?q=porto%20de%20mos,PT&limit=5&appid=f56b2228d2888531cedd5596dd2be12c
	/// </summary>
	public class Engine
	{
		//PRIVATE
		private readonly string _url = "https://api.openweathermap.org/data/2.5/";
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
		public async Task<WeatherRootObjectModel> GetWeather(string country, string state, string city)
		{
			WeatherRootObjectModel weatherData = null;
			string url = $"{_url}weather?q={city},{state},{country}&appid={_key}";

			using (HttpClient client = new HttpClient())
			using (HttpResponseMessage response = await client.GetAsync(url))
			{
				response.EnsureSuccessStatusCode();

				string responseBody = await response.Content.ReadAsStringAsync();

				weatherData = JsonConvert.DeserializeObject<WeatherRootObjectModel>(responseBody);

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
		public async Task<List<SmallMainModel>> SearchCitiesAsync(string query, CancellationToken ct)
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

					List<SmallMainModel> raw = JsonConvert.DeserializeObject<List<SmallMainModel>>(json) ?? new List<SmallMainModel>();

					return raw;
				}
			}
			catch (TaskCanceledException) when (ct.IsCancellationRequested)
			{
				return new List<SmallMainModel>();
			}
		}

		/// <summary>
		/// Reverse geocodes the coordinates
		/// </summary>
		/// <param name="lat"></param>
		/// <param name="lon"></param>
		/// <param name="ct"></param>
		/// <returns></returns>
		public async Task<List<SmallMainModel>> ReverseGeocodeAsync(double lat, double lon)
		{
			string url = $"https://api.openweathermap.org/geo/1.0/reverse?lat={lat}&lon={lon}&limit=5&appid={_key}";

			using (HttpClient client = new HttpClient())
			using (HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url))
			{
				HttpResponseMessage resp = await client.SendAsync(req, HttpCompletionOption.ResponseHeadersRead);
				resp.EnsureSuccessStatusCode();

				string json = await resp.Content.ReadAsStringAsync();

				List<SmallMainModel> raw = JsonConvert.DeserializeObject<List<SmallMainModel>>(json) ?? new List<SmallMainModel>();

				return raw;
			}
		}

		/// <summary>
		/// Gets the weather by coordinates
		/// </summary>
		/// <param name="lat"></param>
		/// <param name="lon"></param>
		/// <returns></returns>
		public async Task<WeatherRootObjectModel> GetWeatherByCoordinates(double lat, double lon)
		{
			WeatherRootObjectModel weatherData = null;
			string url = $"{_url}weather?lat={lat}&lon={lon}&appid={_key}&units=metric";

			using (HttpClient client = new HttpClient())
			using (HttpResponseMessage response = await client.GetAsync(url))
			{
				response.EnsureSuccessStatusCode();
				string responseBody = await response.Content.ReadAsStringAsync();

				weatherData = JsonConvert.DeserializeObject<WeatherRootObjectModel>(responseBody);

				weatherData.Weather.First().Image = ImagesUtil.ImageUrlToBitmap($"http://openweathermap.org/img/wn/{weatherData.Weather.First().Icon}@2x.png");

				return weatherData;
			}
		}

		/// <summary>
		/// Forecast for 5 days
		/// </summary>
		/// <param name="lat"></param>
		/// <param name="lon"></param>
		/// <returns></returns>
		public async Task<(List<DailySummaryModel>, List<Next24HoursModel>)> GetForecast(double lat, double lon)
		{
			string url = $"{_url}/forecast?lat={lat}&lon={lon}&units=metric&appid={_key}";

			using (HttpClient client = new HttpClient())
			using (HttpResponseMessage response = await client.GetAsync(url))
			{
				response.EnsureSuccessStatusCode();
				string responseBody = await response.Content.ReadAsStringAsync();

				ForecastRootObjectModel forecast = JsonConvert.DeserializeObject<ForecastRootObjectModel>(responseBody);

				List<Next24HoursModel> next12Hours = forecast.List
					.Take(8) // 4 blocos * 3h = 12h
					.Select(item => new Next24HoursModel
					{
						Time = DateTime.Parse(item.DtTxt),
						Temp = item.Main.Temp
					})
					.ToList();

				var dailyGroups = forecast.List
					.Select(item => new
					{
						Item = item,
						Date = DateTime.Parse(item.DtTxt)
					})
					.GroupBy(x => x.Date)
					.OrderBy(x => x.Key)
					.Take(5);

				List<DailySummaryModel> next5Days = new List<DailySummaryModel>();

				foreach (var dayGroup in dailyGroups)
				{
					List<WeatherRootObjectModel> items = dayGroup.Select(x => x.Item).ToList();

					double minTemp = items.Min(i => i.Main.TempMin);
					double maxTemp = items.Max(i => i.Main.TempMin);

					string icon = items
						.Where(i => i.Weather != null && i.Weather.Any())
						.GroupBy(i => i.Weather.First().Icon)
						.OrderByDescending(g => g.Count())
						.Select(g => g.Key)
						.FirstOrDefault();

					next5Days.Add(new DailySummaryModel
					{
						Date = dayGroup.Key,
						MinTemp = minTemp,
						MaxTemp = maxTemp,
						Icon = icon
					});
				}

				return (next5Days, next12Hours);
			}
		}

	
	}
}
