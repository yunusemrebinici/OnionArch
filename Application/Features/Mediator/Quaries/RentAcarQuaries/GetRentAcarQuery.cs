using Application.Features.Mediator.Results.GetRentAcarQueryResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.GetRentAcarQuery
{
	public class GetRentAcarQuery:IRequest<List<GetRentAcarQueryResult>>
	{
		public int LocationId { get; set; }

		public bool Available { get; set; }

		
	}
}
