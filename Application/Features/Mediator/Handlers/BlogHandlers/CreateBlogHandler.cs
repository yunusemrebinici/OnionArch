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
	public class CreateBlogHandler : IRequestHandler<CreateBlogCommand>
	{
		private readonly IRepository<Blog>_repository;

		public CreateBlogHandler(IRepository<Blog> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Blog
			{
				CoverImage = request.CoverImage,
				Date = request.Date,
				Description = request.Description,
				Title = request.Title,
				ViewCount = 0,
				AuthorID = request.AuthorID,
				CategoryID = request.CategoryID,

			});
		}
	}
}
