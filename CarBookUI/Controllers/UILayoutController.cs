using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
