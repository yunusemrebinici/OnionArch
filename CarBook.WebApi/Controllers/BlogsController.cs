﻿using Application.Features.Mediator.Commands.BlogCommands;
using Application.Features.Mediator.Quaries.BlogQuaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BlogsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public BlogsController(IMediator mediator)
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

		[HttpGet("GetLast3BlogsWithAuthor")]
		public async Task<IActionResult> GetLast3BlogsWithAuthor()
		{
			return Ok(await _mediator.Send(new GetLast3BlogsWithAuthorQuery()));
		}

		[HttpGet("GetAllBlogsWithAuthor")]
		public async Task<IActionResult> GetAllBlogsWithAuthor()
		{
			return Ok(await _mediator.Send(new GetAllBlogsWithAuthorQuery()));
		}
		[HttpGet("GetAuthorByBlogId/{id}")]
		public async Task<IActionResult>GetAuthorByBlogId(int id)
		{
			return Ok(await _mediator.Send(new GetAuthorByBlogIdQuery(id)));
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

		[HttpDelete("{id}")]
		public async Task<IActionResult> RemoveBlog(int id)
		{
			await _mediator.Send(new RemoveBlogCommend(id));
			return Ok("Silme İşlemi Başarılı");
		}
	}
}
