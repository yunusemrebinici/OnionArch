using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.Controllers
{
	public class UIAdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public async Task<PartialViewResult> Head()
		{
			return PartialView();
		}

		public async Task<PartialViewResult> Navbar()
		{
			return PartialView();
		}

		public async Task<PartialViewResult> Sidebar()
		{
			return PartialView();
		}

		public async Task<PartialViewResult> Footer()
		{
			return PartialView();
		}

		public async Task<PartialViewResult> Scripts()
		{
			return PartialView();
		}


	}
}
