using Application.Features.Mediator.Quaries.CommentQuaries;
using Application.Features.Mediator.Results.CommentResult;
using Application.Interfaces.IBlogRepositories;
using Application.Interfaces.ICommentRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.CommentHandlers
{
	public class GetCommentByBlogIdQueryHandler : IRequestHandler<GetCommentByBlogIdQuery, List<GetCommentByBlogIdQueryResult>>
	{
		private readonly ICommentRepository _commentRepository;

		public GetCommentByBlogIdQueryHandler(ICommentRepository commentRepository)
		{
			_commentRepository = commentRepository;
		}

		public async Task<List<GetCommentByBlogIdQueryResult>> Handle(GetCommentByBlogIdQuery request, CancellationToken cancellationToken)
		{
			return await _commentRepository.GetCommentByBlogId(request.Id);
		}
	}
}
