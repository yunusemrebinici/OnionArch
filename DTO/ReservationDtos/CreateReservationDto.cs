﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ReservationDtos
{
	public class CreateReservationDto
	{
		public string Name { get; set; }

		public string Surname { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }

		public int CarID { get; set; }

		public int? StartLocationID { get; set; }

		public int? EndLocationID { get; set; }

		public int Age { get; set; }

		public int DriverLicenceYear { get; set; }

		public string? Description { get; set; }

	}

}
