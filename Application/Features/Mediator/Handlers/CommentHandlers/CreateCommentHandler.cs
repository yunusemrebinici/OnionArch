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
	public class CreateCommentHandler : IRequestHandler<CreateCommentCommant>
	{
		private readonly IRepository<Comment> _repository;

		public CreateCommentHandler(IRepository<Comment> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateCommentCommant request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Comment
			{

				BlogComment = request.BlogComment,
				Name = request.Name,
				BlogID = request.BlogID,
				CoverImage = request.CoverImage,
				Email = request.Email,
				Title = request.Title,


			});
		}
	}
}
