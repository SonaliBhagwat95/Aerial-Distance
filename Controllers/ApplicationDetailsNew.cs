using Microsoft.AspNetCore.Mvc;

namespace AerialDistance.Controllers
{
    public class ApplicationDetailsNew : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ApplicationDetails()
        {
            return View();
        }
    }
}
