using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
