using Application.Features.CQRS.Commands.ContactCommands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.ContactHandlers
{
	public class UpdateContactCommandHandler
	{
		private readonly IRepository<Contact> _contactRepository;

		public UpdateContactCommandHandler(IRepository<Contact> contactRepository)
		{
			_contactRepository = contactRepository;
		}

		public async Task Handle(UpdateContactCommand command)
		{
			await _contactRepository.UpdateAsync(new Contact
			{
				ContactID = command.ContactID,
				Email = command.Email,
				Message = command.Message,
				Name = command.Name,
				SendDate = command.SendDate,
				Subject = command.Subject,

			});
		}
	}
}
