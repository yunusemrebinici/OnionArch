using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.BlogDetailViewComponent
{
	public class _AllTagCloudsComponentPartial:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
