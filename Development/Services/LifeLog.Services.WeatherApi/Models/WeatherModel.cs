using Newtonsoft.Json;
using System.Drawing;

namespace LifeLog.Services.WeatherApi.Models
{
	public class WeatherModel
	{
		[JsonIgnore]
		public Bitmap Image { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("main")]
		public string Main { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
