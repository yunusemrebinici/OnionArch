﻿using Application.Features.Mediator.Results.ServiceResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.ServiceQuaries
{
	public class GetServiceQuery:IRequest<List<GetServiceQueryResult>>
	{
	}
}
