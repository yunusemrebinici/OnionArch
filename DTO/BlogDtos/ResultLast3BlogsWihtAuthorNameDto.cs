using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.BlogDtos
{
	public class ResultLast3BlogsWihtAuthorNameDto
	{
		public int blogID { get; set; }
		public string coverImage { get; set; }
		public DateTime date { get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public int viewCount { get; set; }
		public string authorName { get; set; }
	}
}
