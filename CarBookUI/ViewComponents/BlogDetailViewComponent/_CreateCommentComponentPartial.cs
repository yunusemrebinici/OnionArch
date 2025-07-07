using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.BlogDetailViewComponent
{
	public class _CreateCommentComponentPartial:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			ViewBag.Id = id;
			return View();
		}
	}
}
