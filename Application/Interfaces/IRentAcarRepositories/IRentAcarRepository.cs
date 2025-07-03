using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRentAcarRepositories
{
	public interface IRentAcarRepository
	{
		Task<List<RentAcar>> GetByFilterAsync(Expression<Func<RentAcar,bool>>filter);
	}
}
