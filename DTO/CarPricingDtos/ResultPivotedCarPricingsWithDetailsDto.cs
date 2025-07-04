using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CarPricingDtos
{
	public class ResultPivotedCarPricingsWithDetailsDto
	{

		public int carID { get; set; }
		public string coverImage { get; set; }
		public string brand { get; set; }
		public string model { get; set; }
		public decimal dayAmount { get; set; }
		public decimal weekAmount { get; set; }
		public decimal monthAmount { get; set; }

	}
}
