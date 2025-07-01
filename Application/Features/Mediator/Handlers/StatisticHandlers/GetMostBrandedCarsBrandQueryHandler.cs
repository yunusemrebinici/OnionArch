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
	public class GetMostBrandedCarsBrandQueryHandler:IRequestHandler<GetMostBrandedCarsBrandQuery, GetMostBrandedCarsBrandQueryResult>
	{
		private readonly IStatisticRepository _statistic;
		public GetMostBrandedCarsBrandQueryHandler(IStatisticRepository statistic)
		{
			_statistic = statistic;
		}

		public async Task<GetMostBrandedCarsBrandQueryResult> Handle(GetMostBrandedCarsBrandQuery request, CancellationToken cancellationToken)
		{
			var value = await _statistic.GetMostBrandedCarsBrand();
			return new GetMostBrandedCarsBrandQueryResult { mostBrandedCarsBrand = value };
		}
	}
}
