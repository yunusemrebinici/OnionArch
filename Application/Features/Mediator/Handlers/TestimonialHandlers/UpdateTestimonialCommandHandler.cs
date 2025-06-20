using Application.Features.Mediator.Commands.TestimonialCommands;
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
	public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
	{
		private readonly IRepository<Testimonial>_repository;

		public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
		{
			_repository = repository;
		}

		async Task IRequestHandler<UpdateTestimonialCommand>.Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
		{
			await _repository.UpdateAsync(new Testimonial
			{
				Comment = request.Comment,
				ImageUrl = request.ImageUrl,
				Name = request.Name,
				TestimonialID = request.TestimonialID,
				Title = request.Title,
			});
		}
	}
}
