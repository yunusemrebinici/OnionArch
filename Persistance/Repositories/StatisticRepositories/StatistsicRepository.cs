using Application.Interfaces.IStatisticRepositories;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.StatisticRepositories
{
	public class StatistsicRepository : IStatisticRepository
	{
		private readonly CarBookContext _context;

		public StatistsicRepository(CarBookContext carBookContext)
		{
			_context = carBookContext;
		}

		public async Task<int> GetAuthorCount()
		{
			int value = await _context.Authors.Select(x => x.AuthorID).CountAsync();
			return value;
		}

		public async Task<int> GetAutomaticTransMissionCarCount()
		{
			int value = await _context.Cars.Where(x => x.Transmission == "Otomatik").CountAsync();
			return value;

		}

		public async Task<int> GetBlogCount()
		{
			int value = await _context.Blogs.Select(x => x.BlogID).CountAsync();
			return value;
		}

		public async Task<int> GetBrandCount()
		{
			int value = await _context.Brands.Select(x => x.BrandID).CountAsync();
			return value;
		}

		public async Task<int> GetCarCount()
		{
			int value = await _context.Cars.Select(x => x.CarID).CountAsync();
			return value;
		}

		public async Task<int> GetCarUnder1000kmCount()
		{
			int value = await _context.Cars.Where(x => x.Km < 1000).CountAsync();
			return value;
		}

		public async Task<int> GetElectricCarCount()
		{
			int value = await _context.Cars.Where(x => x.Fuel == "Elektrik").CountAsync();
			return value;
		}

		public async Task<int> GetLocationCount()
		{
			int value = await _context.Locations.Select(x => x.LocationID).CountAsync();
			return value;
		}

		public async Task<string> GetMaxTodayPriceCarBrandModel()
		{
			var value = await _context.CarPricings
				.Include(x => x.Car)
				.Where(x => x.PricingID == 2)
				.OrderByDescending(x => x.Amount)
				.Select(x => x.Car.Model)
				.FirstOrDefaultAsync();
			return value;
		}


		public Task<string> GetMinTodayPriceCarBrandModel()
		{
			throw new NotImplementedException();
		}

		public async Task<decimal> GetMonthCarPricingAvg()
		{

			int id = await _context.Pricings.Where(x => x.Name == "Aylık").Select(x => x.PricingID).FirstOrDefaultAsync();
			decimal value = await _context.CarPricings.Where(x => x.CarPricingID == id).AverageAsync(x => x.Amount);
			return value;
		}

		public async Task<int> GetMostBlogCommentCount()
		{
			var mostCommentedBlog = await _context.Comments
				.GroupBy(c => c.BlogID)
				.OrderByDescending(g => g.Count())
				.Select(g => g.Key)
				.FirstOrDefaultAsync();

			return mostCommentedBlog;
		}

		public async Task<string> GetMostBrandedCarsBrand()
		{
			var id = await _context.Cars.GroupBy(x => x.BrandID).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefaultAsync();
			string brand = await _context.Brands.Where(x => x.BrandID == id).Select(x => x.Name).FirstOrDefaultAsync();
			return brand;
		}

		public Task<int> GetTestimonailCount()
		{
			throw new NotImplementedException();
		}

		public async Task<decimal> GetTodayCarPricingAvg()
		{
			int id = await _context.Pricings.Where(x => x.Name == "Günlük").Select(x => x.PricingID).FirstOrDefaultAsync();
			decimal avg = await _context.CarPricings.Where(x => x.PricingID == id).AverageAsync(z => z.Amount);
			return avg;

		}

		public async Task<decimal> GetWeekCarPricingAvg()
		{
			int id = await _context.Pricings.Where(x => x.Name == "Haftalık").Select(x => x.PricingID).FirstOrDefaultAsync();
			decimal avg = await _context.CarPricings.Where(x => x.PricingID == id).AverageAsync(z => z.Amount);
			return avg;
		}
	}
}
