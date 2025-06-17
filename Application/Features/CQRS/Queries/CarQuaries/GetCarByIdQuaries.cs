using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Queries.CarQuaries
{
	public class GetCarByIdQuaries
	{
		public GetCarByIdQuaries(int id)
		{
			Id = id;
		}
		public int Id { get; set; }
	}
}
