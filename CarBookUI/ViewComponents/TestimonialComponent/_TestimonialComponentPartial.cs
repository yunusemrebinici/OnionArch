using Microsoft.AspNetCore.Mvc;

namespace CarBookUI.ViewComponents.TestimonialComponent
{
	public class _TestimonialComponentPartial:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
