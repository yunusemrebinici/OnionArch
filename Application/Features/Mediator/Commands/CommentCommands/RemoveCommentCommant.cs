using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.CommentCommands
{
	public class RemoveCommentCommant:IRequest
	{
		public int Id { get; set; }

		public RemoveCommentCommant(int ıd)
		{
			Id = ıd;
		}
	}
}
