﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Results.AppUserResults
{
	public class GetAppCheckUserQueryResult
	{
		public int Id { get; set; }

		public string UserName { get; set; }

		public string Role { get; set; }

		public bool IsExist { get; set; }
	}
}
