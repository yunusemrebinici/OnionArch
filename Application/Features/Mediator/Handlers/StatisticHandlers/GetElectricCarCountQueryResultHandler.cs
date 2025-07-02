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
	public class GetElectricCarCountQueryResultHandler : IRequestHandler<GetElectricCarCountQuery, GetElectricCarCountQueryResult>
	{
		private readonly IStatisticRepository _repository;

		public GetElectricCarCountQueryResultHandler(IStatisticRepository repository)
		{
			_repository = repository;
		}

		public async Task<GetElectricCarCountQueryResult> Handle(GetElectricCarCountQuery request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetElectricCarCount();
			return new GetElectricCarCountQueryResult
			{
				GetElectricCarCount = value,
			};
		}
	}
}
