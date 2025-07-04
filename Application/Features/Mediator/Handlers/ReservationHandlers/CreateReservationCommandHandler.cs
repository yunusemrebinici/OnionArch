using Application.Features.Mediator.Commands.ReservationCommands;
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
	public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand>
	{
		private readonly IRepository<Reservation> _repository;

		public CreateReservationCommandHandler(IRepository<Reservation> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Reservation
			{
				Age = request.Age,
				CarID = request.CarID,
				Description = request.Description,
				DriverLicenceYear = request.DriverLicenceYear,
				Email = request.Email,
				EndLocationID = request.EndLocationID,
				Name = request.Name,
				Phone = request.Phone,
				StartLocationID = request.StartLocationID,
				Status = "Rezervasyon Alındı",
				Surname = request.Surname,
			});
		}
	}
}
