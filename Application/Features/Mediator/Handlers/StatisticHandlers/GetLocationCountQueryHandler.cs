using Application.Features.Mediator.Quaries.StatisticQuaries;
using Application.Features.Mediator.Results.LocationResults;
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
	public class GetLocationCountQueryHandler : IRequestHandler<GetLocationCountQuery, GetLocationCountQueryResult>
	{
		private readonly IStatisticRepository _statistic;
		public GetLocationCountQueryHandler(IStatisticRepository statistic)
		{
			_statistic = statistic;
		}

		public async Task<GetLocationCountQueryResult> Handle(GetLocationCountQuery request, CancellationToken cancellationToken)
		{
			var value = await _statistic.GetLocationCount();
			return new GetLocationCountQueryResult { LocationCount = value };
		}
	}
}
