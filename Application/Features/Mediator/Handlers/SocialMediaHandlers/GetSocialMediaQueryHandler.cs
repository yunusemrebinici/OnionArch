﻿using Application.Features.Mediator.Quaries.SocialMediaQuaries;
using Application.Features.Mediator.Results.SocialMediaResults;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.SocialMediaHandlers
{
	public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
	{
		private readonly IRepository<SocialMedia> _repository;

		public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GettAllAsync();
			return values.Select(x => new GetSocialMediaQueryResult
			{
				Icon = x.Icon,
				Name = x.Name,
				SocialMediaID = x.SocialMediaID,
				Url = x.Url,
			}).ToList();
		}
	}
}
