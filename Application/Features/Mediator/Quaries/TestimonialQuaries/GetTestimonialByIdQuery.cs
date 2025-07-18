﻿using Application.Features.Mediator.Results.TestimonialResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.TestimonialQuaries
{
	public class GetTestimonialByIdQuery:IRequest<GetTestimonialByIdQueryResult>
	{
		public int Id { get; set; }

		public GetTestimonialByIdQuery(int id)
		{
			Id = id;
		}
	}
}
