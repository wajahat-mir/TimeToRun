using System.Text.Json.Serialization;

namespace TimeToRun.Models
{
    public class WeatherData
    {
        [JsonPropertyName("daily_units")]
        public WeatherUnits Units { get; set; }
        [JsonPropertyName("daily")]
        public WeatherTime DailyForecast { get; set; }   
    }

    public class WeatherTime
    {
        [JsonPropertyName("time")]
        public List<string> Date { get; set; }
        [JsonPropertyName("apparent_temperature_max")]
        public List<double> TemperatureMax { get; set; }
        [JsonPropertyName("apparent_temperature_min")]
        public List<double> TemperatureMin { get; set; }
    }

    public class WeatherUnits
    {
        [JsonPropertyName("apparent_temperature_max")]
        public string ApparentTemperature { get; set; }
        [JsonPropertyName("precipitation_sum")]
        public string Percipitation { get; set; }
        [JsonPropertyName("wind_speed_10m_max")]
        public string WindSpeed { get; set; }
        [JsonPropertyName("uv_index_max")]
        public string Uv { get; set; }
    }
}
