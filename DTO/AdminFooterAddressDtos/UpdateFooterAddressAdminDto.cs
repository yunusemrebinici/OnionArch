using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AdminFooterAddressDtos
{
	public class UpdateFooterAddressAdminDto
	{
		public int FooterAddressID { get; set; }

		public string Address { get; set; }

		public string Phone { get; set; }

		public string Email { get; set; }
	}
}
