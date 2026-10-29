using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;
using MyPortolio.DAL.Entities;

namespace MyPortolio.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            var values = context.Abouts.FirstOrDefault();
            ViewBag.V1 = values.Title;
            ViewBag.V2 = values.SubDesciption;
            ViewBag.V3 = values.Details;
            return View(values);
        }


        [HttpPost]
        public IActionResult Index(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
