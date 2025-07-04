using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Location
	{
		public int LocationID { get; set; }

		public string Name { get; set; }

		public List<RentAcar> RentAcars { get; set; }

		public List<Reservation> StartLocationList { get; set; }

		public List<Reservation> EndLocationList { get; set; }

	}
}
