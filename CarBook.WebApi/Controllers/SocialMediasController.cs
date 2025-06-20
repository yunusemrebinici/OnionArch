using Application.Features.Mediator.Commands.SocialMediaCommands;
using Application.Features.Mediator.Quaries.SocialMediaQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SocialMediasController : ControllerBase
	{
		private readonly IMediator _mediator;

		public SocialMediasController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> SocialMediaList()
		{
			return Ok(await _mediator.Send(new GetSocialMediaQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetSocialMedia(int id)
		{
			return Ok(await _mediator.Send(new GetSocialMediaByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveSocialMedia(int id)
		{
			await _mediator.Send(new RemoveSocialMediaCommand(id));
			return Ok("Silme İşlemi Başarılı");
		}
	}
}
