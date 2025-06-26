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
	public class GetCarPricingByIdQueryHandler : IRequestHandler<GetCarPricingByIdQuery, GetCarPricingByIdQueryResult>
	{
		private readonly IRepository<CarPricing>_repository;

		public GetCarPricingByIdQueryHandler(IRepository<CarPricing> repository)
		{
			_repository = repository;
		}

		public async Task<GetCarPricingByIdQueryResult> Handle(GetCarPricingByIdQuery request, CancellationToken cancellationToken)
		{
			var value= await _repository.GetByIdAsync(request.Id);
			return new GetCarPricingByIdQueryResult
			{
				Amount = value.Amount,
				CarID = value.CarID,
				CarPricingID = value.CarPricingID,
				PricingID = value.PricingID,
			};
		}
	}
}
