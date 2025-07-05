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

		public async Task<List<GetCarWithBrandAndPriceQuaryRusult>> GetCarWithBrand()
		{
			var values = await _context.Cars.Include(c => c.Brand).Include(x=>x.CarPricing).ToListAsync();
			return values.Select(y => new GetCarWithBrandAndPriceQuaryRusult
			{
				CarID = y.CarID,
				BrandID = y.BrandID,
				CarPricing = y.CarPricing.Where(x=>x.CarID==y.CarID).Select(z=>z.Amount).FirstOrDefault(),
				CoverImageUrl = y.CoverImageUrl,
				Model = y.Model,
				Name = y.Brand.Name,
			}).ToList();


		}

		public async Task<List<GetLast5CarsWithBrandQueryResult>> GetLast5CarsWithBrandQueryResult()
		{
			var values = await _context.Cars.Include(x => x.Brand).Include(y=>y.CarPricing).OrderByDescending(z => z.CarID).Take(5).ToListAsync();
			return values.Select(x => new GetLast5CarsWithBrandQueryResult
			{
				CarID = x.CarID,
				BrandID = x.BrandID,
				CoverImageUrl = x.CoverImageUrl,		
				Model = x.Model,			
				Name = x.Brand.Name,
				Amount=x.CarPricing.Where(y=>y.CarID==x.CarID).Select(z=>z.Amount).FirstOrDefault()

			}).ToList();
		}

		public async Task<int> GetLastCarById()
		{
			var values= await _context.Cars.OrderByDescending(x=>x.CarID).Select(x=>x.CarID).FirstOrDefaultAsync();
			return values;
		}
	}
}
