using Application.Features.CQRS.Commands.CarCommands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CarHandlers
{
	public class UpdateCarCommandHandler
	{
		private readonly IRepository<Car> _repository;

		public UpdateCarCommandHandler(IRepository<Car> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateCarCommand command)
		{
			await _repository.UpdateAsync(new Car
			{
				CoverImageUrl = command.CoverImageUrl,
				BigImageUrl = command.BigImageUrl,
				BrandID = command.BrandID,
				CarID = command.CarID,
				Transmission = command.Transmission,
				Seat = command.Seat,
				Model = command.Model,
				Luggage = command.Luggage,
				Km = command.Km,
				Fuel = command.Fuel,
			});
		}
	}
}
