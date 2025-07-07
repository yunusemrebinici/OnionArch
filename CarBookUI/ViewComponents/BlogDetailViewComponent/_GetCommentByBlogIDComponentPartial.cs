
using DTO.CommentDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.BlogDetailViewComponent
{
	public class _GetCommentByBlogIDComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _GetCommentByBlogIDComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Comments/GetCommentsByBlogId/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(json);
				ViewBag.count = values.Count();
				return View(values);
			}

			return View();
		}
	}
}
