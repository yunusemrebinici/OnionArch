using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Controllers
{
	public class CarPricingController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.v1 = "Araç Fiyatları";
			return View();
		}
	}
}
