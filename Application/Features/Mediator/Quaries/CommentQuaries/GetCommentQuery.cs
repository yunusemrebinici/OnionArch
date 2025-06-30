using Application.Features.Mediator.Results.CommentResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.CommentQuaries
{
	public class GetCommentQuery:IRequest<List<GetCommentQueryResult>>
	{
	}
}
