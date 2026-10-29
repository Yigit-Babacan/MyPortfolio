using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _FooterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
