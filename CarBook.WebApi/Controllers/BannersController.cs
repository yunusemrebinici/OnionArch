using Application.Features.CQRS.Commands.BannerCommands;
using Application.Features.CQRS.Handlers.BannerHandlers;
using Application.Features.CQRS.Queries.BannerQuaries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BannersController : ControllerBase
	{
		private readonly CreateBannerCommandHandler _createBanner;
		private readonly GetBannerQueryHandler _getBannerQuery;
		private readonly GetBannerByIdQueryHandler _getBannerByIdQuery;
		private readonly RemoveBannerCommandHandler _removeBanner;
		private readonly UpdateBannerCommandHandler _updateBanner;

		public BannersController(
			CreateBannerCommandHandler createBanner,
			GetBannerQueryHandler getBannerQuery,
			GetBannerByIdQueryHandler getBannerByIdQuery,
			RemoveBannerCommandHandler removeBanner,
			UpdateBannerCommandHandler updateBanner)
		{
			_createBanner = createBanner;
			_getBannerQuery = getBannerQuery;
			_getBannerByIdQuery = getBannerByIdQuery;
			_removeBanner = removeBanner;
			_updateBanner = updateBanner;
		}

		[HttpGet]
		public async Task<IActionResult> BannerList()
		{
			return Ok(await _getBannerQuery.Handle());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetBanner(int id)
		{
			return Ok(await _getBannerByIdQuery.Handle(new GetBannerByIdQuary(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateBanner(CreateBannerCommand command)
		{
			await _createBanner.Handle(command);
			return Ok("Banner Ekleme Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateBanner(UpdateBannerCommand command)
		{
			await _updateBanner.Handle(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> RemoveBanner(int id)
		{
			RemoveBannerCommand command = new RemoveBannerCommand(id);

			await _removeBanner.Handle(command);
			return Ok("Silme İşlemi Başarılı"); 
			
		}


	}
}
