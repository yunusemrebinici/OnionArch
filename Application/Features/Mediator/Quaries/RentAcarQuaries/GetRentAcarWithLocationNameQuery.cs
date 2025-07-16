using Application.Features.Mediator.Results.RentAcarResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.RentAcarQuaries
{
	public class GetRentAcarWithLocationNameQuery:IRequest<List<GetRentAcarWithLocationNameResult>>
	{
		public int CarId { get; set; }

		public GetRentAcarWithLocationNameQuery(int Id)
		{
			CarId = Id;
		}
	}
}
