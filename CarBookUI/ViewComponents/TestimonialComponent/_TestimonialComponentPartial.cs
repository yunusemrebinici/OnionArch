﻿using DTO.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBookUI.ViewComponents.TestimonialComponent
{
	public class _TestimonialComponentPartial:ViewComponent
	{

		private readonly IHttpClientFactory _httpClientFactory;

		public _TestimonialComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Testimonials");
			if (responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStringAsync();
				var values= JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(json);
				return View(values);
			}
			return View();
		}
	}
}
