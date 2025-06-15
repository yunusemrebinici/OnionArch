using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
	public class Repositoriy<T> : IRepository<T> where T : class
	{
		private readonly CarBookContext _context;
		public Repositoriy(CarBookContext bookContext)
		{
			_context = bookContext;
		}
		public async Task CreateAsync(T t)
		{
			await _context.AddAsync(t);
			await _context.SaveChangesAsync();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _context.FindAsync<T>(id);
		}

		public async Task<List<T>> GettAllAsync()
		{
			return await _context.Set<T>().ToListAsync();

		}

		public async Task RemoveAsync(T t)
		{
		      _context.Remove(t);
			 await _context.SaveChangesAsync();
			return;
		}

		public async Task UpdateAsync(T t)
		{
			_context.Set<T>().Update(t);
			await _context.SaveChangesAsync();
			return;
		}
	}
}
