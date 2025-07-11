using DTO.AdminBlogDtos;
using DTO.AdminCommentDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CarBookUI.Areas.Admin.Controllers
{
	[Authorize]
	[Area("Admin")]
	[Route("Admin/[Controller]/[Action]")]
	public class CommentController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public CommentController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetBlogComments(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Comments/GetCommentsByBlogId/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<GetCommentByBlogIdAdminDto>>(json);
				return View(values);
			}
			return View();
		}
	}
}
