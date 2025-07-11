﻿using Application.Features.Mediator.Commands.FooterAddressCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.FooterAddressHandlers
{
	public class CreateFooterAddressCommantHandler : IRequestHandler<CreateFooterAdressCommand>
	{
		private readonly IRepository<FooterAddress> _repository;

		public CreateFooterAddressCommantHandler(IRepository<FooterAddress> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateFooterAdressCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new FooterAddress
			{
				Address = request.Address,
				Description = request.Description,
				Email = request.Email,
				Phone = request.Phone,
			});
		}
	}
}
