﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Results.CarFeatureResults
{
	public class GetCarFeatureQueryResult
	{
		public int FeatureID { get; set; }

		public int CarID { get; set; }

		public string FeatureName { get; set; }

		public bool Available { get; set; }
	}
}
