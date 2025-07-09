using Application.Features.Mediator.Quaries.CarDescriptionQuaries;
using Application.Features.Mediator.Quaries.TestimonialQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarDescriptionsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CarDescriptionsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> CarDescriptionList()
		{
			return Ok(await _mediator.Send(new GetCarDescriptionQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCarDescription(int id)
		{
			return Ok(await _mediator.Send(new GetCarDescriptionByIdQuery(id)));
		}

		[HttpGet("GetCarDescriptionByCarId/{id}")]
		public async Task<IActionResult> GetCarDescriptionByCarId(int id)
		{
			return Ok(await _mediator.Send(new GetCarDescriptionByCarIdQuery(id)));
		}



	}
}
