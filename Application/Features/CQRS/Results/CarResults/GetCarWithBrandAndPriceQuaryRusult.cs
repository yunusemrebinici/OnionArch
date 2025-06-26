using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Results.CarResults
{
	public class GetCarWithBrandAndPriceQuaryRusult
	{
		public int CarID { get; set; }

		public int BrandID { get; set; }

		public string Name { get; set; }

		public string Model { get; set; }

		public string CoverImageUrl { get; set; }

		public decimal CarPricing { get; set; }

	}
}
