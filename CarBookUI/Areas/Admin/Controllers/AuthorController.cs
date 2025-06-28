using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Areas.Admin.Controllers
{
	public class AuthorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
