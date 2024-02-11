using System.Text.Json;
using TimeToRun.Interfaces;
using TimeToRun.Models;

namespace TimeToRun.Repositories
{
    public class WeatherRespository : IWeatherRespository
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherRespository(IHttpClientFactory httpClientFactory) =>
            _httpClientFactory = httpClientFactory;

        public async Task<WeatherData> WeeklyConditions(double latitude, double longitude)
        {
            var httpClient = _httpClientFactory.CreateClient("OpenMeteo");
            var httpResponseMessage = await httpClient.GetAsync($"?latitude={latitude.ToString()}&longitude={longitude.ToString()}&daily=apparent_temperature_max,apparent_temperature_min,precipitation_sum,wind_speed_10m_max,uv_index_max");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();

                return await JsonSerializer.DeserializeAsync
                    <WeatherData>(contentStream);
            }
            return null;
        }
    }
}
