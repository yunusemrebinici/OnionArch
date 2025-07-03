using Application.Features.Mediator.Quaries.GetRentAcarQuery;
using Application.Features.Mediator.Results.GetRentAcarQueryResult;
using Application.Interfaces.IRentAcarRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.RentAcarHandler
{
	public class GetRentAcarQueryHandler : IRequestHandler<GetRentAcarQuery, List<GetRentAcarQueryResult>>
	{
		private readonly IRentAcarRepository _repository;

		public GetRentAcarQueryHandler(IRentAcarRepository repository)
		{
			_repository = repository;
		}

		public async Task<List<GetRentAcarQueryResult>> Handle(GetRentAcarQuery request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByFilterAsync(x=>x.LocationID==request.LocationId && x.Available==request.Available);

			return value.Select(x=>new GetRentAcarQueryResult
			{
				CarID=x.CarID,
			}).ToList();
		}
	}
}
