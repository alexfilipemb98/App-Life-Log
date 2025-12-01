using Newtonsoft.Json;

namespace LifeLog.Services.WeatherApi.Models.Root
{
	public class ForecastRootObjectModel
	{
		[JsonProperty("cod")]
		public string Cod { get; set; }

		[JsonProperty("message")]
		public int Message { get; set; }

		[JsonProperty("cnt")]
		public int Cnt { get; set; }

		[JsonProperty("list")]
		public WeatherRootObjectModel[] List { get; set; }

		[JsonProperty("city")]
		public CityModel City { get; set; }
	}
}
