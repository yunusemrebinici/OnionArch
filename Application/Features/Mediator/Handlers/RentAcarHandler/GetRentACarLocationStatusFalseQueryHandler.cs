using Application.Features.Mediator.Quaries.RentAcarQuaries;
using Application.Interfaces.IRentAcarRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.RentAcarHandler
{
	public class GetRentACarLocationStatusFalseQueryHandler : IRequestHandler<GetRentACarLocationStatusFalseQuery>
	{
		private readonly IRentAcarRepository _repository;

		public GetRentACarLocationStatusFalseQueryHandler(IRentAcarRepository repository)
		{
			_repository = repository;
		}

		public async Task Handle(GetRentACarLocationStatusFalseQuery request, CancellationToken cancellationToken)
		{
			await _repository.GetRentACarLocationStatusFalse(request);
		}
	}
}
