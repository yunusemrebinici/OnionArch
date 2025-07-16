using Application.Features.Mediator.Quaries.RentAcarQuaries;
using Application.Features.Mediator.Results.RentAcarResults;
using Application.Interfaces.IRentAcarRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.RentAcarRepositories
{
	public class RentAcarRepository : IRentAcarRepository

	{
		private readonly CarBookContext _context;

		public RentAcarRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task<List<RentAcar>> GetByFilterAsync(Expression<Func<RentAcar, bool>> filter)
		{
			var values = await _context.RentAcars.Where(filter).Include(x => x.Car).Include(y=>y.Car.Brand).Include(z=>z.Car.CarPricing).ToListAsync();
			return values;
		}

		public async Task GetRentACarLocationStatusFalse(GetRentACarLocationStatusFalseQuery falseQuery)
		{
			var value= await _context.RentAcars.Where(x=>x.RentAcarID==falseQuery.RentAcarID && x.CarID==falseQuery.CarID && x.LocationID==falseQuery.LocationID).FirstOrDefaultAsync();
			value.Available = false;
			await _context.SaveChangesAsync();
			

		}

		public async Task GetRentACarLocationStatusTrue(GetRentACarLocationStatusTrueQuery trueQuery)
		{
			var value = await _context.RentAcars.Where(x => x.RentAcarID == trueQuery.RentAcarID && x.CarID == trueQuery.CarID && x.LocationID == trueQuery.LocationID).FirstOrDefaultAsync();
			value.Available = true;
			await _context.SaveChangesAsync();
		}

		public async Task<List<GetRentAcarWithLocationNameResult>> GetRentAcarWithLocationNameResults(int id)
		{
			var values= await _context.RentAcars.Include(z=>z.Location).Where(x=>x.CarID==id).ToListAsync();
			return values.Select(x=> new GetRentAcarWithLocationNameResult
			{
				CarID = x.CarID,
				Available = x.Available,
				LocationID = x.LocationID,
				LocationName=x.Location.Name,
				RentAcarID = x.RentAcarID,
				
			}).ToList();
		}
	}
}
