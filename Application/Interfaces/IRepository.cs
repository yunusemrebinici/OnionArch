using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
	public interface IRepository<T> where T : class
	{
		Task<List<T>> GettAllAsync();

		Task<T> GetByIdAsync(int id);

		Task CreateAsync(T t);

		Task UpdateAsync(T t);

		Task RemoveAsync(T t);

	}
}
