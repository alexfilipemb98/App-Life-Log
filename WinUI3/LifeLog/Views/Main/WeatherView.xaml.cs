using LifeLog.Core.Items;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Shapes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace LifeLog.Views.Main;

public sealed partial class WeatherView : UserControl
{
    //PRIVATE
    private readonly HttpClient _httpClient = new HttpClient();
    private const string API_KEY = "f56b2228d2888531cedd5596dd2be12c";
    private string _lastSearchedCity = "Leiria,PT";
    private ObservableCollection<DailyForecastItem> FiveDayForecast;

    public WeatherView()
    {
        this.InitializeComponent();
        FiveDayForecast = new ObservableCollection<DailyForecastItem>();
        DailyForecastList.ItemsSource = FiveDayForecast;
        
        _ = FetchWeatherData(_lastSearchedCity);
    }

    private async void CitySearchBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
    {
        if (args.Reason != AutoSuggestionBoxTextChangeReason.UserInput)
        {
            return;
        }

        string query = sender.Text?.Trim() ?? string.Empty;
        if (query.Length < 2)
        {
            sender.ItemsSource = null;
            return;
        }

        try
        {
            sender.ItemsSource = await FetchCitySuggestions(query);
        }
        catch (Exception ex)
        {
            sender.ItemsSource = null;
            System.Diagnostics.Debug.WriteLine(ex.Message);
        }
    }

    private void CitySearchBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
    {
        if (args.SelectedItem is string selected)
        {
            sender.Text = selected;
        }
    }

    private void CitySearchBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
    {
        if (args.ChosenSuggestion is string chosen)
        {
            _lastSearchedCity = chosen;
            _ = FetchWeatherData(_lastSearchedCity);
            return;
        }

        if (!string.IsNullOrWhiteSpace(args.QueryText))
        {
            _lastSearchedCity = args.QueryText;
            _ = FetchWeatherData(_lastSearchedCity);
        }
    }

    private void RefreshBtn_Click(object sender, RoutedEventArgs e)
    {
        _ = FetchWeatherData(_lastSearchedCity);
    }

    private async Task<List<string>> FetchCitySuggestions(string query)
    {
        string suggestUrl = $"https://api.openweathermap.org/geo/1.0/direct?q={Uri.EscapeDataString(query)}&limit=5&appid={API_KEY}";
        string suggestJson = await _httpClient.GetStringAsync(suggestUrl);
        JsonNode suggestData = JsonNode.Parse(suggestJson);
        if (suggestData is null)
        {
            return new List<string>();
        }

        var suggestions = new List<string>();
        foreach (var item in suggestData.AsArray())
        {
            string name = (string)item["name"];
            string state = (string?)item["state"] ?? string.Empty;
            string country = (string)item["country"];

            var parts = new List<string> { name };
            if (!string.IsNullOrWhiteSpace(state))
            {
                parts.Add(state);
            }

            if (!string.IsNullOrWhiteSpace(country))
            {
                parts.Add(country);
            }

            suggestions.Add(string.Join(", ", parts));
        }

        return suggestions.Distinct().ToList();
    }

    private async Task FetchWeatherData(string query)
    {
        LastUpdateLabel.Text = "Fetching data...";

        try
        {
            // 1. DADOS ATUAIS
            string currentUrl = $"https://api.openweathermap.org/data/2.5/weather?q={query}&units=metric&appid={API_KEY}";
            string currentJson = await _httpClient.GetStringAsync(currentUrl);
            JsonNode currentData = JsonNode.Parse(currentJson);
            UpdateCurrentWeatherUI(currentData);
            int timezoneOffsetSeconds = (int)currentData["timezone"];

            // 2. PREVISÃO 5 DIAS / 3 HORAS
            string forecastUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={query}&units=metric&appid={API_KEY}";
            string forecastJson = await _httpClient.GetStringAsync(forecastUrl);
            JsonNode forecastData = JsonNode.Parse(forecastJson);

            // Atualizar o gráfico das 24 horas (próximos 8 segmentos de 3h)
            Update24HourChart(forecastData, timezoneOffsetSeconds);

            // Atualizar os cartões dos próximos 5 dias
            Update5DayForecast(forecastData, timezoneOffsetSeconds);

            LastUpdateLabel.Text = $"Last update: {DateTime.Now.ToString("yyyy/MM/dd HH:mm")}";
        }
        catch (Exception ex)
        {
            LastUpdateLabel.Text = "Error fetching data. Check city name.";
            System.Diagnostics.Debug.WriteLine(ex.Message);
        }
    }

    private void UpdateCurrentWeatherUI(JsonNode data)
    {
        CityTitle.Text = $"{((string)data["name"]).ToUpper()}, {(string)data["sys"]["country"]}";
        TempLabel.Text = Math.Round((double)data["main"]["temp"]).ToString();
        FeelsLikeLabel.Text = $"Feels like {Math.Round((double)data["main"]["feels_like"])}°C";
        ConditionText.Text = (string)data["weather"][0]["description"];
        MainWeatherIcon.Glyph = GetIconForWeather((string)data["weather"][0]["main"]);
        CloudinessText.Text = $"Cloudiness: {(int)data["clouds"]["all"]}%";
        PressureText.Text = $"Pressure: {(int)data["main"]["pressure"]} hPa";
        HumidityText.Text = $"Humidity: {(int)data["main"]["humidity"]}%";
        WindSpeedText.Text = $"{Math.Round((double)data["wind"]["speed"] * 3.6, 1)} km/h";
        WindDirText.Text = $"Direction: {GetCompassDirection((int)data["wind"]["deg"])}";

        int timezoneOffsetSeconds = (int)data["timezone"];
        SunriseTimeText.Text = UnixTimeStampToDateTime((long)data["sys"]["sunrise"], timezoneOffsetSeconds).ToString("HH:mm");
        SunsetTimeText.Text = UnixTimeStampToDateTime((long)data["sys"]["sunset"], timezoneOffsetSeconds).ToString("HH:mm");
    }

