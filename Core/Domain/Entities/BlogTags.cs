using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class BlogTags
	{
		public int BlogTagsID { get; set; }

		public int TagID { get; set; }

		public Tag Tag { get; set; }

		public Blog Blog { get; set; }

		public int BlogID { get; set; }

		
	}
}
