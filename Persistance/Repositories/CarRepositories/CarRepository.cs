using Application.Features.CQRS.Results.CarResults;
using Application.Interfaces.ICarRepositories;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.CarRepositories
{
	public class CarRepository : ICarRepository
	{
		private readonly CarBookContext _context;

		public CarRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task<List<GetCarWithBrandQuaryRusult>> GetCarWithBrand()
		{
			var values = await _context.Cars.Include(c => c.Brand).Select(y => new GetCarWithBrandQuaryRusult
			{
				CarID = y.CarID,
				Name = y.Brand.Name,
				BigImageUrl = y.BigImageUrl,
				BrandID = y.BrandID,
				CoverImageUrl = y.CoverImageUrl,
				Fuel = y.Fuel,
				Km = y.Km,
				Luggage = y.Luggage,
				Model = y.Model,
				Seat = y.Seat,
				Transmission = y.Transmission,

			}).ToListAsync();
			return values;

		}
	}
}
