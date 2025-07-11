using DTO.AdminBrandDtos;
using DTO.AdminCarDtos;
using DTO.AdminCarPricingDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace CarBookUI.Controllers
{
	[Authorize(Roles = "Admin")]
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
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Cars/GetCarsWithBrand");
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultBrandInAdminDto>>(json);
				List<SelectListItem> list = (from x in values
											 select new SelectListItem
											 {
												 Text = x.name,
												 Value = x.brandID.ToString(),
											 }).ToList();
				ViewBag.Brand = list;
				return View();
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateCar(CreateCarDto createCar)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createCar);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7217/api/Cars", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			
			return View();
		}

		public async Task<IActionResult> DeleteCar(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync("https://localhost:7217/api/Cars/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}


		[HttpGet]
		public async Task<IActionResult> UpdateCar(int id)
		{
			#region seleclistitem 

			var client1 = _httpClientFactory.CreateClient();
			var responseMessage2 = await client1.GetAsync("https://localhost:7217/api/Cars/GetCarsWithBrand");
			if (responseMessage2.IsSuccessStatusCode)
			{
				var json1 = await responseMessage2.Content.ReadAsStringAsync();
				var values1 = JsonConvert.DeserializeObject<List<ResultBrandInAdminDto>>(json1);
				List<SelectListItem> list = (from x in values1
											 select new SelectListItem
											 {
												 Text = x.name,
												 Value = x.brandID.ToString(),
											 }).ToList();
				ViewBag.Brand = list;
				
			}
			#endregion

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Cars/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateCarAdminDto>(json);
				return View(values);
			}
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> UpdateCar(UpdateCarAdminDto update)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(update);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:7217/api/Cars", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();

		}
	}
}


