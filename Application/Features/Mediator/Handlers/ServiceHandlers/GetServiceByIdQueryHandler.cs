using Application.Features.Mediator.Quaries.ServiceQuaries;
using Application.Features.Mediator.Results.ServiceResults;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.ServiceHandlers
{
	public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
	{
		private readonly IRepository<Domain.Entities.Services> _repository;

		public GetServiceByIdQueryHandler(IRepository<Domain.Entities.Services> repository)
		{
			_repository = repository;
		}

		public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
		{
			var value= await _repository.GetByIdAsync(request.Id);
			return new GetServiceByIdQueryResult
			{
				Description = value.Description,
				IconUrl = value.IconUrl,
				ServicesID = value.ServicesID,
				Title = value.Title,
			};
		}
	}
}
