using Application.Features.CQRS.Queries.BrandQuaries;
using Application.Features.CQRS.Results.BrandResults;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.BrandHandlers
{
	public class GetBrandByIdQueryHandler
	{
		private readonly IRepository<Brand> _repository;
		public GetBrandByIdQueryHandler(IRepository<Brand>repository)
		{
			_repository = repository;

		}

		public async Task<GetBrandByIdQueryResult>Handle(GetBrandByIdQuary quary)
		{
			var value= await _repository.GetByIdAsync(quary.Id);
			return new GetBrandByIdQueryResult
			{
				BrandID = value.BrandID,
				Cars = value.Cars,
				Name = value.Name,
			};
		}
	}
}
