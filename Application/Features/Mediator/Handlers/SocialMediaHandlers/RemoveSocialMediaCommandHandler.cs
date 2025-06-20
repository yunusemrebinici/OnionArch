using Application.Features.Mediator.Commands.SocialMediaCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.SocialMediaHandlers
{
	public class RemoveSocialMediaCommandHandler : IRequestHandler<RemoveaSocialMediaCommand>
	{
		private readonly IRepository<SocialMedia> _repository;

		public RemoveSocialMediaCommandHandler(IRepository<SocialMedia> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveaSocialMediaCommand request, CancellationToken cancellationToken)
		{
			var remove= await _repository.GetByIdAsync(request.Id);	
			await _repository.RemoveAsync(remove);
		}
	}
}
