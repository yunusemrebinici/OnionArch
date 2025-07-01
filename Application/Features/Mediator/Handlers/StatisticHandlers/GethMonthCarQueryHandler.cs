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
	public class GethMonthCarQueryHandler:IRequestHandler<GethMonthCarQuery, GetMonthCarPricingQueryResult>
	{
		private readonly IStatisticRepository _statistic;
		public GethMonthCarQueryHandler(IStatisticRepository statistic)
		{
			
		}

		public async Task<GetMonthCarPricingQueryResult> Handle(GethMonthCarQuery request, CancellationToken cancellationToken)
		{
			var value = await _statistic.GetMonthCarPricingAvg();
			return new GetMonthCarPricingQueryResult {  MonthCarPricing = value };

		}
	}
}
