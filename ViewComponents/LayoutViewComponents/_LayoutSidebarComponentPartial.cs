using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
