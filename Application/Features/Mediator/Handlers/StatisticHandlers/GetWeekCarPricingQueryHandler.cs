using Application.Features.Mediator.Quaries.StatisticQuaries;
using Application.Features.Mediator.Results.StatisticResults;
using Application.Interfaces.ICarRepositories;
using Application.Interfaces.IStatisticRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.StatisticHandlers
{
	public class GetWeekCarPricingQueryHandler : IRequestHandler<GetWeekCarPricingQuery, GetWeekCarPricingQueryResult>
	{
		private readonly IStatisticRepository _statistic;

		public GetWeekCarPricingQueryHandler(IStatisticRepository statistic)
		{
			_statistic = statistic;
		}

		public async Task<GetWeekCarPricingQueryResult> Handle(GetWeekCarPricingQuery request, CancellationToken cancellationToken)
		{
			var value= await _statistic.GetWeekCarPricingAvg();
			return new GetWeekCarPricingQueryResult { WeekCarPricing=value };
		}
	}
}
