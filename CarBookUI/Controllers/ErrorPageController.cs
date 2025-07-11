using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Error() { 
		
			return View();
		
		}
			
	}
}
