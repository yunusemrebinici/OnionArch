using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
