using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class AppUser
	{
		public int AppuserID { get; set; }

		public string UserName { get; set; }

		public int Password { get; set; }

		public int AppRoleID { get; set; }

		public AppRole AppRole { get; set; }

	}
}
