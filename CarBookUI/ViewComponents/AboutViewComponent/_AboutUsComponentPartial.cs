using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.AboutViewComponent
{
	public class _AboutUsComponentPartial:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
