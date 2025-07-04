using DTO.LocationDtos;
using DTO.ReservationDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CarBookUI.Controllers
{
	public class ReservationController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ReservationController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		
		public async Task<IActionResult> Index(int id)
		{

			ViewBag.carID=id;
			ViewBag.v1 = "Reservasyon Sayfası";
			var client = _httpClientFactory.CreateClient();
			var reponseMessage = await client.GetAsync("https://localhost:7217/api/Locations");
			if (reponseMessage.IsSuccessStatusCode)
			{
				var json = await reponseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(json);

				List<SelectListItem> selectListItems = (from x in values
														select
														new SelectListItem
														{
															Text = x.name,
															Value = x.locationID.ToString(),
														}
													  ).ToList();
				ViewBag.SelectListItems = selectListItems;

				return View();
			}
			return View();

			
		}

		[HttpPost]
		public async Task<IActionResult>Index(CreateReservationDto  create)
		{
			var client = _httpClientFactory.CreateClient();
			var json=JsonConvert.SerializeObject(create);
			StringContent content = new StringContent(json,Encoding.UTF8,"application/json");
			var responseMessage = await client.PostAsync("https://localhost:7217/api/Reservations",content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index","Default");
			}

			return View();
		}
	}
}
