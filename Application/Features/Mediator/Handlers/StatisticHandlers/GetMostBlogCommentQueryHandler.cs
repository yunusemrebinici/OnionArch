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
	public class GetMostBlogCommentQueryHandler:IRequestHandler<GetMostBlogCommentQuery, GetMostBlogCommentQueryResult>
	{
		private readonly IStatisticRepository _statistic;
		public GetMostBlogCommentQueryHandler(IStatisticRepository statistic)
		{
			_statistic = statistic;
		}

		public async Task<GetMostBlogCommentQueryResult> Handle(GetMostBlogCommentQuery request, CancellationToken cancellationToken)
		{
			var value = await _statistic.GetMostBlogCommentCount();
			return new GetMostBlogCommentQueryResult { MostBlogComment = value }; 
		}
	}
}
