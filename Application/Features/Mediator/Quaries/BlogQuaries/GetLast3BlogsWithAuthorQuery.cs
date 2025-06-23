﻿using Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.BlogQuaries
{
	public class GetLast3BlogsWithAuthorQuery:IRequest<List<GetLast3BlogsWithAuthorQueryResult>>
	{
	}
}
