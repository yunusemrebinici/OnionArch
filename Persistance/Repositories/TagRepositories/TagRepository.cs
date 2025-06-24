using Application.Features.Mediator.Results.TagResult;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.TagRepositories
{
	public class TagRepository : ITagRepository
	{
		private readonly CarBookContext _context;

		public TagRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task<List<GetTagByBlogIdQueryResult>> GetTagByBlogId(int id)
		{
			var values = await _context.BlogTags.Include(x=>x.Tag).Where(x=>x.BlogID==id).ToListAsync();
			return values.Select(x=> new GetTagByBlogIdQueryResult
			{
				Name=x.Tag.Name,
			}).ToList();
		}
	}
}
