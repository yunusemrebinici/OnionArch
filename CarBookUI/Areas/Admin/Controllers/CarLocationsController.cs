using DTO.AdminCarFeatureDtos;
using DTO.AdminCarLocationsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBookUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("/Admin/[Controller]/[Action]")]
	public class CarLocationsController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public CarLocationsController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Index(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/RentAcars/GetRentAcarWithLocationName/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCarLocationsAdminDto>>(json);
				return View(values);
			}
			return View();
		}
	}
}
