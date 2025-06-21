using Application.Features.Mediator.Commands.ServiceCommands;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.ServiceHandlers
{
	public class RemoveServiceCommandHandler : IRequestHandler<RemoveServiceCommand>
	{
		private readonly IRepository<Domain.Entities.Services> _repository;

		public RemoveServiceCommandHandler(IRepository<Domain.Entities.Services> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveServiceCommand request, CancellationToken cancellationToken)
		{
			var remove= await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(remove);
		}


	}
}
