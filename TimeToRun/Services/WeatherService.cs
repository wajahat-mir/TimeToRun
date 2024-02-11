using TimeToRun.Interfaces;
using TimeToRun.Models;

namespace TimeToRun.Services
{
    public class WeatherService: IWeatherService
    {
        private readonly IWeatherRespository _weatherRepository;

        public WeatherService(IWeatherRespository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public async Task<IEnumerable<WeatherModel>> GetWeeklyWeather(double latitude, double longitude)
        {
            var data = await _weatherRepository.WeeklyConditions(latitude, longitude);
            var model = new List<WeatherModel>();
            for(int i = 0; i < data.DailyForecast.Date.Count(); i++)
            {
                var day = new WeatherModel
                {
                    Date = data.DailyForecast.Date[i],
                    TemperatureMax = data.DailyForecast.TemperatureMax[i].ToString(),
                    TemperatureMin = data.DailyForecast.TemperatureMin[i].ToString(),
                    Status = data.DailyForecast.TemperatureMax[i] < 30 && data.DailyForecast.TemperatureMin[i] > 10 
                        ? "Time to run!" : "Stay home"
                };
                model.Add(day);
            }
            return model;
        }
    }
}
