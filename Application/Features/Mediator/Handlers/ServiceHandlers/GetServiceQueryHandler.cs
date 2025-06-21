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
	public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
	{
		private readonly IRepository<Domain.Entities.Services> _repository;

		public GetServiceQueryHandler(IRepository<Domain.Entities.Services> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GettAllAsync();
			return values.Select(x => new GetServiceQueryResult
			{
				Description = x.Description,
				IconUrl = x.IconUrl,
				ServicesID = x.ServicesID,
				Title = x.Title,

			}).ToList();
		}
	}
}
