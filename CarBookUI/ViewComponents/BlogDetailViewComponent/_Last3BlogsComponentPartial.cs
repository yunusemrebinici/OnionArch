using DTO.BlogDetailDtos;
using DTO.CarDtos;
using DTO.TagDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.BlogDetailViewComponent
{
	public class _Last3BlogsComponentPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _Last3BlogsComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Blogs/GetLast3BlogsWithAuthor");
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultLast3BlogInBlogDetailDto>>(json);
				return View(values);
			}

			return View();
		}
	}
}
