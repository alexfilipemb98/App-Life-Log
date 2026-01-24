using System.Globalization;
using System.Threading.Tasks;
using LifeLog.Core.Utils;
using LifeLog.Services.Weather.Models;
using LifeLog.Services.Weather.Models.Root;
using Newtonsoft.Json;

namespace LifeLog.Services.Weather;

/// <summary>
/// https://api.openweathermap.org/data/2.5/weather?q=Leiria,10,PT&appid=f56b2228d2888531cedd5596dd2be12c 
/// https://api.openweathermap.org/data/2.5/forecast?q=Leiria,PT&units=metric&appid=f56b2228d2888531cedd5596dd2be12c 
/// https://api.openweathermap.org/geo/1.0/reverse?lat=39.6023941&lon=-8.8185271&limit=5&appid=f56b2228d2888531cedd5596dd2be12c
/// https://api.openweathermap.org/geo/1.0/direct?q=porto%20de%20mos,PT&limit=5&appid=f56b2228d2888531cedd5596dd2be12c 
/// </summary>
public sealed class WeatherData
{
	private static readonly Uri BaseUri = new Uri("https://api.openweathermap.org/");

	private readonly HttpClient _http;
	private readonly string _key;

	// opcional
	private readonly string _defaultUnits;
	private readonly string? _defaultLang;

	/// <summary>
	/// Cria engine com HttpClient injetado (recomendado).
	/// </summary>
	public WeatherData(string key, HttpClient httpClient, string defaultUnits = "metric", string? defaultLang = null)
	{
		_key = key ?? throw new ArgumentNullException(nameof(key));
		_http = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

		if (_http.BaseAddress == null)
			_http.BaseAddress = BaseUri;

		_defaultUnits = defaultUnits;
		_defaultLang = defaultLang;
	}

	/// <summary>
	/// Cria engine sem DI (ok, mas garante 1 HttpClient para toda a vida do Engine).
	/// </summary>
	public WeatherData(string key, string defaultUnits = "metric", string? defaultLang = null)
		: this(key, new HttpClient { BaseAddress = BaseUri }, defaultUnits, defaultLang)
	{
	}

	/// <summary>
	/// Gets the weather by country, state and city
	/// </summary>
	public async Task<WeatherRootObjectModel?> GetWeather(string country, string state, string city, CancellationToken ct = default)
	{
		// Nota: para MSSQL etc não importa, mas para OpenWeather convém enviar units
		string q = $"{city},{state},{country}".Trim().Trim(',');

		string url = BuildUrl("data/2.5/weather", new Dictionary<string, string?>
		{
			["q"] = q,
			["units"] = _defaultUnits,
			["lang"] = _defaultLang
		});

		var weatherData = await GetJsonAsync<WeatherRootObjectModel>(url, ct);

		// ícone
		await TryAttachIcon(weatherData);

		return weatherData;
	}

	/// <summary>
	/// Searches for cities matching the query
	/// </summary>
	public async Task<List<SmallMainModel>> SearchCitiesAsync(string query, CancellationToken ct)
	{
		if (string.IsNullOrWhiteSpace(query))
			return new List<SmallMainModel>();

		string normalized = StringsUtil.RemoveAccents(query);

		string url = BuildUrl("geo/1.0/direct", new Dictionary<string, string?>
		{
			["q"] = normalized,
			["limit"] = "5"
		});

		try
		{
			var raw = await GetJsonAsync<List<SmallMainModel>>(url, ct);
			return raw ?? new List<SmallMainModel>();
		}
		catch (TaskCanceledException) when (ct.IsCancellationRequested)
		{
			return new List<SmallMainModel>();
		}
	}

	/// <summary>
	/// Reverse geocodes the coordinates
	/// </summary>
	public async Task<List<SmallMainModel>> ReverseGeocodeAsync(double lat, double lon, CancellationToken ct = default)
	{
		string url = BuildUrl("geo/1.0/reverse", new Dictionary<string, string?>
		{
			["lat"] = lat.ToString(CultureInfo.InvariantCulture),
			["lon"] = lon.ToString(CultureInfo.InvariantCulture),
			["limit"] = "5"
		});

		var raw = await GetJsonAsync<List<SmallMainModel>>(url, ct);
		return raw ?? new List<SmallMainModel>();
	}

