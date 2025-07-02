using Application.Features.Mediator.Results.StatisticResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.StatisticQuaries
{
	public class GetCarUnder1000kmCountQuery:IRequest<GetCarUnder1000kmCountQueryResult>
	{
	}
}
