﻿using Application.Features.Mediator.Results.FeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.FeatureQuaries
{
	public class GetFeatureQuery:IRequest<List<GetFeatureQueryResult>>
	{
	}
}
