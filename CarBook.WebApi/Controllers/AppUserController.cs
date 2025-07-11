using Application.Features.Mediator.Commands.AppUserCommands;
using Application.Features.Mediator.Quaries.AppUserQuaries;
using Application.Tools;
using Application.Validators;
using FluentValidation;
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
		public async Task<IActionResult> Login(GetCheckAppUserQuery query)
		{

			var value = await _mediator.Send(new GetCheckAppUserQuery(query.UserName,query.Password));
			if (value.IsExist == true)
			{

				return Created("", JwtTokenGenerator.GenerateToken(value));
				
			}
			{
				return Ok(value);
			}

		}

		[HttpPost("Register")]
		public async Task<IActionResult> Register(CreateAppUserCommand createAppUser)
		{
			AppUserValidate validationRules = new AppUserValidate();
			var validate=validationRules.Validate(createAppUser);

			if (validate.IsValid)
			{
				await _mediator.Send(new CreateAppUserCommand()
				{
					AppRoleID = createAppUser.AppRoleID,
					Password = createAppUser.Password,
					UserName = createAppUser.UserName,
				});
				return Ok("Ekleme Başarılı");
			}
			return BadRequest(validate.Errors);
			
			
		}
	}
}