    // --- A MAGIA DO GRÁFICO (AGORA COM TEMPERATURAS!) ---
    private void Update24HourChart(JsonNode data, int timezoneOffsetSeconds)
    {
        var list = data["list"].AsArray();
        int pointCount = Math.Min(8, list.Count); // 8 segmentos = 24 horas

        ForecastCanvas.Children.Clear(); // Limpa o quadro

        // Encontrar mínimas e máximas para a escala do gráfico
        double minTemp = double.MaxValue, maxTemp = double.MinValue;
        for (int i = 0; i < pointCount; i++)
        {
            double t = (double)list[i]["main"]["temp"];
            if (t < minTemp) minTemp = t;
            if (t > maxTemp) maxTemp = t;
        }

        double range = maxTemp - minTemp;
        if (range == 0) range = 1;

        double canvasWidth = 900; // Largura do espaço do gráfico
        double canvasHeight = 100; // Altura útil
        double stepX = canvasWidth / (pointCount - 1); // Distância entre pontos

        // Preparar a linha principal
        var polyline = new Polyline
        {
            Stroke = App.Current.Resources["SystemAccentColor"] as Brush ?? new SolidColorBrush(Microsoft.UI.Colors.DodgerBlue),
            StrokeThickness = 3,
            StrokeLineJoin = PenLineJoin.Round
        };

        for (int i = 0; i < pointCount; i++)
        {
            double t = (double)list[i]["main"]["temp"];
            DateTime localTime = UnixTimeStampToDateTime((long)list[i]["dt"], timezoneOffsetSeconds);

            double x = i * stepX;
            // Normaliza o Y (inverter porque no Canvas o Y cresce para baixo)
            double y = canvasHeight - (((t - minTemp) / range) * canvasHeight) + 20;

            polyline.Points.Add(new Windows.Foundation.Point(x, y));

            // Texto da Temperatura (Em cima do ponto)
            var tempText = new TextBlock
            {
                Text = $"{Math.Round(t)}°",
                FontSize = 14,
                FontWeight = Microsoft.UI.Text.FontWeights.Bold,
                Foreground = App.Current.Resources["TextFillColorPrimaryBrush"] as Brush
            };
            Canvas.SetLeft(tempText, x - 10);
            Canvas.SetTop(tempText, y - 25); // Puxar 25px para cima

            // Texto da Hora (Em baixo do gráfico)
            var timeText = new TextBlock
            {
                Text = localTime.ToString("HH:mm"),
                FontSize = 12,
                Foreground = App.Current.Resources["TextFillColorSecondaryBrush"] as Brush
            };
            Canvas.SetLeft(timeText, x - 15);
            Canvas.SetTop(timeText, canvasHeight + 35); // Puxar para a base

            ForecastCanvas.Children.Add(tempText);
            ForecastCanvas.Children.Add(timeText);
        }

        // Adiciona a linha no fim, para ficar por trás do texto
        ForecastCanvas.Children.Add(polyline);
    }

    // --- NOVIDADE: PREVISÃO DE 5 DIAS ---
    private void Update5DayForecast(JsonNode data, int timezoneOffsetSeconds)
    {
        var list = data["list"].AsArray();
        FiveDayForecast.Clear();

        // Agrupa os dados por DIA usando LINQ!
        var dailyGroups = list.GroupBy(item =>
            UnixTimeStampToDateTime((long)item["dt"], timezoneOffsetSeconds).Date);

        int dayCount = 0;
        foreach (var group in dailyGroups)
        {
            // Salta o dia de hoje, queremos mostrar os PRÓXIMOS 5 dias
            if (group.Key == DateTime.Now.Date) continue;
            if (dayCount >= 5) break;

            double maxT = group.Max(item => (double)item["main"]["temp_max"]);
            double minT = group.Min(item => (double)item["main"]["temp_min"]);

            // Pega na condição meteorológica do meio do dia (12h) ou da primeira disponível
            var midDayItem = group.FirstOrDefault(item =>
                UnixTimeStampToDateTime((long)item["dt"], timezoneOffsetSeconds).Hour >= 12) ?? group.First();

            string iconCond = (string)midDayItem["weather"][0]["main"];

            FiveDayForecast.Add(new DailyForecastItem
            {
                DayName = group.Key.ToString("ddd, MMM dd"), // Ex: "Wed, Apr 30"
                MaxTempStr = $"{Math.Round(maxT)}°",
                MinTempStr = $"{Math.Round(minT)}°",
                IconGlyph = GetIconForWeather(iconCond)
            });

            dayCount++;
        }
    }

    private DateTime UnixTimeStampToDateTime(long unixTimeStamp, int timezoneOffset)
    {
        DateTimeOffset dto = DateTimeOffset.FromUnixTimeSeconds(unixTimeStamp);
        return dto.ToOffset(TimeSpan.FromSeconds(timezoneOffset)).DateTime;
    }

    private string GetCompassDirection(int degree)
    {
        string[] caridnals = { "N", "NE", "E", "SE", "S", "SW", "W", "NW", "N" };
        return caridnals[(int)Math.Round(((double)degree % 360) / 45)];
    }

    private string GetIconForWeather(string condition)
    {
        return condition.ToLower() switch
        {
            "clear" => "\uE706",
            "clouds" => "\uE753",
            "rain" => "\uE738",
            "snow" => "\uE8B1",
            "thunderstorm" => "\uE90D",
            "drizzle" => "\uE738",
            _ => "\uE753"
        };
    }
}