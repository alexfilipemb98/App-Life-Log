using Newtonsoft.Json;

namespace LifeLog.Services.WeatherApi.Models
{
	public class CityModel
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("coord")]
		public CoordModel Coord { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("population")]
		public int Population { get; set; }

		[JsonProperty("timezone")]
		public int Timezone { get; set; }

		[JsonProperty("sunrise")]
		public int Sunrise { get; set; }

		[JsonProperty("sunset")]
		public int Sunset { get; set; }
	}
}
