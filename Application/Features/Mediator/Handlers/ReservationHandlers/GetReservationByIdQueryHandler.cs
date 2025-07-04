
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
	public class GetReservationByIdQueryHandler : IRequestHandler<GetReservationByIdQuery, GetReservationByIdQueryResult>
	{
		private readonly IRepository<Reservation> _repository;

		public GetReservationByIdQueryHandler(IRepository<Reservation> repository)
		{
			_repository = repository;
		}

		public async Task<GetReservationByIdQueryResult> Handle(GetReservationByIdQuery request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			return new GetReservationByIdQueryResult
			{
				ReservationID = value.ReservationID,
				Age = value.Age,
				CarID = value.CarID,
				Description = value.Description,
				DriverLicenceYear = value.DriverLicenceYear,
				Email = value.Email,
				EndLocationID = value.EndLocationID,
				Name = value.Name,
				Phone = value.Phone,
				StartLocationID = value.StartLocationID,
				Status = value.Status,
				Surname = value.Surname,
			};
		}
	}
}
