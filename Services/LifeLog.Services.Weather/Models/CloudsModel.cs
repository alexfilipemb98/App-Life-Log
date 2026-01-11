using Newtonsoft.Json;

namespace LifeLog.Services.Weather.Models
{
	public class CloudsModel
	{
		[JsonProperty("all")]
		public int All { get; set; }
	}
}
