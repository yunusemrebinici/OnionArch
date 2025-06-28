using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AdminAuthorDtos
{
	public class UpdateAuthorAdminDto
	{
		public int AuthorID { get; set; }

		public string Name { get; set; }

		public string CoverImage { get; set; }

		public string Description { get; set; }
	}
}
