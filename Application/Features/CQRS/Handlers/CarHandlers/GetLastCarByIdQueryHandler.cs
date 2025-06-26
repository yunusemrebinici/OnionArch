using Application.Interfaces.ICarRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CarHandlers
{
	public class GetLastCarByIdQueryHandler
	{
		private readonly ICarRepository _carRepository;

		public GetLastCarByIdQueryHandler(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}

		public async Task<int> Handle()
		{
			return await _carRepository.GetLastCarById();	
		}
	}
}
