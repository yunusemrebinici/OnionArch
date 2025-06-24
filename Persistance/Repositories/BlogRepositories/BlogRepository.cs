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

		public async Task<List<GetAllBlogsWithAuthorQueryResult>> GetAllBlogsWithAuthor()
		{
			var values = await _context.Blogs.Include(b => b.Author).ToListAsync();
			return values.Select(x => new GetAllBlogsWithAuthorQueryResult
			{
				BlogID = x.BlogID,
				AuthorName = x.Author.Name,
				CoverImage = x.CoverImage,
				Title = x.Title,
				Description = x.Description,
				Date = x.Date,
				ViewCount = x.ViewCount,


			}).ToList();
		}

		public async Task<GetAuthorByBlogIdQueryResult> GetAuthorByBlogId(int blogid)
		{
			var value = await _context.Blogs.Include(x => x.Author).FirstOrDefaultAsync(y => y.BlogID == blogid);
			return new GetAuthorByBlogIdQueryResult
			{
				CoverImage = value.Author.CoverImage,
				Name = value.Author.Name,
				Description = value.Author.Description,
			};


		}

		public async Task<List<GetLast3BlogsWithAuthorQueryResult>> GetLast3Blogs()
		{
			var values = await _context.Blogs.Include(x => x.Author).OrderByDescending(x => x.BlogID).Take(3).ToListAsync();
			return values.Select(y => new GetLast3BlogsWithAuthorQueryResult
			{
				BlogID = y.BlogID,
				AuthorName = y.Author.Name,
				CoverImage = y.CoverImage,
				Date = y.Date,
				Description = y.Description,
				Title = y.Title,
				ViewCount = y.ViewCount,

			}).ToList();
		}
	}
}
