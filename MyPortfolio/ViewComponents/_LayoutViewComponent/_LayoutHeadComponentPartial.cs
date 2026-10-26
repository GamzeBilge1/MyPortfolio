using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents._LayoutViewComponent
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
