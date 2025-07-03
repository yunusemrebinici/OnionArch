using Application.Features.Mediator.Quaries.GetRentAcarQuery;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RentAcarsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public RentAcarsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> GetCar(GetRentAcarQuery query)
		{
			var values= await _mediator.Send(query);
			return Ok(values);
		}
	}
}
