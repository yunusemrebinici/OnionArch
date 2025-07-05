using DTO.AdminStatisticDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.DefaultViewComponent
{
	public class _StatisticDefaultComponentPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _StatisticDefaultComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task <IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();

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


			return View();
		}

	}
}
