using Application.Features.Mediator.Quaries.BlogQuaries;
using Application.Features.Mediator.Results.BlogResults;
using Application.Interfaces.IBlogRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.BlogHandlers
{
	public class GetLast3BlogsWithAuthorQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorQuery, List<GetLast3BlogsWithAuthorQueryResult>>
	{
		private readonly IBlogRepository _blogRepository;

		public GetLast3BlogsWithAuthorQueryHandler(IBlogRepository blogRepository)
		{
			_blogRepository = blogRepository;
		}

		public async Task<List<GetLast3BlogsWithAuthorQueryResult>> Handle(GetLast3BlogsWithAuthorQuery request, CancellationToken cancellationToken)
		{
			var values = await _blogRepository.GetLast3Blogs();
			return values.Select(x => new GetLast3BlogsWithAuthorQueryResult
			{
				AuthorName = x.AuthorName,
				BlogID = x.BlogID,
				CoverImage = x.CoverImage,
				Date = x.Date,
				Description = x.Description,
				Title = x.Title,
				ViewCount = x.ViewCount,

			}).ToList();
		}
	}
}
