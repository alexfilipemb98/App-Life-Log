using Newtonsoft.Json;

namespace LifeLog.Services.WeatherApi.Models
{
	public class CloudsModel
	{
		[JsonProperty("all")]
		public int All { get; set; }
	}
}
