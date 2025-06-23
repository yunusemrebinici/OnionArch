using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.BlogCommands
{
	public class CreateBlogCommand:IRequest
	{

		public string CoverImage { get; set; }

		public DateTime Date { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public int ViewCount { get; set; }

		public int AuthorID { get; set; }

		public int CategoryID { get; set; }
		
	}
}
