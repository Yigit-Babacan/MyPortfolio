using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.ToDoListCount = context.TodoLists.Where(x => x.Status == false).Count();
			var values = context.TodoLists.Where(x => x.Status == false).ToList();
			return View(values);
		}
	}
}
