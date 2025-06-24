using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Results.BlogResults
{
	public class GetAllBlogsWithAuthorQueryResult
	{
		public int BlogID { get; set; }

		public string CoverImage { get; set; }

		public DateTime Date { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public int ViewCount { get; set; }

		public string AuthorName { get; set; }
	}
}
