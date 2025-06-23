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
	public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
	{
		private readonly IRepository<Blog>_repository;

		public GetBlogByIdQueryHandler(IRepository<Blog> repository)
		{
			_repository = repository;
		}

		public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
		{
			var value= await _repository.GetByIdAsync(request.Id);
			return new GetBlogByIdQueryResult
			{
				BlogID = value.BlogID,
				CoverImage = value.CoverImage,
				Date = value.Date,
				Description = value.Description,
				Title = value.Title,
				ViewCount = value.ViewCount,
				AuthorID = value.AuthorID,
				CategoryID = value.CategoryID,
			};
		}
	}
}
