using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.UILayoutViewComponent
{
	public class _MainCoverUILayoutComponentPartial:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
