using DTO.BlogDtos;
using DTO.FooterAddressDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.BlogViewComponent
{
	public class _GetLast3BlogsWithAuthorName:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _GetLast3BlogsWithAuthorName(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var reponseMessage = await client.GetAsync("https://localhost:7217/api/Blogs/GetLast3BlogsWithAuthor");
			if (reponseMessage.IsSuccessStatusCode)
			{
				var json = await reponseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultLast3BlogsWihtAuthorNameDto>>(json);
				return View(values);
			}
			return View();
		}
	}
}
