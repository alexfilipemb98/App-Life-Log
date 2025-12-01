using Newtonsoft.Json;

namespace LifeLog.Services.WeatherApi.Models
{
	public class CoordModel
	{
		[JsonProperty("lat")]
		public float Lat { get; set; }
		
		[JsonProperty("lon")]
		public float Lon { get; set; }
	}
}
