﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.CarDescriptionDtos
{
	public class ResultCarDescriptionByCarIdDto
	{
		public int carDescriptionID { get; set; }
		public int carID { get; set; }
		public string details { get; set; }
	}
}
