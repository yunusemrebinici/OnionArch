using Application.Features.Mediator.Results.CarDescriptionResults;
using Application.Interfaces.ICarDescriptionRepositories;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.CarDescriptionRepositories
{
	public class CarDescriptionRepository : ICarDescriptionRepository
	{
		private readonly CarBookContext _context;

		public CarDescriptionRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task<GetCarDescriptionByIdQueryResult> GetCarDescriptionByCarId(int id)
		{
			var value = await _context.CarDescriptions.Where(x=>x.CarID==id).FirstOrDefaultAsync();
			return new GetCarDescriptionByIdQueryResult
			{
				CarID=value.CarID,
				CarDescriptionID=value.CarDescriptionID,
				Details=value.Details,
			};
		}
	}
}
