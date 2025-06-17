using Application.Features.CQRS.Commands.BrandCommands;
using Application.Features.CQRS.Handlers.BrandHandlers;
using Application.Features.CQRS.Queries.BrandQuaries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BrandsController : ControllerBase
	{
		private readonly CreateBrandCommandHandler _createCommandHandler;
		private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
		private readonly GetBrandQueryHandler _getBrandQueryHandler;
		private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;
		private readonly UpdateBrandCommendHandler _updateBrandCommandHandler;

		public BrandsController(
			CreateBrandCommandHandler createCommandHandler,
			GetBrandByIdQueryHandler getBrandByIdQueryHandler,
			GetBrandQueryHandler getBrandQueryHandler,
			RemoveBrandCommandHandler removeBrandCommandHandler,
			UpdateBrandCommendHandler updateBrandCommandHandler)
		{
			_createCommandHandler = createCommandHandler;
			_getBrandByIdQueryHandler = getBrandByIdQueryHandler;
			_getBrandQueryHandler = getBrandQueryHandler;
			_removeBrandCommandHandler = removeBrandCommandHandler;
			_updateBrandCommandHandler = updateBrandCommandHandler;
		}


		[HttpGet]
		public async Task<IActionResult> BrandList()
		{
			return Ok(await _getBrandQueryHandler.Handle());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetBrand(int id)
		{
			return Ok(await _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuary(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
		{
			await _createCommandHandler.Handle(command);
			return Ok("Marka Bilgisi Eklendi");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveBrand(int id)
		{
			await _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
			return Ok("Silme İşlemi Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
		{
			await _updateBrandCommandHandler.Handle(command);
			return Ok("Güncelleme Başarılı");
		}


	}
}
