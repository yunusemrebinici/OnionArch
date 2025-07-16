using Application.Features.CQRS.Commands.CarCommands;
using Application.Features.CQRS.Results.CarResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICarRepositories
{
	public interface ICarRepository
	{
		Task<List<GetCarWithBrandAndPriceQuaryRusult>> GetCarWithBrand();

		Task<List<GetLast5CarsWithBrandQueryResult>> GetLast5CarsWithBrandQueryResult();

		Task <int> GetLastCarById();

		Task CreateCarWithFeatureCommand(CreateCarCommand create);
	}
}
