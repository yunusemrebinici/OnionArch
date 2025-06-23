using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.BlogCommands
{
	public class RemoveBlogCommend:IRequest
	{
		public int Id { get; set; }

		public RemoveBlogCommend(int id)
		{
			Id = id;
		}
	}
}
