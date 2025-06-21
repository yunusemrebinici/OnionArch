using DTO.BannerDtos;
using DTO.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.DefaultViewComponent
{
	public class _MainCoverDefaultComponentPartial:ViewComponent
	{

		private readonly IHttpClientFactory _httpClientFactory;

		public _MainCoverDefaultComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Banners");
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultlBannerDto>>(json);
				return View(values);
			}
			return View();
		}
	}
}
