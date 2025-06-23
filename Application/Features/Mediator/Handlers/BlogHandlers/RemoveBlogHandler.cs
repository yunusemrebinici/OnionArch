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
	public class RemoveBlogHandler : IRequestHandler<RemoveBlogCommend>
	{
		private readonly IRepository<Blog>_repository;

		public RemoveBlogHandler(IRepository<Blog> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveBlogCommend request, CancellationToken cancellationToken)
		{
			var remove= await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(remove);
		}
	}
}
