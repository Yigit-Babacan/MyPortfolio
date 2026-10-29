using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
