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

		public CarsController(
			CreateCarCommandHandler createCommandHandler,
			GetCarByIdQueryHandler getCarByIdQueryHandler,
			GetCarQueryHandler getCarQueryHandler,
			RemoveCarCommandHandler removeCarCommandHandler,
			UpdateCarCommandHandler updateCarCommandHandler)
		{
			_createCommandHandler = createCommandHandler;
			_getCarByIdQueryHandler = getCarByIdQueryHandler;
			_getCarQueryHandler = getCarQueryHandler;
			_removeCarCommandHandler = removeCarCommandHandler;
			_updateCarCommandHandler = updateCarCommandHandler;
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
	}
}
