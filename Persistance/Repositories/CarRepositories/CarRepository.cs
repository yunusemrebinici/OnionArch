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
			var values = await _context.CarPricings.Include(x => x.Car).ThenInclude(z => z.Brand).Where(x => x.PricingID == 2).ToListAsync();
			return values.Select(y => new GetCarWithBrandAndPriceQuaryRusult
			{
				CarID = y.CarID,
				CarPricing = y.Amount,
				CoverImageUrl = y.Car.CoverImageUrl,
				Model = y.Car.Model,
				Name = y.Car.Brand.Name,
			}).ToList();


		}

		public async Task<List<GetLast5CarsWithBrandQueryResult>> GetLast5CarsWithBrandQueryResult()
		{
			var values = await _context.Cars.Include(x => x.Brand).OrderByDescending(z => z.CarID).Take(5).ToListAsync();
			return values.Select(x => new GetLast5CarsWithBrandQueryResult
			{
				CarID = x.CarID,
				BigImageUrl = x.BigImageUrl,
				BrandID = x.BrandID,
				CoverImageUrl = x.CoverImageUrl,
				Fuel = x.Fuel,
				Km = x.Km,
				Luggage = x.Luggage,
				Model = x.Model,
				Seat = x.Seat,
				Transmission = x.Transmission,
				Name = x.Brand.Name,

			}).ToList();
		}
	}
}
