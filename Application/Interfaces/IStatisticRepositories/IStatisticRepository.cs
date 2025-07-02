using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IStatisticRepositories
{
	public interface IStatisticRepository
	{
		Task<int> GetCarCount();
		Task<int> GetLocationCount();
		Task<int> GetAuthorCount();
		Task<int> GetBlogCount();
		Task<int> GetBrandCount();
		Task<decimal> GetTodayCarPricingAvg();
		Task<decimal> GetWeekCarPricingAvg();
		Task<decimal> GetMonthCarPricingAvg();
		Task<int> GetAutomaticTransMissionCarCount();
		Task<string> GetMostBrandedCarsBrand();
		Task<int> GetMostBlogCommentCount();

		Task<int>GetTestimonailCount();
		Task<int> GetCarUnder1000kmCount();
		Task<int> GetElectricCarCount();
		Task<string> GetMaxTodayPriceCarBrandModel();
		Task<string> GetMinTodayPriceCarBrandModel();

	}
}
