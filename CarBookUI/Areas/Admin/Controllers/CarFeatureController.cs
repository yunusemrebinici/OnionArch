using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("/Admin/[Controller]/[Action]")]
	public class CarFeatureController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
