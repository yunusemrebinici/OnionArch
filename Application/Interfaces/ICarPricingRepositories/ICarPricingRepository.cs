using Application.Features.Mediator.Results.CarPricingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICarPricingRepositories
{
	public interface ICarPricingRepository
	{
		Task<List<GetCarPricingWithCarAndPriceQueryResult>> GetAll();
	}
}
