using DTO.AdminCarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.Controllers
{
	public class AdminCarController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public AdminCarController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Cars/GetCarsWithBrand");
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCarListWithBrandAdminDto>>(json);
				return View(values);
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> CreateCar()
		{
			
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateCar(CreateCarDto createCar)
		{
			return View();
		}
	}
}
