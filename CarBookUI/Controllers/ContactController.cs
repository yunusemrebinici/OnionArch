using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
