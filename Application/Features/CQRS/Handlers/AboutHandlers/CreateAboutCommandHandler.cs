﻿using Application.Features.CQRS.Commands.AboutComment;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.AboutHandlers
{
	public class CreateAboutCommandHandler
	{
		private readonly IRepository<About>_aboutRepository;

		public CreateAboutCommandHandler(IRepository<About> repository)
		{
			_aboutRepository = repository;
		}

		public async Task Handle(CreateAboutCommand command)
		{
			 
			await _aboutRepository.CreateAsync(new About
			{
				Title = command.Title,
				Description = command.Description,
				ImageUrl = command.ImageUrl,
				
			});

		}
	}
}
