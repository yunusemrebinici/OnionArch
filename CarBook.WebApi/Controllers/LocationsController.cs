using Application.Features.Mediator.Commands.LocationCommands;
using Application.Features.Mediator.Quaries.LocationQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LocationsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public LocationsController(IMediator mediator)
		{
			_mediator = mediator;
		}


		[HttpGet]
		public async Task<IActionResult> LocationList()
		{
			return Ok(await _mediator.Send(new GetLocationQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetLocation(int id)
		{
			return Ok(await _mediator.Send(new GetLocationByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateLocation(CreateLocationCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateLocation(UpdateLocationCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteLocation(int id)
		{
			await _mediator.Send(new RemoveLocationCommand(id));
			return Ok("Silme İşlemi Başarılı");
		}
	}
}
