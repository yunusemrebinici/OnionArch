using DTO.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBookUI.Controllers
{
	public class ContactController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ContactController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			ViewBag.v1 = "İletişim";
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(CreateContactDto contactDto)
		{

			contactDto.SendDate = DateTime.Now;
			var client = _httpClientFactory.CreateClient();
			var jsonData= JsonConvert.SerializeObject(contactDto);
			StringContent content = new StringContent(jsonData, Encoding.UTF8,"application/json");

			var responseMessage = await client.PostAsync("https://localhost:7217/api/Contacts", content);
			if (responseMessage.IsSuccessStatusCode) { 
			
				return RedirectToAction("Index");
			}

			return View();
		}
	}
}
