using Application.Features.Mediator.Quaries.AuthorQuaries;
using Application.Features.Mediator.Results.AuthorResults;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.AuthorHandlers
{
	public class GetAuthorQueryHandler:IRequestHandler<GetAuthorQuery,List<GetAuthorQueryResult>>
	{
		private readonly IRepository<Author> _repository;

		public GetAuthorQueryHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GettAllAsync();
			return values.Select(x=> new GetAuthorQueryResult
			{
				AuthorID = x.AuthorID,
				CoverImage = x.CoverImage,
				Description = x.Description,
				Name=x.Name,
			}).ToList();
		}
	}
}
