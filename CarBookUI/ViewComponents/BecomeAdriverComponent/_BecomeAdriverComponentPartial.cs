using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.BecomeAdriverComponent
{
	public class _BecomeAdriverComponentPartial:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();	
		}
	}
}
