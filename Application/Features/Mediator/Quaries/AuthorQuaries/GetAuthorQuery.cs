using Application.Features.Mediator.Results.AuthorResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.AuthorQuaries
{
	public class GetAuthorQuery:IRequest<List<GetAuthorQueryResult>>
	{
	}
}
