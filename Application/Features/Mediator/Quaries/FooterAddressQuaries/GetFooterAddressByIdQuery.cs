﻿using Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Quaries.FooterAddressQuaries
{
	public class GetFooterAddressByIdQuery:IRequest<GetFooterAddressByIdQueryResult>
	{
		public int Id { get; set; }

		public GetFooterAddressByIdQuery(int id)
		{
			Id = id;
		}
	}
}
