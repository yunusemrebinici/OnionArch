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
	public class RemoveContactCommandHandler
	{
		private readonly IRepository<Contact> _contactRepository;

		public RemoveContactCommandHandler(IRepository<Contact> contactRepository)
		{
			_contactRepository = contactRepository;
		}

		public async Task Handle(RemoveContactCommand command)
		{
			var values = await _contactRepository.GetByIdAsync(command.Id);
			await _contactRepository.RemoveAsync(values);
		}
	}
}
