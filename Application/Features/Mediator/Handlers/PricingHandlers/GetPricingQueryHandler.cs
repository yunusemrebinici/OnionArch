﻿using Application.Features.Mediator.Quaries.PricingQuaries;
using Application.Features.Mediator.Results.PricingResults;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.PricingHandlers
{
	public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>

	{
		private readonly IRepository<Pricing>_repository;

		public GetPricingQueryHandler(IRepository<Pricing> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GettAllAsync();
			return values.Select(x => new GetPricingQueryResult
			{
				Name = x.Name,
				PricingID = x.PricingID,
			}).ToList();
		}
	}
}
