using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Results.CarPricingResults
{
	public class GetCarPricingWithCarAndPriceQueryResult
	{
		
		public int CarID { get; set; }

		public string CoverImage { get; set; }

		public string Brand { get; set; }

		public string Model { get; set; }

		public decimal DayAmount { get; set; }

		public decimal WeekAmount { get; set; }

		public decimal MonthAmount { get; set; }


	}
}
