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
	public class UpdateCommentHandler : IRequestHandler<UpdateCommentCommant>
	{
		private readonly IRepository<Comment> _repository;

		public UpdateCommentHandler(IRepository<Comment> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateCommentCommant request, CancellationToken cancellationToken)
		{
			await _repository.UpdateAsync(new Comment
			{
				BlogComment = request.BlogComment,
				CoverImage = request.CoverImage,
				Name = request.Name,
				Email = request.Email,
				Title = request.Title,
				BlogID = request.BlogID,

			});
		}
	}
}
