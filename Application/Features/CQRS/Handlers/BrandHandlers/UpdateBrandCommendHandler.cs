using Application.Features.CQRS.Commands.BrandCommands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.BrandHandlers
{
	public class UpdateBrandCommendHandler
	{
		private readonly IRepository<Brand> _repository;

		public UpdateBrandCommendHandler(IRepository<Brand> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateBrandCommand command)
		{
			await _repository.UpdateAsync(new Brand { 
			
				BrandID = command.BrandID,
				Name=command.Name,	
			});
		}
	}
}
