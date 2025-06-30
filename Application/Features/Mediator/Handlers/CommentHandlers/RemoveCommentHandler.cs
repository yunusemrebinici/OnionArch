using Application.Features.Mediator.Commands.CommentCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.CommentHandlers
{
	public class RemoveCommentHandler : IRequestHandler<RemoveCommentCommant>
	{
		private readonly IRepository<Comment> _repository;

		public RemoveCommentHandler(IRepository<Comment> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveCommentCommant request, CancellationToken cancellationToken)
		{
			var remove =await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(remove);
		}
	}
}
