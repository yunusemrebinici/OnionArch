﻿using Application.Features.Mediator.Commands.PricingCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.PricingHandlers
{
	public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommand>
	{

		private readonly IRepository<Pricing>_repository;

		public UpdatePricingCommandHandler(IRepository<Pricing> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
		{
			await _repository.UpdateAsync(new Pricing
			{
				Name = request.Name,
				PricingID = request.PricingID,
			});
		}
	}
}
