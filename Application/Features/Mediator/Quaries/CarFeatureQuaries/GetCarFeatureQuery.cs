using Application.Features.Mediator.Results.CarFeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.CarFeatureQuaries
{
	public class GetCarFeatureQuery:IRequest<List<GetCarFeatureQueryResult>>
	{
	
		public int CarID { get; set; }

		public GetCarFeatureQuery(int carID)
		{
			CarID = carID;
		}
	}
}
