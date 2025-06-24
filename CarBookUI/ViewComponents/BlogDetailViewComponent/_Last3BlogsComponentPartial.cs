using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.BlogDetailViewComponent
{
	public class _Last3BlogsComponentPartial:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