	/// <summary>
	/// Gets the weather by coordinates
	/// </summary>
	public async Task<WeatherRootObjectModel?> GetWeatherByCoordinates(double lat, double lon, CancellationToken ct = default)
	{
		string url = BuildUrl("data/2.5/weather", new Dictionary<string, string?>
		{
			["lat"] = lat.ToString(CultureInfo.InvariantCulture),
			["lon"] = lon.ToString(CultureInfo.InvariantCulture),
			["units"] = _defaultUnits,
			["lang"] = _defaultLang
		});

		var weatherData = await GetJsonAsync<WeatherRootObjectModel>(url, ct);

		await TryAttachIcon(weatherData);

		return weatherData;
	}

	/// <summary>
	/// Forecast (endpoint /forecast = 5 dias em blocos de 3h)
	/// Devolve (5 dias resumo, próximas 24 horas)
	/// </summary>
	public async Task<(List<DailySummaryModel> Next5Days, List<Next24HoursModel> Next24Hours)>
		GetForecast(double lat, double lon, CancellationToken ct = default)
	{
		string url = BuildUrl("data/2.5/forecast", new Dictionary<string, string?>
		{
			["lat"] = lat.ToString(CultureInfo.InvariantCulture),
			["lon"] = lon.ToString(CultureInfo.InvariantCulture),
			["units"] = _defaultUnits,
			["lang"] = _defaultLang
		});

		var forecast = await GetJsonAsync<ForecastRootObjectModel>(url, ct);

		if (forecast?.List == null || forecast.List.Count() == 0)
			return (new List<DailySummaryModel>(), new List<Next24HoursModel>());

		// Próximas 24h: 8 * 3h = 24h
		var next24Hours = forecast.List
			.Take(8)
			.Select(item => new Next24HoursModel
			{
				Time = ParseDtTxt(item.DtTxt),
				Temp = item.Main.Temp
			})
			.ToList();

		// Agrupar por DIA (Date)
		var dailyGroups = forecast.List
			.Select(item => new
			{
				Item = item,
				Day = ParseDtTxt(item.DtTxt).Date
			})
			.GroupBy(x => x.Day)
			.OrderBy(g => g.Key)
			.Take(5);

		var next5Days = new List<DailySummaryModel>();

		foreach (var dayGroup in dailyGroups)
		{
			var items = dayGroup.Select(x => x.Item).ToList();

			double minTemp = items.Min(i => i.Main.TempMin);
			double maxTemp = items.Max(i => i.Main.TempMax); // ✅ corrigido

			string? icon = items
				.Where(i => i.Weather != null && i.Weather.Any())
				.GroupBy(i => i.Weather.First().Icon)
				.OrderByDescending(g => g.Count())
				.Select(g => g.Key)
				.FirstOrDefault();

			next5Days.Add(new DailySummaryModel
			{
				Date = dayGroup.Key,
				MinTemp = minTemp,
				MaxTemp = maxTemp,
				Icon = icon ?? string.Empty
			});
		}

		return (next5Days, next24Hours);
	}

	#region FUNCTIONS

	#region PRIVATE

	private async Task<T?> GetJsonAsync<T>(string url, CancellationToken ct)
	{
		using var req = new HttpRequestMessage(HttpMethod.Get, url);
		using HttpResponseMessage resp = await _http.SendAsync(req, HttpCompletionOption.ResponseHeadersRead, ct);

		resp.EnsureSuccessStatusCode();

		string json = await resp.Content.ReadAsStringAsync();
		return JsonConvert.DeserializeObject<T>(json);
	}

	private string BuildUrl(string path, Dictionary<string, string?> query)
	{
		// appid sempre
		query["appid"] = _key;

		// montar querystring
		var parts = query
			.Where(kvp => !string.IsNullOrWhiteSpace(kvp.Value))
			.Select(kvp => $"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value!)}");

		return $"{path}?{string.Join("&", parts)}";
	}

	private static DateTime ParseDtTxt(string dtTxt)
	{
		// OpenWeather costuma enviar "yyyy-MM-dd HH:mm:ss"
		if (DateTime.TryParse(dtTxt, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out var dt))
			return dt;

		return DateTime.Parse(dtTxt);
	}

	private static async Task TryAttachIcon(WeatherRootObjectModel? weatherData)
	{
		if (weatherData?.Weather == null || weatherData.Weather.Count() == 0)
			return;

		string? icon = weatherData.Weather.First().Icon;
		if (string.IsNullOrWhiteSpace(icon))
			return;

		weatherData.Weather.First().Image =
		   await ImagesUtil.ImageUrlToBitmapAsync($"https://openweathermap.org/img/wn/{icon}@2x.png");
	}

	#endregion

	#endregion
}