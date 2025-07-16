using DTO.AdminCarFeatureDtos;
using DTO.AdminCarLocationsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

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

		[HttpPost("{id}")]
		public async Task<IActionResult> Index(List<CarLocationsStatusChangeDto> changeStatus)
		{
			CarLocationsStatusChangeDto change = new CarLocationsStatusChangeDto();
			var client = _httpClientFactory.CreateClient();
			foreach (var item in changeStatus)
			{
				if (item.Available == true)
				{
					change.LocationID = item.LocationID;
					change.CarID = item.CarID;
					change.RentAcarID = item.RentAcarID;
					var json = JsonConvert.SerializeObject(change);
					StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
					var responseMessage = await client.PostAsync("https://localhost:7217/api/RentAcars/GetRentACarLocationStatusTrue", content);
				}
				else
				{
					change.LocationID = item.LocationID;
					change.CarID = item.CarID;
					change.RentAcarID = item.RentAcarID;
					var json = JsonConvert.SerializeObject(change);
					StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
					var responseMessage = await client.PostAsync("https://localhost:7217/api/RentAcars/GetRentACarLocationStatusFalse", content);
				}


			}
			return RedirectToAction("Index", "AdminCar");
		}
	}
}
