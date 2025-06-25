using DTO.TagDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.BlogDetailViewComponent
{
	public class _GetTagsByBlogIdComponentPartial : ViewComponent
	{

		private readonly IHttpClientFactory _httpClientFactory;

		public _GetTagsByBlogIdComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Tags/"+id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var json= await responseMessage.Content.ReadAsStringAsync();
				var values= JsonConvert.DeserializeObject<List<ResultTagsByBlogIdDto>>(json);
				return View(values);
			}

		    return View();
		}
	}
}
