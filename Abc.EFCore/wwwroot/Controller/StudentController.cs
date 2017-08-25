using Microsoft.AspNetCore.Mvc;

namespace Abc.EFCore.Controller
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}