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
	public class GetMaxTodayPriceCarBrandModelQueryHandler : IRequestHandler<GetMaxTodayPriceCarBrandModelQuery, GetMaxTodayPriceCarBrandModelQueryResult>
	{
		private readonly IStatisticRepository _statisticRepository;

		public GetMaxTodayPriceCarBrandModelQueryHandler(IStatisticRepository statisticRepository)
		{
			_statisticRepository = statisticRepository;
		}

		public async Task<GetMaxTodayPriceCarBrandModelQueryResult> Handle(GetMaxTodayPriceCarBrandModelQuery request, CancellationToken cancellationToken)
		{
			var value = await _statisticRepository.GetMaxTodayPriceCarBrandModel();
			return new GetMaxTodayPriceCarBrandModelQueryResult { MaxTodayPriceCarBrandModel = value };
		}
	}
}
