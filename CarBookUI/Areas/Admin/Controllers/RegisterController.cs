using DTO.LoginDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBookUI.Areas.Admin.Controllers
{
	[AllowAnonymous]
	[Area("Admin")]
	[Route("Admin/[Controller]/[Action]")]
	public class RegisterController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public RegisterController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Index(CreateLoginDto login)
		{
			var client = _httpClientFactory.CreateClient();
			var json = JsonConvert.SerializeObject(login);
			StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
			// API URL'ine POST isteği atılıyor
			var responseMessage = await client.PostAsync("https://localhost:7217/api/AppUser/Register", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "Login");
			}

			return View();
		}
	}
}

	

