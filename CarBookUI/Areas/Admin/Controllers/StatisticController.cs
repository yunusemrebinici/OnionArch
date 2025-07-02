using DTO.AdminStatisticDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("/Admin/[Controller]/[Action]")]
	public class StatisticController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public StatisticController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
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

			#region LocationCount
			var responseMessage4 = await client.GetAsync("https://localhost:7217/api/Statistics/GetLocationCount");
			if (responseMessage4.IsSuccessStatusCode)
			{
				var json4 = await responseMessage4.Content.ReadAsStringAsync();
				var values4 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json4);

				ViewBag.locationCount = values4.LocationCount;

			}

			#endregion

			#region MonthCarPricingt
			var responseMessage5 = await client.GetAsync("https://localhost:7217/api/Statistics/GetMonthCarPricingAvg");
			if (responseMessage5.IsSuccessStatusCode)
			{
				var json5 = await responseMessage5.Content.ReadAsStringAsync();
				var values5 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json5);

				ViewBag.monthCarPricing = values5.MonthCarPricing.ToString("0.00"+" ₺");

			}

			#endregion

			#region MostBlogComment
			var responseMessage6 = await client.GetAsync("https://localhost:7217/api/Statistics/GetMostBlogCommentCount");
			if (responseMessage6.IsSuccessStatusCode)
			{
				var json6 = await responseMessage6.Content.ReadAsStringAsync();
				var values6 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json6);

				ViewBag.mostBlogComment = values6.MostBlogComment;

			}

			#endregion

			#region mostBrandedCarsBrand
			var responseMessage7 = await client.GetAsync("https://localhost:7217/api/Statistics/GetMostBrandedCarsBrand");
			if (responseMessage7.IsSuccessStatusCode)
			{
				var json7 = await responseMessage7.Content.ReadAsStringAsync();
				var values7 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json7);

				ViewBag.mostBrandedCarBrand = values7.mostBrandedCarsBrand;

			}

			#endregion

			#region authorCount
			var responseMessage8 = await client.GetAsync("https://localhost:7217/api/Statistics/GetAuthorCount");
			if (responseMessage8.IsSuccessStatusCode)
			{
				var json8 = await responseMessage8.Content.ReadAsStringAsync();
				var values8 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json8);

				ViewBag.authorCount = values8.Authorcount;

			}

			#endregion

			#region todayCarPricingAvg
			var responseMessage9 = await client.GetAsync("https://localhost:7217/api/Statistics/GetTodayCarPricingAvg");
			if (responseMessage9.IsSuccessStatusCode)
			{
				var json9 = await responseMessage9.Content.ReadAsStringAsync();
				var values9 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json9);

				ViewBag.todayCarPricingAvg = values9.TodayCarPricing.ToString("0.00"+" ₺");

			}

			#endregion

			#region weekCarPricingAvg
			var responseMessage10 = await client.GetAsync("https://localhost:7217/api/Statistics/GetWeekCarPricingAvg");
			if (responseMessage10.IsSuccessStatusCode)
			{
				var json10 = await responseMessage10.Content.ReadAsStringAsync();
				var values10 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json10);

				ViewBag.weekCarPricingAvg = values10.WeekCarPricing.ToString("0.00" + " ₺");

			}

			#endregion

			#region GetMinTodayPriceCarBrandModel
			var responseMessage11 = await client.GetAsync("https://localhost:7217/api/Statistics/GetMinTodayPriceCarBrandModel");
			if (responseMessage11.IsSuccessStatusCode)
			{
				var json11 = await responseMessage11.Content.ReadAsStringAsync();
				var values11 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json11);

				ViewBag.MinTodayPriceCarBrandModel = values11.GetMinTodayPriceCarBrandModel;

			}

			#endregion

			#region MaxTodayPriceCarBrandModel
			var responseMessage12 = await client.GetAsync("https://localhost:7217/api/Statistics/GetMaxTodayPriceCarBrandModel");
			if (responseMessage12.IsSuccessStatusCode)
			{
				var json12 = await responseMessage12.Content.ReadAsStringAsync();
				var values12 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json12);

				ViewBag.MaxTodayPriceCarBrandModel = values12.MaxTodayPriceCarBrandModel;

			}

			#endregion

			#region GetElectricCarCount
			var responseMessage13 = await client.GetAsync("https://localhost:7217/api/Statistics/GetElectricCarCount");
			if (responseMessage13.IsSuccessStatusCode)
			{
				var json13 = await responseMessage13.Content.ReadAsStringAsync();
				var values13 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json13);

				ViewBag.getElectricCarCount = values13.GetElectricCarCount;

			}

			#endregion

			#region GetCarUnder1000kmCount
			var responseMessage14 = await client.GetAsync("https://localhost:7217/api/Statistics/GetCarUnder1000kmCount");
			if (responseMessage14.IsSuccessStatusCode)
			{
				var json14 = await responseMessage14.Content.ReadAsStringAsync();
				var values14 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json14);

				ViewBag.getCarUnder1000kmCount = values14.GetCarUnder1000kmCount;

			}

			#endregion

			#region GetTestimonailCount
			var responseMessage15 = await client.GetAsync("https://localhost:7217/api/Statistics/GetTestimonailCount");
			if (responseMessage15.IsSuccessStatusCode)
			{
				var json15 = await responseMessage15.Content.ReadAsStringAsync();
				var values15 = JsonConvert.DeserializeObject<ResultAllStatisticsAdminDto>(json15);

				ViewBag.getTestimonailCount = values15.GetTestimonailCount;

			}

			#endregion

			return View();
		}
	}
}
