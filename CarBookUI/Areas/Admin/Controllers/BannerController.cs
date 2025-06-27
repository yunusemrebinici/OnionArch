using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Areas.Admin.Controllers
{
	public class BannerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
