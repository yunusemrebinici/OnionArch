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
	public class GetMinTodayPriceCarBrandModelQueryHandler : IRequestHandler<GetMinTodayPriceCarBrandModelQuery, GetMinTodayPriceCarBrandModelQueryResult>
	{
		private readonly IStatisticRepository _statisticRepository;

		public GetMinTodayPriceCarBrandModelQueryHandler(IStatisticRepository statisticRepository)
		{
			_statisticRepository = statisticRepository;
		}

		public async Task<GetMinTodayPriceCarBrandModelQueryResult> Handle(GetMinTodayPriceCarBrandModelQuery request, CancellationToken cancellationToken)
		{
			var value = await _statisticRepository.GetMinTodayPriceCarBrandModel();
			return new GetMinTodayPriceCarBrandModelQueryResult { GetMinTodayPriceCarBrandModel= value };
		}
	}
}
