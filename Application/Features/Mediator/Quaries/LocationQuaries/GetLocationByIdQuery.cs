﻿using Application.Features.Mediator.Results.LocationResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.LocationQuaries
{
	public class GetLocationByIdQuery:IRequest<GetLocationByIdQueryResult>
	{
		public int Id { get; set; }

		public GetLocationByIdQuery(int id)
		{
			Id = id;
		}
	}
}
