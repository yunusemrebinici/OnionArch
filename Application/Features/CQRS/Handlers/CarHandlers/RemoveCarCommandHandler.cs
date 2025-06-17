using Application.Features.CQRS.Commands.CarCommands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.CarHandlers
{
	public class RemoveCarCommandHandler
	{
		private readonly IRepository<Car> _repositoriy;

		public RemoveCarCommandHandler(IRepository<Car> repository)
		{
			_repositoriy = repository;
		}

		public async Task Handle(RemoveCarCommand command)
		{
			var value = await _repositoriy.GetByIdAsync(command.Id);
			await _repositoriy.RemoveAsync(value);
			return;
		}
	}
}
