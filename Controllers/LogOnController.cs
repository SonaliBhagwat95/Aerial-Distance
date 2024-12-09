
using AerialDistance.Repositories.Contracts;
using AerialDistance.Repositories.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace AerialDistance.Controllers
{
    public class LogOnController : BaseController
    {
        private readonly UnitOfWorks _uow;
        private readonly ISession Session;

        public LogOnController(IUnitOfWork uow, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            this._uow = uow as UnitOfWorks;
            this.Session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public JsonResult Index(LoginModel loginModel, string returnUrl)
        //{

        //    try
        //    {
        //        UserModel model = this._uow.userRepository.ValidateUser(loginModel.LoginId, loginModel.Password);
        //        if (model == null)
        //        {
        //            return Json(new { Result = false, Message = "Invalid username or password." });
        //        }
        //        else
        //        {
        //            this.Session.SetString("FirstName", model.FullName);
        //            int UserRoleId = model.UserRoleID;
        //            this.Session.SetInt32("UserRoleId", UserRoleId);
        //            this.Session.GetInt32("UserRoleId");
        //            int RoleId = Convert.ToInt32(HttpContext.Session.GetInt32("UserRoleId"));

        //            var LoginClaims = new List<Claim>()
        //                {
        //                     new Claim(ClaimTypes.Name, model.EmpId.ToString()),
        //                     new Claim(Constants.ClaimType.UserId, model.EmpId.ToString()),
        //                     new Claim(Constants.ClaimType.FullName, model.FullName),
        //                     new Claim(Constants.ClaimType.UserRoleID, model.UserRoleID.ToString())

        //                };

        //            var LoginIdentity = new ClaimsIdentity(LoginClaims, "Login Identity");
        //            if (model.Roles != null)
        //            {
        //                foreach (var item in model.Roles)
        //                {
        //                    LoginIdentity.AddClaim(new Claim(ClaimTypes.Role, item.ToString()));
        //                }
        //            }

        //            var userPrinciple = new ClaimsPrincipal(new[] { LoginIdentity });
        //            HttpContext.SignInAsync(userPrinciple);

        //            if (string.IsNullOrEmpty(returnUrl))
        //                this.Session.SetString("RedirectUrl", "~/Home/Dashboard");
        //            else
        //                this.Session.GetString("RedirectUrl");

        //            this.Session.SetInt32("UserId", model.EmpId);
        //            this.Session.SetString("UserName", model.FullName);
        //            this.Session.SetString("UserRoleId", model.UserRoleID.ToString());
        //            return Json(new { Result = true });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Result = false, Message = ex.Message });
        //    }

        //}
        //[Microsoft.AspNetCore.Authorization.Authorize]

        //public async Task<IActionResult> LogOff()
        //{
        //    // Clear authentication cookie
        //    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    return RedirectToAction("LogIn"); // Redirect to login page
        //}
    }
}