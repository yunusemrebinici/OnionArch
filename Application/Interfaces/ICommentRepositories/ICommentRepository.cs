using Application.Features.Mediator.Results.CommentResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICommentRepositories
{
	public interface ICommentRepository
	{
		Task<List<GetCommentByBlogIdQueryResult>> GetCommentByBlogId(int id);
	}
}
