﻿using Application.Features.Mediator.Results.SocialMediaResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.SocialMediaQuaries
{
	public class GetSocialMediaQuery:IRequest<List<GetSocialMediaQueryResult>>
	{
	}
}
