using Application.Features.Mediator.Commands.CarFeatureCommands;
using Application.Interfaces.ICarFeatureRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.CarFeatureHandlers
{
	public class CarFeatureChangeStatusFalseHandler : IRequestHandler<CarFeatureChangeStatusFalseCommand>
	{

		private readonly ICarFeatureRepository _carFeatureRepository;

		public CarFeatureChangeStatusFalseHandler(ICarFeatureRepository carFeatureRepository)
		{
			_carFeatureRepository = carFeatureRepository;
		}

		public async Task Handle(CarFeatureChangeStatusFalseCommand request, CancellationToken cancellationToken)
		{
			await _carFeatureRepository.CarFeatureChangeStatusFalseByCarAndFeatureId(request);
		}
	}
}
