using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Queries.BannerQuaries
{
	public class GetBannerByIdQuary
	{
		public GetBannerByIdQuary(int id)
		{
			Id = id;
		}
		public int Id { get; set; }
	}
}
