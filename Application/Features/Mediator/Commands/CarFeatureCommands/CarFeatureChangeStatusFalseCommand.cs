using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.CarFeatureCommands
{
	public class CarFeatureChangeStatusFalseCommand:IRequest
	{
		public CarFeatureChangeStatusFalseCommand(int featureID, int carID)
		{
			FeatureID = featureID;
			CarID = carID;
		}

		public int FeatureID { get; set; }

		public int CarID { get; set; }
	}
}
