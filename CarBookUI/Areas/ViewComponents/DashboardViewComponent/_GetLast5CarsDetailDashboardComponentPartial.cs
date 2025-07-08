using DTO.AdminDashboardDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.Areas.ViewComponents.DashboardViewComponent
{
	public class _GetLast5CarsDetailDashboardComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _GetLast5CarsDetailDashboardComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/CarPricing/GetPivotedCarPricingsWithDetails");
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<GetLast5CarsDetailDashboardDto>>(json);
				return View(values.TakeLast(3).ToList());
			}
			return View();
		}
	}
}
