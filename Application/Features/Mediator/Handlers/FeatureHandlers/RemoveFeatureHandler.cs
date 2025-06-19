using Application.Features.Mediator.Commands.FeatureCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.FeatureHandlers
{
	public class RemoveFeatureHandler : IRequestHandler<RemoveFeatureCommand>
	{
		private readonly IRepository<Feature> _repository;

		public RemoveFeatureHandler(IRepository<Feature> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
		{
			var remove= await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(remove);
		}
	}
}
