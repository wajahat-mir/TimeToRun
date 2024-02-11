using TimeToRun.Models;

namespace TimeToRun.Interfaces
{
    public interface IWeatherRespository
    {
        Task<WeatherData> WeeklyConditions(double latitude, double longitude);
    }
}
