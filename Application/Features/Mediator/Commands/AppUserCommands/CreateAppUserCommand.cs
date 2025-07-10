﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.AppUserCommands
{
	public class CreateAppUserCommand:IRequest
	{
		public string UserName { get; set; }

		public int Password { get; set; }

		public int AppRoleID { get; set; }
	}
}
