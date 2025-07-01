using DTO.AdminTestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBookUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[Controller]/[Action]")]
	public class TestimonialController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public TestimonialController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

	
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Testimonials");
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultTestimonialAdminDto>>(json);
				return View(values);
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateTestimonial(CreateTestimonialAdminDto create)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(create);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7217/api/Testimonials", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> CreateTestimonial()
		{
			return View();
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> UpdateTestimonial(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Testimonials/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateTestimonialAdminDto>(json);
				return View(values);
			}
			return View();
		}

		[HttpPost("{id}")]
		public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialAdminDto update)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(update);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:7217/api/Testimonials", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> DeleteTestimonial(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync("https://localhost:7217/api/Testimonials/" + id);

			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
