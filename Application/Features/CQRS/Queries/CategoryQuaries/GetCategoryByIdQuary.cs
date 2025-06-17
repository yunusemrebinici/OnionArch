using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Queries.CategoryQuaries
{
	public class GetCategoryByIdQuary
	{
		public int Id { get; set; }

		public GetCategoryByIdQuary(int id)
		{
			Id = id;
		}
	}
}
