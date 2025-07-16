using Application.Features.CQRS.Commands.CarCommands;
using Application.Interfaces;
using Application.Interfaces.ICarRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CarHandlers
{
	public class CreateCarWihtFeatureCommandHandler
	{
		private readonly ICarRepository _carRepository;

		public CreateCarWihtFeatureCommandHandler(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}

		public async Task Handle(CreateCarCommand command)
		{
			await _carRepository.CreateCarWithFeatureCommand(command);
		}
	}
}

