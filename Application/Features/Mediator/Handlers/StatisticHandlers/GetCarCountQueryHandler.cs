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
	public class GetCarCountQueryHandler:IRequestHandler<GetCarCountQuery, GetCarCountQueryResult>
	{
		private readonly IStatisticRepository _statistic;
		public GetCarCountQueryHandler(IStatisticRepository statistic)
		{
			_statistic = statistic;
		}

		public async Task<GetCarCountQueryResult> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
		{
			var value = await _statistic.GetCarCount();
			return new GetCarCountQueryResult { CarCount = value };
		}
	}
}
