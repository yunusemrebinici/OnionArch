using Application.Features.Mediator.Quaries.TagQuaries;
using Application.Features.Mediator.Results.TagResult;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.TagHandlers
{
	public class GetTagQueryHandler : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
	{
		private readonly IRepository<Tag>_repository;

		public GetTagQueryHandler(IRepository<Tag> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GettAllAsync();
			return values.Select(x=> new GetTagQueryResult
			{
				Name = x.Name,
				TagID=x.TagID,
			}).ToList();
		}
	}
}
