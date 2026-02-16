using Asp.NetPractice10.Services;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetPractice10.ViewComponents
{
    public class TimerViewComponent : ViewComponent
    {
        ITimeService timeService;
        public TimerViewComponent(ITimeService service)
        {
            timeService = service;
        }
        public IViewComponentResult Invoke()
        {
            string time = $"Current time: {timeService.GetTime()}";
            return View(time);
        }
    }
}
