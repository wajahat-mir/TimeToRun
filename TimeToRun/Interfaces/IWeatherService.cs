using TimeToRun.Models;

namespace TimeToRun.Interfaces
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherModel>> GetWeeklyWeather(double latitude, double longitude);
    }
}
