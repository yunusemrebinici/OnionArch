using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AdminCarFeatureDtos
{
	public class ResultCarFeatureDto
	{
		public int featureID { get; set; }
		public int carID { get; set; }
		public string featureName { get; set; }
		public bool available { get; set; }
	}
}
