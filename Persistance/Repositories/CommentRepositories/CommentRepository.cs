using Application.Features.Mediator.Results.CommentResult;
using Application.Interfaces.ICommentRepositories;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.CommentRepositories
{
	public class CommentRepository : ICommentRepository
	{
		private readonly CarBookContext _context;

		public CommentRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task<List<GetCommentByBlogIdQueryResult>> GetCommentByBlogId(int id)
		{
			var values=await _context.Comments.Where(x=>x.BlogID==id).ToListAsync();
			return values.Select(x => new GetCommentByBlogIdQueryResult{
				BlogID=x.BlogID,
				BlogComment=x.BlogComment,
				CommentID=x.CommentID,
				CoverImage=x.CoverImage,
				Email=x.Email,
				Name=x.Name,
				Title=x.Title,
				
			}).ToList();
		}
	}
}
