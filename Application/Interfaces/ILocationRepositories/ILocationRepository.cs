using Application.Features.Mediator.Commands.LocationCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ILocationRepositories
{
	public interface ILocationRepository
	{
		Task CreateaLocationWihtRentAcar(CreateLocationWithRentAcarCommand command);
	}
}
