using Application.Features.CQRS.Commands.CategoryCommands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CategoryHandlers
{
	public class UpdateCategoryCommandHandler
	{
		private readonly IRepository<Category>_repository;

		public UpdateCategoryCommandHandler(IRepository<Category> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateCategoryCommend commend)
		{
			await _repository.UpdateAsync(new Category
			{
				CategoryID = commend.CategoryID,
				Name = commend.Name,
			});
		}
	}
}
