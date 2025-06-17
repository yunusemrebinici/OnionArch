﻿using Application.Features.CQRS.Commands.ContactCommands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.ContactHandlers
{
	public class CreateContactCommandHandler
	{
		private readonly IRepository<Contact> _contactRepository;

		public CreateContactCommandHandler(IRepository<Contact> contactRepository)
		{
			_contactRepository = contactRepository;
		}
		
		public async Task Handle(CreateContactCommand command)
		{
			await _contactRepository.CreateAsync(new Contact
			{
				Email = command.Email,
				Message = command.Message,
				Name = command.Name,
				SendDate = command.SendDate,
				Subject = command.Subject,
			});
		}
	}
}
