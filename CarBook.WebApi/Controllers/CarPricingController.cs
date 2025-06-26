using Application.Features.Mediator.Commands.CarPricingCommands;
using Application.Features.Mediator.Quaries.CarPricingQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarPricingController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CarPricingController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> CarPricingList()
		{
			return Ok(await _mediator.Send(new GetCarPricingQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCarPricing(int id)
		{
			return Ok(await _mediator.Send(new GetCarPricingByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateCarPricing(CreateCarPricingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateCarPricing(UpdateCarPricingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveCarPricing(int id)
		{
			await _mediator.Send(new RemoveCarPricingCommand(id));
			return Ok("Silme İşlemi Başarılı");
		}

	}
}
