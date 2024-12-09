using AerialDistance.Model;
using AerialDistance.Repositories.Contracts;
using AerialDistance.Repositories.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AerialDistance.Controllers
{
    public class ApplicationDetailsNewController : BaseController
    {
        private UnitOfWorks _uow;
        public ApplicationDetailsNewController(IUnitOfWork uow, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            this._uow = uow as UnitOfWorks;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ApplicationDetails(ApplicationDetailsNewModel ApplicationDetailsNewModel)
        {
            try
            {
                if (ApplicationDetailsNewModel.ApplicationNo == null)
                {
                    return View();
                }
                ApplicationDetailsNewModel.MobileNo = 99;
                ApplicationDetailsNewModel.MobileNo2 = 99;
                ApplicationDetailsNewModel.CreatedBy = 99;
                ApplicationDetailsNewModel.UploadFilePath = "sa";

                ApplicationDetailsNewModel model = ApplicationDetailsNewModel;
                int flag = _uow.ApplicationDetailsRepository.SaveApplicatonDetails(model);
                if (flag == 0 || flag == -1)
                    return RedirectToAction("Index", "ApplicationDetailsNewController");

                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
