using DTO.CarDtos;
using DTO.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.Controllers
{
	public class CarController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public CarController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var reponseMessage = await client.GetAsync("https://localhost:7217/api/Cars/GetCarsWithBrand");
			if (reponseMessage.IsSuccessStatusCode)
			{
				var json = await reponseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCarWithBrandDto>>(json);
				return View(values);
			}

			return View();
		}
	}
}
