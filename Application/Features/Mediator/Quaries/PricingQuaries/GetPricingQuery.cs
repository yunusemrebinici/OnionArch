using Application.Features.Mediator.Results.PricingResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.PricingQuaries
{
	public class GetPricingQuery:IRequest<List<GetPricingQueryResult>>
	{
	}
}
