using Application.Features.CQRS.Results.CarResults;
using Application.Interfaces.ICarRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CarHandlers
{
	public class GetCarWithBrandAndPriceQueryHandler
	{
		private readonly ICarRepository _carRepository;

		public GetCarWithBrandAndPriceQueryHandler(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}

		public async Task<List<GetCarWithBrandAndPriceQuaryRusult>> Handle()
		{		
			return await _carRepository.GetCarWithBrand();
		}
	}
}
