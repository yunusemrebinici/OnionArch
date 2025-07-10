using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.LoginDtos
{
	public class CreateLoginDto
	{
		public string UserName { get; set; }

		public int Password { get; set; }
	}
}
