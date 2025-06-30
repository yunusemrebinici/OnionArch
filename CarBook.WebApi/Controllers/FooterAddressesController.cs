using Application.Features.Mediator.Commands.FooterAddressCommands;
using Application.Features.Mediator.Quaries.FooterAddressQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FooterAddressesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public FooterAddressesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> FooterAddressList()
		{
			return Ok(await _mediator.Send(new GetFooterAddressQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetFooterAddress(int id)
		{
			return Ok( await _mediator.Send(new GetFooterAddressByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult>CreateFooterAddress(CreateFooterAdressCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteFooterAddress(int id)
		{
			await _mediator.Send(new RemoveFooterAdressCommand(id));
			return Ok("Silme İşlemi Başarılı");
		}
	}
}
