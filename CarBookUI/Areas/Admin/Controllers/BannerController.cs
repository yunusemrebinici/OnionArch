
using DTO.AdminBannerDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBookUI.Areas.Admin.Controllers
{
	[Authorize]
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	public class BannerController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public BannerController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Banners");
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultBannerAdminDto>>(json);
				return View(values);
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> CreateBanner()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Banners/GetBannersWithBanner");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateBanner(CreateBannerAdminDto createBanner)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createBanner);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7217/api/Banners", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> UpdateBanner(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Banners/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateBannerAdminDto>(json);
				return View(values);
			}
			return View();
		}

		[HttpPost("{id}")]
		public async Task<IActionResult> UpdateBanner(UpdateBannerAdminDto update)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(update);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:7217/api/Banners", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpGet("{id}")]    
		public async Task<IActionResult> DeleteBanner(int id)
		{
			var client = _httpClientFactory.CreateClient();	
			var responseMessage = await client.DeleteAsync("https://localhost:7217/api/Banners/" + id);

			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}

