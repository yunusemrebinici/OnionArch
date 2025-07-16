using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Results.RentAcarResults
{
	public class GetRentAcarWithLocationNameResult
	{
		public int RentAcarID { get; set; }

		public int LocationID { get; set; }

		public string LocationName { get; set; }

		public int CarID { get; set; }

		public bool Available { get; set; }
	}
}
