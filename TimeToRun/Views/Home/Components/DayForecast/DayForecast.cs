using Microsoft.AspNetCore.Mvc;
using TimeToRun.Models;

namespace TimeToRun.Views.Home.Components.DayForecast
{
    public class DayForecast : ViewComponent
    {
        public IViewComponentResult Invoke(WeatherModel model)
        {
            return View(model);
        }
    }
}
