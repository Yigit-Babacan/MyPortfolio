using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;
using MyPortolio.DAL.Entities;

namespace MyPortolio.Controllers
{
	public class ToDoListController : Controller
	{
		MyPortfolioContext contex = new MyPortfolioContext();
		public IActionResult Index()
		{
			var values = contex.TodoLists.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateToDoList()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList)
		{
			toDoList.Status = false;
			contex.TodoLists.Add(toDoList);
			contex.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteToDoList(int id)
		{
			var values = contex.TodoLists.Find(id);
			contex.TodoLists.Remove(values);
			contex.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var values = contex.TodoLists.Find(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList toDoList)
		{
			var values = contex.TodoLists.Update(toDoList);
			contex.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ChangeToDoListStatusToTrue(int id)
		{
			var value = contex.TodoLists.Find(id);
			value.Status = true;
			contex.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ChangeToDoListStatusToFalse(int id)
		{
			var value = contex.TodoLists.Find(id);
			value.Status = false;
			contex.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
