using Application.Features.CQRS.Results.AboutResults;
using Application.Features.Mediator.Quaries.TagQuaries;
using Application.Features.Mediator.Results.TagResult;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.TagHandlers
{
	public class GetTagByBlogIdQueryHandler : IRequestHandler<GetTagByBlogIdQuery, List<GetTagByBlogIdQueryResult>>
	{
		private readonly ITagRepository _tagRepository;

		public GetTagByBlogIdQueryHandler(ITagRepository tagRepository)
		{
			_tagRepository = tagRepository;
		}

		public async Task<List<GetTagByBlogIdQueryResult>> Handle(GetTagByBlogIdQuery request, CancellationToken cancellationToken)
		{
			return await _tagRepository.GetTagByBlogId(request.Id);
		}

		
	}
}
