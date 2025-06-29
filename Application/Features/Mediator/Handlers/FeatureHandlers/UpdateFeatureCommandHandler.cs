﻿using Application.Features.Mediator.Commands.FeatureCommands;
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
	public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
	{
		private readonly IRepository<Feature > _repository;

		public UpdateFeatureCommandHandler(IRepository<Feature> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
		{
			await _repository.UpdateAsync(new Feature
			{
				FeatureID = request.FeatureID,
				Name = request.Name,
			});
		}
	}
}
