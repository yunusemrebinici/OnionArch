using Application.Features.Mediator.Commands.CarFeatureCommands;
using Application.Features.Mediator.Quaries.CarFeatureQuaries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarFeaturesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CarFeaturesController(IMediator mediator)
		{
			_mediator = mediator;
		}


		[HttpGet("{id}")]
		public async Task<IActionResult> GetCarFeatureByBlogId(int id)
		{
			return Ok(await _mediator.Send(new GetCarFeatureQuery(id)));
		}

		[HttpPost("CarFeatureStatusTrue")]
		public async Task<IActionResult> CarFeatureStatusTrue(CarFeatureChangeStatusTrueCommand carFeatures)
		{
			await _mediator.Send(new CarFeatureChangeStatusTrueCommand(carFeatures.FeatureID,carFeatures.CarID));
			return Ok("İşlem Başarılı");
		}

		[HttpPost("CarFeatureStatusFalse")]
		public async Task<IActionResult> CarFeatureStatusFalse(CarFeatureChangeStatusFalseCommand carFeatures)
		{
			await _mediator.Send(new CarFeatureChangeStatusFalseCommand(carFeatures.FeatureID, carFeatures.CarID));
			return Ok("İşlem Başarılı");
		}
	}
}
