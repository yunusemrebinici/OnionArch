using Application.Features.Mediator.Quaries.CarFeatureQuaries;
using Application.Features.Mediator.Results.CarFeatureResults;
using Application.Interfaces.ICarFeatureRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.CarFeatureHandlers
{
	public class GetCarFeatureQueryHandlers : IRequestHandler<GetCarFeatureQuery, List<GetCarFeatureQueryResult>>
	{
		private readonly ICarFeatureRepository _carFeatureRepository;

		public GetCarFeatureQueryHandlers(ICarFeatureRepository carFeatureRepository)
		{
			_carFeatureRepository = carFeatureRepository;
		}

		public async Task<List<GetCarFeatureQueryResult>> Handle(GetCarFeatureQuery request, CancellationToken cancellationToken)
		{
			
			var values = await _carFeatureRepository.GetGetCarFeatureListByCarId(request);
			return values;
		}
	}
}
