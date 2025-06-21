using Application.Features.CQRS.Results.CarResults;
using Application.Interfaces.ICarRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CarHandlers
{
	public class GetLast5CarsWithBrandQueryHandler
	{
		private readonly ICarRepository _carRepository;

		public GetLast5CarsWithBrandQueryHandler(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}

		public async Task<List<GetLast5CarsWithBrandQueryResult>> Handle()
		{
			var values= await _carRepository.GetLast5CarsWithBrandQueryResult();
			return values;
		}
	}
}
