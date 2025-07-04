﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Results.BrandResults
{
	public class GetBrandQueryResult
	{
		public int BrandID { get; set; }

		public string Name { get; set; }

		public List<Car> Cars { get; set; }
	}
}
