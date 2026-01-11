using Newtonsoft.Json;

namespace LifeLog.Services.Weather.Models
{

	public class MainModel
	{
		[JsonProperty("temp")]
		public float Temp { get; set; }

		[JsonProperty("feels_like")]
		public float FeelsLike { get; set; }

		[JsonProperty("temp_min")]
		public float TempMin { get; set; }

		[JsonProperty("temp_max")]
		public float TempMax { get; set; }

		[JsonProperty("pressure")]
		public int Pressure { get; set; }

		[JsonProperty("sea_level")]
		public int SeaLevel { get; set; }

		[JsonProperty("grnd_level")]
		public int GrndLevel { get; set; }

		[JsonProperty("humidity")]
		public int Humidity { get; set; }

		[JsonProperty("temp_kf")]
		public float TempKf { get; set; }
	}
}
