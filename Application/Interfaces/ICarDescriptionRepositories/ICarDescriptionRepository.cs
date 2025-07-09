using Application.Features.Mediator.Results.CarDescriptionResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICarDescriptionRepositories
{
	public interface ICarDescriptionRepository
	{
		Task<GetCarDescriptionByIdQueryResult>GetCarDescriptionByCarId(int id);
	}
}
