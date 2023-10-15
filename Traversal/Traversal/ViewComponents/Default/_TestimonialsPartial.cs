using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _TestimonialsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
