﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Results.CarPricingResults
{
	public class GetCarPricingByIdQueryResult
	{
		public int CarPricingID { get; set; }

		public int CarID { get; set; }

		public int PricingID { get; set; }

		public decimal Amount { get; set; }
	}
}
