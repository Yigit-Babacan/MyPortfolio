using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.Controllers
{
	public class LayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
