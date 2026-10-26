using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {

            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();

            ViewBag.Skills = context.Skills.ToList();
            ViewBag.DoneCount = context.ToDoLists.Count(x => x.Status == true);
            ViewBag.NotDoneCount = context.ToDoLists.Count(x => x.Status == false);
            return View();
        }
    }
}
