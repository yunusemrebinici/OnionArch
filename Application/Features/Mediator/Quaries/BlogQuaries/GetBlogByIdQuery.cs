using Application.Features.CQRS.Results.AboutResults;
using Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.BlogQuaries
{
	public class GetBlogByIdQuery:IRequest<GetBlogByIdQueryResult>
	{
		public int Id { get; set; }

		public GetBlogByIdQuery(int id)
		{
			Id = id;
		}
	}
}
