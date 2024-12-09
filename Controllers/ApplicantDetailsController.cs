using Microsoft.AspNetCore.Mvc;

namespace AerialDistance.Controllers
{
    public class ApplicantDetailsController : BaseController
    {
        public ApplicantDetailsController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
