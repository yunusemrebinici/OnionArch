using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Controllers
{
	public class AdminCarController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
