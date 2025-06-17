using Application.Features.CQRS.Queries.BannerQuaries;
using Application.Features.CQRS.Queries.CarQuaries;
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
	public class GetCarByIdQueryHandler
	{
		private readonly IRepository<Car> _repository;
		public GetCarByIdQueryHandler(IRepository<Car> repository)
		{
			_repository = repository;
		}

		public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuary quary)
		{
			var value = await _repository.GetByIdAsync(quary.Id);
			return new GetCarByIdQueryResult
			{
				BigImageUrl = value.BigImageUrl,
				BrandID = value.BrandID,
				CarID = value.CarID,
				CoverImageUrl = value.CoverImageUrl,
				Fuel = value.Fuel,
				Km = value.Km,
				Luggage = value.Luggage,
				Model = value.Model,
				Seat = value.Seat,
				Transmission = value.Transmission,

			};
		}
	}
}
