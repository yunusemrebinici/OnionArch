﻿using Application.Features.CQRS.Results.AboutResults;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.AboutHandlers
{
	public class GetAboutQueryHandler
	{
		private readonly IRepository<About>_repository;

		public GetAboutQueryHandler(IRepository<About> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetAboutByIdQueryResult>> Handle()
		{
			var values = await _repository.GettAllAsync();
			


			return values.Select(x=>new GetAboutByIdQueryResult
			{
				AboutID = x.AboutID,
				Description = x.Description,
				ImageUrl = x.ImageUrl, 
				Title = x.Title,
			}).ToList();
		}
	}
}
