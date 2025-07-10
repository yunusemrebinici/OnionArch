using Application.Dtos;
using Application.Features.Mediator.Quaries.AppUserQuaries;
using Application.Features.Mediator.Results.AppUserResults;
using Application.Interfaces;
using Application.Interfaces.IAppUserRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.GetCheckAppUserHandlers
{
	public class GetCheckAppUserQueryHandler : IRequestHandler<GetCheckAppUserQuery, GetAppCheckUserQueryResult>
	{
		private readonly IAppUserRepository _appUserRepository;

		public GetCheckAppUserQueryHandler(IAppUserRepository appUserRepository)
		{
			_appUserRepository = appUserRepository;
		}

		public async Task<GetAppCheckUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
		{
			var user= new GetAppCheckUserQueryResult();
			var value = await _appUserRepository.GetFilterAsync(x => x.UserName == request.UserName && x.Password == request.Password);
			if (value == null) { 
			  user.IsExist= false;
			}
			{
				user.IsExist = true;
				user.UserName = request.UserName;
				user.Role = Enum.GetName(typeof(RoleDto), value.AppRoleID);

			}
			return user;
		}
	}
}
