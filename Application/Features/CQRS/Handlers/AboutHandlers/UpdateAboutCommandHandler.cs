using Application.Features.CQRS.Commands.AboutCommands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.AboutHandlers
{
	public class UpdateAboutCommandHandler
	{
		private readonly IRepository<About> _repository;

		public UpdateAboutCommandHandler(IRepository<About> repository)
		{
			_repository = repository;
		}
		
		public async Task Handle(UpdateAboutCommand command)
		{
			await _repository.UpdateAsync(new About
			{
				AboutID = command.AboutID,
				Description = command.Description,
				ImageUrl = command.ImageUrl,
				Title = command.Title	
			});
		}
	}
}
