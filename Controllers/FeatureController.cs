using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;
using MyPortolio.DAL.Entities;

namespace MyPortolio.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Features.FirstOrDefault();
            ViewBag.V1 = values.Title;
            ViewBag.V2 = values.Description;
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            context.Features.Update(feature);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
