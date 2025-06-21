using Application.Features.Mediator.Commands.ServiceCommands;
using Application.Features.Mediator.Quaries.ServiceQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public ServicesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> ServiceList()
		{
			return Ok(await _mediator.Send(new GetServiceQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetService(int id)
		{
			return Ok(await _mediator.Send(new GetServiceByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateService(CreateServiceCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateService(UpdateServiceCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveService(int id)
		{
			await _mediator.Send(new RemoveServiceCommand(id));
			return Ok("Silme İşlemi Başarılı");
		}

	}
}
