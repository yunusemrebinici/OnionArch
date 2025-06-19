using Application.Features.Mediator.Commands.FooterAddressCommands;
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
	public class UpdateFooterAddressCommantHandler : IRequestHandler<UpdateFooterAddressCommand>
	{
		private readonly IRepository<FooterAddress> _repository;

		public UpdateFooterAddressCommantHandler(IRepository<FooterAddress> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
		{
			await _repository.UpdateAsync(new FooterAddress
			{
				Address = request.Address,
				Description = request.Description,
				Email = request.Email,
				FooterAddressID = request.FooterAddressID,
				Phone = request.Phone			
			});
		}
	}
}
