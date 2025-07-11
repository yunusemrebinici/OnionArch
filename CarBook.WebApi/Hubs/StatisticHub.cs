using Application.Interfaces.IStatisticRepositories;
using Microsoft.AspNetCore.SignalR;
using Persistance.Context;

namespace CarBook.WebApi.Hubs
{
	public class StatisticHub : Hub
	{

		private readonly IHttpClientFactory _httpClientFactory;

		private readonly IStatisticRepository _statisticRepository;

		public StatisticHub(IHttpClientFactory httpClientFactory, IStatisticRepository statisticRepository)
		{
			_httpClientFactory = httpClientFactory;
			_statisticRepository = statisticRepository;
		}

		public async Task Test()
		{
			var value= await _statisticRepository.GetCarCount();
			await Clients.All.SendAsync("ReceiveCarCount", value);

			var brandcount = await _statisticRepository.GetBrandCount();
			await Clients.All.SendAsync("ReceiveBrandCount", brandcount);

			var blogcount = await _statisticRepository.GetBlogCount();
			await Clients.All.SendAsync("ReceiveBlogCount", blogcount);

			var locationcount = await _statisticRepository.GetLocationCount();
			await Clients.All.SendAsync("ReceiveLocationCount", locationcount);
		}

	}
}
