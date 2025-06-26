using Application.Features.CQRS.Commands.CarCommands;
using Application.Features.CQRS.Handlers.CarHandlers;
using Application.Features.CQRS.Queries.CarQuaries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarsController : ControllerBase
	{
		private readonly CreateCarCommandHandler _createCommandHandler;
		private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
		private readonly GetCarQueryHandler _getCarQueryHandler;
		private readonly RemoveCarCommandHandler _removeCarCommandHandler;
		private readonly UpdateCarCommandHandler _updateCarCommandHandler;
		private readonly GetCarWithBrandAndPriceQueryHandler _getCarWithBrandQueryHandler;
		private readonly GetLast5CarsWithBrandQueryHandler _getLast5CarsWithBrandQueryHandler;
		private readonly GetLastCarByIdQueryHandler _getLastCarByIdQueryHandler;

		public CarsController(
			CreateCarCommandHandler createCommandHandler,
			GetCarByIdQueryHandler getCarByIdQueryHandler,
			GetCarQueryHandler getCarQueryHandler,
			RemoveCarCommandHandler removeCarCommandHandler,
			UpdateCarCommandHandler updateCarCommandHandler,
			GetCarWithBrandAndPriceQueryHandler getCarWithBrandQueryHandler,
			GetLast5CarsWithBrandQueryHandler getLast5CarsWithBrandQueryHandler, GetLastCarByIdQueryHandler getLastCarByIdQueryHandler)
		{
			_createCommandHandler = createCommandHandler;
			_getCarByIdQueryHandler = getCarByIdQueryHandler;
			_getCarQueryHandler = getCarQueryHandler;
			_removeCarCommandHandler = removeCarCommandHandler;
			_updateCarCommandHandler = updateCarCommandHandler;
			_getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
			_getLast5CarsWithBrandQueryHandler = getLast5CarsWithBrandQueryHandler;
			_getLastCarByIdQueryHandler = getLastCarByIdQueryHandler;
		}


		[HttpGet]
		public async Task<IActionResult> CarList()
		{
			return Ok(await _getCarQueryHandler.Handle());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCarList(int id)
		{
			return Ok(await _getCarByIdQueryHandler.Handle(new GetCarByIdQuary(id)));
		}

		[HttpGet("GetLast5CarsWithBrand")]
		public async Task<IActionResult> GetLast5CarsWithBrand()
		{
			return Ok(await _getLast5CarsWithBrandQueryHandler.Handle());
		}

		[HttpPost]
		public async Task<IActionResult>CreateCar(CreateCarCommand command)
		{
			await _createCommandHandler.Handle(command);
			return Ok("Ekleme İşlemi Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
		{
			await _updateCarCommandHandler.Handle(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete]
		public async Task<IActionResult>RemoveCar(int id)
		{
			await _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
			return Ok("Silme Başarılı");
		}

		[HttpGet("GetCarsWithBrand")]
		public async Task<IActionResult> GetCarsWithBrand()
		{
			return Ok(await _getCarWithBrandQueryHandler.Handle());
		}
		[HttpGet("GetLastCarById")]
		public async Task<IActionResult> GetLastCarById()
		{
			return Ok(await _getLastCarByIdQueryHandler.Handle());
		}

	}
}
