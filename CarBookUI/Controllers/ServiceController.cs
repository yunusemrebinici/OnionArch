using DTO.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.Controllers
{
	public class ServiceController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ServiceController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var reponseMessage = await client.GetAsync("https://localhost:7217/api/Services");
			if (reponseMessage.IsSuccessStatusCode)
			{
				var json = await reponseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(json);
				return View(values);
			}

			return View();
		}
	}
}
