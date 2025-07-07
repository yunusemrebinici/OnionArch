using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CommentDtos
{
	public class ResultCommentDto
	{


		public int commentID { get; set; }
		public int blogID { get; set; }
		public string email { get; set; }
		public string name { get; set; }
		public string title { get; set; }
		public string blogComment { get; set; }
		public string coverImage { get; set; }


	}
}
