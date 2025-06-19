using Application.Features.Mediator.Commands.PricingCommands;
using Application.Features.Mediator.Quaries.PricingQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PricingsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public PricingsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> PricingList()
		{
			return Ok(await _mediator.Send(new GetPricingQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetPricing(int id)
		{
			return Ok(await _mediator.Send(new GetPricingByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreatePricing(CreatePricingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete]
		public async Task<IActionResult> RemovePricing(int id)
		{
			await _mediator.Send(new RemovePricingCommand(id));
			return Ok("Silme İşlemi Başarılı");
		}
	}
}

