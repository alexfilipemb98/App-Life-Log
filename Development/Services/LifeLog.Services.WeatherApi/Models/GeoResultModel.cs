using LifeLog.Base.Utils;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LifeLog.Services.WeatherApi.Models
{
	public class GeoResultModel
	{
		[JsonProperty("name")]
		public string Name { get; set; } = string.Empty;

		[JsonProperty("country")]
		public string Country { get; set; } = string.Empty;

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("lat")]
		public double Latitude { get; set; }

		[JsonProperty("lon")]
		public double Longitude { get; set; }

		[JsonProperty("local_names")]
		public Dictionary<string, string> LocalNames { get; set; }

		[JsonIgnore]
		public string CountryFlag => Country.ToFlagEmoji();

		[JsonIgnore]
		public string DisplayName =>
			string.IsNullOrWhiteSpace(State)
				? $"{Name}, {Country}"
				: $"{Name}, {State}, {Country}";

		[JsonIgnore]
		public string SearchName =>
			$"{DisplayName}   (Lat: {Latitude:0.#####}, Lon: {Longitude:0.#####})";

		[JsonIgnore]
		public string HtmlSearchName =>
			$"<b>{CountryFlag} {DisplayName}</b><br>" +
			$"<color=Gray>(Lat: {Latitude:0.#####}, Lon: {Longitude:0.#####})</color>";

		public override string ToString() => SearchName;
	}
}
