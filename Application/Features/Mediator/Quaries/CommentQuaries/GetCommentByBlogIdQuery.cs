using Application.Features.Mediator.Results.CommentResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.CommentQuaries
{
	public class GetCommentByBlogIdQuery:IRequest<List<GetCommentByBlogIdQueryResult>>
	{
		public int Id { get; set; }

		public GetCommentByBlogIdQuery(int id)
		{
			Id = id;
		}
	}
}
