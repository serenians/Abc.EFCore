using Microsoft.AspNetCore.Mvc;

namespace samplewebapp.Controllers
{
    public class ProgramController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}