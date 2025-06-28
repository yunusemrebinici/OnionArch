using Application.Features.Mediator.Commands.AuthorCommands;
using Application.Features.Mediator.Quaries.AuthorQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthorsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public AuthorsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> AuthorList()
		{
			return Ok(await _mediator.Send(new GetAuthorQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetAuthor(int id)
		{
			return Ok(await _mediator.Send(new GetAuthorByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateAuthor(CreateAuthorCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> RemoveAuthor(int id)
		{
			await _mediator.Send(new RemoveAuthorCommand(id));
			return Ok("Silme İşlemi Başarılı");
		}
	}
}
