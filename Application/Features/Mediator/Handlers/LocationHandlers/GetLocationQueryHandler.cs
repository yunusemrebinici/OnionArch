using Application.Features.Mediator.Quaries.LocationQuaries;
using Application.Features.Mediator.Results.LocationResults;
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
	public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery,List<GetLocationQueryResult>>
	{
		private readonly IRepository<Location>_locationRepository;

		public GetLocationQueryHandler(IRepository<Location> locationRepository)
		{
			_locationRepository = locationRepository;
		}

		public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
		{
			var values = await _locationRepository.GettAllAsync();
			return values.Select(x => new GetLocationQueryResult
			{
				LocationID = x.LocationID,
				Name = x.Name,
			}).ToList();
		}
	}
}
