using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
