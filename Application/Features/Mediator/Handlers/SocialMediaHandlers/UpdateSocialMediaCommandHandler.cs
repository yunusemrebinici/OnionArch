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
	public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
	{
		private readonly IRepository<SocialMedia> _repository;

		public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
		{
			await _repository.UpdateAsync(new SocialMedia
			{
				Icon = request.Icon,
				Name = request.Name,
				SocialMediaID = request.SocialMediaID,
				Url = request.Url,

			});
		}
	}
}
