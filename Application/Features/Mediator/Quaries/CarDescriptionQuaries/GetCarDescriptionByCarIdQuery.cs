using Application.Features.Mediator.Results.CarDescriptionResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.CarDescriptionQuaries
{
	public class GetCarDescriptionByCarIdQuery:IRequest<GetCarDescriptionByIdQueryResult>
	{
		public int CarID { get; set; }

		public GetCarDescriptionByCarIdQuery(int carID)
		{
			CarID = carID;
		}
	}
}
