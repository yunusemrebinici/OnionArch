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
	public class GetRentACarLocationStatusTrueQueryHandler : IRequestHandler<GetRentACarLocationStatusTrueQuery>
	{
		private readonly IRentAcarRepository _repository;

		public GetRentACarLocationStatusTrueQueryHandler(IRentAcarRepository repository)
		{
			_repository = repository;
		}

		public async Task Handle(GetRentACarLocationStatusTrueQuery request, CancellationToken cancellationToken)
		{
			await _repository.GetRentACarLocationStatusTrue(request);
		}
	}
}
