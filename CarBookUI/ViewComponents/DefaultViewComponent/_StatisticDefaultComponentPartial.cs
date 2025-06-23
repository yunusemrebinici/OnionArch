using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.DefaultViewComponent
{
	public class _StatisticDefaultComponentPartial:ViewComponent
	{

		public async Task <IViewComponentResult> InvokeAsync()
		{
			return View();
		}

	}
}
