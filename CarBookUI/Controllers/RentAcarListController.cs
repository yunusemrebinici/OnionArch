using DTO.CarDtos;
using DTO.RentAcarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace CarBookUI.Controllers
{
	public class RentAcarListController : Controller
	{

		private readonly IHttpClientFactory _httpClientFactory;

		public RentAcarListController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}


		public async Task<IActionResult> Index()
		{
			ViewBag.v1 = "Araç Listesi";
			var locationId = TempData["startlocation"];

			var client = _httpClientFactory.CreateClient();
			var reponseMessage = await client.GetAsync($"https://localhost:7217/api/RentAcars/{locationId}/true");
			if (reponseMessage.IsSuccessStatusCode)
			{
				var json = await reponseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultRentAcarDto>>(json);
				return View(values);
			}


			return View();
		}
	}
}
