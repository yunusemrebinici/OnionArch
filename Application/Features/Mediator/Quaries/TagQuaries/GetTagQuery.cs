using Application.Features.Mediator.Results.TagResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.TagQuaries
{
	public class GetTagQuery:IRequest<List<GetTagQueryResult>>
	{
	}
}
