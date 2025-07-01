using Application.Features.CQRS.Results.BrandResults;
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
	public class GetBrandCountQueryHandler:IRequestHandler<GetBrandCountQuery, GetBrandCountQueryResult>
	{
		private readonly IStatisticRepository _statistic;
		public GetBrandCountQueryHandler(IStatisticRepository statistic)
		{
			_statistic = statistic;
		}

		public async Task<GetBrandCountQueryResult> Handle(GetBrandCountQuery request, CancellationToken cancellationToken)
		{
			var value = await _statistic.GetBrandCount();
			return new GetBrandCountQueryResult { BrandCount = value };
		}
	}
}
