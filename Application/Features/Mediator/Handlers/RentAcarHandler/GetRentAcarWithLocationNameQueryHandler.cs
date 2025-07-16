using Application.Features.Mediator.Quaries.RentAcarQuaries;
using Application.Features.Mediator.Results.RentAcarResults;
using Application.Interfaces.IRentAcarRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.RentAcarHandler
{
	public class GetRentAcarWithLocationNameQueryHandler : IRequestHandler<GetRentAcarWithLocationNameQuery, List<GetRentAcarWithLocationNameResult>>
	{

		private readonly IRentAcarRepository _repository;

		public GetRentAcarWithLocationNameQueryHandler(IRentAcarRepository repository)
		{
			_repository = repository;
		}

		public async Task<List<GetRentAcarWithLocationNameResult>> Handle(GetRentAcarWithLocationNameQuery request, CancellationToken cancellationToken)
		{
			return await _repository.GetRentAcarWithLocationNameResults(request.CarId);
		}
	}
}
