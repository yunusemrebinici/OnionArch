﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class RentAcar
	{
		public int RentAcarID { get; set; }

		public int LocationID { get; set; }

		public Location Location { get; set; }

		public int CarID { get; set; }

		public Car Car { get; set; }

		public bool Available { get; set; }

	}
}
