using DTO.BlogDtos;
using DTO.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBookUI.Controllers
{
	public class BlogController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public BlogController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			ViewBag.v1 = "Blog";
			var client = _httpClientFactory.CreateClient();
			var reponseMessage = await client.GetAsync("https://localhost:7217/api/Blogs/GetAllBlogsWithAuthor");
			if (reponseMessage.IsSuccessStatusCode)
			{
				var json = await reponseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultGetAllBlogsWithAuthorDto>>(json);
				return View(values);
			}

			return View();
		}

		public async Task<IActionResult> BlogDetail(int id)
		{
			ViewBag.v1 = "Blog";
			ViewBag.Id=id;
			return View();
		}
	}
}
