using Newtonsoft.Json;

namespace LifeLog.Services.WeatherApi.Models
{
	public class CoordModel
	{
		[JsonProperty("lon")]
		public float Lon { get; set; }

		[JsonProperty("lat")]
		public float Lat { get; set; }
	}

}
