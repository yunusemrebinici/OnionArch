using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AdminCarDtos
{
	public class CreateCarDto
	{
		public int brandID { get; set; }

		public string model { get; set; }

		public string coverImageUrl { get; set; }

		public decimal carPricing { get; set; }
	}
}
