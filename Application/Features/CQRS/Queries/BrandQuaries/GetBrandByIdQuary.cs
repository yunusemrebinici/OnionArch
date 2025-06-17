using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Queries.BrandQuaries
{
	public class GetBrandByIdQuary
	{
		public GetBrandByIdQuary(int id	)
		{
		    Id = id;
		}

		public int Id { get; set; }
	}
}
