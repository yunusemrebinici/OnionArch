﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Commands.AuthorCommands
{
	public class UpdateAuthorCommand:IRequest
	{
		public int AuthorID { get; set; }

		public string Name { get; set; }

		public string CoverImage { get; set; }

		public string Description { get; set; }
	}
}
