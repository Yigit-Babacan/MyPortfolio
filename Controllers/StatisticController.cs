using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.Controllers
{
	public class StatisticController : Controller
	{

		MyPortfolioContext context = new MyPortfolioContext();

		public IActionResult Index()
		{
			ViewBag.V1 = context.Skills.Count();
			ViewBag.V2 = context.Messages.Count();
			ViewBag.V3 = context.Messages.Where(x => x.IsRead == false).Count();
			ViewBag.V4 = context.Messages.Where(x => x.IsRead == true).Count();
			return View();
		}
	}
}
