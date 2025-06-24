using Application.Features.Mediator.Results.TagResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
	public interface ITagRepository
	{
		Task<List<GetTagByBlogIdQueryResult>> GetTagByBlogId(int id);
	}
}
