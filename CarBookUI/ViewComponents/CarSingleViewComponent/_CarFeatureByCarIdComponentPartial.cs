using DTO.CarSingleDtos;
using DTO.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.CarSingleViewComponent
{
	public class _CarFeatureByCarIdComponentPartial:ViewComponent
	{
		//
		private readonly IHttpClientFactory _httpClientFactory;

		public _CarFeatureByCarIdComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/CarFeatures/"+id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<GetCarFeatureByIdDto>>(json);
				return View(values);	
			}
			return View();
		}
	}
}
