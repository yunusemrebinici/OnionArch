using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.CarSingleViewComponent
{
	public class _CarFeatureByCarIdComponentPartial:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			return View();
		}
	}
}
