using Microsoft.AspNetCore.Mvc;

namespace TimeToRun.Views.Home.Components.DayForecast
{
    public class DayForecast : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
