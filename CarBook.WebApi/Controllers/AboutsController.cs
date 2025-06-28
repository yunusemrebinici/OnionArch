using Application.Features.CQRS.Commands.AboutCommands;
using Application.Features.CQRS.Commands.AboutComment;
using Application.Features.CQRS.Handlers.AboutHandlers;
using Application.Features.CQRS.Queries.AboutQuaries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AboutsController : ControllerBase
	{
		private readonly CreateAboutCommandHandler _createCommandHandler;
		private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
		private readonly GetAboutQueryHandler _getAboutQueryHandler;
		private readonly RemoveAboutCommandHandler _removeAboutCommandHandler;
		private readonly UpdateAboutCommandHandler _updateAboutCommandHandler;

		public AboutsController(
			CreateAboutCommandHandler createCommandHandler,
			GetAboutByIdQueryHandler getAboutByIdQueryHandler,
			GetAboutQueryHandler getAboutQueryHandler,
			RemoveAboutCommandHandler removeAboutCommandHandler,
			UpdateAboutCommandHandler updateAboutCommandHandler)
		{
			_createCommandHandler = createCommandHandler;
			_getAboutByIdQueryHandler = getAboutByIdQueryHandler;
			_getAboutQueryHandler = getAboutQueryHandler;
			_removeAboutCommandHandler = removeAboutCommandHandler;
			_updateAboutCommandHandler = updateAboutCommandHandler;
		}


		[HttpGet]
		public async Task<IActionResult> AboutList()
		{
			return Ok(await _getAboutQueryHandler.Handle());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult>GetAbout(int id)
		{
			return Ok(await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult>CreateAbout(CreateAboutCommand command)
		{
			await _createCommandHandler.Handle(command);
			return Ok("Hakkımda Bilgisi Eklendi");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult>RemoveAbout(int id)
		{
			await _removeAboutCommandHandler.Handle(new RemoveAboutCommand (id));
			return Ok("Silme İşlemi Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
		{
			await _updateAboutCommandHandler.Handle(command);
			return Ok("Güncelleme Başarılı");
		}

	}
}
