using DTO.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.BlogDetailViewComponent
{
	public class _CategoryComponetPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _CategoryComponetPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Category");
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(json);
				return View(values);
			}

			return View();
		}
	}
}
