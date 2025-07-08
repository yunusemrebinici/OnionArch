using DTO.AdminCommentDtos;
using DTO.AdminDashboardDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBookUI.Areas.ViewComponents.DashboardViewComponent
{
	public class _GetLast3BlogsDashboardComponentPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _GetLast3BlogsDashboardComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Blogs/GetLast3BlogsWithAuthor");
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<GetLast3BlogsDashboardDto>>(json);
				return View(values);
			}
			return View();

			
		}
	}
}
