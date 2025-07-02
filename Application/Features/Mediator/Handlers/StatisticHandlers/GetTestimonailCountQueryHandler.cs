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
	public class GetTestimonailCountQueryHandler : IRequestHandler<GetTestimonailCountQuery, GetTestimonailCountQueryResult>
	{
		private readonly IStatisticRepository _statisticRepository;

		public GetTestimonailCountQueryHandler(IStatisticRepository statisticRepository)
		{
			_statisticRepository = statisticRepository;
		}

		public async Task<GetTestimonailCountQueryResult> Handle(GetTestimonailCountQuery request, CancellationToken cancellationToken)
		{
			var value = await _statisticRepository.GetTestimonailCount();
			return new GetTestimonailCountQueryResult
			{
				GetTestimonailCount	=value,
			};
		}
	}
}
