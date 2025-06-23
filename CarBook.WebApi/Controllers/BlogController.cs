using Application.Features.Mediator.Commands.BlogCommands;
using Application.Features.Mediator.Quaries.BlogQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BlogController : ControllerBase
	{
		private readonly IMediator _mediator;

		public BlogController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> BlogList()
		{
			return Ok(await _mediator.Send(new GetBlogQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetBlog(int id)
		{
			return Ok(await _mediator.Send(new GetBlogByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveBlog(int id)
		{
			await _mediator.Send(new RemoveBlogCommend(id));
			return Ok("Silme İşlemi Başarılı");
		}
	}
}
