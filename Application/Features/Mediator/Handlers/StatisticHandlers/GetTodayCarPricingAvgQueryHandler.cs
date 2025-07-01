using Application.Features.Mediator.Quaries.StatisticQuaries;
using Application.Features.Mediator.Results.StatisticResults;
using Application.Interfaces.IStatisticRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.StatisticHandlers
{
	public class GetTodayCarPricingAvgQueryHandler:IRequestHandler<GetTodayCarPricingAvgQuery, GetTodayCarPricingAvgQueryResult>
	{
		private readonly IStatisticRepository _statistic;

		public GetTodayCarPricingAvgQueryHandler(IStatisticRepository statistic)
		{
			_statistic = statistic;
		}

		public async Task<GetTodayCarPricingAvgQueryResult> Handle(GetTodayCarPricingAvgQuery request, CancellationToken cancellationToken)
		{
			var value = await _statistic.GetTodayCarPricingAvg();
			return new GetTodayCarPricingAvgQueryResult { TodayCarPricing = value };
		}
	}
}
