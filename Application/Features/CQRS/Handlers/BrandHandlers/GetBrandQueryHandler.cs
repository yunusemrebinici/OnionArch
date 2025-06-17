﻿using Application.Features.CQRS.Results.BrandResults;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.BrandHandlers
{
	public class GetBrandQueryHandler
	{
		private readonly IRepository<Brand>_repository;
		public GetBrandQueryHandler(IRepository<Brand> repository)
		{
			_repository = repository;

		}

		public async Task<List<GetBrandQueryResult>> Handle()
		{
			var values= await _repository.GettAllAsync();
			return values.Select(x => new GetBrandQueryResult
			{
				BrandID = x.BrandID,
				Cars = x.Cars,
				Name = x.Name,
			}).ToList();
		}
	}
}
