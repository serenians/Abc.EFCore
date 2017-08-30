using Microsoft.AspNetCore.Mvc;

namespace Abc.EFCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}