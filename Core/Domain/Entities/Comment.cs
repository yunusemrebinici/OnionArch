using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Comment
	{
		public int CommentID { get; set; }

		public int BlogID { get; set; }

		public Blog Blog { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public string Title { get; set; }

		public string BlogComment { get; set; }

		public string CoverImage { get; set; }

	}
}
