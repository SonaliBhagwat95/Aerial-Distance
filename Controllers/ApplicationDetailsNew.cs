using Microsoft.AspNetCore.Mvc;

namespace AerialDistance.Controllers
{
    public class ApplicationDetailsNewController : Controller
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
