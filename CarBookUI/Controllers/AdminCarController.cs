using DTO.AdminBrandDtos;
using DTO.AdminCarDtos;
using DTO.AdminCarPricingDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

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

				//Car tablosuna son eklenen arabanın Id`numarasını çekip günlük haftalık ve aylık ücretini ekliyoruz.

				var getbyLastCarId = await client.GetAsync("https://localhost:7217/api/Cars/GetLastCarById");
				var json = await getbyLastCarId.Content.ReadAsStringAsync();
				var id = JsonConvert.DeserializeObject<int>(json);

				#region AddCarPricingTableDay
				CreateCarPricingAdminDto create = new CreateCarPricingAdminDto()
				{
					amount = createCar.DayCarPricing,
					carID = id,
					pricingID = 2
				};
				var dayJson = JsonConvert.SerializeObject(create);
				StringContent dayContant = new StringContent(dayJson, Encoding.UTF8, "application/json");
				var dayMessage = await client.PostAsync("https://localhost:7217/api/CarPricing", dayContant);

				#endregion

				#region AddCarPricingTableWeek
				CreateCarPricingAdminDto create2 = new CreateCarPricingAdminDto()
				{
					amount = createCar.WeekCarPricing,
					carID = id,
					pricingID = 3
				};
				var weekJson = JsonConvert.SerializeObject(create2);
				StringContent weekContant = new StringContent(weekJson, Encoding.UTF8, "application/json");
				var weekMessage = await client.PostAsync("https://localhost:7217/api/CarPricing", weekContant);

				#endregion

				#region AddCarPricingTableMonth
				CreateCarPricingAdminDto create3 = new CreateCarPricingAdminDto()
				{
					amount = createCar.MonthCarPricing,
					carID = id,
					pricingID = 4
				};
				var monthJson = JsonConvert.SerializeObject(create3);
				StringContent monthContant = new StringContent(monthJson, Encoding.UTF8, "application/json");
				var monthMessage = await client.PostAsync("https://localhost:7217/api/CarPricing", monthContant);

				#endregion

				if (monthMessage.IsSuccessStatusCode)
				{
					return RedirectToAction("Index");
				}


			}


			return View();
		}
	}
}
