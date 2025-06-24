using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.BlogDetailViewComponent
{
	public class _BlogAuthorDetailComponentPartial:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
