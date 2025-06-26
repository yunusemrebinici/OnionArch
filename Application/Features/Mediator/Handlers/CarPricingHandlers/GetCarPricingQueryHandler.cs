using Application.Features.Mediator.Quaries.CarPricingQuaries;
using Application.Features.Mediator.Results.CarPricingResults;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.CarPricingHandlers
{
	public class GetCarPricingQueryHandler : IRequestHandler<GetCarPricingQuery, List<GetCarPricingQueryResult>>
	{
		private readonly IRepository<CarPricing> _repository;

		public GetCarPricingQueryHandler(IRepository<CarPricing> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetCarPricingQueryResult>> Handle(GetCarPricingQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GettAllAsync();
			return values.Select(x=>new GetCarPricingQueryResult
			{
				Amount = x.Amount,
				CarID = x.CarID,
				CarPricingID = x.CarPricingID,
				PricingID=x.PricingID,
				
			}).ToList();
		}
	}
}
