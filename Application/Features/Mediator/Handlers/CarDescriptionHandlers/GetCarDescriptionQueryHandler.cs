using Application.Features.Mediator.Quaries.CarDescriptionQuaries;
using Application.Features.Mediator.Results.CarDescriptionResults;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.CarDescriptionHandlers
{
	public class GetCarDescriptionQueryHandler : IRequestHandler<GetCarDescriptionQuery, List<GetCarDescriptionQueryResult>>
	{
		private readonly IRepository<CarDescription>_repository;

		public GetCarDescriptionQueryHandler(IRepository<CarDescription> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetCarDescriptionQueryResult>> Handle(GetCarDescriptionQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GettAllAsync();
			return values.Select(x=> new GetCarDescriptionQueryResult
			{
				CarDescriptionID = x.CarDescriptionID,
				CarID = x.CarID,
				Details=x.Details,
			}).ToList();
		}
	}
}
