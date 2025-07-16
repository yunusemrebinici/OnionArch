using Application.Features.Mediator.Commands.LocationCommands;
using Application.Interfaces.ILocationRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.LocationRepositories
{
	public class LocationRepository : ILocationRepository
	{
		private readonly CarBookContext _context;

		public LocationRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task CreateaLocationWihtRentAcar(CreateLocationWithRentAcarCommand command)
		{
			Location location = new Location()
			{
			     Name = command.Name,
			};

			await _context.Locations.AddAsync(location);
			await _context.SaveChangesAsync();
			 
			var Id=location.LocationID;

			#region AddRentAcar

			List<Car> cars = new List<Car>();
			cars = await _context.Cars.ToListAsync();
			foreach (var car in cars ) 
			{
			    RentAcar rentAcar = new RentAcar()
				{
					Available = false,
					CarID=car.CarID,
					LocationID=Id,
				};
				await _context.RentAcars.AddAsync(rentAcar);
				

               			
			}
			await _context.SaveChangesAsync();
			#endregion
		}
	}
}
