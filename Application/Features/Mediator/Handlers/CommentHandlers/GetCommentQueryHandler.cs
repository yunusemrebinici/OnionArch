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
	public class GetCommentQueryHandler : IRequestHandler<GetCommentQuery, List<GetCommentQueryResult>>
	{
		private readonly IRepository<Comment> _repository;

		public GetCommentQueryHandler(IRepository<Comment> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetCommentQueryResult>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GettAllAsync();
			return values.Select(x=>new GetCommentQueryResult
			{
				BlogComment = x.BlogComment,
				BlogID = x.BlogID,
				CommentID = x.CommentID,
				CoverImage = x.CoverImage,
				Email = x.Email,
				Title=x.Title,
			}).ToList();
		}
	}
}
