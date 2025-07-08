﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CarSingleDtos
{
	public class GetCarDetailByIdDto
	{
		public int carID { get; set; }
		public int brandID { get; set; }
		public string model { get; set; }
		public int km { get; set; }
		public string transmission { get; set; }
		public int seat { get; set; }
		public int luggage { get; set; }
		public string fuel { get; set; }
		public string bigImageUrl { get; set; }
	}
}
