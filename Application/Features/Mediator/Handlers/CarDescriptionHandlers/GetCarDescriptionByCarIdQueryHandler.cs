using Application.Features.Mediator.Quaries.CarDescriptionQuaries;
using Application.Features.Mediator.Results.CarDescriptionResults;
using Application.Interfaces.ICarDescriptionRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.CarDescriptionHandlers
{
	public class GetCarDescriptionByCarIdQueryHandler : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionByIdQueryResult>
	{

		private readonly ICarDescriptionRepository _repository;

		public GetCarDescriptionByCarIdQueryHandler(ICarDescriptionRepository repository)
		{
			_repository = repository;
		}

		public async Task<GetCarDescriptionByIdQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetCarDescriptionByCarId(request.CarID);
			return new GetCarDescriptionByIdQueryResult
			{
				CarID = value.CarID,
				CarDescriptionID = value.CarDescriptionID,
				Details = value.Details,
			};
		}
	}
}
