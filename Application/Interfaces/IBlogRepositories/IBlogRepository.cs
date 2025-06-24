using Application.Features.Mediator.Results.BlogResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IBlogRepositories
{
	public interface IBlogRepository
	{
		Task<List<GetLast3BlogsWithAuthorQueryResult>> GetLast3Blogs();

		Task<List<GetAllBlogsWithAuthorQueryResult>>GetAllBlogsWithAuthor();

		Task<GetAuthorByBlogIdQueryResult> GetAuthorByBlogId(int blogid);
	}
}
