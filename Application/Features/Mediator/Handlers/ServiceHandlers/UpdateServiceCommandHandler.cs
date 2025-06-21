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
	public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
	{

		private readonly IRepository<Domain.Entities.Services> _repository;

		public UpdateServiceCommandHandler(IRepository<Domain.Entities.Services> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
		{
			await _repository.UpdateAsync(new Domain.Entities.Services
			{
				Description = request.Description,
				IconUrl = request.IconUrl,
				ServicesID = request.ServicesID,
				Title = request.Title,

			});
		}
	}
}
