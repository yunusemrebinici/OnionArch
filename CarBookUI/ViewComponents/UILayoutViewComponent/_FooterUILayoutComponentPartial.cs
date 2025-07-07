using DTO.AdminSocialMediaDtos;
using DTO.BlogDtos;
using DTO.FooterAddressDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.UILayoutViewComponent
{
	public class _FooterUILayoutComponentPartial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _FooterUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var reponseMessage = await client.GetAsync("https://localhost:7217/api/FooterAddresses");
			var reponseMessage2 = await client.GetAsync("https://localhost:7217/api/SocialMedias");
			if (reponseMessage.IsSuccessStatusCode)
			{
				var jsonSM= await reponseMessage2.Content.ReadAsStringAsync();
				var json = await reponseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(json);
				var valuesSM = JsonConvert.DeserializeObject<List<ResultSocialMediaAdminDto>>(jsonSM);
				#region SocialMedia
				ViewBag.socialmedia = valuesSM.ToList(); ;
				#endregion
				#region FooterAddressVbag
				ViewBag.address = values.Select(x => x.Address).FirstOrDefault();
				ViewBag.phone = values.Select(x => x.Phone).FirstOrDefault();
				ViewBag.mail = values.Select(x => x.Email).FirstOrDefault();
				#endregion


				return View();
			}
			return View();
		}
	}
}
