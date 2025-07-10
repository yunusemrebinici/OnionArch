using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IAppUserRepositories
{
	public interface IAppUserRepository
	{
        Task<AppUser>GetFilterAsync(Expression<Func<AppUser,bool>>filter);
	}
}
