using Application.Features.Mediator.Quaries.AppUserQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AppUserController : ControllerBase
	{
		private readonly IMediator _mediator;

		public AppUserController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> GetFilter(string appuser,int password)
		{
				
			return Ok(await _mediator.Send(new GetCheckAppUserQuery(appuser,password)));
		}
	}
}
