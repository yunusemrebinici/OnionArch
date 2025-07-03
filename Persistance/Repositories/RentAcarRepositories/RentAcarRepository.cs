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
			var values = await _context.RentAcars.Where(filter).ToListAsync();
			return values;
		}
	}
}
