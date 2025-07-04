using Application.Features.Mediator.Results.CarPricingResults;
using Application.Interfaces.ICarPricingRepositories;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.CarPricingRepositories
{
	public class CarPricingRepository : ICarPricingRepository
	{
		private readonly CarBookContext _context;

		public CarPricingRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task<List<GetCarPricingWithCarAndPriceQueryResult>> GetAll()
		{
			var carPricingsWithCars = await _context.CarPricings
	   .Include(cp => cp.Car).Include(y=>y.Car.Brand) // Car nesnesini de yükle
	   .ToListAsync(); // Veriyi belleğe çek

			// C# tarafında pivotlama ve Car bilgilerini çıktıya dahil etme
			var pivotedCarDetails = carPricingsWithCars
				.GroupBy(cp => cp.CarID) // Her bir CarID'ye göre grupla
				.Select(g => new GetCarPricingWithCarAndPriceQueryResult // Yeni DTO'muzu oluştur
				{
					CarID = g.Key,
					// Grubu oluşturan ilk elemandan Car bilgilerini alıyoruz.
					// Bu, aynı CarID'ye sahip tüm fiyatlandırmaların aynı Car nesnesine işaret ettiğini varsayar.
					Brand = g.First().Car.Brand.Name, // Eğer Brand bilgisi Car tablosunda ise
					Model = g.First().Car.Model,
					CoverImage = g.First().Car.CoverImageUrl, // DTO'daki adıyla eşleştir

					// PricingID'lere göre fiyatları çek ve DTO'daki property'lere ata
					// PricingID'lerin 2, 3, 4 olduğunu varsayıyoruz (Günlük, Haftalık, Aylık)
					DayAmount = g.FirstOrDefault(cp => cp.PricingID == 2)?.Amount ?? 0,
					WeekAmount = g.FirstOrDefault(cp => cp.PricingID == 3)?.Amount ?? 0,
					MonthAmount = g.FirstOrDefault(cp => cp.PricingID == 4)?.Amount ?? 0

					// Eğer PricingID değerleri dinamikse veya farklıysa, bu kısımları ona göre ayarlaman gerekir.
				})
				.ToList(); // Sonuçları bir List<CarPricingDetailsDto> olarak al

			return pivotedCarDetails.Select(x=>new GetCarPricingWithCarAndPriceQueryResult
			{
			   CarID = x.CarID,
			   WeekAmount= x.WeekAmount,
			   MonthAmount= x.MonthAmount,
			   Model = x.Model,
			   DayAmount= x.DayAmount,
			   CoverImage=x.CoverImage,
			   Brand= x.Brand,
			   
			}).ToList();
		}
	}
}
