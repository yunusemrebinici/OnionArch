using Application.Features.Mediator.Commands.FooterAddressCommands;
using Application.Features.Mediator.Quaries.FooterAddressQuaries;
using Application.Features.Mediator.Quaries.TagQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TagsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public TagsController(IMediator mediator)
		{
			_mediator = mediator;
		}


		[HttpGet("{id}")]
		public async Task<IActionResult>GetTagByBlogId(int id)
		{
			return Ok(await _mediator.Send(new GetTagByBlogIdQuery(id)));
		}

		[HttpGet]
		public async Task<IActionResult> TagList()
		{
			return Ok(await _mediator.Send(new GetTagQuery()));
		}

		
	
	}
}
