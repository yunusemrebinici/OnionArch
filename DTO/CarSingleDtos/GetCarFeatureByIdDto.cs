using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CarSingleDtos
{
	public class GetCarFeatureByIdDto
	{


		public int featureID { get; set; }
		public int carID { get; set; }
		public string featureName { get; set; }
		public bool available { get; set; }


	}
}
