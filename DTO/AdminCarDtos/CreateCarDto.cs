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

		public int Km { get; set; }

		public string Transmission { get; set; }

		public byte Seat { get; set; }

		public byte Luggage { get; set; }

		public string Fuel { get; set; }

		public string BigImageUrl { get; set; }
	}
}
