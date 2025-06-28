using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AdminBlogDtos
{
	public class GetBlogDetailByIdAdminDto
	{

		
			public int blogID { get; set; }
			public string coverImage { get; set; }
			public string title { get; set; }
			public string description { get; set; }
			public int viewCount { get; set; }
			
		

	}
}
