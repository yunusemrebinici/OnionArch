using DTO.LoginDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBookUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[Controller]/[Action]")]
	public class LoginController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public LoginController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Index(LoginDto login)
		{
			var client = _httpClientFactory.CreateClient();
			var json = JsonConvert.SerializeObject(login);
			StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
			// API URL'ine POST isteği atılıyor
			var responseMessage = await client.PostAsync("https://localhost:7217/api/AppUser", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "Statistic");
			}
			else
			{
				ViewBag.s = login.UserName;
			}
			return View();
		}


	}
}
