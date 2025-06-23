using Application.Features.Mediator.Results.BlogResults;
using Application.Interfaces.IBlogRepositories;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.BlogRepositories
{
	public class BlogRepository : IBlogRepository
	{
		private readonly CarBookContext _context;

		public BlogRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task<List<GetLast3BlogsWithAuthorQueryResult>> GetLast3Blogs()
		{
			var values = await _context.Blogs.Include(x=>x.Author).OrderByDescending(x=>x.BlogID).Take(3).ToListAsync();
			return values.Select(y=>new GetLast3BlogsWithAuthorQueryResult
			{
				BlogID = y.BlogID,
				AuthorName=y.Author.Name,
				CoverImage = y.CoverImage,
				Date = y.Date,
				Description = y.Description,
				Title = y.Title,
				ViewCount=y.ViewCount,
				
			}).ToList();
		}
	}
}
