using Application.Features.Mediator.Quaries.BlogQuaries;
using Application.Features.Mediator.Results.BlogResults;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.BlogHandlers
{
	public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogQueryResult>>
	{
		private readonly IRepository<Blog> _repository;

		public GetBlogQueryHandler(IRepository<Blog> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GettAllAsync();
			return values.Select(x => new GetBlogQueryResult
			{
				BlogID = x.BlogID,
				AuthorID = x.AuthorID,
				CategoryID = x.CategoryID,
				CoverImage = x.CoverImage,
				Date = x.Date,
				Description = x.Description,
				Title = x.Title,
				ViewCount = x.ViewCount,

			}).ToList();
		}
	}
}
