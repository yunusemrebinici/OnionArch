using Application.Features.Mediator.Commands.BlogCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.BlogHandlers
{
	public class UpdateBlogHandler : IRequestHandler<UpdateBlogCommand>
	{
		private readonly IRepository<Blog> _repository;

		public UpdateBlogHandler(IRepository<Blog> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
		{
			await _repository.UpdateAsync(new Blog
			{
				BlogID = request.BlogID,
				CoverImage = request.CoverImage,
				Date = request.Date,
				Description = request.Description,
				Title = request.Title,
				ViewCount = 0,
			});
		}
	}
}
