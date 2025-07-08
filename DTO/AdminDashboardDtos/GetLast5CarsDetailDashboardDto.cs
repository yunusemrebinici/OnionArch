using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AdminDashboardDtos
{
	public class GetLast5CarsDetailDashboardDto
	{

    	
		public string brand { get; set; }
		public string model { get; set; }
		public decimal dayAmount { get; set; }
		public decimal weekAmount { get; set; }
		public decimal monthAmount { get; set; }
	}
}
