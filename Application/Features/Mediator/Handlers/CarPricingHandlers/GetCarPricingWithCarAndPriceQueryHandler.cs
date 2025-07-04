using Application.Features.Mediator.Quaries.CarPricingQuaries;
using Application.Features.Mediator.Results.CarPricingResults;
using Application.Interfaces.ICarPricingRepositories;
using Application.Interfaces.ICarRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.CarPricingHandlers
{
	public class GetCarPricingWithCarAndPriceQueryHandler : IRequestHandler<GetCarPricingWithCarAndPriceQuery, List<GetCarPricingWithCarAndPriceQueryResult>>
	{

		private readonly ICarPricingRepository _carPricingRepository;

		public GetCarPricingWithCarAndPriceQueryHandler(ICarPricingRepository carPricingRepository)
		{
			_carPricingRepository = carPricingRepository;
		}

		public async Task<List<GetCarPricingWithCarAndPriceQueryResult>> Handle(GetCarPricingWithCarAndPriceQuery request, CancellationToken cancellationToken)
		{
			var value = await _carPricingRepository.GetAll();

			return value.Select(x=>new GetCarPricingWithCarAndPriceQueryResult
			{
				Brand = x.Brand,
				CarID = x.CarID,
				CoverImage = x.CoverImage,
				DayAmount = x.DayAmount,
				Model = x.Model,
				MonthAmount = x.MonthAmount,
				WeekAmount= x.WeekAmount,
			}).ToList();
		}
	}
}
