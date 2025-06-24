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
	public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
	{
		private readonly IBlogRepository _blogRepository;

		public GetAllBlogsWithAuthorQueryHandler(IBlogRepository blogRepository)
		{
			_blogRepository = blogRepository;
		}

		public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
		{
			return await _blogRepository.GetAllBlogsWithAuthor();
		}
	}
}
