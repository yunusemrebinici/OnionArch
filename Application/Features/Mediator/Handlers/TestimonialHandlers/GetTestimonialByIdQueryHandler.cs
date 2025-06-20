﻿using Application.Features.Mediator.Quaries.TestimonialQuaries;
using Application.Features.Mediator.Results.TestimonialResults;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.TestimonialHandlers
{
	public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
	{
		private readonly IRepository<Testimonial> _repository;

		public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
		{
			_repository = repository;
		}

		public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
		{
			var value=await _repository.GetByIdAsync(request.Id);
			return new GetTestimonialByIdQueryResult
			{
				Comment = value.Comment,
				ImageUrl = value.ImageUrl,
				Name = value.Name,
				TestimonialID = value.TestimonialID,
				Title = value.Title,

			};
		}
	}
}
