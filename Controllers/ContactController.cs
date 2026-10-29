using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;
using MyPortolio.DAL.Entities;

namespace MyPortolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Contacts.FirstOrDefault();
            ViewBag.V1 = values.Title;
            ViewBag.V2 = values.Description;
            ViewBag.V3 = values.Phone1;
            ViewBag.V4 = values.Phone2;
            ViewBag.V5 = values.Email1;
            ViewBag.V6 = values.Email2;
            ViewBag.V7 = values.Adress;
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
