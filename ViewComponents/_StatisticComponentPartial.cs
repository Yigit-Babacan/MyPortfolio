using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
