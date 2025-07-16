using Application.Features.Mediator.Quaries.GetRentAcarQuery;
using Application.Features.Mediator.Quaries.RentAcarQuaries;
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

		[HttpGet("{LocationId}/{Available}")]
		public async Task<IActionResult> GetCar(int LocationId,bool Available)
		{
			 GetRentAcarQuery query=new GetRentAcarQuery();
			query.Available = Available;
			query.LocationId = LocationId;
			var values= await _mediator.Send(query);
			return Ok(values);
		}

		[HttpGet("GetRentAcarWithLocationName/{id}")]
		public async Task<IActionResult>GetRentAcarWithLocationName(int id)
		{
			return Ok(await _mediator.Send(new GetRentAcarWithLocationNameQuery(id)));
		}
	}
}
