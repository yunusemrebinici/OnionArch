using Application.Features.Mediator.Results.ReservationResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.ReservationQuaries
{
	public class GetReservationQuery:IRequest<List<GetReservationQueryResult>>
	{
	}
}
