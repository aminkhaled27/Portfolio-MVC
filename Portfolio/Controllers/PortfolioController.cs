using Microsoft.AspNetCore.Mvc;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            ProjectViewModel vm = new ProjectViewModel();
            return View(vm);
        }
    }
}
