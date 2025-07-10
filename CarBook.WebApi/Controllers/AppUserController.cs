using Application.Features.Mediator.Quaries.AppUserQuaries;
using Application.Tools;
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
		public async Task<IActionResult> Login(string appuser,int password)
		{

			var value = await _mediator.Send(new GetCheckAppUserQuery(appuser, password));
			if (value.IsExist == true) { 
			
				return Created("",JwtTokenGenerator.GenerateToken(value));
			}
			{
				return Ok();
			}
			
		}
	}
}
