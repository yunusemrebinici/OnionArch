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
	public class UpdateCarPricingCommandHandler : IRequestHandler<UpdateCarPricingCommand>
	{
		private readonly IRepository<CarPricing> _repository;

		public UpdateCarPricingCommandHandler(IRepository<CarPricing> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateCarPricingCommand request, CancellationToken cancellationToken)
		{
			await _repository.UpdateAsync(new CarPricing
			{
				CarPricingID = request.CarPricingID,
				Amount = request.Amount,
				CarID = request.CarID,
				PricingID = request.PricingID,
			});
		}
	}
}
