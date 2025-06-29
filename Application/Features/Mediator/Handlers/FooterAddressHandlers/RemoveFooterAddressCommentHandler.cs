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
	public class RemoveFooterAddressCommentHandler : IRequestHandler<RemoveFooterAdressCommand>
	{
		private readonly IRepository<FooterAddress> _repository;

		public RemoveFooterAddressCommentHandler(IRepository<FooterAddress> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveFooterAdressCommand request, CancellationToken cancellationToken)
		{
			var value= await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(value);
		}
	}
}
