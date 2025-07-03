using DTO.LocationDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBookUI.Controllers
{
	public class DefaultController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public DefaultController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
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
		public async Task<IActionResult> Index(int locationID)
		{

		    TempData["startlocation"]= locationID;
			var value= TempData["startlocation"];
			return RedirectToAction("Index", "RentAcarList");
		}
	}
}
