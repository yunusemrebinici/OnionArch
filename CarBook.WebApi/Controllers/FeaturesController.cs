using Application.Features.Mediator.Commands.FeatureCommands;
using Application.Features.Mediator.Quaries.FeatureQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FeaturesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public FeaturesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> FeatureList()
		{
			return Ok(await _mediator.Send(new GetFeatureQuery()));
		}


		[HttpGet("{id}")]
		public async Task<IActionResult>GetFeature(int id)
		{
			return Ok(await _mediator.Send(new GetFeatureByIdQuery(id))); 
		}

		[HttpPost]
		public async Task<IActionResult> CreateFeature(CreateFetureCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult>UpdateFeature(UpdateFeatureCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveFeature(RemoveFeatureCommand command)
		{
			await _mediator.Send(command);
			return Ok("Silme İşlemi Başarılı");
		}


	}
}
