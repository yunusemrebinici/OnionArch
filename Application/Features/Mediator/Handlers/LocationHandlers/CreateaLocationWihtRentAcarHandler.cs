using Application.Features.Mediator.Commands.LocationCommands;
using Application.Interfaces.ILocationRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.LocationHandlers
{
	public class CreateaLocationWihtRentAcarHandler : IRequestHandler<CreateLocationWithRentAcarCommand>
	{
		private readonly ILocationRepository _locationRepository;

		public CreateaLocationWihtRentAcarHandler(ILocationRepository locationRepository)
		{
			_locationRepository = locationRepository;
		}

		public async Task Handle(CreateLocationWithRentAcarCommand request, CancellationToken cancellationToken)
		{
			await _locationRepository.CreateaLocationWihtRentAcar(request);
		}
	}
}
