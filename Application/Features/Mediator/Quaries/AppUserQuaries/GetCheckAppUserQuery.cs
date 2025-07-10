using Application.Features.Mediator.Results.AppUserResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.AppUserQuaries
{
	public class GetCheckAppUserQuery:IRequest<GetAppCheckUserQueryResult>
	{
		public GetCheckAppUserQuery(string userName, int password)
		{
			UserName = userName;
			Password = password;
		}

		public string UserName { get; set; }

		public int Password { get; set; }
	}
}
