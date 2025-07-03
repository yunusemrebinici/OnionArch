using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class RentAcarProcess
	{
		public int RentAcarProcessID { get; set; }

		public int CarID { get; set; }

		public Car Car { get; set; }

		public int StartLocation { get; set; }

		public int EndLocation { get; set; }

		[Column(TypeName = "date")]
		public DateTime StartDate { get; set; }

		[Column(TypeName = "date")]
		public DateTime EndDate { get; set; }

		public decimal Amount { get; set; }

		public int CustomerID { get; set; }

		public Customer Customer { get; set; }

		public string PickUpDescription { get; set; }

		public string DropOffDescription { get; set; }

		public decimal TotalAmount { get; set; }
	}
}
