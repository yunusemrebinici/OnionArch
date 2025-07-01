using Application.Features.Mediator.Quaries.StatisticQuaries;
using Application.Features.Mediator.Results.AuthorResults;
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
	public class GetOuthorCountQueryHandler:IRequestHandler<GetOuthorCountQuery, GetOuthorCountQueryResult>
	{
		private readonly IStatisticRepository _statistic;
		public GetOuthorCountQueryHandler(IStatisticRepository statistic)
		{
			_statistic = statistic;
		}

		public async Task<GetOuthorCountQueryResult> Handle(GetOuthorCountQuery request, CancellationToken cancellationToken)
		{
			var value = await _statistic.GetAuthorCount();
			return new GetOuthorCountQueryResult { Authorcount = value };
		}
	}
}
