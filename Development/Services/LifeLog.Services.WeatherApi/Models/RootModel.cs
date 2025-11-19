using Newtonsoft.Json;

namespace LifeLog.Services.WeatherApi.Models
{

	public class RootModel
	{
		[JsonProperty("coord")]
		public CoordModel Coord { get; set; }

		[JsonProperty("weather")]
		public WeatherModel[] Weather { get; set; }

		// "_base" é palavra reservada → mapeamos assim
		[JsonProperty("base")]
		public string Base { get; set; }

		[JsonProperty("main")]
		public MainModel Main { get; set; }

		[JsonProperty("visibility")]
		public int Visibility { get; set; }

		[JsonProperty("wind")]
		public WindModel Wind { get; set; }

		[JsonProperty("clouds")]
		public CloudsModel Clouds { get; set; }

		[JsonProperty("dt")]
		public int Dt { get; set; }

		[JsonProperty("sys")]
		public SysModel Sys { get; set; }

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
