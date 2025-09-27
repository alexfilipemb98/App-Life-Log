using LifeLog.Base.Utils;
using LifeLog.Services.WeatherApi.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LifeLog.Services.WeatherApi
{
	/// <summary>
	/// https://api.openweathermap.org/data/2.5/weather?q=Leiria,10,PT&appid=f56b2228d2888531cedd5596dd2be12c
	/// </summary>
	public class Engine : IDisposable
	{
		//PRIVATE
		private readonly string _url = "https://api.openweathermap.org/data/2.5/weather?q=";
		private readonly string _key = "f56b2228d2888531cedd5596dd2be12c";

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
			string url = $"{_url}{city},{state},{country}&appid={_key}";

			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage response = await client.GetAsync(url);

				if (response.IsSuccessStatusCode)
				{
					string responseBody = await response.Content.ReadAsStringAsync();

					weatherData = JsonConvert.DeserializeObject<RootModel>(responseBody);

					weatherData.weather.First().image = ImagesUtil.ImageUrlToBitmap($"http://openweathermap.org/img/wn/{weatherData.weather.First().icon}@2x.png");
				
				}

				return weatherData; 
			}
		}

		#region FUNCTIONS
		
		/// <summary>
		/// Dispose
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		public void Dispose()
		{
		}

		#endregion
	}
}
