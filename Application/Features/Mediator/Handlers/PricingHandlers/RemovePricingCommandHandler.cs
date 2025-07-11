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
	public class RemovePricingCommandHandler : IRequestHandler<RemovePricingCommand>
	{
		private readonly IRepository<Pricing> _repository;

		public RemovePricingCommandHandler(IRepository<Pricing> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemovePricingCommand request, CancellationToken cancellationToken)
		{
			var remove= await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(remove);
		}
	}
}
