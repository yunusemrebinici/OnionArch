using Application.Features.Mediator.Commands.CarFeatureCommands;
using Application.Features.Mediator.Quaries.CarFeatureQuaries;
using Application.Features.Mediator.Results.CarFeatureResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICarFeatureRepositories
{
	public interface ICarFeatureRepository
	{
		Task CarFeatureChangeStatusTrueByCarAndFeatureId(CarFeatureChangeStatusTrueCommand carFeature);

		Task CarFeatureChangeStatusFalseByCarAndFeatureId(CarFeatureChangeStatusFalseCommand falseOrTrue);

		Task<List<GetCarFeatureQueryResult>> GetGetCarFeatureListByCarId(GetCarFeatureQuery result);
	}
}
