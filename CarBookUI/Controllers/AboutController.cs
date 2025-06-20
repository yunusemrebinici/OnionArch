using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
