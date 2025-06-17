using Application.Features.CQRS.Commands.CategoryCommands;
using Application.Features.CQRS.Handlers.AboutHandlers;
using Application.Features.CQRS.Handlers.CategoryHandlers;
using Application.Features.CQRS.Handlers.CategoryHandlers;
using Application.Features.CQRS.Queries.CategoryQuaries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly CreateCategoryCommandHandler _createCommandHandler;
		private readonly GetCategoryByIdQuaryHandler _getCategoryByIdQueryHandler;
		private readonly GetCategoryQuaryHandler _getCategoryQueryHandler;
		private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;
		private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;

		public CategoryController(
			CreateCategoryCommandHandler createCommandHandler,
			GetCategoryByIdQuaryHandler getCategoryByIdQueryHandler,
			GetCategoryQuaryHandler getCategoryQueryHandler,
			RemoveCategoryCommandHandler removeCategoryCommandHandler,
			UpdateCategoryCommandHandler updateCategoryCommandHandler)
		{
			_createCommandHandler = createCommandHandler;
			_getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
			_getCategoryQueryHandler = getCategoryQueryHandler;
			_removeCategoryCommandHandler = removeCategoryCommandHandler;
			_updateCategoryCommandHandler = updateCategoryCommandHandler;
		}


		[HttpGet]
		public async Task<IActionResult> CategoryList()
		{
			return Ok(await _getCategoryQueryHandler.Handle());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCategory(int id)
		{
			return Ok(await _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuary(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
		{
			await _createCommandHandler.Handle(command);
			return Ok("Category Bilgisi Eklendi");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveCategory(int id)
		{
			await _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand (id));
			return Ok("Silme İşlemi Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateCategory(UpdateCategoryCommend command)
		{
			await _updateCategoryCommandHandler.Handle(command);
			return Ok("Güncelleme Başarılı");
		}

	}
}
