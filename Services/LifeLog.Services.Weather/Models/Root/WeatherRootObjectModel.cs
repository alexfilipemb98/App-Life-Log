using Newtonsoft.Json;

namespace LifeLog.Services.Weather.Models.Root
{
	public class WeatherRootObjectModel
	{
		[JsonProperty("main")]
		public MainModel Main { get; set; }

		[JsonProperty("weather")]
		public WeatherModel[] Weather { get; set; }

		[JsonProperty("clouds")]
		public CloudsModel Clouds { get; set; }

		[JsonProperty("wind")]
		public WindModel Wind { get; set; }

		[JsonProperty("sys")]
		public SysModel Sys { get; set; }

		[JsonProperty("coord")]
		public CoordModel Coord { get; set; }

		[JsonProperty("rain")]
		public RainModel Rain { get; set; }

		[JsonProperty("dt")]
		public int Dt { get; set; }

		[JsonProperty("visibility")]
		public int Visibility { get; set; }

		[JsonProperty("pop")]
		public float Pop { get; set; }

		[JsonProperty("dt_txt")]
		public string DtTxt { get; set; }

		[JsonProperty("base")]
		public string Base { get; set; }

		[JsonProperty("timezone")]
		public int Timezone { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("cod")]
		public int Cod { get; set; }
	}
}
