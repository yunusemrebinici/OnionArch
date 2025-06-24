using DTO.BlogDetailDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.BlogDetailViewComponent
{
	public class _BlogAuthorDetailComponentPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _BlogAuthorDetailComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Blogs/GetAuthorByBlogId/"+id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var json= await responseMessage.Content.ReadAsStringAsync();
				var value=JsonConvert.DeserializeObject<ResultAuthorByBlogIdDto>(json);
				return View(value);
			}
			return View();
		}
	}
}
