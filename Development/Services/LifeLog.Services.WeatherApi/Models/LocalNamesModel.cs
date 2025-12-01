using Newtonsoft.Json;

namespace LifeLog.Services.WeatherApi.Models
{
	public class LocalNamesModel
	{
		[JsonProperty("el")]
		public string El { get; set; }

		[JsonProperty("lt")]
		public string Lt { get; set; }

		[JsonProperty("uk")]
		public string Uk { get; set; }

		[JsonProperty("pt")]
		public string Pt { get; set; }

		[JsonProperty("ru")]
		public string Ru { get; set; }

		[JsonProperty("hu")]
		public string Hu { get; set; }

		[JsonProperty("ar")]
		public string Ar { get; set; }
	}
}
