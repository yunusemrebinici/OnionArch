using Application.Features.CQRS.Queries.ContactQuaries;
using Application.Features.CQRS.Results.ContactResults;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Handlers.ContactHandlers
{
	public class GetContactByIdQueryHandler
	{
		private readonly IRepository<Contact> _contactRepository;

		public GetContactByIdQueryHandler(IRepository<Contact> contactRepository)
		{
			_contactRepository = contactRepository;
		}

		public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
		{
			var value = await _contactRepository.GetByIdAsync(query.Id);
			return new GetContactByIdQueryResult
			{
				ContactID = value.ContactID,
				Email = value.Email,
				Message = value.Message,
				Name = value.Name,
				SendDate = value.SendDate,
				Subject=value.Subject,
			};
		  
		}
	}
}
