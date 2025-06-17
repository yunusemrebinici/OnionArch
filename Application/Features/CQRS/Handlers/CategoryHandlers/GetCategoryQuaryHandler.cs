﻿using Application.Features.CQRS.Results.CategoryResults;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CategoryHandlers
{
	public class GetCategoryQuaryHandler
	{
		private readonly IRepository<Category> _repository;

		public GetCategoryQuaryHandler(IRepository<Category> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetCategoryQueryResult>> Handle()
		{
			var values = await _repository.GettAllAsync();
			return values.Select(x => new GetCategoryQueryResult
			{

				Name = x.Name,
				CategoryID=x.CategoryID,	
			}).ToList();
		}
	}
}
