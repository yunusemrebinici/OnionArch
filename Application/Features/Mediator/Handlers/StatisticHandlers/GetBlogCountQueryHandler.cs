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
	public class GetBlogCountQueryHandler:IRequestHandler<GetBlogCountQuery, GetBlogCountQueryResult>
	{
		private readonly IStatisticRepository _statistic;

		public GetBlogCountQueryHandler(IStatisticRepository statistic)
		{
			_statistic = statistic;
		}

		public async Task<GetBlogCountQueryResult> Handle(GetBlogCountQuery request, CancellationToken cancellationToken)
		{
			var value = await _statistic.GetBlogCount();
			return new GetBlogCountQueryResult { BlogCount = value };
		}
	}
}
