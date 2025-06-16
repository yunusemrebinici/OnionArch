using Application.Features.CQRS.Commands.BannerCommands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.BannerHandlers
{
	public class UpdateBannerCommandHandler
	{
		private readonly IRepository<Banner>_bannerRepository;
		public UpdateBannerCommandHandler(IRepository<Banner> repository)
		{
			_bannerRepository = repository;
		}

		public async Task Handle(UpdateBannerCommand command)
		{
			await _bannerRepository.UpdateAsync(new Banner
			{
				BannerID = command.BannerID,
				Description = command.Description,
				Title = command.Title,	
				VideoDescription = command.VideoDescription,	
				VideoUrl = command.VideoUrl	
			});
		}
	}
}
