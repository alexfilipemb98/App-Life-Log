using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace LifeLog.Views.Main
{
    public sealed partial class WeatherView : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient();
        // A tua Key (Num projeto real, guarda isto noutro ficheiro seguro!)
        private const string API_KEY = "f56b2228d2888531cedd5596dd2be12c";
        private string _lastSearchedCity = "Leiria,PT";

        public WeatherView()
        {
            this.InitializeComponent();
            // Carrega os dados de Leiria ao iniciar a app
            _ = FetchWeatherData(_lastSearchedCity);
        }

        private void CitySearchBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
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

        private async Task FetchWeatherData(string query)
        {
            LastUpdateLabel.Text = "Fetching data...";

            try
            {
                // 1. DADOS ATUAIS (CURRENT WEATHER)
                string currentUrl = $"https://api.openweathermap.org/data/2.5/weather?q={query}&units=metric&appid={API_KEY}";
                string currentJson = await _httpClient.GetStringAsync(currentUrl);
                JsonNode currentData = JsonNode.Parse(currentJson);

                UpdateCurrentWeatherUI(currentData);

                // 2. PREVISÃO 24h (FORECAST)
                string forecastUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={query}&units=metric&appid={API_KEY}";
                string forecastJson = await _httpClient.GetStringAsync(forecastUrl);
                JsonNode forecastData = JsonNode.Parse(forecastJson);

                UpdateForecastChart(forecastData, (int)currentData["timezone"]);

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
            // Info Geral
            string city = (string)data["name"];
            string country = (string)data["sys"]["country"];
            CityTitle.Text = $"{city.ToUpper()}, {country}";

            // Temperaturas e Condições
            double temp = (double)data["main"]["temp"];
            double feelsLike = (double)data["main"]["feels_like"];
            TempLabel.Text = Math.Round(temp).ToString();
            FeelsLikeLabel.Text = $"Feels like {Math.Round(feelsLike)}°C";

            string description = (string)data["weather"][0]["description"];
            string mainCond = (string)data["weather"][0]["main"];
            ConditionText.Text = char.ToUpper(description[0]) + description.Substring(1);

            // Ícone Inteligente
            MainWeatherIcon.Glyph = GetIconForWeather(mainCond);

            // Detalhes (Atmosphere)
            CloudinessText.Text = $"Cloudiness: {(int)data["clouds"]["all"]}%";
            PressureText.Text = $"Pressure: {(int)data["main"]["pressure"]} hPa";
            HumidityText.Text = $"Humidity: {(int)data["main"]["humidity"]}%";

            // Vento (Converter m/s para km/h)
            double windSpeedMs = (double)data["wind"]["speed"];
            int windDeg = (int)data["wind"]["deg"];
            WindSpeedText.Text = $"{Math.Round(windSpeedMs * 3.6, 1)} km/h";
            WindDirText.Text = $"Direction: {GetCompassDirection(windDeg)}";

            // Localização e Fuso Horário
            double lat = (double)data["coord"]["lat"];
            double lon = (double)data["coord"]["lon"];
            LatLonText.Text = $"LAT: {lat}, LON: {lon}";

            int timezoneOffsetSeconds = (int)data["timezone"];
            TimeSpan tz = TimeSpan.FromSeconds(timezoneOffsetSeconds);
            TimezoneText.Text = $"UTC {(tz.Hours >= 0 ? "+" : "")}{tz.Hours:00}:{tz.Minutes:00}";

            // Nascer / Pôr do Sol convertido para a hora local da cidade!
            long sunriseUnix = (long)data["sys"]["sunrise"];
            long sunsetUnix = (long)data["sys"]["sunset"];

            SunriseTimeText.Text = UnixTimeStampToDateTime(sunriseUnix, timezoneOffsetSeconds).ToString("HH:mm");
            SunsetTimeText.Text = UnixTimeStampToDateTime(sunsetUnix, timezoneOffsetSeconds).ToString("HH:mm");
        }

        private void UpdateForecastChart(JsonNode data, int timezoneOffsetSeconds)
        {
            var list = data["list"].AsArray();
            ForecastLine.Points.Clear();
            ForecastTimeLabelsGrid.Children.Clear();
            ForecastTimeLabelsGrid.ColumnDefinitions.Clear();

            // Vamos apanhar os próximos 8 segmentos (3h x 8 = 24 horas)
            int pointCount = Math.Min(8, list.Count);

            double minTemp = double.MaxValue;
            double maxTemp = double.MinValue;

            // 1ª Passagem: Encontrar Máximos e Mínimos para escalar o gráfico
            for (int i = 0; i < pointCount; i++)
            {
                double t = (double)list[i]["main"]["temp"];
                if (t < minTemp) minTemp = t;
                if (t > maxTemp) maxTemp = t;
            }

            // Margin de segurança no gráfico para a linha não bater no teto
            double range = maxTemp - minTemp;
            if (range == 0) range = 1;

            // 2ª Passagem: Desenhar Linha e Colocar as Horas
            for (int i = 0; i < pointCount; i++)
            {
                double t = (double)list[i]["main"]["temp"];
                long timeUnix = (long)list[i]["dt"];
                DateTime localTime = UnixTimeStampToDateTime(timeUnix, timezoneOffsetSeconds);

                // Normalizar a temperatura entre 0 e 100 (inverter porque o Y desce no ecrã)
                double normalizedY = 100 - (((t - minTemp) / range) * 100);

                // Adiciona o ponto ao Gráfico (X avança 100px por item)
                ForecastLine.Points.Add(new Windows.Foundation.Point(i * 100, normalizedY));

                // Adiciona a coluna para a Label da Hora
                ForecastTimeLabelsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                // Cria o texto da hora por baixo do gráfico
                var timeBlock = new TextBlock
                {
                    Text = localTime.ToString("HH:mm"),
                    FontSize = 10,
                    Foreground = App.Current.Resources["TextFillColorSecondaryBrush"] as Brush,
                    HorizontalAlignment = HorizontalAlignment.Center
                };

                Grid.SetColumn(timeBlock, i);
                ForecastTimeLabelsGrid.Children.Add(timeBlock);
            }
        }

        // --- MÉTODOS DE AJUDA ---

        private DateTime UnixTimeStampToDateTime(long unixTimeStamp, int timezoneOffset)
        {
            // Converter de Unix para a hora real na cidade pesquisada
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
            // Mapeamento básico para ícones do Segoe Fluent
            return condition.ToLower() switch
            {
                "clear" => "\uE706",   // Sol
                "clouds" => "\uE753",  // Nuvem
                "rain" => "\uE738",    // Chuva
                "snow" => "\uE8B1",    // Neve
                "thunderstorm" => "\uE90D", // Trovoada
                "drizzle" => "\uE738", // Chuvisco
                _ => "\uE753" // Default Nuvem
            };
        }
    }
}