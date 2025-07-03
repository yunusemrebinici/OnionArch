﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.RentAcarDtos
{
	public class ResultRentAcarDto
	{
		public int CarID { get; set; }

		public int LocationId { get; set; }

		public string Name { get; set; }

		public string Model { get; set; }

		public string CoverImageUrl { get; set; }

		public decimal Amount { get; set; }
	}
}
