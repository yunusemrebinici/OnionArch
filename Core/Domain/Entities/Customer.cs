﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Customer
	{
		public int CustomerID { get; set; }

		public string Name  { get; set; }

		public string Surname  { get; set; }

		public string Email  { get; set; }

		public List<RentAcarProcess> RentAcarProcesses { get; set; }

	}
}
