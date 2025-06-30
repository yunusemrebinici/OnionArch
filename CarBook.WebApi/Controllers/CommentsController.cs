using Application.Features.Mediator.Commands.CommentCommands;
using Application.Features.Mediator.Quaries.CommentQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CommentsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CommentsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> CommentList()
		{
			return Ok(await _mediator.Send(new GetCommentQuery()));
		}

		[HttpGet("GetCommentsByBlogId/{id}")]
		public async Task<IActionResult> GetCommentsByBlogId(int id)
		{
			return Ok(await _mediator.Send(new GetCommentByBlogIdQuery(id)));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetComment(int id)
		{
			return Ok(await _mediator.Send(new GetCommentByIdQuery(id)));
		}

		[HttpPost]
		public async Task<IActionResult> CreateComment(CreateCommentCommant command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme Başarılı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateComment(UpdateCommentCommant command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme Başarılı");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveComment(int id)
		{
			await _mediator.Send(new RemoveCommentCommant(id));
			return Ok("Silme İşlemi Başarılı");
		}
	}
}
