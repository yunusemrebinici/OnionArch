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
	public class RemoveCarPricingCommandHandler : IRequestHandler<RemoveCarPricingCommand>
	{

		private readonly IRepository<CarPricing> _repository;

		public RemoveCarPricingCommandHandler(IRepository<CarPricing> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveCarPricingCommand request, CancellationToken cancellationToken)
		{
			var remove = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(remove);

		}
	}
}
