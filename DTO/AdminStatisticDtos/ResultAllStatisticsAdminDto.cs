using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AdminStatisticDtos
{
	public class ResultAllStatisticsAdminDto
	{
		public int AutoTransCarCount { get; set; }
		public int BlogCount { get; set; }
		public int BrandCount { get; set; }
		public int CarCount { get; set; }
		public int LocationCount { get; set; }
		public decimal MonthCarPricing { get; set; }
		public int MostBlogComment { get; set; }
		public string mostBrandedCarsBrand { get; set; }
		public int Authorcount { get; set; }
		public decimal TodayCarPricing { get; set; }
		public decimal WeekCarPricing { get; set; }
	}
}
