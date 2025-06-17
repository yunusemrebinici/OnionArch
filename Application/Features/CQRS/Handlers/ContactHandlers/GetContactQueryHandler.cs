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
	public class GetContactQueryHandler
	{
		private readonly IRepository<Contact> _contactRepository;

		public GetContactQueryHandler(IRepository<Contact> contactRepository)
		{
			_contactRepository = contactRepository;
		}

		public async Task<List<GetContactQueryResult>> Handle()
		{
			var values=await _contactRepository.GettAllAsync();
			return values.Select(x=> new GetContactQueryResult
			{
				ContactID = x.ContactID,
				Email=x.Email,
				Message = x.Message,
				Name = x.Name,
				SendDate = x.SendDate,
				Subject=x.Subject,
				
			}).ToList();
			
		}
	}


}
