using Application.Features.Mediator.Commands.LocationCommands;
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
	public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand>
	{

		private readonly IRepository<Location> _locationRepository;

		public UpdateLocationCommandHandler(IRepository<Location> locationRepository)
		{
			_locationRepository = locationRepository;
		}

		public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
		{
			await _locationRepository.UpdateAsync(new Location
			{
				LocationID = request.LocationID,
				Name = request.Name,
			});
		}
	}
}
