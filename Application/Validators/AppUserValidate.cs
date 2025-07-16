using Application.Features.Mediator.Commands.AppUserCommands;
using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
	public class AppUserValidate:AbstractValidator<CreateAppUserCommand>
	{
		public AppUserValidate()
		{
			RuleFor(x => x.UserName).NotEmpty().MinimumLength(2).MaximumLength(15).WithMessage("Boş Geçilemez , Min 2 - Max 15 Karakter Olmalıdır");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Boş Geçilemez ve 10 karakterden fazla Olmalıdır");

		}
	}
}
