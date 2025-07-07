using DTO.AdminCarFeatureDtos;
using DTO.AdminCategoryDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CarBookUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("/Admin/[Controller]/[Action]")]
	public class CarFeatureController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public CarFeatureController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Index(int id)
		{

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/CarFeatures/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCarFeatureDto>>(json);
				return View(values);
			}
			return View();

		}

		[HttpPost("{id}")]
		public async Task<IActionResult> Index(List<ResultCarFeatureDto> changeStatus)
		{
			CarFeatureStatusChangeDto change= new CarFeatureStatusChangeDto();
			var client = _httpClientFactory.CreateClient();
			foreach( var item in changeStatus)
			{
				if (item.available == true) 
				{ 
				    change.FeatureID=item.featureID;
					change.CarID=item.carID;
					var json = JsonConvert.SerializeObject(change);
					StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
					var responseMessage = await client.PostAsync("https://localhost:7217/api/CarFeatures/CarFeatureStatusTrue", content);
				}
				else
				{
					change.FeatureID = item.featureID;
					change.CarID = item.carID;
					var json = JsonConvert.SerializeObject(change);
					StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
					var responseMessage = await client.PostAsync("https://localhost:7217/api/CarFeatures/CarFeatureStatusFalse", content);
				}
				

			}
			
			return RedirectToAction("Index", "AdminCar");
		}
	}
}
