using Application.Features.CQRS.Commands.CategoryCommands;
using Application.Features.CQRS.Queries.CategoryQuaries;
using Application.Features.CQRS.Results.CategoryResults;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CategoryHandlers
{
	public class GetCategoryByIdQuaryHandler
	{
		private readonly IRepository<Category>_repository;

		public GetCategoryByIdQuaryHandler(IRepository<Category> repository)
		{
			_repository = repository;
		}

		public async Task <GetCategoryByIdQueryResult>Handle(GetCategoryByIdQuary quary)
		{
			var values= await _repository.GetByIdAsync(quary.Id);
			return new GetCategoryByIdQueryResult
			{
				CategoryID = values.CategoryID,
				Name = values.Name,

			};

		}
	}
}
