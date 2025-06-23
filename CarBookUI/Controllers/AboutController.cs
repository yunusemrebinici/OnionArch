using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.v1 = "Hakkımızda";
			return View();
		}
	}
}
