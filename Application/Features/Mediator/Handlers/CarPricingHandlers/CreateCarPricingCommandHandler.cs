using Application.Features.Mediator.Commands.CarPricingCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.CarPricingHandlers
{
	public class CreateCarPricingCommandHandler : IRequestHandler<CreateCarPricingCommand>
	{
		private readonly IRepository<CarPricing>_repository;

		public CreateCarPricingCommandHandler(IRepository<CarPricing> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateCarPricingCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new CarPricing
			{
				Amount = request.Amount,
				CarID = request.CarID,
				PricingID = request.PricingID,

			});
		}
	}
}
