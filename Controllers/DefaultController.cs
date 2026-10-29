using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
