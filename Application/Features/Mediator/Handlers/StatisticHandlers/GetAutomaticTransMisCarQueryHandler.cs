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
	public class GetAutomaticTransMisCarQueryHandler:IRequestHandler<GetAutomaticTransMisCarQuery, GetAutomaticTransMissionCarCountQueryResult>
	{
		private readonly IStatisticRepository _statistic;
		public GetAutomaticTransMisCarQueryHandler(IStatisticRepository statistic)
		{
			_statistic = statistic;
		}

		public async Task<GetAutomaticTransMissionCarCountQueryResult> Handle(GetAutomaticTransMisCarQuery request, CancellationToken cancellationToken)
		{
			var value = await _statistic.GetAutomaticTransMissionCarCount();
			return new GetAutomaticTransMissionCarCountQueryResult { AutoTransCarCount = value };
		}
	}
}
