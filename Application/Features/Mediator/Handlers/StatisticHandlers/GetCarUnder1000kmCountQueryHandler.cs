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
	public class GetCarUnder1000kmCountQueryHandler : IRequestHandler<GetCarUnder1000kmCountQuery, GetCarUnder1000kmCountQueryResult>
	{
		private readonly IStatisticRepository _statisticRepository;

		public GetCarUnder1000kmCountQueryHandler(IStatisticRepository statisticRepository)
		{
			_statisticRepository = statisticRepository;
		}

		public async Task<GetCarUnder1000kmCountQueryResult> Handle(GetCarUnder1000kmCountQuery request, CancellationToken cancellationToken)
		{
			var value = await _statisticRepository.GetCarUnder1000kmCount();
			return new GetCarUnder1000kmCountQueryResult
			{
				GetCarUnder1000kmCount = value,
			};
		}
	}
}
