using DTO.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.Controllers
{
	public class ServiceController : Controller
	{


		public async Task<IActionResult> Index()
		{
			return View();
		}
	}
}
