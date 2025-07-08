using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Controllers
{
	public class CarSingleController : Controller
	{
		public IActionResult Index(int id)
		{
			ViewBag.v1 = "Detaylar";
			ViewBag.Id = id;
			return View();
		}
	}
}
