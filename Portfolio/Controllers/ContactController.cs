using Microsoft.AspNetCore.Mvc;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ContactInfoViewModel vm = new ContactInfoViewModel();
            return View(vm);
        }
    }
}
