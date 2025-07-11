using DTO.AdminStatisticDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBookUI.Areas.Admin.Controllers
{
	[Authorize]
	[Area("Admin")]
	[Route("Admin/[Controller]/[Action]")]
	public class DashboardController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public DashboardController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task< IActionResult> Index()
		{

			var client = _httpClientFactory.CreateClient();
			#region AutoTransCarCount
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Statistics/GetAutomaticTransMissionCarCount");
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json);


				ViewBag.autoTransCarCount = values.AutoTransCarCount;



			}
			#endregion

			#region BlogCount
			var responseMessage1 = await client.GetAsync("https://localhost:7217/api/Statistics/GetBlogCount");
			if (responseMessage1.IsSuccessStatusCode)
			{
				var json1 = await responseMessage1.Content.ReadAsStringAsync();
				var values1 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json1);


				ViewBag.blogCount = values1.BlogCount;


			}

			#endregion

			#region BrandCount
			var responseMessage2 = await client.GetAsync("https://localhost:7217/api/Statistics/GetBrandCount");
			if (responseMessage2.IsSuccessStatusCode)
			{
				var json2 = await responseMessage2.Content.ReadAsStringAsync();
				var values2 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json2);


				ViewBag.brandCount = values2.BrandCount;


			}

			#endregion

			#region CarCount
			var responseMessage3 = await client.GetAsync("https://localhost:7217/api/Statistics/GetCarCount");
			if (responseMessage3.IsSuccessStatusCode)
			{
				var json3 = await responseMessage3.Content.ReadAsStringAsync();
				var values3 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json3);


				ViewBag.carCount = values3.CarCount;


			}

			#endregion

			return View();
		}
	}
}
