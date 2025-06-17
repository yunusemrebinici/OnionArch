using Application.Features.CQRS.Results.CarResults;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CarHandlers
{
	public class GetCarQueryHandler
	{
		private readonly IRepository<Car>_repository;
		public GetCarQueryHandler(IRepository<Car> repository)
		{
			_repository = repository;

		}

		public async Task<List<GetCarQueryResult>> Handle() 
		{ 
		
		     var value= await _repository.GettAllAsync();

			return value.Select(x => new GetCarQueryResult
			{
				BigImageUrl = x.BigImageUrl,
				BrandID = x.BrandID,
				CarID = x.CarID,
				CoverImageUrl = x.CoverImageUrl,
				Fuel = x.Fuel,
				Km = x.Km,
				Luggage = x.Luggage,
				Model = x.Model,
				Seat = x.Seat,
				Transmission = x.Transmission,

			}).ToList();
			
		
		}
	}
}
