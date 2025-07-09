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
	public class GetCarDescriptionByIdQueryHandler : IRequestHandler<GetCarDescriptionByIdQuery, GetCarDescriptionByIdQueryResult>
	{

		private readonly IRepository<CarDescription> _repository;

		public GetCarDescriptionByIdQueryHandler(IRepository<CarDescription> repository)
		{
			_repository = repository;
		}

		public async Task<GetCarDescriptionByIdQueryResult> Handle(GetCarDescriptionByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.CarID);
			return new GetCarDescriptionByIdQueryResult
			{
				CarDescriptionID = request.CarID,
				CarID = values.CarID,
				Details = values.Details,
			};
		}
	}
}
