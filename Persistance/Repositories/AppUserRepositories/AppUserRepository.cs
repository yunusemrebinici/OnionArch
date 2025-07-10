using Application.Interfaces.IAppUserRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.AppUserRepositories
{
	public class AppUserRepository : IAppUserRepository
	{
		private readonly CarBookContext _carBookContext;

		public AppUserRepository(CarBookContext carBookContext)
		{
			_carBookContext = carBookContext;
		}

		public async Task<AppUser> GetFilterAsync(Expression<Func<AppUser, bool>> filter)
		{
			var values = await _carBookContext.AppUsers.Where(filter).FirstOrDefaultAsync();
			return values;
		}
	}
}
