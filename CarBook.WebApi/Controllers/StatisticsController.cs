using Application.Features.Mediator.Quaries.StatisticQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StatisticsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public StatisticsController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpGet("GetCarCount")]
		public async Task<IActionResult> GetCarCount()
		{
			var values = await _mediator.Send(new GetCarCountQuery());
			return Ok(values);
		}

		[HttpGet("GetCarUnder1000kmCount")]
		public async Task<IActionResult> GetCarUnder1000kmCount()
		{
			var values = await _mediator.Send(new GetCarUnder1000kmCountQuery());
			return Ok(values);
		}

		[HttpGet("GetElectricCarCount")]
		public async Task<IActionResult> GetElectricCarCount()
		{
			var values = await _mediator.Send(new GetElectricCarCountQuery());
			return Ok(values);
		}


		[HttpGet("GetMinTodayPriceCarBrandModel")]
		public async Task<IActionResult> GetMinTodayPriceCarBrandModel()
		{
			var values = await _mediator.Send(new GetMinTodayPriceCarBrandModelQuery());
			return Ok(values);
		}

		[HttpGet("GetTestimonailCount")]
		public async Task<IActionResult> GetTestimonailCount()
		{
			var values = await _mediator.Send(new GetTestimonailCountQuery());
			return Ok(values);
		}


		[HttpGet("GetMaxTodayPriceCarBrandModel")]
		public async Task<IActionResult> GetMaxTodayPriceCarBrandModel()
		{
			var values = await _mediator.Send(new GetMaxTodayPriceCarBrandModelQuery());
			return Ok(values);
		}

		[HttpGet("GetLocationCount")]
		public async Task<IActionResult> GetLocationCount()
		{
			var values = await _mediator.Send(new GetLocationCountQuery());
			return Ok(values);
		}

		[HttpGet("GetAuthorCount")]
		public async Task<IActionResult> GetAuthorCount()
		{
			var values = await _mediator.Send(new GetOuthorCountQuery());
			return Ok(values);
		}
		[HttpGet("GetBrandCount")]
		public async Task<IActionResult> GetBrandCount()
		{
			var values = await _mediator.Send(new GetBrandCountQuery());
			return Ok(values);
		}
		[HttpGet("GetBlogCount")]
		public async Task<IActionResult> GetBlogCount()
		{
			var values = await _mediator.Send(new GetBlogCountQuery());
			return Ok(values);
		}
		[HttpGet("GetTodayCarPricingAvg")]
		public async Task<IActionResult> GetTodayCarPricingAvg()
		{
			var values = await _mediator.Send(new GetTodayCarPricingAvgQuery());
			return Ok(values);
		}
		[HttpGet("GetWeekCarPricingAvg")]
		public async Task<IActionResult> GetWeekCarPricingAvg()
		{
			var values = await _mediator.Send(new GetWeekCarPricingQuery());
			return Ok(values);
		}


		[HttpGet("GetMonthCarPricingAvg")]
		public async Task<IActionResult> GetMonthCarPricingAvg()
		{
			var values = await _mediator.Send(new GethMonthCarQuery());
			return Ok(values);
		}

		[HttpGet("GetAutomaticTransMissionCarCount")]
		public async Task<IActionResult> GetAutomaticTransMissionCarCount()
		{
			var values = await _mediator.Send(new GetAutomaticTransMisCarQuery());
			return Ok(values);
		}
		[HttpGet("GetMostBrandedCarsBrand")]
		public async Task<IActionResult> GetMostBrandedCarsBrand()
		{
			var values = await _mediator.Send(new GetMostBrandedCarsBrandQuery());
			return Ok(values);
		}
		[HttpGet("GetMostBlogCommentCount")]
		public async Task<IActionResult> GetMostBlogCommentCount()
		{
			var values = await _mediator.Send(new GetMostBlogCommentQuery());
			return Ok(values);
		}

	}
}
