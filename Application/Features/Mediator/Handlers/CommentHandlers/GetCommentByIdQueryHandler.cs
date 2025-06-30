using Application.Features.CQRS.Queries.ContactQuaries;
using Application.Features.Mediator.Quaries.CommentQuaries;
using Application.Features.Mediator.Results.CommentResult;
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
	public class GetCommentByIdQueryHandler : IRequestHandler<GetCommentByIdQuery, GetCommentByIdQueryResult>
	{
		private readonly IRepository<Comment> _repository;

		public GetCommentByIdQueryHandler(IRepository<Comment> repository)
		{
			_repository = repository;
		}

		async Task<GetCommentByIdQueryResult> IRequestHandler<GetCommentByIdQuery, GetCommentByIdQueryResult>.Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
		{
			var value= await _repository.GetByIdAsync(request.Id);
			return new GetCommentByIdQueryResult
			{
				BlogComment = value.BlogComment,
				BlogID = value.BlogID,
				CommentID = value.CommentID,
				CoverImage = value.CoverImage,
				Email = value.Email,
				Title = value.Title,

			};
		}
	}
}

