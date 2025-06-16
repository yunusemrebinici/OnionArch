using Application.Features.CQRS.Queries.BannerQuaries;
using Application.Features.CQRS.Results.BannerResults;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.BannerHandlers
{
	public class GetBannerByIdQueryHandler
	{
		private readonly IRepository<Banner>  _bannerRepository;

		public GetBannerByIdQueryHandler(IRepository<Banner> repository)
		{
			_bannerRepository = repository;
		}

		public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuary quary)
		{
	     	var value= await _bannerRepository.GetByIdAsync(quary.Id);
			return new GetBannerByIdQueryResult
			{
				BannerID = value.BannerID,
				Description = value.Description,
				Title = value.Title,
				VideoDescription = value.VideoDescription,
				VideoUrl = value.VideoUrl,
			};
		}
	}
}
