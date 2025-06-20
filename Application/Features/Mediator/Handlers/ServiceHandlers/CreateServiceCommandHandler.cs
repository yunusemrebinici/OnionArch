﻿using Application.Features.Mediator.Commands.ServiceCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Features.Mediator.Handlers.ServiceHandlers
{
	public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
	{
		private readonly IRepository<Domain.Entities.Services> _repository;

		public CreateServiceCommandHandler(IRepository<Domain.Entities.Services> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Domain.Entities.Services
			{
				Description = request.Description,
				IconUrl = request.IconUrl,
				Title = request.Title,
			});
		}
	}
}
