﻿using Application.Features.Mediator.Commands.LocationCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.LocationHandlers
{
	public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand>
	{
		private readonly IRepository<Location> _locationRepository;

		public CreateLocationCommandHandler(IRepository<Location> locationRepository)
		{
			_locationRepository = locationRepository;
		}

		public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
		{
			await _locationRepository.CreateAsync(new Location
			{
				Name = request.Name,

			});
		}
	}
}
