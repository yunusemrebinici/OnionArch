using Application.Features.Mediator.Commands.AuthorCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.AuthorHandlers
{
	public class UpdateAuthorCommandHandler:IRequestHandler<UpdateAuthorCommand>
	{
		private readonly IRepository<Author> _repository;

		public UpdateAuthorCommandHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
		{
			await _repository.UpdateAsync(new Author
			{
				Description = request.Description,
				CoverImage = request.CoverImage,
				Name = request.Name,
				AuthorID = request.AuthorID,
			});
		}
	}
}
