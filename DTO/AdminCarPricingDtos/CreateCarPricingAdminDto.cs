using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AdminCarPricingDtos
{
	public class CreateCarPricingAdminDto
	{
		public int carID { get; set; }

		public int pricingID { get; set; }

		public decimal amount { get; set; }
	}
}
