using LifeLog.Core.Utils;
using Newtonsoft.Json;

namespace LifeLog.Services.Weather.Models;

public class SmallMainModel
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("local_names")]
    public LocalNamesModel LocalNames { get; set; }

    [JsonProperty("lat")]
    public float Lat { get; set; }

    [JsonProperty("lon")]
    public float Lon { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonIgnore]
    public string CountryFlag => Country.ToFlagEmoji();

    [JsonIgnore]
    public string DisplayName =>
        string.IsNullOrWhiteSpace(State)
            ? $"{Name}, {Country}"
            : $"{Name}, {State}, {Country}";

    [JsonIgnore]
    public string SearchName =>
        $"{DisplayName}   (Lat: {Lat:0.#####}, Lon: {Lon:0.#####})";

    [JsonIgnore]
    public string HtmlSearchName =>
        $"<b>{CountryFlag} {DisplayName}</b><br>" +
        $"<color=Gray>(Lat: {Lat:0.#####}, Lon: {Lon:0.#####})</color>";

    public override string ToString() => SearchName;
}
