using Application.Features.CQRS.Commands.ContactCommands;
using Application.Features.CQRS.Handlers.ContactHandlers;
using Application.Features.CQRS.Handlers.ContactHandlers;
using Application.Features.CQRS.Queries.ContactQuaries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactsController : ControllerBase
	{
		private readonly CreateContactCommandHandler _createCommandHandler;
		private readonly GetContactByIdQueryHandler _getContactByIdQueryHandler;
		private readonly GetContactQueryHandler _getContactQueryHandler;
		private readonly RemoveContactCommandHandler _removeContactCommandHandler;
		private readonly UpdateContactCommandHandler _updateContactCommandHandler;

		public ContactsController(
			CreateContactCommandHandler createCommandHandler,
			GetContactByIdQueryHandler getContactByIdQueryHandler,
			GetContactQueryHandler getContactQueryHandler,
			RemoveContactCommandHandler removeContactCommandHandler,
			UpdateContactCommandHandler updateContactCommandHandler)
		{
			_createCommandHandler = createCommandHandler;
			_getContactByIdQueryHandler = getContactByIdQueryHandler;
			_getContactQueryHandler = getContactQueryHandler;
			_removeContactCommandHandler = removeContactCommandHandler;
			_updateContactCommandHandler = updateContactCommandHandler;
		}


		[HttpGet]
		public async Task<IActionResult> ContactList()
		{
			return Ok(await _getContactQueryHandler.Handle());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetContact(int id)
		{
			return Ok(await _getContactByIdQueryHandler.Handle(new GetContactByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateContact(CreateContactCommand command)
		{
			await _createCommandHandler.Handle(command);
			return Ok("Contact Bilgisi Eklendi");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveContact(int id)
		{
			await _removeContactCommandHandler.Handle(new RemoveContactCommand(id));
			return Ok("Silme İşlemi Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
		{
			await _updateContactCommandHandler.Handle(command);
			return Ok("Güncelleme Başarılı");
		}

	}
}
