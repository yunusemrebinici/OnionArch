using Application.Features.Mediator.Commands.AppUserCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.AppUserHandlers
{
	public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
	{
		private readonly IRepository<AppUser> _repository;

		public CreateAppUserCommandHandler(IRepository<AppUser> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
		{

			request.AppRoleID = 1;
			await _repository.CreateAsync(new AppUser(){
				AppRoleID=request.AppRoleID,
				Password=request.Password,
				UserName=request.UserName,
			});
		}
	}
}
