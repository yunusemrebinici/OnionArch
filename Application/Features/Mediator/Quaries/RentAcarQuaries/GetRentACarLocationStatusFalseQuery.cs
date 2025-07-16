using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.RentAcarQuaries
{
	public class GetRentACarLocationStatusFalseQuery:IRequest
	{
		public GetRentACarLocationStatusFalseQuery(int rentAcarID, int locationID, int carID)
		{
			RentAcarID = rentAcarID;
			LocationID = locationID;
			CarID = carID;
		}

		public int RentAcarID { get; set; }

		public int LocationID { get; set; }

		public int CarID { get; set; }
	}
}
