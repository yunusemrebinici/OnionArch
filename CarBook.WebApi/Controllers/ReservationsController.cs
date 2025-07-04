using Application.Features.Mediator.Commands.ReservationCommands;
using Application.Features.Mediator.Quaries.ReservationQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ReservationsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public ReservationsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> ReservationList()
		{
			return Ok(await _mediator.Send(new GetReservationQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetReservation(int id)
		{
			return Ok(await _mediator.Send(new GetReservationByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateReservation(CreateReservationCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme Başarılı");
		}
	}
}
