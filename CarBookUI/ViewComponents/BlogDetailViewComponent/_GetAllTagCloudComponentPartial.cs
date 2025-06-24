using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.BlogDetailViewComponent
{
	public class _GetAllTagCloudComponentPartial:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
		    return View();
		}
	}
}
