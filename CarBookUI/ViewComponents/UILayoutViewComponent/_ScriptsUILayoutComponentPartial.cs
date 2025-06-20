using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.UILayoutViewComponent
{
	public class _ScriptsUILayoutComponentPartial:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
