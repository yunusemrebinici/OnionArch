using Application.Features.Mediator.Quaries.ReservationQuaries;
using Application.Features.Mediator.Results.ReservationResults;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.ReservationHandlers
{
	public class GetReservationQueryHandler : IRequestHandler<GetReservationQuery, List<GetReservationQueryResult>>
	{

		private readonly IRepository<Reservation> _repository;

		public GetReservationQueryHandler(IRepository<Reservation> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetReservationQueryResult>> Handle(GetReservationQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GettAllAsync();
			return values.Select(x => new GetReservationQueryResult {
				ReservationID=x.ReservationID,
				Age = x.Age,
				CarID = x.CarID,
				Description = x.Description,
				DriverLicenceYear = x.DriverLicenceYear,
				Email = x.Email,
				EndLocationID = x.EndLocationID,
				Name = x.Name,
				Phone = x.Phone,
				StartLocationID = x.StartLocationID,
			    Status = x.Status,
				Surname = x.Surname,

			}).ToList();	
		}
	}
}
