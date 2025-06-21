using DTO.FooterAddressDtos;
using DTO.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.FooterAddressesComponent
{
	public class _FooterAddressesComponentPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _FooterAddressesComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var reponseMessage = await client.GetAsync("https://localhost:7217/api/FooterAddresses");
			if (reponseMessage.IsSuccessStatusCode)
			{
				var json = await reponseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(json);
				return View(values);
			}
			return View();
		}
	}
}
