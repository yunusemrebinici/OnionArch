﻿using Application.Features.CQRS.Results.BannerResults;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.BannerHandlers
{
	public class GetBannerQueryHandler
	{
		private readonly IRepository<Banner>_repository;
		public GetBannerQueryHandler(IRepository<Banner> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetBannerQueryResult>> Handle()
		{
			var values= await _repository.GettAllAsync();
			return values.Select(x=> new GetBannerQueryResult
			{
				BannerID = x.BannerID,
				Description = x.Description,
				Title = x.Title,
				VideoDescription = x.VideoDescription,
				VideoUrl= x.VideoUrl,

			}).ToList();
		}
	}
}
